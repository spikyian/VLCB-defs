/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate_java.sh from vlcb-defs.csv
 */

package uk.org.merg.vlcb;

// Copyright (C) Sven Rosvall (sven@rosvall.ie)
// This file is part of VLCB-Arduino project on https://github.com/SvenRosvall/VLCB-Arduino
// Licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
// The full licence can be found at: http://creativecommons.org/licenses/by-nc-sa/4.0/

public enum CbusRocRailModuleTypes {
// 
// Rocrail Module types
// 
	MTYP_CANGC1(1),	//RS232 PC interface
	MTYP_CANGC2(2),	//16 I/O
	MTYP_CANGC3(3),	//Command station (derived from cancmd)
	MTYP_CANGC4(4),	//8 channel RFID reader
	MTYP_CANGC5(5),	//Cab for fixed panels (derived from cancab)
	MTYP_CANGC6(6),	//4 channel servo controller
	MTYP_CANGC7(7),	//Fast clock module
	MTYP_CANGC1e(11);	//CAN<->Ethernet interface

	private final int v;

	private CbusRocRailModuleTypes(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
