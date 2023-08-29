/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate_java.sh from vlcb-defs.csv
 */

package uk.org.merg.vlcb;

// Copyright (C) Sven Rosvall (sven@rosvall.ie)
// This file is part of VLCB-Arduino project on https://github.com/SvenRosvall/VLCB-Arduino
// Licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
// The full licence can be found at: http://creativecommons.org/licenses/by-nc-sa/4.0/

public enum VlcbGrspCodes {
// 
// GRSP codes
// 
	GRSP_OK(0),	//Success
	GRSP_UNKNOWN_NVM_TYPE(254),	//Unknown non volatile memory type
	GRSP_INVALID_DIAGNOSTIC(253),	//Invalid diagnostic
	GRSP_INVALID_SERVICE(252),	//Invalid service
	GRSP_INVALID_COMMAND_PARAMETER(251),	//Invalid parameter in command
	GRSP_INVALID_MODE(250);	//Invalid Mode

	private final int v;

	private VlcbGrspCodes(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
