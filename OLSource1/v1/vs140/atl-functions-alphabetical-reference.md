---
title: "ATL Functions Alphabetical Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "functions [ATL]"
ms.assetid: 8968fe02-2a8a-4b72-9c58-c6c19e9f703c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Functions Alphabetical Reference
In this section, reference topics for the ATL global functions are organized alphabetically. To find a particular function by category, see [ATL Functions](../vs140/atl-functions.md).  
  
|Function|Description|  
|--------------|-----------------|  
|[AtlAdvise](../vs140/atladvise.md)|Creates a connection between an object's connection point and a client's sink.|  
|[AtlAdviseSinkMap](../vs140/atladvisesinkmap.md)|Call this function to advise or unadvise all entries in the object's sink event map.|  
|[AtlAxAttachControl](../vs140/atlaxattachcontrol.md)|Attaches a previously created control to the specified window.|  
|[AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)|Creates an ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.|  
|[AtlAxCreateControlLicEx](../vs140/atlaxcreatecontrollicex.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.|  
|[AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)|Creates an ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateDialog](../vs140/atlaxcreatedialog.md)|Creates a modeless dialog box from a dialog template provided by the user.|  
|[AtlAxDialogBox](../vs140/atlaxdialogbox.md)|Creates a modal dialog box from a dialog template provided by the user.|  
|[AtlAxGetControl](../vs140/atlaxgetcontrol.md)|Obtains a direct interface pointer to the control contained inside a specified window given its handle.|  
|[AtlAxGetHost](../vs140/atlaxgethost.md)|Obtains a direct interface pointer to the container for a specified window (if any), given its handle.|  
|[AtlAxWinInit](../vs140/atlaxwininit.md)|This function initializes ATL's control hosting code by registering the **"AtlAxWin80"** and **"AtlAxWinLic80"** window classes plus a couple of custom window messages.|  
|[AtlAxWinTerm](../vs140/atlaxwinterm.md)|This function uninitializes ATL's control hosting code by unregistering the **"AtlAxWin80"** and **"AtlAxWinLic80"** window classes.|  
|[AtlCanonicalizeUrl](../vs140/atlcanonicalizeurl.md)|Call this function to canonicalize a URL, which includes converting unsafe characters and spaces into escape sequences.|  
|[AtlCombineUrl](../vs140/atlcombineurl.md)|Call this function to combine a base URL and a relative URL into a single, canonical URL.|  
|[AtlComModuleGetClassObject](../vs140/atlcommodulegetclassobject.md)|This function is called to return the class factory.|  
|[AtlComModuleRegisterClassObjects](../vs140/atlcommoduleregisterclassobjects.md)|This function is called to register class objects.|  
|[AtlComModuleRegisterServer](../vs140/atlcommoduleregisterserver.md)|This function is called to register every object in the object map.|  
|[AtlComModuleRevokeClassObjects](../vs140/atlcommodulerevokeclassobjects.md)|This function is called to remove the class factory/factories from the Running Object Table.|  
|[AtlComModuleUnregisterServer](../vs140/atlcommoduleunregisterserver.md)|This function is called to unregister every object in the object map.|  
|[AtlComPtrAssign](../vs140/atlcomptrassign.md)|Assigns an interface pointer to another interface pointer of the same type.|  
|[AtlComQIPtrAssign](../vs140/atlcomqiptrassign.md)|Assigns an interface pointer to another interface pointer of a different type.|  
|[AtlCreateTargetDC](../vs140/atlcreatetargetdc.md)|Creates a device context for the device specified in the [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure.|  
|[AtlEscapeUrl](../vs140/atlescapeurl.md)|Call this function to convert all unsafe characters to escape sequences.|  
|[AtlFreeMarshalStream](../vs140/atlfreemarshalstream.md)|Releases the marshal data in the stream, then releases the stream pointer.|  
|[AtlGetDacl](../vs140/atlgetdacl.md)|Call this function to retrieve the discretionary access-control list (DACL) information of a specified object.|  
|[AtlGetDefaultUrlPort](../vs140/atlgetdefaulturlport.md)|Call this function to get the default port number associated with a particular Internet protocol or scheme.|  
|[AtlGetGroupSid](../vs140/atlgetgroupsid.md)|Call this function to retrieve the group security identifier (SID) of an object.|  
|[AtlGetHexValue](../vs140/atlgethexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md)|Call this function to retrieve information about the default source interface of an object.|  
|[AtlGetOwnerSid](../vs140/atlgetownersid.md)|Call this function to retrieve the owner security identifier (SID) of an object.|  
|[AtlGetPerUserRegistration](../vs140/atlgetperuserregistration.md)|Use this function to determine whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AtlGetSacl](../vs140/atlgetsacl.md)|Call this function to retrieve the system access-control list (SACL) information of a specified object.|  
|[AtlGetSecurityDescriptor](../vs140/atlgetsecuritydescriptor.md)|Call this function to retrieve the security descriptor of a given object.|  
|[AtlHexDecode](../vs140/atlhexdecode.md)|Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../vs140/atlhexencode.md).|  
|[AtlHexDecodeGetRequiredLength](../vs140/atlhexdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a hex-encoded string of the specified length.|  
|[AtlHexEncode](../vs140/atlhexencode.md)|Call this function to encode some data as a string of hexadecimal text.|  
|[AtlHexEncodeGetRequiredLength](../vs140/atlhexencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[AtlHexValue](../vs140/atlhexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlHiMetricToPixel](../vs140/atlhimetrictopixel.md)|Converts an object's size in HIMETRIC units (each unit is 0.01 millimeter) to a size in pixels on the screen device.|  
|[AtlHresultFromLastError](../vs140/atlhresultfromlasterror.md)|Returns the calling thread's last-error code value in the form of an HRESULT.|  
|[AtlHresultFromWin32](../vs140/atlhresultfromwin32.md)|Converts a Win32 error code into an HRESULT.|  
|[AtlInternalQueryInterface](../vs140/atlinternalqueryinterface.md)|Retrieves a pointer to the requested interface.|  
|[AtlIsUnsafeUrlChar](../vs140/atlisunsafeurlchar.md)|Call this function to find out whether a character is safe for use in a URL.|  
|[AtlLoadTypeLib](../vs140/atlloadtypelib.md)|This function is called to load a type library.|  
|[AtlMarshalPtrInProc](../vs140/atlmarshalptrinproc.md)|Creates a new stream object, writes the CLSID of the proxy to the stream, and marshals the specified interface pointer by writing the data needed to initialize the proxy into the stream.|  
|[AtlModuleRegisterServer](../vs140/atlmoduleregisterserver.md)|Registers every object in the object map.|  
|[AtlModuleRegisterTypeLib](../vs140/atlmoduleregistertypelib.md)|Registers a type library.|  
|[AtlModuleUnregisterServerEx](../vs140/atlmoduleunregisterserverex.md)|Unregisters every object in the object map.|  
|[AtlModuleUnregisterServer](../vs140/atlmoduleunregisterserver.md)|Unregisters every object in the object map. It is similar to `AtlModuleUnregisterServerEx` except that it cannot unregister the type library.|  
|[AtlModuleUnregisterTypeLib](../vs140/atlmoduleunregistertypelib.md)|Unregisters a type library.|  
|[ATLPath::AddBackslash](../vs140/atlpath--addbackslash.md)|This function is an overloaded wrapper for [PathAddBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773561).|  
|[ATLPath::AddExtension](../vs140/atlpath--addextension.md)|This function is an overloaded wrapper for [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).|  
|[ATLPath::Append](../vs140/atlpath--append.md)|This function is an overloaded wrapper for [PathAppend](http://msdn.microsoft.com/library/windows/desktop/bb773565).|  
|[ATLPath::BuildRoot](../vs140/atlpath--buildroot.md)|This function is an overloaded wrapper for [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).|  
|[ATLPath::Canonicalize](../vs140/atlpath--canonicalize.md)|This function is an overloaded wrapper for [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569).|  
|[ATLPath::Combine](../vs140/atlpath--combine.md)|This function is an overloaded wrapper for [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571).|  
|[ATLPath::CommonPrefix](../vs140/atlpath--commonprefix.md)|This function is an overloaded wrapper for [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).|  
|[ATLPath::CompactPath](../vs140/atlpath--compactpath.md)|This function is an overloaded wrapper for [PathCompactPath](http://msdn.microsoft.com/library/windows/desktop/bb773575).|  
|[ATLPath::CompactPathEx](../vs140/atlpath--compactpathex.md)|This function is an overloaded wrapper for [PathCompactPathEx](http://msdn.microsoft.com/library/windows/desktop/bb773578).|  
|[ATLPath::FileExists](../vs140/atlpath--fileexists.md)|This function is an overloaded wrapper for [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584).|  
|[ATLPath::FindExtension](../vs140/atlpath--findextension.md)|This function is an overloaded wrapper for [PathFindExtension](http://msdn.microsoft.com/library/windows/desktop/bb773587).|  
|[ATLPath::FindFileName](../vs140/atlpath--findfilename.md)|This function is an overloaded wrapper for [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589).|  
|[ATLPath::GetDriveNumber](../vs140/atlpath--getdrivenumber.md)|This function is an overloaded wrapper for [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612).|  
|[ATLPath::IsDirectory](../vs140/atlpath--isdirectory.md)|This function is an overloaded wrapper for [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621).|  
|[ATLPath::IsFileSpec](../vs140/atlpath--isfilespec.md)|This function is an overloaded wrapper for [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).|  
|[ATLPath::IsPrefix](../vs140/atlpath--isprefix.md)|This function is an overloaded wrapper for [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).|  
|[ATLPath::IsRelative](../vs140/atlpath--isrelative.md)|This function is an overloaded wrapper for [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660).|  
|[ATLPath::IsRoot](../vs140/atlpath--isroot.md)|This function is an overloaded wrapper for [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674).|  
|[ATLPath::IsSameRoot](../vs140/atlpath--issameroot.md)|This function is an overloaded wrapper for [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).|  
|[ATLPath::IsUNC](../vs140/atlpath--isunc.md)|This function is an overloaded wrapper for [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).|  
|[ATLPath::IsUNCServer](../vs140/atlpath--isuncserver.md)|This function is an overloaded wrapper for [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).|  
|[ATLPath::IsUNCServerShare](../vs140/atlpath--isuncservershare.md)|This function is an overloaded wrapper for [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).|  
|[ATLPath::MakePretty](../vs140/atlpath--makepretty.md)|This function is an overloaded wrapper for [PathMakePretty](http://msdn.microsoft.com/library/windows/desktop/bb773725).|  
|[ATLPath::MatchSpec](../vs140/atlpath--matchspec.md)|This function is an overloaded wrapper for [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).|  
|[ATLPath::QuoteSpaces](../vs140/atlpath--quotespaces.md)|This function is an overloaded wrapper for [PathQuoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773739).|  
|[ATLPath::RelativePathTo](../vs140/atlpath--relativepathto.md)|This function is an overloaded wrapper for [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).|  
|[ATLPath::RemoveArgs](../vs140/atlpath--removeargs.md)|This function is an overloaded wrapper for [PathRemoveArgs](http://msdn.microsoft.com/library/windows/desktop/bb773742).|  
|[ATLPath::RemoveBackslash](../vs140/atlpath--removebackslash.md)|This function is an overloaded wrapper for [PathRemoveBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773743).|  
|[ATLPath::RemoveBlanks](../vs140/atlpath--removeblanks.md)|This function is an overloaded wrapper for [PathRemoveBlanks](http://msdn.microsoft.com/library/windows/desktop/bb773745).|  
|[ATLPath::RemoveExtension](../vs140/atlpath--removeextension.md)|This function is an overloaded wrapper for [PathRemoveExtension](http://msdn.microsoft.com/library/windows/desktop/bb773746).|  
|[ATLPath::RemoveFileSpec](../vs140/atlpath--removefilespec.md)|This function is an overloaded wrapper for [PathRemoveFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773748).|  
|[ATLPath::RenameExtension](../vs140/atlpath--renameextension.md)|This function is an overloaded wrapper for [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).|  
|[ATLPath::SkipRoot](../vs140/atlpath--skiproot.md)|This function is an overloaded wrapper for [PathSkipRoot](http://msdn.microsoft.com/library/windows/desktop/bb773754).|  
|[ATLPath::StripPath](../vs140/atlpath--strippath.md)|This function is an overloaded wrapper for [PathStripPath](http://msdn.microsoft.com/library/windows/desktop/bb773756).|  
|[ATLPath::StripToRoot](../vs140/atlpath--striptoroot.md)|This function is an overloaded wrapper for [PathStripToRoot](http://msdn.microsoft.com/library/windows/desktop/bb773757).|  
|[ATLPath::UnquoteSpaces](../vs140/atlpath--unquotespaces.md)|This function is an overloaded wrapper for [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763).|  
|[AtlPixelToHiMetric](../vs140/atlpixeltohimetric.md)|Converts an object's size in pixels on the screen device to a size in HIMETRIC units (each unit is 0.01 millimeter).|  
|[AtlRegisterTypeLib](../vs140/atlregistertypelib.md)|This function is called to register a type library.|  
|[AtlReportError](../vs140/atlreporterror.md)|Sets up the [IErrorInfo](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447) interface to provide error information to clients of the object.|  
|[AtlSetChildSite](../vs140/atlsetchildsite.md)|Call this function to set the site of the child object to the **IUnknown** of the parent object.|  
|[AtlSetDacl](../vs140/atlsetdacl.md)|Call this function to set the discretionary access-control list (DACL) information of a specified object.|  
|[AtlSetGroupSid](../vs140/atlsetgroupsid.md)|Call this function to set the group security identifier (SID) of an object.|  
|[AtlSetOwnerSid](../vs140/atlsetownersid.md)|Call this function to set the owner security identifier (SID) of an object.|  
|[AtlSetPerUserRegistration](../vs140/atlsetperuserregistration.md)|Sets whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AtlSetSacl](../vs140/atlsetsacl.md)|Call this function to set the system access-control list (SACL) information of a specified object.|  
|[AtlThrowLastWin32](../vs140/atlthrowlastwin32.md)|Call this function to signal an error based on the result of the Windows function `GetLastError`.|  
|[AtlThrow](../vs140/atlthrow.md)|Call this function to signal an error based on a `HRESULT` status code.|  
|[AtlUnadvise](../vs140/atlunadvise.md)|Terminates the connection established through [AtlAdvise](../vs140/atladvise.md).|  
|[AtlUnescapeUrl](../vs140/atlunescapeurl.md)|Call this function to convert escaped characters back to their original values.|  
|[AtlUnicodeToUTF8](../vs140/atlunicodetoutf8.md)|Call this function to convert a Unicode string to UTF-8.|  
|[AtlUnmarshalPtr](../vs140/atlunmarshalptr.md)|Converts the stream's marshaling data into an interface pointer that can be used by the client.|  
|[AtlUnRegisterTypeLib](../vs140/atlunregistertypelib.md)|This function is called to unregister a type library.|  
|[AtlUpdateRegistryFromResourceD](../vs140/atlupdateregistryfromresourced.md) **<Removed\>**|This function was deprecated in earlier releases and is removed in Visual Studio 2015.|  
|[AtlWaitWithMessageLoop](../vs140/atlwaitwithmessageloop.md)|Waits for the object to be signaled, meanwhile dispatching window messages as needed.|  
|[AtlWinModuleAddCreateWndData](../vs140/atlwinmoduleaddcreatewnddata.md)|This function is used to initialize and add an `_AtlCreateWndData` structure.|  
|[AtlWinModuleExtractCreateWndData](../vs140/atlwinmoduleextractcreatewnddata.md)|Call this function to extract an existing `_AtlCreateWndData` structure.|  
|[BEncode](../vs140/bencode.md)|Call this function to convert some data using the "B" encoding.|  
|[BEncodeGetRequiredLength](../vs140/bencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[EscapeXML](../vs140/escapexml.md)|Call this function to convert characters that are unsafe for use in XML to their safe equivalents.|  
|[GetExtendedChars](../vs140/getextendedchars.md)|Call this function to get the number of extended characters in a string.|  
|[InlineIsEqualIUnknown](../vs140/inlineisequaliunknown.md)|Call this function, for the special case of testing for **IUnknown**.|  
|[IsExtendedChar](../vs140/isextendedchar.md)|Call this function to find out if a given character is an extended character (less than 32, greater than 126, and not a tab, linefeed or carriage return)|  
|[QEncode](../vs140/qencode.md)|Call this function to convert some data using the "Q" encoding.|  
|[QEncodeGetRequiredLength](../vs140/qencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[QPDecode](../vs140/qpdecode.md)|Decodes a string of data that has been encoded in quoted-printable format such as by a previous call to [QPEncode](../vs140/qpencode.md).|  
|[QPDecodeGetRequiredLength](../vs140/qpdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from quoted-printable-encoded string of the specified length.|  
|[QPEncode](../vs140/qpencode.md)|Call this function to encode some data in quoted-printable format.|  
|[QPEncodeGetRequiredLength](../vs140/qpencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[RegistryDataExchange](../vs140/registrydataexchange.md)|This function is called to read from, or write to, the system registry.|  
|[RGBToHtml](../vs140/rgbtohtml.md)|Converts a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value to the HTML text corresponding to that color value.|  
|[Sids::AccountOps](../vs140/sids--accountops.md)|Returns the DOMAIN_ALIAS_RID_ACCOUNT_OPS SID.|  
|[Sids::Admins](../vs140/sids--admins.md)|Returns the DOMAIN_ALIAS_RID_ADMINS SID.|  
|[Sids::AnonymousLogon](../vs140/sids--anonymouslogon.md)|Returns the SECURITY_ANONYMOUS_LOGON_RID SID.|  
|[Sids::AuthenticatedUser](../vs140/sids--authenticateduser.md)|Returns the SECURITY_AUTHENTICATED_USER_RID SID.|  
|[Sids::BackupOps](../vs140/sids--backupops.md)|Returns the DOMAIN_ALIAS_RID_BACKUP_OPS SID.|  
|[Sids::Batch](../vs140/sids--batch.md)|Returns the SECURITY_BATCH_RID SID.|  
|[Sids::CreatorGroupServer](../vs140/sids--creatorgroupserver.md)|Returns the SECURITY_CREATOR_GROUP_SERVER_RID SID.|  
|[Sids::CreatorGroup](../vs140/sids--creatorgroup.md)|Returns the SECURITY_CREATOR_GROUP_RID SID.|  
|[Sids::CreatorOwnerServer](../vs140/sids--creatorownerserver.md)|Returns the SECURITY_CREATOR_OWNER_SERVER_RID SID.|  
|[Sids::CreatorOwner](../vs140/sids--creatorowner.md)|Returns the SECURITY_CREATOR_OWNER_RID SID.|  
|[Sids::Dialup](../vs140/sids--dialup.md)|Returns the SECURITY_DIALUP_RID SID.|  
|[Sids::Guests](../vs140/sids--guests.md)|Returns the DOMAIN_ALIAS_RID_GUESTS SID.|  
|[Sids::Interactive](../vs140/sids--interactive.md)|Returns the SECURITY_INTERACTIVE_RID SID.|  
|[Sids::Local](../vs140/sids--local.md)|Returns the SECURITY_LOCAL_RID SID.|  
|[Sids::Network](../vs140/sids--network.md)|Returns the SECURITY_NETWORK_RID SID.|  
|[Sids::NetworkService](../vs140/sids--networkservice.md)|Returns the SECURITY_NETWORK_SERVICE_RID SID.|  
|[Sids::Null](../vs140/sids--null.md)|Returns the SECURITY_NULL_RID SID.|  
|[Sids::PowerUsers](../vs140/sids--powerusers.md)|Returns the DOMAIN_ALIAS_RID_POWER_USERS SID.|  
|[Sids::PreW2KAccess](../vs140/sids--prew2kaccess.md)|Returns the DOMAIN_ALIAS_RID_PREW2KCOMPACCESS SID.|  
|[Sids::PrintOps](../vs140/sids--printops.md)|Returns the DOMAIN_ALIAS_RID_PRINT_OPS SID.|  
|[Sids::Proxy](../vs140/sids--proxy.md)|Returns the SECURITY_PROXY_RID SID.|  
|[Sids::RasServers](../vs140/sids--rasservers.md)|Returns the DOMAIN_ALIAS_RID_RAS_SERVERS SID.|  
|[Sids::Replicator](../vs140/sids--replicator.md)|Returns the DOMAIN_ALIAS_RID_REPLICATOR SID.|  
|[Sids::RestrictedCode](../vs140/sids--restrictedcode.md)|Returns the SECURITY_RESTRICTED_CODE_RID SID.|  
|[Sids::Self](../vs140/sids--self.md)|Returns the SECURITY_PRINCIPAL_SELF_RID SID.|  
|[Sids::ServerLogon](../vs140/sids--serverlogon.md)|Returns the SECURITY_SERVER_LOGON_RID SID.|  
|[Sids::Service](../vs140/sids--service.md)|Returns the SECURITY_SERVICE_RID SID.|  
|[Sids::SystemOps](../vs140/sids--systemops.md)|Returns the DOMAIN_ALIAS_RID_SYSTEM_OPS SID.|  
|[Sids::System](../vs140/sids--system.md)|Returns the SECURITY_LOCAL_SYSTEM_RID SID.|  
|[Sids::TerminalServer](../vs140/sids--terminalserver.md)|Returns the SECURITY_TERMINAL_SERVER_RID SID.|  
|[Sids::Users](../vs140/sids--users.md)|Returns the DOMAIN_ALIAS_RID_USERS SID.|  
|[Sids::World](../vs140/sids--world.md)|Returns the SECURITY_WORLD_RID SID.|  
|[SystemTimeToHttpDate](../vs140/systemtimetohttpdate.md)|Call this function to convert a system time to a string in a format suitable for using in HTTP headers.|  
|[UUDecode](../vs140/uudecode.md)|Decodes a string of data that has been uuencoded such as by a previous call to [UUEncode](../vs140/uuencode.md).|  
|[UUDecodeGetRequiredLength](../vs140/uudecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a uuencoded string of the specified length.|  
|[UUEncode](../vs140/uuencode.md)|Call this function to uuencode some data.|  
|[UUEncodeGetRequiredLength](../vs140/uuencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|