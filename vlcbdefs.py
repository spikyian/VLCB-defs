# DO NOT EDIT THIS FILE.
# This file is automatically generated by ./generate_py.sh from vlcb-defs.csv
#

from micropython import const

#         Copyright (C) Sven Rosvall (sven@rosvall.ie)
#         This file is part of VLCB-Arduino project on https://github.com/SvenRosvall/VLCB-Arduino
#         Licensed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
#         The full licence can be found at: http://creativecommons.org/licenses/by-nc-sa/4.0/
# 
# Manufacturer definitions
# Where the manufacturer already has an NMRA code, this is used
# 
MANU_DEV = const(13)    # For new manufacturer development - who don't have a manufacturer id yet
MANU_MERG = const(165)    # https://www.merg.co.uk
MANU_SPROG = const(44)    # https://www.sprog-dcc.co.uk/
MANU_ROCRAIL = const(70)    # http://www.rocrail.net
MANU_SPECTRUM = const(80)    # http://animatedmodeler.com  (Spectrum Engineering)
MANU_MERG_VLCB = const(250)    # range of MERG VLCB modules
MANU_SYSPIXIE = const(249)    # Konrad Orlowski
MANU_RME = const(248)    # http://rmeuk.com  (Railway Modelling Experts Limited)
# 
# 
# MODULE TYPES
# 
# Please note that the existence of a module type id does not necessarily mean that firmware has been implemented
# 
# MERG Module types
# 
MTYP_SLIM = const(0)    # default for SLiM nodes
MTYP_CANACC4 = const(1)    # Solenoid point driver
MTYP_CANACC5 = const(2)    # Motorised point driver
MTYP_CANACC8 = const(3)    # 8 digital outputs
MTYP_CANACE3 = const(4)    # Control panel switch/button encoder
MTYP_CANACE8C = const(5)    # 8 digital inputs
MTYP_CANLED = const(6)    # 64 led driver
MTYP_CANLED64 = const(7)    # 64 led driver (multi leds per event)
MTYP_CANACC4_2 = const(8)    # 12v version of CANACC4
MTYP_CANCAB = const(9)    # CANCAB hand throttle
MTYP_CANCMD = const(10)    # CANCMD command station
MTYP_CANSERVO = const(11)    # 8 servo driver (on canacc8 or similar hardware)
MTYP_CANBC = const(12)    # BC1a command station
MTYP_CANRPI = const(13)    # RPI and RFID interface
MTYP_CANTTCA = const(14)    # Turntable controller (turntable end)
MTYP_CANTTCB = const(15)    # Turntable controller (control panel end)
MTYP_CANHS = const(16)    # Handset controller for old BC1a type handsets
MTYP_CANTOTI = const(17)    # Track occupancy detector
MTYP_CAN8I8O = const(18)    # 8 inputs 8 outputs
MTYP_CANSERVO8C = const(19)    # Canservo with servo position feedback
MTYP_CANRFID = const(20)    # RFID input
MTYP_CANTC4 = const(21)    # 
MTYP_CANACE16C = const(22)    # 16 inputs
MTYP_CANIO8 = const(23)    # 8 way I/O
MTYP_CANSNDX = const(24)    # ??
MTYP_CANEther = const(25)    # Ethernet interface
MTYP_CANSIG64 = const(26)    # Multiple aspect signalling for CANLED module
MTYP_CANSIG8 = const(27)    # Multiple aspect signalling for CANACC8 module
MTYP_CANCOND8C = const(28)    # Conditional event generation
MTYP_CANPAN = const(29)    # Control panel 32/32
MTYP_CANACE3C = const(30)    # Newer version of CANACE3 firmware
MTYP_CANPanel = const(31)    # Control panel 64/64
MTYP_CANMIO = const(32)    # Multiple I/O – Universal CANMIO firmware
MTYP_CANACE8MIO = const(33)    # Multiple IO module 16 inputs emulating CANACE8C on CANMIO hardware
MTYP_CANSOL = const(34)    # Solenoid driver module
MTYP_CANBIP = const(35)    # Universal CANBIP firmware - Bipolar IO module with additional 8 I/O pins (CANMIO family)
MTYP_CANCDU = const(36)    # Solenoid driver module with additional 6 I/O pins (CANMIO family)
MTYP_CANACC4CDU = const(37)    # CANACC4 firmware ported to CANCDU
MTYP_CANWiBase = const(38)    # CAN to MiWi base station
MTYP_WiCAB = const(39)    # Wireless cab using MiWi protocol
MTYP_CANWiFi = const(40)    # CAN to WiFi connection with Withrottle to CBUS protocol conversion
MTYP_CANFTT = const(41)    # Turntable controller configured using FLiM
MTYP_CANHNDST = const(42)    # Handset (alternative to CANCAB)
MTYP_CANTCHNDST = const(43)    # Touchscreen handset
MTYP_CANRFID8 = const(44)    # multi-channel RFID reader
MTYP_CANmchRFID = const(45)    # either a 2ch or 8ch RFID reader
MTYP_CANPiWi = const(46)    # a Raspberry Pi based module for WiFi
MTYP_CAN4DC = const(47)    # DC train controller
MTYP_CANELEV = const(48)    # Nelevator controller
MTYP_CANSCAN = const(49)    # 128 switch inputs
MTYP_CANMIO_SVO = const(50)    # 16MHz 25k80 version of CANSERVO8c on CANMIO hardware
MTYP_CANMIO_INP = const(51)    # 16MHz 25k80 version of CANACE8MIO on CANMIO hardware
MTYP_CANMIO_OUT = const(52)    # 16MHz 25k80 version of CANACC8 on CANMIO hardware
MTYP_CANBIP_OUT = const(53)    # 16MHz 25k80 version of CANACC5 on CANBIP hardware
MTYP_CANASTOP = const(54)    # DCC stop generator
MTYP_CANCSB = const(55)    # CANCMD with on board 3A booster
MTYP_CANMAG = const(56)    # Magnet on Track detector
MTYP_CANACE16CMIO = const(57)    # 16 input equivaent to CANACE8C
MTYP_CANPiNODE = const(58)    # CBUS module based on Raspberry Pi
MTYP_CANDISP = const(59)    # 25K80 version of CANLED64 (IHart and MB)
MTYP_CANCOMPUTE = const(60)    # Compute Event processing engine
MTYP_CANRC522 = const(61)    # Read/Write from/to RC522 RFID tags
MTYP_CANINP = const(62)    # 8 inputs module (2g version of CANACE8c) (Pete Brownlow)
MTYP_CANOUT = const(63)    # 8 outputs module (2g version of CANACC8) (Pete Brownlow)
MTYP_CANXIO = const(64)    # Extended CANMIO (24 I/O ports) (Pete Brownlow)
MTYP_CANCABDC = const(65)    # DC cab
MTYP_CANRCOM = const(66)    # DC Railcom detector/reader
MTYP_CANMP3 = const(67)    # MP3 sound player in response to events (eg: station announcements) (Duncan Greenwood)
MTYP_CANXMAS = const(68)    # Addressed RGB LED driver (Duncan Greenwood)
MTYP_CANSVOSET = const(69)    # Servo setting box (Duncan Greenwood)
MTYP_CANCMDDC = const(70)    # DC Command station
MTYP_CANTEXT = const(71)    # Text message display
MTYP_CANASIGNAL = const(72)    # Signal controller
MTYP_CANSLIDER = const(73)    # DCC cab with slider control (Dave Radcliffe)
MTYP_CANDCATC = const(74)    # DC ATC module (Dave Harris)
MTYP_CANGATE = const(75)    # Logic module using and/or gates (Phil Silver)
MTYP_CANSINP = const(76)    # Q series PIC input module (Ian Hart)
MTYP_CANSOUT = const(77)    # Q series PIC input module (Ian Hart)
MTYP_CANSBIP = const(78)    # Q series PIC input module (Ian Hart)
MTYP_CANBUFFER = const(79)    # Message buffer (Phil Silver)
MTYP_CANLEVER = const(80)    # Lever frame module (Tim Coombs)
MTYP_CANSHIELD = const(81)    # Kit 110 Arduino shield test firmware
MTYP_CAN4IN4OUT = const(82)    # 4 inputs 4 outputs (Arduino module)
MTYP_CANCMDB = const(83)    # CANCMD with built in booster (Simon West)
MTYP_CANPIXEL = const(84)    # neopixel driver (Jon Denham)
MTYP_CANCABPE = const(85)    # Cab2 with pot or encoder (Simon West hardware, Jon Denham new C firmware)
MTYP_CANSMARTTD = const(86)    # Smart train detector (Michael Smith)
MTYP_VLCB = const(0xFC)    # All VLCB modules have the same ID
# 
# 
# 
# At the time of writing the list of defined MERG module types is maintained by Pete Brownlow software@upsys.co.uk
# Please liaise with Pete before adding new module types, 
# and/or create your own GitHub branch, add your proposed new module type(s) and then create a Pull Request
# 
MTYP_CAN_SW = const(0xFF)    # Software nodes
MTYP_EMPTY = const(0xFE)    # Empty module, bootloader only
MTYP_CANUSB = const(0xFD)    # USB interface
MTYP_CANDEV = const(0xFC)    # Module type for use by developers when developing something new
# 
# Sprog Module types
# 
MTYP_CANPiSPRG3 = const(1)    # Pi-SPROG 3 programmer/command station
MTYP_CANSPROG3P = const(2)    # SPROG 3 Plus programmer/command station
MTYP_CANSPROG = const(3)    # CAN SPROG programmer/command station
MTYP_CANSBOOST = const(4)    # System Booster
MTYP_CANPiSPRGP = const(5)    # Pi-SPROG 3 Plus programmer/command station
MTYP_CANSOLNOID  = const(8)    # 8-channel (4-pairs) Solenoid I/O module
MTYP_CANSERVOIO = const(50)    # 8-channel Servo I/O module
MTYP_CANISB = const(100)    # CAN ISB Isolated CAN USB Interface
MTYP_CANSOLIO  = const(101)    # 8-channel (4-pairs) Solenoid I/O module
# 
# 
# Rocrail Module types
# 
MTYP_CANGC1 = const(1)    # RS232 PC interface
MTYP_CANGC2 = const(2)    # 16 I/O
MTYP_CANGC3 = const(3)    # Command station (derived from cancmd)
MTYP_CANGC4 = const(4)    # 8 channel RFID reader
MTYP_CANGC5 = const(5)    # Cab for fixed panels (derived from cancab)
MTYP_CANGC6 = const(6)    # 4 channel servo controller
MTYP_CANGC7 = const(7)    # Fast clock module
MTYP_CANGC1e = const(11)    # CAN<->Ethernet interface
# 
# Spectrum Engineering Animated Modeller module types
# 
MTYP_AMCTRLR = const(1)    # Animation controller (firmware derived from cancmd)
MTYP_DUALCAB = const(2)    # Dual cab based on cancab
# 
# 
# SysPixie Module types (Konrad Orlowski)
# 
MTYP_CANPMSense = const(1)    # Motorised point motor driver with current sense
# 
# 
# 
# VLCB opcodes list
# 
# Packets with no data bytes
# 
OPC_ACK = const(0x00)    # General ack
OPC_NAK = const(0x01)    # General nak
OPC_HLT = const(0x02)    # Bus Halt
OPC_BON = const(0x03)    # Bus on
OPC_TOF = const(0x04)    # Track off
OPC_TON = const(0x05)    # Track on
OPC_ESTOP = const(0x06)    # Track stopped
OPC_ARST = const(0x07)    # System reset
OPC_RTOF = const(0x08)    # Request track off
OPC_RTON = const(0x09)    # Request track on
OPC_RESTP = const(0x0a)    # Request emergency stop all
OPC_RSTAT = const(0x0c)    # Request node status
OPC_QNN = const(0x0d)    # Query nodes
# 
OPC_RQNP = const(0x10)    # Read node parameters
OPC_RQMN = const(0x11)    # Request name of module type
# 
# Packets with 1 data byte
# 
OPC_KLOC = const(0x21)    # Release engine by handle
OPC_QLOC = const(0x22)    # Query engine by handle
OPC_DKEEP = const(0x23)    # Keep alive for cab
# 
OPC_DBG1 = const(0x30)    # Debug message with 1 status byte
OPC_EXTC = const(0x3F)    # Extended opcode
# 
# Packets with 2 data bytes
# 
OPC_RLOC = const(0x40)    # Request session for loco
OPC_QCON = const(0x41)    # Query consist
OPC_SNN = const(0x42)    # Set node number
OPC_ALOC = const(0X43)    # Allocate loco (used to allocate to a shuttle in cancmd)
# 
OPC_STMOD = const(0x44)    # Set Throttle mode
OPC_PCON = const(0x45)    # Consist loco
OPC_KCON = const(0x46)    # De-consist loco
OPC_DSPD = const(0x47)    # Loco speed/dir
OPC_DFLG = const(0x48)    # Set engine flags
OPC_DFNON = const(0x49)    # Loco function on
OPC_DFNOF = const(0x4A)    # Loco function off
OPC_SSTAT = const(0x4C)    # Service mode status
OPC_NNRSM = const(0x4F)    # Reset to manufacturer's defaults
# 
OPC_RQNN = const(0x50)    # Request Node number in setup mode
OPC_NNREL = const(0x51)    # Node number release
OPC_NNACK = const(0x52)    # Node number acknowledge
OPC_NNLRN = const(0x53)    # Set learn mode
OPC_NNULN = const(0x54)    # Release learn mode
OPC_NNCLR = const(0x55)    # Clear all events
OPC_NNEVN = const(0x56)    # Read available event slots
OPC_NERD = const(0x57)    # Read all stored events
OPC_RQEVN = const(0x58)    # Read number of stored events
OPC_WRACK = const(0x59)    # Write acknowledge
OPC_RQDAT = const(0x5A)    # Request node data event
OPC_RQDDS = const(0x5B)    # Request short data frame
OPC_BOOT = const(0x5C)    # Put node into boot mode
OPC_ENUM = const(0x5D)    # Force can_id self enumeration
OPC_NNRST = const(0x5E)    # Reset node (as in restart)
OPC_EXTC1 = const(0x5F)    # Extended opcode with 1 data byte
# 
# Packets with 3 data bytes
# 
OPC_DFUN = const(0x60)    # Set engine functions
OPC_GLOC = const(0x61)    # Get loco (with support for steal/share)
OPC_ERR = const(0x63)    # Command station error
OPC_CMDERR = const(0x6F)    # Errors from nodes during config
# 
OPC_EVNLF = const(0x70)    # Event slots left response
OPC_NVRD = const(0x71)    # Request read of node variable
OPC_NENRD = const(0x72)    # Request read stored event by index
OPC_RQNPN = const(0x73)    # Request read module parameters
OPC_NUMEV = const(0x74)    # Number of events stored response
OPC_CANID = const(0x75)    # Set canid
OPC_MODE = const(0x76)    # Set mode
OPC_RQSD = const(0x78)    # Request service discovery
OPC_EXTC2 = const(0x7F)    # Extended opcode with 2 data bytes
# 
# Packets with 4 data bytes
# 
OPC_RDCC3 = const(0x80)    # 3 byte DCC packet
OPC_WCVO = const(0x82)    # Write CV byte Ops mode by handle
OPC_WCVB = const(0x83)    # Write CV bit Ops mode by handle
OPC_QCVS = const(0x84)    # Read CV
OPC_PCVS = const(0x85)    # Report CV
OPC_RDGN = const(0x87)    # Request diagnostics
OPC_NVSETRD = const(0x8E)    # Set NV with Read
# 
OPC_ACON = const(0x90)    # on event
OPC_ACOF = const(0x91)    # off event
OPC_AREQ = const(0x92)    # Accessory Request event
OPC_ARON = const(0x93)    # Accessory response event on
OPC_AROF = const(0x94)    # Accessory response event off
OPC_EVULN = const(0x95)    # Unlearn event
OPC_NVSET = const(0x96)    # Set a node variable
OPC_NVANS = const(0x97)    # Node variable value response
OPC_ASON = const(0x98)    # Short event on
OPC_ASOF = const(0x99)    # Short event off
OPC_ASRQ = const(0x9A)    # Short Request event
OPC_PARAN = const(0x9B)    # Single node parameter response
OPC_REVAL = const(0x9C)    # Request read of event variable
OPC_ARSON = const(0x9D)    # Accessory short response on event
OPC_ARSOF = const(0x9E)    # Accessory short response off event
OPC_EXTC3 = const(0x9F)    # Extended opcode with 3 data bytes
# 
# Packets with 5 data bytes
# 
OPC_RDCC4 = const(0xA0)    # 4 byte DCC packet
OPC_WCVS = const(0xA2)    # Write CV service mode
OPC_HEARTB = const(0xAB)    # Heartbeat
OPC_SD = const(0xAC)    # Service discovery response
OPC_GRSP = const(0xAF)    # General response
# 
OPC_ACON1 = const(0xB0)    # On event with one data byte
OPC_ACOF1 = const(0xB1)    # Off event with one data byte
OPC_REQEV = const(0xB2)    # Read event variable in learn mode
OPC_ARON1 = const(0xB3)    # Accessory on response (1 data byte)
OPC_AROF1 = const(0xB4)    # Accessory off response (1 data byte)
OPC_NEVAL = const(0xB5)    # Event variable by index read response
OPC_PNN = const(0xB6)    # Response to QNN
OPC_ASON1 = const(0xB8)    # Accessory short on with 1 data byte
OPC_ASOF1 = const(0xB9)    # Accessory short off with 1 data byte
OPC_ARSON1 = const(0xBD)    # Short response event on with one data byte
OPC_ARSOF1 = const(0xBE)    # Short response event off with one data byte
OPC_EXTC4 = const(0xBF)    # Extended opcode with 4 data bytes
# 
# Packets with 6 data bytes
# 
OPC_RDCC5 = const(0xC0)    # 5 byte DCC packet
OPC_WCVOA = const(0xC1)    # Write CV ops mode by address
OPC_CABDAT = const(0xC2)    # Cab data (cab signalling)
OPC_DGN = const(0xC7)    # Diagnostics
OPC_FCLK = const(0xCF)    # Fast clock
# 
OPC_ACON2 = const(0xD0)    # On event with two data bytes
OPC_ACOF2 = const(0xD1)    # Off event with two data bytes
OPC_EVLRN = const(0xd2)    # Teach event
OPC_EVANS = const(0xd3)    # Event variable read response in learn mode
OPC_ARON2 = const(0xD4)    # Accessory on response
OPC_AROF2 = const(0xD5)    # Accessory off response
OPC_ASON2 = const(0xD8)    # Accessory short on with 2 data bytes
OPC_ASOF2 = const(0xD9)    # Accessory short off with 2 data bytes
OPC_ARSON2 = const(0xDD)    # Short response event on with two data bytes
OPC_ARSOF2 = const(0xDE)    # Short response event off with two data bytes
OPC_EXTC5 = const(0xDF)    # Extended opcode with 5 data bytes
# 
# Packets with 7 data bytes
# 
OPC_RDCC6 = const(0xE0)    # 6 byte DCC packets
OPC_PLOC = const(0xE1)    # Loco session report
OPC_NAME = const(0xE2)    # Module name response
OPC_STAT = const(0xE3)    # Command station status report
OPC_ENACK = const(0xE6)    # Event Acknowledge
OPC_ESD = const(0xE7)    # Extended service discovery
OPC_DTXC = const(0xE9)    # Long message packet
OPC_PARAMS = const(0xEF)    # Node parameters response
# 
OPC_ACON3 = const(0xF0)    # On event with 3 data bytes
OPC_ACOF3 = const(0xF1)    # Off event with 3 data bytes
OPC_ENRSP = const(0xF2)    # Read node events response
OPC_ARON3 = const(0xF3)    # Accessory on response
OPC_AROF3 = const(0xF4)    # Accessory off response
OPC_EVLRNI = const(0xF5)    # Teach event using event indexing
OPC_ACDAT = const(0xF6)    # Accessory data event: 5 bytes of node data (eg: RFID)
OPC_ARDAT = const(0xF7)    # Accessory data response
OPC_ASON3 = const(0xF8)    # Accessory short on with 3 data bytes
OPC_ASOF3 = const(0xF9)    # Accessory short off with 3 data bytes
OPC_DDES = const(0xFA)    # Short data frame aka device data event (device id plus 5 data bytes)
OPC_DDRS = const(0xFB)    # Short data frame response aka device data response
OPC_DDWS = const(0xFC)    # Device Data Write Short
OPC_ARSON3 = const(0xFD)    # Short response event on with 3 data bytes
OPC_ARSOF3 = const(0xFE)    # Short response event off with 3 data bytes
OPC_EXTC6 = const(0xFF)    # Extended opcode with 6 data byes
# 
# Opcodes that are proposed and/or agreed but not yet in the current published specification
# 
OPC_VCVS = const(0xA4)    # Verify CV service mode - used for CV read hints
# 
# 
# Modes for STMOD
# 
TMOD_SPD_MASK = const(3)    # 
TMOD_SPD_128 = const(0)    # 
TMOD_SPD_14 = const(1)    # 
TMOD_SPD_28I = const(2)    # 
TMOD_SPD_28 = const(3)    # 
# 
# Error codes for OPC_ERR
# 
ERR_LOCO_STACK_FULL = const(1)    # 
ERR_LOCO_ADDR_TAKEN = const(2)    # 
ERR_SESSION_NOT_PRESENT = const(3)    # 
ERR_CONSIST_EMPTY = const(4)    # 
ERR_LOCO_NOT_FOUND = const(5)    # 
ERR_CMD_RX_BUF_OFLOW = const(6)    # 
ERR_INVALID_REQUEST = const(7)    # 
ERR_SESSION_CANCELLED = const(8)    # 
# 
# Status codes for OPC_SSTAT
# 
SSTAT_NO_ACK = const(1)    # 
SSTAT_OVLD = const(2)    # 
SSTAT_WR_ACK = const(3)    # 
SSTAT_BUSY = const(4)    # 
SSTAT_CV_ERROR = const(5)    # 
# 
# Error codes for OPC_CMDERR
# 
CMDERR_INV_CMD = const(1)    # Invalid command
CMDERR_NOT_LRN = const(2)    # Not in learn mode
CMDERR_NOT_SETUP = const(3)    # Not in setup mode
CMDERR_TOO_MANY_EVENTS = const(4)    # Too many events
CMDERR_NO_EV = const(5)    # No EV
CMDERR_INV_EV_IDX = const(6)    # Invalid EV index
CMDERR_INVALID_EVENT = const(7)    # Invalid event
CMDERR_INV_EN_IDX = const(8)    # now reserved
CMDERR_INV_PARAM_IDX = const(9)    # Invalid param index
CMDERR_INV_NV_IDX = const(10)    # Invalid NV index
CMDERR_INV_EV_VALUE = const(11)    # Invalid EV value
CMDERR_INV_NV_VALUE = const(12)    # Invalid NV value
# 
# Additional error codes proposed and/or agreed but not yet in the current published specification
# 
CMDERR_LRN_OTHER = const(13)    # Sent when module in learn mode sees NNLRN for different module (also exits learn mode) 
# 
# 
# GRSP codes
# 
GRSP_OK = const(0)    # Success
GRSP_UNKNOWN_NVM_TYPE = const(254)    # Unknown non volatile memory type
GRSP_INVALID_DIAGNOSTIC = const(253)    # Invalid diagnostic
GRSP_INVALID_SERVICE = const(252)    # Invalid service
GRSP_INVALID_COMMAND_PARAMETER = const(251)    # Invalid parameter in command
GRSP_INVALID_MODE = const(250)    # Invalid Mode
# 
# Sub opcodes for OPC_CABDAT
# 
CDAT_CABSIG = const(1)    # 
# 
# Aspect codes for CDAT_CABSIG
# 
# First aspect byte
# 
SASP_DANGER = const(0)    # 
SASP_CAUTION = const(1)    # 
SASP_PRELIM_CAUTION = const(2)    # 
SASP_PROCEED = const(3)    # 
SASP_CALLON = const(4)    # Set bit 2 for call-on - main aspect will usually be at danger
SASP_THEATRE = const(8)    # Set bit 3 to 0 for upper nibble is feather lcoation, set 1 for upper nibble is theatre code
# 
# Aspect codes for CDAT_CABSIG
# 
# Second Aspect byte
# 
SASP_LIT = const(0)    # Set bit 0 to indicate lit
SASP_LUNAR = const(1)    # Set bit 1 for lunar indication
# 
# Remaining bits in second aspect byte yet to be defined - can be used for other signalling systems
# 
# VLCB Service Types
# 
SERVICE_ID_MNS = const(1)    # The minimum node service. All modules must implement this.
SERVICE_ID_NV = const(2)    # The NV service.
SERVICE_ID_CAN = const(3)    # CAN service. Deals with CANID enumeration.
SERVICE_ID_OLD_TEACH = const(4)    # Old (CBUS) event teaching service.
SERVICE_ID_PRODUCER = const(5)    # Event producer service.
SERVICE_ID_CONSUMER = const(6)    # Event comsumer service.
SERVICE_ID_TEACH = const(7)    # New event teaching service.
SERVICE_ID_CONSUME_OWN_EVENTS = const(8)    # Consume own events service.
SERVICE_ID_EVENTACK = const(9)    # Event acknowledge service. Useful for debugging event configuration.
SERVICE_ID_BOOT = const(10)    # FCU/PIC bootloader service.
SERVICE_ID_STREAMING = const(17)    # Streaming (Long Messages) service.
# 
# 
# Parameter index numbers (readable by OPC_RQNPN, returned in OPC_PARAN)
# Index numbers count from 1, subtract 1 for offset into parameter block
# Note that RQNPN with index 0 returns the parameter count
# 
PAR_NUM = const(0)    # Number of parameters
PAR_MANU = const(1)    # Manufacturer id
PAR_MINVER = const(2)    # Minor version letter
PAR_MTYP = const(3)    # Module type code
PAR_EVTNUM = const(4)    # Number of events supported
PAR_EVNUM = const(5)    # Event variables per event
PAR_NVNUM = const(6)    # Number of Node variables
PAR_MAJVER = const(7)    # Major version number
PAR_FLAGS = const(8)    # Node flags
PAR_CPUID = const(9)    # Processor type
PAR_BUSTYPE = const(10)    # Bus type
PAR_LOAD = const(11)    # load address, 4 bytes
PAR_CPUMID = const(15)    # CPU manufacturer's id as read from the chip config space, 4 bytes (note - read from cpu at runtime, so not included in checksum)
PAR_CPUMAN = const(19)    # CPU manufacturer code
PAR_BETA = const(20)    # Beta revision (numeric), or 0 if release
# 
# Offsets to other values stored at the top of the parameter block.
# These are not returned by opcode PARAN, but are present in the hex
# file for FCU.
# 
PAR_COUNT = const(0x18)    # Number of parameters implemented
PAR_NAME = const(0x1A)    # 4 byte Address of Module type name, up to 8 characters null terminated
PAR_CKSUM = const(0x1E)    # Checksum word at end of parameters
# 
# Flags in PAR_FLAGS
# 
PF_NOEVENTS = const(0)    # Module doesn't support events
PF_CONSUMER = const(1)    # Module is a consumer of events
PF_PRODUCER = const(2)    # Module is a producer of events
PF_COMBI = const(3)    # Module is both a consumer and producer of events
PF_FLiM = const(4)    # Module is in FLiM (CBUS)
PF_NORMAL = const(4)    # Module is in Normal mode (VLCB)
PF_BOOT = const(8)    # Module supports the FCU bootloader protocol
PF_COE = const(16)    # Module can consume its own events
PF_LRN = const(32)    # Module is in learn mode
PF_VLCB = const(64)    # Module is VLCB compatible
PF_SD = const(64)    # Module supports Service Discovery
# 
# Parameters to the MODE op-code
# 
# Exclusive modes
MODE_UNINITIALISED = const(0xFF)    # Uninitialised / factory settings
MODE_SETUP = const(0)    # Set up mode
MODE_NORMAL = const(1)    # Normal operation mode
# Event Teaching Service modes
MODE_LEARN_ON = const(0x08)    # Turn on learn mode
MODE_LEARN_OFF = const(0x09)    # Turn off learn mode
# Event Acknowledgment Service modes
MODE_EVENT_ACK_ON = const(0x0A)    # Turn on event acknowledgements
MODE_EVENT_ACK_OFF = const(0x0B)    # Turn off event acknowledgements
# Minimum Node Service modes
MODE_HEARTBEAT_ON = const(0x0C)    # Turn on heartbeat
MODE_HEARTBEAT_OFF = const(0x0D)    # Turn off heartbeat
# Boot modes
MODE_BOOT = const(0x0E)    # PIC Boot loader mode
# 
# BUS type that module is connected to
# 
PB_CAN = const(1)    # 
PB_ETH = const(2)    # 
PB_MIWI = const(3)    # 
PB_USB = const(4)    # 
# 
# Processor manufacturer codes
# 
CPUM_MICROCHIP = const(1)    # 
CPUM_ATMEL = const(2)    # 
CPUM_ARM = const(3)    # 
# 
# Microchip Processor type codes (identifies to FCU for bootload compatibility)
# 
P18F2480 = const(1)    # 
P18F4480 = const(2)    # 
P18F2580 = const(3)    # 
P18F4580 = const(4)    # 
P18F2585 = const(5)    # 
P18F4585 = const(6)    # 
P18F2680 = const(7)    # 
P18F4680 = const(8)    # 
P18F2682 = const(9)    # 
P18F4682 = const(10)    # 
P18F2685 = const(11)    # 
P18F4685 = const(12)    # 
# 
P18F25K80 = const(13)    # 
P18F45K80 = const(14)    # 
P18F26K80 = const(15)    # 
P18F46K80 = const(16)    # 
P18F65K80 = const(17)    # 
P18F66K80 = const(18)    # 
P18F25K83 = const(19)    # 
P18F26K83 = const(20)    # 
P18F27Q84 = const(21)    # 
P18F47Q84 = const(22)    # 
P18F27Q83 = const(23)    # 
P18F14K22 = const(25)    # 
# 
P32MX534F064 = const(30)    # 
P32MX564F064 = const(31)    # 
P32MX564F128 = const(32)    # 
P32MX575F256 = const(33)    # 
P32MX575F512 = const(34)    # 
P32MX764F128 = const(35)    # 
P32MX775F256 = const(36)    # 
P32MX775F512 = const(37)    # 
P32MX795F512 = const(38)    # 
# 
# ARM Processor type codes (identifies to FCU for bootload compatibility)
# 
ARM1176JZF_S = const(1)    # As used in Raspberry Pi
ARMCortex_A7 = const(2)    # As Used in Raspberry Pi 2
ARMCortex_A53 = const(3)    # As used in Raspberry Pi 3
