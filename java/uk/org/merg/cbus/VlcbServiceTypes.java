/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate.sh from vlcb-defs.csv
 */ 

package uk.org.merg.cbus;

// Copyright (C) Sven Rosvall (sven@rosvall.ie)
// This file is part of VLCB-Arduino project on https://github.com/SvenRosvall/VLCB-Arduino
// Licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
// The full licence can be found at: http://creativecommons.org/licenses/by-nc-sa/4.0/

public enum VlcbServiceTypes {
// 
// VLCB Service Types
// 
	SERVICE_ID_MNS(1),	//The minimum node service. All modules must implement this.
	SERVICE_ID_NV(2),	//The NV service.
	SERVICE_ID_CAN(3),	//CAN service. Deals with CANID enumeration.
	SERVICE_ID_TEACH(4),	//Old (CBUS) event teaching service.
	SERVICE_ID_PRODUCER(5),	//Event producer service.
	SERVICE_ID_CONSUMER(6),	//Event comsumer service.
	SERVICE_ID_TEACH(7),	//New event teaching service.
	SERVICE_ID_EVENTACK(9),	//Event acknowledge service. Useful for debugging event configuration.
	SERVICE_ID_BOOT(10),	//FCU/PIC bootloader service.
	SERVICE_ID_STREAMING(17);	//Streaming (Long Messages) service.

	private final int v;

	private VlcbServiceTypes(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
