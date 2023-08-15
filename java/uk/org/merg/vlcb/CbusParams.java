/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate_java.sh from vlcb-defs.csv
 */

package uk.org.merg.vlcb;

// Copyright (C) Sven Rosvall (sven@rosvall.ie)
// This file is part of VLCB-Arduino project on https://github.com/SvenRosvall/VLCB-Arduino
// Licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
// The full licence can be found at: http://creativecommons.org/licenses/by-nc-sa/4.0/

public enum CbusParams {
// 
// 
// Parameter index numbers (readable by OPC_RQNPN, returned in OPC_PARAN)
// Index numbers count from 1, subtract 1 for offset into parameter block
// Note that RQNPN with index 0 returns the parameter count
// 
	PAR_NUM(0),	//Number of parameters
	PAR_MANU(1),	//Manufacturer id
	PAR_MINVER(2),	//Minor version letter
	PAR_MTYP(3),	//Module type code
	PAR_EVTNUM(4),	//Number of events supported
	PAR_EVNUM(5),	//Event variables per event
	PAR_NVNUM(6),	//Number of Node variables
	PAR_MAJVER(7),	//Major version number
	PAR_FLAGS(8),	//Node flags
	PAR_CPUID(9),	//Processor type
	PAR_BUSTYPE(10),	//Bus type
	PAR_LOAD(11),	//load address, 4 bytes
	PAR_CPUMID(15),	//CPU manufacturer's id as read from the chip config space, 4 bytes (note - read from cpu at runtime, so not included in checksum)
	PAR_CPUMAN(19),	//CPU manufacturer code
	PAR_BETA(20);	//Beta revision (numeric), or 0 if release

	private final int v;

	private CbusParams(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
