#!/bin/bash
#set -x

# Although this may seem like a random collection of punctuation it is 
# actually a bash script. I.e. it is executed by the bash command. 
#
# Git Bash may be downloaded as part of the Git tools from 
# https://git-scm.com/downloads
#
# This script produces language specific variants of vlcb-defs.csv

############################
# vlcbdefs.inc
############################
OUTPUT=vlcbdefs.inc
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
; DO NOT EDIT THIS FILE.
; This file is automatically generated by $0 from vlcb-defs.csv

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ "$type" = "comment" ]; then
		echo -e "; $name\t$value\t$comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "; $value$comment" 
		else
			start=`echo -e $value | cut -c1-2 | tr "x" "X"`
			if [ "x$start" = "x0X" ]; then
				echo -e "$name\tequ $value\t; $comment" 
			else
				echo -e "$name\tequ .$value\t; $comment" 
			fi
		fi
	fi
done < vlcb-defs.csv >>$OUTPUT
	
# finally output the trailer stuff
# none needed


############################
# vlcbdefs.h
############################
OUTPUT=vlcbdefs.h
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from vlcb-defs.csv
 */
#ifndef __VLCBDEFS
#define __VLCBDEFS

#ifdef	__cplusplus
extern "C" {
#endif

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ "$type" = "comment" ]; then
		echo -e "// $name\t$value\t$comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "// $value$comment" 
		else
			echo -e "#define $name\t$value\t// $comment" 
		fi
	fi
done < vlcb-defs.csv >>$OUTPUT
	
# finally output the trailer stuff
cat << EOF >> $OUTPUT

#ifdef	__cplusplus
}
#endif

#endif // __VLCBDEFS

EOF


############################
# vlcbdefs.hpp
############################
sh ./generate_cpp.sh


############################
# vlcbdefs.pas
############################
OUTPUT=vlcbdefs.pas
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
{ DO NOT EDIT THIS FILE.
  This file is automatically generated by $0 from vlcb-defs.csv
} 
unit vlcbdefs;

interface

const

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ "$type" = "comment" ]; then
		echo -e "{ $name\t$value\t$comment }" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "// $value$comment" 
		else
			echo -e " $name\t=  $value;\t// $comment" 
		fi
	fi
done < vlcb-defs.csv >>$OUTPUT
	
# finally output the trailer stuff
cat << EOF >> $OUTPUT

implementation

end.
EOF

############################
#  Java files
############################
PACKAGE=uk.org.merg.vlcb
JAVAPATH=`echo java/$PACKAGE|tr '.' '/'`
mkdir -p $JAVAPATH
# get the list of classes
for class in $(cat vlcb-defs.csv|cut -f1 -d ,|grep -v comment|sort|uniq)
do
	OUTPUT="$JAVAPATH/$class.java"
	echo "Generating $OUTPUT"
	# output the fixed part
	cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from vlcb-defs.csv
 */ 

package $PACKAGE;

EOF
	# output the comments
	grep '^comment' vlcb-defs.csv | cut -f2- -d , | sed 's!^!// !' |sed 's!,!!' | sed 's!,!!' >> $OUTPUT
	# output heading
	cat << EOF >> $OUTPUT

public enum $class {
EOF
	# capture the name and values into a variable
	BODY=`while IFS="," read type	name value comment 
	do
		if [ "$type" = "$class" ]; then
			if [ "X$name" = "X" ]; then
				echo -e "// $value$comment" 
			else
				echo -e "\t$name($value),\t//$comment" 
			fi
		fi
	done < vlcb-defs.csv`
	# change the ',' at the end of the last entry to ';'
	#echo "$BODY" | sed 's!\(.*\)),!\1);!' >>$OUTPUT
	# find the line to change
	CHANGE_LINE=`echo "$BODY" | grep -n '),' | tail -1 |cut -f1 -d ':'`
	# output the lines prior to that
	echo "$BODY"|head -n `expr $CHANGE_LINE - 1` >>$OUTPUT
	# output the remainder with the change
	echo "$BODY"|tail -n +$CHANGE_LINE | sed 's!),!);!' >> $OUTPUT


	# output trailer
	cat << EOF >> $OUTPUT

	private final int v;

	private $class(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
EOF
done

############################
# vlcbdefs.cs
############################
sh ./generate_cs.sh

############################
# vlcbdefsenums.cs
############################
sh ./generate_cs_enums.sh

############################
# vlcbdefs.py
############################
OUTPUT=vlcbdefs.py
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
# DO NOT EDIT THIS FILE.
# This file is automatically generated by $0 from vlcb-defs.csv
#

from micropython import const

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ "$type" = "comment" ]; then
		echo -e "# $name    $value    $comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "# $value$comment" 
		else
			echo -e "$name = const($value)    # $comment" 
		fi
	fi
done < vlcb-defs.csv >>$OUTPUT

# finally output the trailer stuff
# there is none for Python

echo "Finished"
exit 0
