/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate_cs_enums.sh from cbusdefs.csv
 */ 

namespace Merg.Cbus
{

    // 
    // Copyright (C) Pete Brownlow 2011-2020   software@upsys.co.uk
    // Originally derived from opcodes.h (c) Andrew Crosland.
    // CSV version by Ian Hogg inspired by David W Radcliffe
    // 
    // Ver 8v (WIP: not yet released)
    // 
    //   This work is licensed under the:
    //       Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
    //   To view a copy of this license, visit:
    //       http://creativecommons.org/licenses/by-nc-sa/4.0/
    //   or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
    // 
    //   License summary:
    //     You are free to:
    //       Share, copy and redistribute the material in any medium or format
    //       Adapt, remix, transform, and build upon the material
    // 
    //     The licensor cannot revoke these freedoms as long as you follow the license terms.
    // 
    //     Attribution : You must give appropriate credit, provide a link to the license,
    //                    and indicate if changes were made. You may do so in any reasonable manner,
    //                    but not in any way that suggests the licensor endorses you or your use.
    // 
    //     NonCommercial : You may not use the material for commercial purposes. **(see note below)
    // 
    //     ShareAlike : If you remix, transform, or build upon the material, you must distribute
    //                   your contributions under the same license as the original.
    // 
    //     No additional restrictions : You may not apply legal terms or technological measures that
    //                                   legally restrict others from doing anything the license permits.
    // 
    //    ** For commercial use, please contact the original copyright holder(s) to agree licensing terms
    // 
    //     This software is distributed in the hope that it will be useful, but WITHOUT ANY
    //     WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE
    // 
    // Version history:
    // Pete Brownlow,6/4/11,Original from spec version 7e
    // Roger Healey,6/4/11,Add OPC_CMDERR response codes
    // Pete Brownlow,7/6/11,Updated to spec ver 7f and add new module ids
    // Pete Brownlow,4/7/11,Updated to spec ver 7g
    // Pete Brownlow,14/8/11,Updated to spec ver 7h
    // Pete Brownlow,18/2/12,Updated to spec ver 8a, Rocrail and animated modeller module types added
    // Pete Brownlow,10/4/12,Updated to spec ver 8b, extended parameter bytes
    // Pete Brownlow,17/4/12,Updated parameter block definitions, added processor type definitions.
    // Roger Healey,13/7/12,Add CANTOTI
    // Pete Brownlow,15/9/12,Updated to spec ver 8c, added 0x5D ENUM and 0x75 CANID
    // Pete Brownlow,4/1/13,Ver 8d New module types, added 0x5E  NNRST
    // Roger Healey,15/2/13,Now at version d. Added new Module Ids (as per ModuleIds Issue 9) and
    //          Align Processor Ids with constants.inc
    //          Added .(fullstop) before each processor Id > 9
    //          Added OPC_NNRST
    // Roger Healey,27/4/13,Added CANSIG8 and CANSIG64
    // Roger Healey,6/8/13,Added CANCOND8C
    // Roger Healey,22/1/14,Added CANPAN, CANACE3C, CANPanel and CANMIO
    // Pete Brownlow,22/1/14,Ver 8g New module types, OPC_NNRST & OPC_NNRSM, catch up with .inc file
    //          Added parameter definitions for manufacturer's CPU id
    //          Added extern C so can be included by c++ code
    //          Fixed CANGC1e type definition
    // Phil Wheeler,1/2/14,Corrected some typos. Added PRM_BETA, dotted some more decimal numbers
    // Phil Wheeler,9/3/14,Corrected CANSIG MTYP definitions
    // Pete Brownlow,19/4/14,Ver 8h Added module type defs for CANTOTIMIO, CANACE8MIO, CANBIP, CANSOL
    // Pete Brownlow,06/7/15,Ver 8j Add new module types as per modules definitions v17 : CANCDU, CANACC4CDU, CANWiBase, WiCAB, CANWiFi, CANFTT
    //          Add new opcode ALOC, added CPU manufacturer code CPUM_ATMEL
    // Mike Bolton,2/3/16,Ver 8k    Add module type CANRFID8
    // Pete Brownlow,2/7/16,Ver 8m Add new module types CANHNDST, CANTCHNDST, CANmchRFID and CANPiWi
    //          Add processor codes for ARM chips used in Raspberry Pi's
    // Pete Brownlow,16/2/17,Ver 8n Add module ids to bring it up to module ids document ver 25
    // Pete Brownlow,29/7/17,Ver 8p Add new module ids and new cab signalling opcode
    // Pete Brownlow,09/1/18,Ver 8q Add new parameter flag for module can consume its own events
    // Ian Hogg,11/9/18,Ver 8r Added CANACE16CMIO, CANPiNODE, CANDISP, CANCOMPUTE
    // Richard Crawshaw,29/02/2020,Fixed order of columns in CbusCabSigAspect2.
    // Pete Brownlow,01/09/20,Ver 8s for additional module ids defined in the ModuleIds file ver 33.
    //                        Updated descriptive comments for some module types
    //                        Updated CABDAT opcode to match RFC0004
    // Pete Brownlow,06/09/20,Ver 8t Added module type for CANRCOM. Fixed: Opcode for CABDAT, names for CANRC522 and CANMAG
    // Pete Brownlow,13/10/20,Ver 8u Added module types 67 to 74 including some Arduino projects
    //                               Added SPROG manufacturer code 44 and new SPROG CBUS module types
    //                               Additional error code for overload - now removed as not required after all
    //                               New bus type USB for modules with only USB and no CAN
    // Pete Brownlow,19/02/21,Ver 8u Added manufacturer code 13 for new development - who don't have a manufacturer id yet
    //                               Added proccessor identification codes for 18F25k83, 18F26k83 and 18F14K22.
    // Andrew Crosland,21/09/2021,Ver 8t Added PICs P18F14K22 P18F26K83 P18F27Q84 P18F47Q84 and P18F27Q83
    // Andrew Crosland,19/01/2022,Ver 8t, Added OPC_VCVS, Verify CV service mode - used for CV read hints, update SPORG modules types (PR#13)
    // Duncan Greenwood,07/10/2021,Ver 8t Added OPC_DTXC opcode (0xE9) for CBUS long messages
    // Richard Crawshaw,11/10/2021,Ver 8t Fixed trailing comma in CbusCabSigAspect0
    // Pete Brownlow,28/07/2022,Ver 8v Resolve and merge changes in 8u branch with changes subsequently applied to master, now ver 8v in new branch,
    //   							Add requested module type ids 75 to 78
    //                               Resolve changes from PR #13,  move proposed and/or agreed opcodes not yet in the published spec to below the others
    //                               

	/// <summary>
	/// 
	/// </summary>
	public enum ArmProcessors
	{
		/// <summary>
		/// As used in Raspberry Pi
		/// </summary>
		Arm1176jzfS = 1,
		/// <summary>
		/// As Used in Raspberry Pi 2
		/// </summary>
		ArmcortexA7 = 2,
		/// <summary>
		/// As used in Raspberry Pi 3
		/// </summary>
		ArmcortexA53 = 3,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum BusTypes
	{
		/// <summary>
		/// 
		/// </summary>
		PbCan = 1,
		/// <summary>
		/// 
		/// </summary>
		PbEth = 2,
		/// <summary>
		/// 
		/// </summary>
		PbMiwi = 3,
		/// <summary>
		/// 
		/// </summary>
		PbUsb = 4,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum CabSigAspect0
	{
		/// <summary>
		/// 
		/// </summary>
		CdatCabsig = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum CabSigAspect1
	{
		/// <summary>
		/// 
		/// </summary>
		Danger = 0,
		/// <summary>
		/// 
		/// </summary>
		Caution = 1,
		/// <summary>
		/// 
		/// </summary>
		PrelimCaution = 2,
		/// <summary>
		/// 
		/// </summary>
		Proceed = 3,
		/// <summary>
		/// Set bit 2 for call-on - main aspect will usually be at danger
		/// </summary>
		Callon = 4,
		/// <summary>
		/// Set bit 3 to 0 for upper nibble is feather lcoation, set 1 for upper nibble is theatre code
		/// </summary>
		Theatre = 8,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum CabSigAspect2
	{
		/// <summary>
		/// Set bit 0 to indicate lit
		/// </summary>
		Lit = 0,
		/// <summary>
		/// Set bit 1 for lunar indication
		/// </summary>
		Lunar = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum CmdErrs
	{
		/// <summary>
		/// 
		/// </summary>
		InvCmd = 1,
		/// <summary>
		/// 
		/// </summary>
		NotLrn = 2,
		/// <summary>
		/// 
		/// </summary>
		NotSetup = 3,
		/// <summary>
		/// 
		/// </summary>
		TooManyEvents = 4,
		/// <summary>
		/// 
		/// </summary>
		NoEv = 5,
		/// <summary>
		/// 
		/// </summary>
		InvEvIdx = 6,
		/// <summary>
		/// 
		/// </summary>
		InvalidEvent = 7,
		/// <summary>
		/// now reserved
		/// </summary>
		InvEnIdx = 8,
		/// <summary>
		/// 
		/// </summary>
		InvParamIdx = 9,
		/// <summary>
		/// 
		/// </summary>
		InvNvIdx = 10,
		/// <summary>
		/// 
		/// </summary>
		InvEvValue = 11,
		/// <summary>
		/// 
		/// </summary>
		InvNvValue = 12,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum Errs
	{
		/// <summary>
		/// 
		/// </summary>
		LocoStackFull = 1,
		/// <summary>
		/// 
		/// </summary>
		LocoAddrTaken = 2,
		/// <summary>
		/// 
		/// </summary>
		SessionNotPresent = 3,
		/// <summary>
		/// 
		/// </summary>
		ConsistEmpty = 4,
		/// <summary>
		/// 
		/// </summary>
		LocoNotFound = 5,
		/// <summary>
		/// 
		/// </summary>
		CmdRxBufOflow = 6,
		/// <summary>
		/// 
		/// </summary>
		InvalidRequest = 7,
		/// <summary>
		/// 
		/// </summary>
		SessionCancelled = 8,
	}

	/// <summary>
	/// CBUS Manufacturer definitions
	/// </summary>
	public enum Manufacturer
	{
		/// <summary>
		/// For new manufacturer development - who don't have a manufacturer id yet
		/// </summary>
		Dev = 13,
		/// <summary>
		/// https://www.merg.co.uk
		/// </summary>
		Merg = 165,
		/// <summary>
		/// https://www.sprog-dcc.co.uk/
		/// </summary>
		Sprog = 44,
		/// <summary>
		/// http://www.rocrail.net
		/// </summary>
		Rocrail = 70,
		/// <summary>
		/// http://animatedmodeler.com  (Spectrum Engineering)
		/// </summary>
		Spectrum = 80,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum MergModuleTypes
	{
		/// <summary>
		/// default for SLiM nodes
		/// </summary>
		Slim = 0,
		/// <summary>
		/// Solenoid point driver
		/// </summary>
		Canacc4 = 1,
		/// <summary>
		/// Motorised point driver
		/// </summary>
		Canacc5 = 2,
		/// <summary>
		/// 8 digital outputs
		/// </summary>
		Canacc8 = 3,
		/// <summary>
		/// Control panel switch/button encoder
		/// </summary>
		Canace3 = 4,
		/// <summary>
		/// 8 digital inputs
		/// </summary>
		Canace8c = 5,
		/// <summary>
		/// 64 led driver
		/// </summary>
		Canled = 6,
		/// <summary>
		/// 64 led driver (multi leds per event)
		/// </summary>
		Canled64 = 7,
		/// <summary>
		/// 12v version of CANACC4
		/// </summary>
		Canacc42 = 8,
		/// <summary>
		/// CANCAB hand throttle
		/// </summary>
		Cancab = 9,
		/// <summary>
		/// CANCMD command station
		/// </summary>
		Cancmd = 10,
		/// <summary>
		/// 8 servo driver (on canacc8 or similar hardware)
		/// </summary>
		Canservo = 11,
		/// <summary>
		/// BC1a command station
		/// </summary>
		Canbc = 12,
		/// <summary>
		/// RPI and RFID interface
		/// </summary>
		Canrpi = 13,
		/// <summary>
		/// Turntable controller (turntable end)
		/// </summary>
		Canttca = 14,
		/// <summary>
		/// Turntable controller (control panel end)
		/// </summary>
		Canttcb = 15,
		/// <summary>
		/// Handset controller for old BC1a type handsets
		/// </summary>
		Canhs = 16,
		/// <summary>
		/// Track occupancy detector
		/// </summary>
		Cantoti = 17,
		/// <summary>
		/// 8 inputs 8 outputs
		/// </summary>
		Can8i8o = 18,
		/// <summary>
		/// Canservo with servo position feedback
		/// </summary>
		Canservo8c = 19,
		/// <summary>
		/// RFID input
		/// </summary>
		Canrfid = 20,
		/// <summary>
		/// 
		/// </summary>
		Cantc4 = 21,
		/// <summary>
		/// 16 inputs
		/// </summary>
		Canace16c = 22,
		/// <summary>
		/// 8 way I/O
		/// </summary>
		Canio8 = 23,
		/// <summary>
		/// ??
		/// </summary>
		Cansndx = 24,
		/// <summary>
		/// Ethernet interface
		/// </summary>
		Canether = 25,
		/// <summary>
		/// Multiple aspect signalling for CANLED module
		/// </summary>
		Cansig64 = 26,
		/// <summary>
		/// Multiple aspect signalling for CANACC8 module
		/// </summary>
		Cansig8 = 27,
		/// <summary>
		/// Conditional event generation
		/// </summary>
		Cancond8c = 28,
		/// <summary>
		/// Control panel 32/32
		/// </summary>
		Canpan = 29,
		/// <summary>
		/// Newer version of CANACE3 firmware
		/// </summary>
		Canace3c = 30,
		/// <summary>
		/// Control panel 64/64
		/// </summary>
		Canpanel = 31,
		/// <summary>
		/// Multiple I/O – Universal CANMIO firmware
		/// </summary>
		Canmio = 32,
		/// <summary>
		/// Multiple IO module 16 inputs emulating CANACE8C on CANMIO hardware
		/// </summary>
		Canace8mio = 33,
		/// <summary>
		/// Solenoid driver module
		/// </summary>
		Cansol = 34,
		/// <summary>
		/// Universal CANBIP firmware - Bipolar IO module with additional 8 I/O pins (CANMIO family)
		/// </summary>
		Canbip = 35,
		/// <summary>
		/// Solenoid driver module with additional 6 I/O pins (CANMIO family)
		/// </summary>
		Cancdu = 36,
		/// <summary>
		/// CANACC4 firmware ported to CANCDU
		/// </summary>
		Canacc4cdu = 37,
		/// <summary>
		/// CAN to MiWi base station
		/// </summary>
		Canwibase = 38,
		/// <summary>
		/// Wireless cab using MiWi protocol
		/// </summary>
		Wicab = 39,
		/// <summary>
		/// CAN to WiFi connection with Withrottle to CBUS protocol conversion
		/// </summary>
		Canwifi = 40,
		/// <summary>
		/// Turntable controller configured using FLiM
		/// </summary>
		Canftt = 41,
		/// <summary>
		/// Handset (alternative to CANCAB)
		/// </summary>
		Canhndst = 42,
		/// <summary>
		/// Touchscreen handset
		/// </summary>
		Cantchndst = 43,
		/// <summary>
		/// multi-channel RFID reader
		/// </summary>
		Canrfid8 = 44,
		/// <summary>
		/// either a 2ch or 8ch RFID reader
		/// </summary>
		Canmchrfid = 45,
		/// <summary>
		/// a Raspberry Pi based module for WiFi
		/// </summary>
		Canpiwi = 46,
		/// <summary>
		/// DC train controller
		/// </summary>
		Can4dc = 47,
		/// <summary>
		/// Nelevator controller
		/// </summary>
		Canelev = 48,
		/// <summary>
		/// 128 switch inputs
		/// </summary>
		Canscan = 49,
		/// <summary>
		/// 16MHz 25k80 version of CANSERVO8c on CANMIO hardware
		/// </summary>
		CanmioSvo = 50,
		/// <summary>
		/// 16MHz 25k80 version of CANACE8MIO on CANMIO hardware
		/// </summary>
		CanmioInp = 51,
		/// <summary>
		/// 16MHz 25k80 version of CANACC8 on CANMIO hardware
		/// </summary>
		CanmioOut = 52,
		/// <summary>
		/// 16MHz 25k80 version of CANACC5 on CANBIP hardware
		/// </summary>
		CanbipOut = 53,
		/// <summary>
		/// DCC stop generator
		/// </summary>
		Canastop = 54,
		/// <summary>
		/// CANCMD with on board 3A booster
		/// </summary>
		Cancsb = 55,
		/// <summary>
		/// Magnet on Track detector
		/// </summary>
		Canmag = 56,
		/// <summary>
		/// 16 input equivaent to CANACE8C
		/// </summary>
		Canace16cmio = 57,
		/// <summary>
		/// CBUS module based on Raspberry Pi
		/// </summary>
		Canpinode = 58,
		/// <summary>
		/// 25K80 version of CANLED64 (IHart and MB)
		/// </summary>
		Candisp = 59,
		/// <summary>
		/// Compute Event processing engine
		/// </summary>
		Cancompute = 60,
		/// <summary>
		/// Read/Write from/to RC522 RFID tags
		/// </summary>
		Canrc522 = 61,
		/// <summary>
		/// 8 inputs module (2g version of CANACE8c) (Pete Brownlow)
		/// </summary>
		Caninp = 62,
		/// <summary>
		/// 8 outputs module (2g version of CANACC8) (Pete Brownlow)
		/// </summary>
		Canout = 63,
		/// <summary>
		/// Extended CANMIO (24 I/O ports) (Pete Brownlow)
		/// </summary>
		Canemio = 64,
		/// <summary>
		/// DC cab
		/// </summary>
		Cancabdc = 65,
		/// <summary>
		/// DC Railcom detector/reader
		/// </summary>
		Canrcom = 66,
		/// <summary>
		/// MP3 sound player in response to events (eg: station announcements) (Duncan Greenwood)
		/// </summary>
		Canmp3 = 67,
		/// <summary>
		/// Addressed RGB LED driver (Duncan Greenwood)
		/// </summary>
		Canxmas = 68,
		/// <summary>
		/// Servo setting box (Duncan Greenwood)
		/// </summary>
		Cansvoset = 69,
		/// <summary>
		/// DC Command station
		/// </summary>
		Cancmddc = 70,
		/// <summary>
		/// Text message display
		/// </summary>
		Cantext = 71,
		/// <summary>
		/// Signal controller
		/// </summary>
		Canasignal = 72,
		/// <summary>
		/// DCC cab with slider control (Dave Radcliffe)
		/// </summary>
		Canslider = 73,
		/// <summary>
		/// DC ATC module (Dave Harris)
		/// </summary>
		Candcatc = 74,
		/// <summary>
		/// Logic module using and/or gates (Phil Silver)
		/// </summary>
		Cangate = 75,
		/// <summary>
		/// Q series PIC input module (Ian Hart)
		/// </summary>
		Cansinp = 76,
		/// <summary>
		/// Q series PIC input module (Ian Hart)
		/// </summary>
		Cansout = 77,
		/// <summary>
		/// Q series PIC input module (Ian Hart)
		/// </summary>
		Cansbip = 78,
		/// <summary>
		/// Software nodes
		/// </summary>
		CanSw = 0xFF,
		/// <summary>
		/// Empty module, bootloader only
		/// </summary>
		Empty = 0xFE,
		/// <summary>
		/// USB interface
		/// </summary>
		Canusb = 0xFD,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum MicrochipProcessors
	{
		/// <summary>
		/// 
		/// </summary>
		P18F2480 = 1,
		/// <summary>
		/// 
		/// </summary>
		P18F4480 = 2,
		/// <summary>
		/// 
		/// </summary>
		P18F2580 = 3,
		/// <summary>
		/// 
		/// </summary>
		P18F4580 = 4,
		/// <summary>
		/// 
		/// </summary>
		P18F2585 = 5,
		/// <summary>
		/// 
		/// </summary>
		P18F4585 = 6,
		/// <summary>
		/// 
		/// </summary>
		P18F2680 = 7,
		/// <summary>
		/// 
		/// </summary>
		P18F4680 = 8,
		/// <summary>
		/// 
		/// </summary>
		P18F2682 = 9,
		/// <summary>
		/// 
		/// </summary>
		P18F4682 = 10,
		/// <summary>
		/// 
		/// </summary>
		P18F2685 = 11,
		/// <summary>
		/// 
		/// </summary>
		P18F4685 = 12,
		/// <summary>
		/// 
		/// </summary>
		P18F25K80 = 13,
		/// <summary>
		/// 
		/// </summary>
		P18F45K80 = 14,
		/// <summary>
		/// 
		/// </summary>
		P18F26K80 = 15,
		/// <summary>
		/// 
		/// </summary>
		P18F46K80 = 16,
		/// <summary>
		/// 
		/// </summary>
		P18F65K80 = 17,
		/// <summary>
		/// 
		/// </summary>
		P18F66K80 = 18,
		/// <summary>
		/// 
		/// </summary>
		P18F25K83 = 19,
		/// <summary>
		/// 
		/// </summary>
		P18F26K83 = 20,
		/// <summary>
		/// 
		/// </summary>
		P18F27Q84 = 21,
		/// <summary>
		/// 
		/// </summary>
		P18F47Q84 = 22,
		/// <summary>
		/// 
		/// </summary>
		P18F27Q83 = 23,
		/// <summary>
		/// 
		/// </summary>
		P18F14K22 = 25,
		/// <summary>
		/// 
		/// </summary>
		P32MX534F064 = 30,
		/// <summary>
		/// 
		/// </summary>
		P32MX564F064 = 31,
		/// <summary>
		/// 
		/// </summary>
		P32MX564F128 = 32,
		/// <summary>
		/// 
		/// </summary>
		P32MX575F256 = 33,
		/// <summary>
		/// 
		/// </summary>
		P32MX575F512 = 34,
		/// <summary>
		/// 
		/// </summary>
		P32MX764F128 = 35,
		/// <summary>
		/// 
		/// </summary>
		P32MX775F256 = 36,
		/// <summary>
		/// 
		/// </summary>
		P32MX775F512 = 37,
		/// <summary>
		/// 
		/// </summary>
		P32MX795F512 = 38,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum OpCodes
	{
		/// <summary>
		/// General ack
		/// </summary>
		Ack = 0x00,
		/// <summary>
		/// General nak
		/// </summary>
		Nak = 0x01,
		/// <summary>
		/// Bus Halt
		/// </summary>
		Hlt = 0x02,
		/// <summary>
		/// Bus on
		/// </summary>
		Bon = 0x03,
		/// <summary>
		/// Track off
		/// </summary>
		Tof = 0x04,
		/// <summary>
		/// Track on
		/// </summary>
		Ton = 0x05,
		/// <summary>
		/// Track stopped
		/// </summary>
		Estop = 0x06,
		/// <summary>
		/// System reset
		/// </summary>
		Arst = 0x07,
		/// <summary>
		/// Request track off
		/// </summary>
		Rtof = 0x08,
		/// <summary>
		/// Request track on
		/// </summary>
		Rton = 0x09,
		/// <summary>
		/// Request emergency stop all
		/// </summary>
		Restp = 0x0a,
		/// <summary>
		/// Request node status
		/// </summary>
		Rstat = 0x0c,
		/// <summary>
		/// Query nodes
		/// </summary>
		Qnn = 0x0d,
		/// <summary>
		/// Read node parameters
		/// </summary>
		Rqnp = 0x10,
		/// <summary>
		/// Request name of module type
		/// </summary>
		Rqmn = 0x11,
		/// <summary>
		/// Release engine by handle
		/// </summary>
		Kloc = 0x21,
		/// <summary>
		/// Query engine by handle
		/// </summary>
		Qloc = 0x22,
		/// <summary>
		/// Keep alive for cab
		/// </summary>
		Dkeep = 0x23,
		/// <summary>
		/// Debug message with 1 status byte
		/// </summary>
		Dbg1 = 0x30,
		/// <summary>
		/// Extended opcode
		/// </summary>
		Extc = 0x3F,
		/// <summary>
		/// Request session for loco
		/// </summary>
		Rloc = 0x40,
		/// <summary>
		/// Query consist
		/// </summary>
		Qcon = 0x41,
		/// <summary>
		/// Set node number
		/// </summary>
		Snn = 0x42,
		/// <summary>
		/// Allocate loco (used to allocate to a shuttle in cancmd)
		/// </summary>
		Aloc = 0X43,
		/// <summary>
		/// Set Throttle mode
		/// </summary>
		Stmod = 0x44,
		/// <summary>
		/// Consist loco
		/// </summary>
		Pcon = 0x45,
		/// <summary>
		/// De-consist loco
		/// </summary>
		Kcon = 0x46,
		/// <summary>
		/// Loco speed/dir
		/// </summary>
		Dspd = 0x47,
		/// <summary>
		/// Set engine flags
		/// </summary>
		Dflg = 0x48,
		/// <summary>
		/// Loco function on
		/// </summary>
		Dfnon = 0x49,
		/// <summary>
		/// Loco function off
		/// </summary>
		Dfnof = 0x4A,
		/// <summary>
		/// Service mode status
		/// </summary>
		Sstat = 0x4C,
		/// <summary>
		/// Reset to manufacturer's defaults
		/// </summary>
		Nnrsm = 0x4F,
		/// <summary>
		/// Request Node number in setup mode
		/// </summary>
		Rqnn = 0x50,
		/// <summary>
		/// Node number release
		/// </summary>
		Nnrel = 0x51,
		/// <summary>
		/// Node number acknowledge
		/// </summary>
		Nnack = 0x52,
		/// <summary>
		/// Set learn mode
		/// </summary>
		Nnlrn = 0x53,
		/// <summary>
		/// Release learn mode
		/// </summary>
		Nnuln = 0x54,
		/// <summary>
		/// Clear all events
		/// </summary>
		Nnclr = 0x55,
		/// <summary>
		/// Read available event slots
		/// </summary>
		Nnevn = 0x56,
		/// <summary>
		/// Read all stored events
		/// </summary>
		Nerd = 0x57,
		/// <summary>
		/// Read number of stored events
		/// </summary>
		Rqevn = 0x58,
		/// <summary>
		/// Write acknowledge
		/// </summary>
		Wrack = 0x59,
		/// <summary>
		/// Request node data event
		/// </summary>
		Rqdat = 0x5A,
		/// <summary>
		/// Request short data frame
		/// </summary>
		Rqdds = 0x5B,
		/// <summary>
		/// Put node into boot mode
		/// </summary>
		Boot = 0x5C,
		/// <summary>
		/// Force can_id self enumeration
		/// </summary>
		Enum = 0x5D,
		/// <summary>
		/// Reset node (as in restart)
		/// </summary>
		Nnrst = 0x5E,
		/// <summary>
		/// Extended opcode with 1 data byte
		/// </summary>
		Extc1 = 0x5F,
		/// <summary>
		/// Set engine functions
		/// </summary>
		Dfun = 0x60,
		/// <summary>
		/// Get loco (with support for steal/share)
		/// </summary>
		Gloc = 0x61,
		/// <summary>
		/// Command station error
		/// </summary>
		Err = 0x63,
		/// <summary>
		/// Errors from nodes during config
		/// </summary>
		Cmderr = 0x6F,
		/// <summary>
		/// Event slots left response
		/// </summary>
		Evnlf = 0x70,
		/// <summary>
		/// Request read of node variable
		/// </summary>
		Nvrd = 0x71,
		/// <summary>
		/// Request read stored event by index
		/// </summary>
		Nenrd = 0x72,
		/// <summary>
		/// Request read module parameters
		/// </summary>
		Rqnpn = 0x73,
		/// <summary>
		/// Number of events stored response
		/// </summary>
		Numev = 0x74,
		/// <summary>
		/// Set canid
		/// </summary>
		Canid = 0x75,
		/// <summary>
		/// Extended opcode with 2 data bytes
		/// </summary>
		Extc2 = 0x7F,
		/// <summary>
		/// 3 byte DCC packet
		/// </summary>
		Rdcc3 = 0x80,
		/// <summary>
		/// Write CV byte Ops mode by handle
		/// </summary>
		Wcvo = 0x82,
		/// <summary>
		/// Write CV bit Ops mode by handle
		/// </summary>
		Wcvb = 0x83,
		/// <summary>
		/// Read CV
		/// </summary>
		Qcvs = 0x84,
		/// <summary>
		/// Report CV
		/// </summary>
		Pcvs = 0x85,
		/// <summary>
		/// on event
		/// </summary>
		Acon = 0x90,
		/// <summary>
		/// off event
		/// </summary>
		Acof = 0x91,
		/// <summary>
		/// Accessory Request event
		/// </summary>
		Areq = 0x92,
		/// <summary>
		/// Accessory response event on
		/// </summary>
		Aron = 0x93,
		/// <summary>
		/// Accessory response event off
		/// </summary>
		Arof = 0x94,
		/// <summary>
		/// Unlearn event
		/// </summary>
		Evuln = 0x95,
		/// <summary>
		/// Set a node variable
		/// </summary>
		Nvset = 0x96,
		/// <summary>
		/// Node variable value response
		/// </summary>
		Nvans = 0x97,
		/// <summary>
		/// Short event on
		/// </summary>
		Ason = 0x98,
		/// <summary>
		/// Short event off
		/// </summary>
		Asof = 0x99,
		/// <summary>
		/// Short Request event
		/// </summary>
		Asrq = 0x9A,
		/// <summary>
		/// Single node parameter response
		/// </summary>
		Paran = 0x9B,
		/// <summary>
		/// Request read of event variable
		/// </summary>
		Reval = 0x9C,
		/// <summary>
		/// Accessory short response on event
		/// </summary>
		Arson = 0x9D,
		/// <summary>
		/// Accessory short response off event
		/// </summary>
		Arsof = 0x9E,
		/// <summary>
		/// Extended opcode with 3 data bytes
		/// </summary>
		Extc3 = 0x9F,
		/// <summary>
		/// 4 byte DCC packet
		/// </summary>
		Rdcc4 = 0xA0,
		/// <summary>
		/// Write CV service mode
		/// </summary>
		Wcvs = 0xA2,
		/// <summary>
		/// On event with one data byte
		/// </summary>
		Acon1 = 0xB0,
		/// <summary>
		/// Off event with one data byte
		/// </summary>
		Acof1 = 0xB1,
		/// <summary>
		/// Read event variable in learn mode
		/// </summary>
		Reqev = 0xB2,
		/// <summary>
		/// Accessory on response (1 data byte)
		/// </summary>
		Aron1 = 0xB3,
		/// <summary>
		/// Accessory off response (1 data byte)
		/// </summary>
		Arof1 = 0xB4,
		/// <summary>
		/// Event variable by index read response
		/// </summary>
		Neval = 0xB5,
		/// <summary>
		/// Response to QNN
		/// </summary>
		Pnn = 0xB6,
		/// <summary>
		/// Accessory short on with 1 data byte
		/// </summary>
		Ason1 = 0xB8,
		/// <summary>
		/// Accessory short off with 1 data byte
		/// </summary>
		Asof1 = 0xB9,
		/// <summary>
		/// Short response event on with one data byte
		/// </summary>
		Arson1 = 0xBD,
		/// <summary>
		/// Short response event off with one data byte
		/// </summary>
		Arsof1 = 0xBE,
		/// <summary>
		/// Extended opcode with 4 data bytes
		/// </summary>
		Extc4 = 0xBF,
		/// <summary>
		/// 5 byte DCC packet
		/// </summary>
		Rdcc5 = 0xC0,
		/// <summary>
		/// Write CV ops mode by address
		/// </summary>
		Wcvoa = 0xC1,
		/// <summary>
		/// Cab data (cab signalling)
		/// </summary>
		Cabdat = 0xC2,
		/// <summary>
		/// Fast clock
		/// </summary>
		Fclk = 0xCF,
		/// <summary>
		/// On event with two data bytes
		/// </summary>
		Acon2 = 0xD0,
		/// <summary>
		/// Off event with two data bytes
		/// </summary>
		Acof2 = 0xD1,
		/// <summary>
		/// Teach event
		/// </summary>
		Evlrn = 0xd2,
		/// <summary>
		/// Event variable read response in learn mode
		/// </summary>
		Evans = 0xd3,
		/// <summary>
		/// Accessory on response
		/// </summary>
		Aron2 = 0xD4,
		/// <summary>
		/// Accessory off response
		/// </summary>
		Arof2 = 0xD5,
		/// <summary>
		/// Accessory short on with 2 data bytes
		/// </summary>
		Ason2 = 0xD8,
		/// <summary>
		/// Accessory short off with 2 data bytes
		/// </summary>
		Asof2 = 0xD9,
		/// <summary>
		/// Short response event on with two data bytes
		/// </summary>
		Arson2 = 0xDD,
		/// <summary>
		/// Short response event off with two data bytes
		/// </summary>
		Arsof2 = 0xDE,
		/// <summary>
		/// Extended opcode with 5 data bytes
		/// </summary>
		Extc5 = 0xDF,
		/// <summary>
		/// 6 byte DCC packets
		/// </summary>
		Rdcc6 = 0xE0,
		/// <summary>
		/// Loco session report
		/// </summary>
		Ploc = 0xE1,
		/// <summary>
		/// Module name response
		/// </summary>
		Name = 0xE2,
		/// <summary>
		/// Command station status report
		/// </summary>
		Stat = 0xE3,
		/// <summary>
		/// Node parameters response
		/// </summary>
		Params = 0xEF,
		/// <summary>
		/// On event with 3 data bytes
		/// </summary>
		Acon3 = 0xF0,
		/// <summary>
		/// Off event with 3 data bytes
		/// </summary>
		Acof3 = 0xF1,
		/// <summary>
		/// Read node events response
		/// </summary>
		Enrsp = 0xF2,
		/// <summary>
		/// Accessory on response
		/// </summary>
		Aron3 = 0xF3,
		/// <summary>
		/// Accessory off response
		/// </summary>
		Arof3 = 0xF4,
		/// <summary>
		/// Teach event using event indexing
		/// </summary>
		Evlrni = 0xF5,
		/// <summary>
		/// Accessory data event: 5 bytes of node data (eg: RFID)
		/// </summary>
		Acdat = 0xF6,
		/// <summary>
		/// Accessory data response
		/// </summary>
		Ardat = 0xF7,
		/// <summary>
		/// Accessory short on with 3 data bytes
		/// </summary>
		Ason3 = 0xF8,
		/// <summary>
		/// Accessory short off with 3 data bytes
		/// </summary>
		Asof3 = 0xF9,
		/// <summary>
		/// Short data frame aka device data event (device id plus 5 data bytes)
		/// </summary>
		Ddes = 0xFA,
		/// <summary>
		/// Short data frame response aka device data response
		/// </summary>
		Ddrs = 0xFB,
		/// <summary>
		/// Device Data Write Short
		/// </summary>
		Ddws = 0xFC,
		/// <summary>
		/// Short response event on with 3 data bytes
		/// </summary>
		Arson3 = 0xFD,
		/// <summary>
		/// Short response event off with 3 data bytes
		/// </summary>
		Arsof3 = 0xFE,
		/// <summary>
		/// Extended opcode with 6 data byes
		/// </summary>
		Extc6 = 0xFF,
		/// <summary>
		/// Verify CV service mode - used for CV read hints
		/// </summary>
		Vcvs = 0xA4,
		/// <summary>
		/// CBUS long message packet
		/// </summary>
		Dtxc = 0xE9,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum ParamFlags
	{
		/// <summary>
		/// Module doesn't support events
		/// </summary>
		Noevents = 0,
		/// <summary>
		/// Module is a consumer of events
		/// </summary>
		Consumer = 1,
		/// <summary>
		/// Module is a producer of events
		/// </summary>
		Producer = 2,
		/// <summary>
		/// Module is both a consumer and producer of events
		/// </summary>
		Combi = 3,
		/// <summary>
		/// Module is in FLiM
		/// </summary>
		Flim = 4,
		/// <summary>
		/// Module supports the FCU bootloader protocol
		/// </summary>
		Boot = 8,
		/// <summary>
		/// Module can consume its own events
		/// </summary>
		Coe = 16,
		/// <summary>
		/// Module is in learn mode
		/// </summary>
		Lrn = 32,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum ParamOffsetsPic
	{
		/// <summary>
		/// Number of parameters implemented
		/// </summary>
		Count = 0x18,
		/// <summary>
		/// 4 byte Address of Module type name, up to 8 characters null terminated
		/// </summary>
		Name = 0x1A,
		/// <summary>
		/// Checksum word at end of parameters
		/// </summary>
		Cksum = 0x1E,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum Params
	{
		/// <summary>
		/// Manufacturer id
		/// </summary>
		Manu = 1,
		/// <summary>
		/// Minor version letter
		/// </summary>
		Minver = 2,
		/// <summary>
		/// Module type code
		/// </summary>
		Mtyp = 3,
		/// <summary>
		/// Number of events supported
		/// </summary>
		Evtnum = 4,
		/// <summary>
		/// Event variables per event
		/// </summary>
		Evnum = 5,
		/// <summary>
		/// Number of Node variables
		/// </summary>
		Nvnum = 6,
		/// <summary>
		/// Major version number
		/// </summary>
		Majver = 7,
		/// <summary>
		/// Node flags
		/// </summary>
		Flags = 8,
		/// <summary>
		/// Processor type
		/// </summary>
		Cpuid = 9,
		/// <summary>
		/// Bus type
		/// </summary>
		Bustype = 10,
		/// <summary>
		/// load address, 4 bytes
		/// </summary>
		Load = 11,
		/// <summary>
		/// CPU manufacturer's id as read from the chip config space, 4 bytes (note - read from cpu at runtime, so not included in checksum)
		/// </summary>
		Cpumid = 15,
		/// <summary>
		/// CPU manufacturer code
		/// </summary>
		Cpuman = 19,
		/// <summary>
		/// Beta revision (numeric), or 0 if release
		/// </summary>
		Beta = 20,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum ProcessorManufacturers
	{
		/// <summary>
		/// 
		/// </summary>
		Microchip = 1,
		/// <summary>
		/// 
		/// </summary>
		Atmel = 2,
		/// <summary>
		/// 
		/// </summary>
		Arm = 3,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum RocRailModuleTypes
	{
		/// <summary>
		/// RS232 PC interface
		/// </summary>
		Cangc1 = 1,
		/// <summary>
		/// 16 I/O
		/// </summary>
		Cangc2 = 2,
		/// <summary>
		/// Command station (derived from cancmd)
		/// </summary>
		Cangc3 = 3,
		/// <summary>
		/// 8 channel RFID reader
		/// </summary>
		Cangc4 = 4,
		/// <summary>
		/// Cab for fixed panels (derived from cancab)
		/// </summary>
		Cangc5 = 5,
		/// <summary>
		/// 4 channel servo controller
		/// </summary>
		Cangc6 = 6,
		/// <summary>
		/// Fast clock module
		/// </summary>
		Cangc7 = 7,
		/// <summary>
		/// CAN<->Ethernet interface
		/// </summary>
		Cangc1e = 11,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum SStats
	{
		/// <summary>
		/// 
		/// </summary>
		NoAck = 1,
		/// <summary>
		/// 
		/// </summary>
		Ovld = 2,
		/// <summary>
		/// 
		/// </summary>
		WrAck = 3,
		/// <summary>
		/// 
		/// </summary>
		Busy = 4,
		/// <summary>
		/// 
		/// </summary>
		CvError = 5,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum SpectrumModuleTypes
	{
		/// <summary>
		/// Animation controller (firmware derived from cancmd)
		/// </summary>
		Amctrlr = 1,
		/// <summary>
		/// Dual cab based on cancab
		/// </summary>
		Dualcab = 2,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum SprogModuleTypes
	{
		/// <summary>
		/// Pi-SPROG 3 programmer/command station
		/// </summary>
		Canpisprg3 = 1,
		/// <summary>
		/// SPROG 3 Plus programmer/command station
		/// </summary>
		Cansprog3p = 2,
		/// <summary>
		/// CAN SPROG programmer/command station
		/// </summary>
		Cansprog = 3,
		/// <summary>
		/// System Booster
		/// </summary>
		Cansboost = 4,
		/// <summary>
		/// Pi-SPROG 3 Plus programmer/command station
		/// </summary>
		Canpisprgp = 5,
		/// <summary>
		/// CAN ISB Isolated CAN USB Interface
		/// </summary>
		Canisb = 6,
		/// <summary>
		/// 8-channel I/O module
		/// </summary>
		Canio = 7,
		/// <summary>
		/// 8-channel Servo I/O module
		/// </summary>
		Canservoio = 8,
		/// <summary>
		/// 8-channel (4-pairs) Solenoid I/O module
		/// </summary>
		Cansolio = 9,
	}

	/// <summary>
	/// 
	/// </summary>
	public enum StmodModes
	{
		/// <summary>
		/// 
		/// </summary>
		SpdMask = 3,
		/// <summary>
		/// 
		/// </summary>
		Spd128 = 0,
		/// <summary>
		/// 
		/// </summary>
		Spd14 = 1,
		/// <summary>
		/// 
		/// </summary>
		Spd28i = 2,
		/// <summary>
		/// 
		/// </summary>
		Spd28 = 3,
	}

}
