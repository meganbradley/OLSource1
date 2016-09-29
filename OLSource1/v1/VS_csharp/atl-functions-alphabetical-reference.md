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
In this section, reference topics for the ATL global functions are organized alphabetically. To find a particular function by category, see [ATL Functions](../VS_csharp/atl-functions.md).  
  
|Function|Description|  
|--------------|-----------------|  
|[AtlAdvise](../VS_csharp/atladvise.md)|Creates a connection between an object's connection point and a client's sink.|  
|[AtlAdviseSinkMap](../VS_csharp/atladvisesinkmap.md)|Call this function to advise or unadvise all entries in the object's sink event map.|  
|[AtlAxAttachControl](../VS_csharp/atlaxattachcontrol.md)|Attaches a previously created control to the specified window.|  
|[AtlAxCreateControlEx](../VS_csharp/atlaxcreatecontrolex.md)|Creates an ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.|  
|[AtlAxCreateControlLicEx](../VS_csharp/atlaxcreatecontrollicex.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.|  
|[AtlAxCreateControlLic](../VS_csharp/atlaxcreatecontrollic.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateControl](../VS_csharp/atlaxcreatecontrol.md)|Creates an ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateDialog](../VS_csharp/atlaxcreatedialog.md)|Creates a modeless dialog box from a dialog template provided by the user.|  
|[AtlAxDialogBox](../VS_csharp/atlaxdialogbox.md)|Creates a modal dialog box from a dialog template provided by the user.|  
|[AtlAxGetControl](../VS_csharp/atlaxgetcontrol.md)|Obtains a direct interface pointer to the control contained inside a specified window given its handle.|  
|[AtlAxGetHost](../VS_csharp/atlaxgethost.md)|Obtains a direct interface pointer to the container for a specified window (if any), given its handle.|  
|[AtlAxWinInit](../VS_csharp/atlaxwininit.md)|This function initializes ATL's control hosting code by registering the **"AtlAxWin80"** and **"AtlAxWinLic80"** window classes plus a couple of custom window messages.|  
|[AtlAxWinTerm](../VS_csharp/atlaxwinterm.md)|This function uninitializes ATL's control hosting code by unregistering the **"AtlAxWin80"** and **"AtlAxWinLic80"** window classes.|  
|[AtlCanonicalizeUrl](../VS_csharp/atlcanonicalizeurl.md)|Call this function to canonicalize a URL, which includes converting unsafe characters and spaces into escape sequences.|  
|[AtlCombineUrl](../VS_csharp/atlcombineurl.md)|Call this function to combine a base URL and a relative URL into a single, canonical URL.|  
|[AtlComModuleGetClassObject](../VS_csharp/atlcommodulegetclassobject.md)|This function is called to return the class factory.|  
|[AtlComModuleRegisterClassObjects](../VS_csharp/atlcommoduleregisterclassobjects.md)|This function is called to register class objects.|  
|[AtlComModuleRegisterServer](../VS_csharp/atlcommoduleregisterserver.md)|This function is called to register every object in the object map.|  
|[AtlComModuleRevokeClassObjects](../VS_csharp/atlcommodulerevokeclassobjects.md)|This function is called to remove the class factory/factories from the Running Object Table.|  
|[AtlComModuleUnregisterServer](../VS_csharp/atlcommoduleunregisterserver.md)|This function is called to unregister every object in the object map.|  
|[AtlComPtrAssign](../VS_csharp/atlcomptrassign.md)|Assigns an interface pointer to another interface pointer of the same type.|  
|[AtlComQIPtrAssign](../VS_csharp/atlcomqiptrassign.md)|Assigns an interface pointer to another interface pointer of a different type.|  
|[AtlCreateTargetDC](../VS_csharp/atlcreatetargetdc.md)|Creates a device context for the device specified in the [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure.|  
|[AtlEscapeUrl](../VS_csharp/atlescapeurl.md)|Call this function to convert all unsafe characters to escape sequences.|  
|[AtlFreeMarshalStream](../VS_csharp/atlfreemarshalstream.md)|Releases the marshal data in the stream, then releases the stream pointer.|  
|[AtlGetDacl](../VS_csharp/atlgetdacl.md)|Call this function to retrieve the discretionary access-control list (DACL) information of a specified object.|  
|[AtlGetDefaultUrlPort](../VS_csharp/atlgetdefaulturlport.md)|Call this function to get the default port number associated with a particular Internet protocol or scheme.|  
|[AtlGetGroupSid](../VS_csharp/atlgetgroupsid.md)|Call this function to retrieve the group security identifier (SID) of an object.|  
|[AtlGetHexValue](../VS_csharp/atlgethexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlGetObjectSourceInterface](../VS_csharp/atlgetobjectsourceinterface.md)|Call this function to retrieve information about the default source interface of an object.|  
|[AtlGetOwnerSid](../VS_csharp/atlgetownersid.md)|Call this function to retrieve the owner security identifier (SID) of an object.|  
|[AtlGetPerUserRegistration](../VS_csharp/atlgetperuserregistration.md)|Use this function to determine whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AtlGetSacl](../VS_csharp/atlgetsacl.md)|Call this function to retrieve the system access-control list (SACL) information of a specified object.|  
|[AtlGetSecurityDescriptor](../VS_csharp/atlgetsecuritydescriptor.md)|Call this function to retrieve the security descriptor of a given object.|  
|[AtlHexDecode](../VS_csharp/atlhexdecode.md)|Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../VS_csharp/atlhexencode.md).|  
|[AtlHexDecodeGetRequiredLength](../VS_csharp/atlhexdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a hex-encoded string of the specified length.|  
|[AtlHexEncode](../VS_csharp/atlhexencode.md)|Call this function to encode some data as a string of hexadecimal text.|  
|[AtlHexEncodeGetRequiredLength](../VS_csharp/atlhexencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[AtlHexValue](../VS_csharp/atlhexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlHiMetricToPixel](../VS_csharp/atlhimetrictopixel.md)|Converts an object's size in HIMETRIC units (each unit is 0.01 millimeter) to a size in pixels on the screen device.|  
|[AtlHresultFromLastError](../VS_csharp/atlhresultfromlasterror.md)|Returns the calling thread's last-error code value in the form of an HRESULT.|  
|[AtlHresultFromWin32](../VS_csharp/atlhresultfromwin32.md)|Converts a Win32 error code into an HRESULT.|  
|[AtlInternalQueryInterface](../VS_csharp/atlinternalqueryinterface.md)|Retrieves a pointer to the requested interface.|  
|[AtlIsUnsafeUrlChar](../VS_csharp/atlisunsafeurlchar.md)|Call this function to find out whether a character is safe for use in a URL.|  
|[AtlLoadTypeLib](../VS_csharp/atlloadtypelib.md)|This function is called to load a type library.|  
|[AtlMarshalPtrInProc](../VS_csharp/atlmarshalptrinproc.md)|Creates a new stream object, writes the CLSID of the proxy to the stream, and marshals the specified interface pointer by writing the data needed to initialize the proxy into the stream.|  
|[AtlModuleRegisterServer](../VS_csharp/atlmoduleregisterserver.md)|Registers every object in the object map.|  
|[AtlModuleRegisterTypeLib](../VS_csharp/atlmoduleregistertypelib.md)|Registers a type library.|  
|[AtlModuleUnregisterServerEx](../VS_csharp/atlmoduleunregisterserverex.md)|Unregisters every object in the object map.|  
|[AtlModuleUnregisterServer](../VS_csharp/atlmoduleunregisterserver.md)|Unregisters every object in the object map. It is similar to `AtlModuleUnregisterServerEx` except that it cannot unregister the type library.|  
|[AtlModuleUnregisterTypeLib](../VS_csharp/atlmoduleunregistertypelib.md)|Unregisters a type library.|  
|[ATLPath::AddBackslash](../VS_csharp/atlpath--addbackslash.md)|This function is an overloaded wrapper for [PathAddBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773561).|  
|[ATLPath::AddExtension](../VS_csharp/atlpath--addextension.md)|This function is an overloaded wrapper for [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).|  
|[ATLPath::Append](../VS_csharp/atlpath--append.md)|This function is an overloaded wrapper for [PathAppend](http://msdn.microsoft.com/library/windows/desktop/bb773565).|  
|[ATLPath::BuildRoot](../VS_csharp/atlpath--buildroot.md)|This function is an overloaded wrapper for [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).|  
|[ATLPath::Canonicalize](../VS_csharp/atlpath--canonicalize.md)|This function is an overloaded wrapper for [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569).|  
|[ATLPath::Combine](../VS_csharp/atlpath--combine.md)|This function is an overloaded wrapper for [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571).|  
|[ATLPath::CommonPrefix](../VS_csharp/atlpath--commonprefix.md)|This function is an overloaded wrapper for [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).|  
|[ATLPath::CompactPath](../VS_csharp/atlpath--compactpath.md)|This function is an overloaded wrapper for [PathCompactPath](http://msdn.microsoft.com/library/windows/desktop/bb773575).|  
|[ATLPath::CompactPathEx](../VS_csharp/atlpath--compactpathex.md)|This function is an overloaded wrapper for [PathCompactPathEx](http://msdn.microsoft.com/library/windows/desktop/bb773578).|  
|[ATLPath::FileExists](../VS_csharp/atlpath--fileexists.md)|This function is an overloaded wrapper for [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584).|  
|[ATLPath::FindExtension](../VS_csharp/atlpath--findextension.md)|This function is an overloaded wrapper for [PathFindExtension](http://msdn.microsoft.com/library/windows/desktop/bb773587).|  
|[ATLPath::FindFileName](../VS_csharp/atlpath--findfilename.md)|This function is an overloaded wrapper for [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589).|  
|[ATLPath::GetDriveNumber](../VS_csharp/atlpath--getdrivenumber.md)|This function is an overloaded wrapper for [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612).|  
|[ATLPath::IsDirectory](../VS_csharp/atlpath--isdirectory.md)|This function is an overloaded wrapper for [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621).|  
|[ATLPath::IsFileSpec](../VS_csharp/atlpath--isfilespec.md)|This function is an overloaded wrapper for [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).|  
|[ATLPath::IsPrefix](../VS_csharp/atlpath--isprefix.md)|This function is an overloaded wrapper for [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).|  
|[ATLPath::IsRelative](../VS_csharp/atlpath--isrelative.md)|This function is an overloaded wrapper for [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660).|  
|[ATLPath::IsRoot](../VS_csharp/atlpath--isroot.md)|This function is an overloaded wrapper for [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674).|  
|[ATLPath::IsSameRoot](../VS_csharp/atlpath--issameroot.md)|This function is an overloaded wrapper for [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).|  
|[ATLPath::IsUNC](../VS_csharp/atlpath--isunc.md)|This function is an overloaded wrapper for [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).|  
|[ATLPath::IsUNCServer](../VS_csharp/atlpath--isuncserver.md)|This function is an overloaded wrapper for [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).|  
|[ATLPath::IsUNCServerShare](../VS_csharp/atlpath--isuncservershare.md)|This function is an overloaded wrapper for [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).|  
|[ATLPath::MakePretty](../VS_csharp/atlpath--makepretty.md)|This function is an overloaded wrapper for [PathMakePretty](http://msdn.microsoft.com/library/windows/desktop/bb773725).|  
|[ATLPath::MatchSpec](../VS_csharp/atlpath--matchspec.md)|This function is an overloaded wrapper for [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).|  
|[ATLPath::QuoteSpaces](../VS_csharp/atlpath--quotespaces.md)|This function is an overloaded wrapper for [PathQuoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773739).|  
|[ATLPath::RelativePathTo](../VS_csharp/atlpath--relativepathto.md)|This function is an overloaded wrapper for [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).|  
|[ATLPath::RemoveArgs](../VS_csharp/atlpath--removeargs.md)|This function is an overloaded wrapper for [PathRemoveArgs](http://msdn.microsoft.com/library/windows/desktop/bb773742).|  
|[ATLPath::RemoveBackslash](../VS_csharp/atlpath--removebackslash.md)|This function is an overloaded wrapper for [PathRemoveBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773743).|  
|[ATLPath::RemoveBlanks](../VS_csharp/atlpath--removeblanks.md)|This function is an overloaded wrapper for [PathRemoveBlanks](http://msdn.microsoft.com/library/windows/desktop/bb773745).|  
|[ATLPath::RemoveExtension](../VS_csharp/atlpath--removeextension.md)|This function is an overloaded wrapper for [PathRemoveExtension](http://msdn.microsoft.com/library/windows/desktop/bb773746).|  
|[ATLPath::RemoveFileSpec](../VS_csharp/atlpath--removefilespec.md)|This function is an overloaded wrapper for [PathRemoveFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773748).|  
|[ATLPath::RenameExtension](../VS_csharp/atlpath--renameextension.md)|This function is an overloaded wrapper for [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).|  
|[ATLPath::SkipRoot](../VS_csharp/atlpath--skiproot.md)|This function is an overloaded wrapper for [PathSkipRoot](http://msdn.microsoft.com/library/windows/desktop/bb773754).|  
|[ATLPath::StripPath](../VS_csharp/atlpath--strippath.md)|This function is an overloaded wrapper for [PathStripPath](http://msdn.microsoft.com/library/windows/desktop/bb773756).|  
|[ATLPath::StripToRoot](../VS_csharp/atlpath--striptoroot.md)|This function is an overloaded wrapper for [PathStripToRoot](http://msdn.microsoft.com/library/windows/desktop/bb773757).|  
|[ATLPath::UnquoteSpaces](../VS_csharp/atlpath--unquotespaces.md)|This function is an overloaded wrapper for [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763).|  
|[AtlPixelToHiMetric](../VS_csharp/atlpixeltohimetric.md)|Converts an object's size in pixels on the screen device to a size in HIMETRIC units (each unit is 0.01 millimeter).|  
|[AtlRegisterTypeLib](../VS_csharp/atlregistertypelib.md)|This function is called to register a type library.|  
|[AtlReportError](../VS_csharp/atlreporterror.md)|Sets up the [IErrorInfo](assetId:///4dda6909-2d9a-4727-ae0c-b5f90dcfa447) interface to provide error information to clients of the object.|  
|[AtlSetChildSite](../VS_csharp/atlsetchildsite.md)|Call this function to set the site of the child object to the **IUnknown** of the parent object.|  
|[AtlSetDacl](../VS_csharp/atlsetdacl.md)|Call this function to set the discretionary access-control list (DACL) information of a specified object.|  
|[AtlSetGroupSid](../VS_csharp/atlsetgroupsid.md)|Call this function to set the group security identifier (SID) of an object.|  
|[AtlSetOwnerSid](../VS_csharp/atlsetownersid.md)|Call this function to set the owner security identifier (SID) of an object.|  
|[AtlSetPerUserRegistration](../VS_csharp/atlsetperuserregistration.md)|Sets whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AtlSetSacl](../VS_csharp/atlsetsacl.md)|Call this function to set the system access-control list (SACL) information of a specified object.|  
|[AtlThrowLastWin32](../VS_csharp/atlthrowlastwin32.md)|Call this function to signal an error based on the result of the Windows function `GetLastError`.|  
|[AtlThrow](../VS_csharp/atlthrow.md)|Call this function to signal an error based on a `HRESULT` status code.|  
|[AtlUnadvise](../VS_csharp/atlunadvise.md)|Terminates the connection established through [AtlAdvise](../VS_csharp/atladvise.md).|  
|[AtlUnescapeUrl](../VS_csharp/atlunescapeurl.md)|Call this function to convert escaped characters back to their original values.|  
|[AtlUnicodeToUTF8](../VS_csharp/atlunicodetoutf8.md)|Call this function to convert a Unicode string to UTF-8.|  
|[AtlUnmarshalPtr](../VS_csharp/atlunmarshalptr.md)|Converts the stream's marshaling data into an interface pointer that can be used by the client.|  
|[AtlUnRegisterTypeLib](../VS_csharp/atlunregistertypelib.md)|This function is called to unregister a type library.|  
|[AtlUpdateRegistryFromResourceD](../VS_csharp/atlupdateregistryfromresourced.md) **<Removed\>**|This function was deprecated in earlier releases and is removed in Visual Studio 2015.|  
|[AtlWaitWithMessageLoop](../VS_csharp/atlwaitwithmessageloop.md)|Waits for the object to be signaled, meanwhile dispatching window messages as needed.|  
|[AtlWinModuleAddCreateWndData](../VS_csharp/atlwinmoduleaddcreatewnddata.md)|This function is used to initialize and add an `_AtlCreateWndData` structure.|  
|[AtlWinModuleExtractCreateWndData](../VS_csharp/atlwinmoduleextractcreatewnddata.md)|Call this function to extract an existing `_AtlCreateWndData` structure.|  
|[BEncode](../VS_csharp/bencode.md)|Call this function to convert some data using the "B" encoding.|  
|[BEncodeGetRequiredLength](../VS_csharp/bencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[EscapeXML](../VS_csharp/escapexml.md)|Call this function to convert characters that are unsafe for use in XML to their safe equivalents.|  
|[GetExtendedChars](../VS_csharp/getextendedchars.md)|Call this function to get the number of extended characters in a string.|  
|[InlineIsEqualIUnknown](../VS_csharp/inlineisequaliunknown.md)|Call this function, for the special case of testing for **IUnknown**.|  
|[IsExtendedChar](../VS_csharp/isextendedchar.md)|Call this function to find out if a given character is an extended character (less than 32, greater than 126, and not a tab, linefeed or carriage return)|  
|[QEncode](../VS_csharp/qencode.md)|Call this function to convert some data using the "Q" encoding.|  
|[QEncodeGetRequiredLength](../VS_csharp/qencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[QPDecode](../VS_csharp/qpdecode.md)|Decodes a string of data that has been encoded in quoted-printable format such as by a previous call to [QPEncode](../VS_csharp/qpencode.md).|  
|[QPDecodeGetRequiredLength](../VS_csharp/qpdecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from quoted-printable-encoded string of the specified length.|  
|[QPEncode](../VS_csharp/qpencode.md)|Call this function to encode some data in quoted-printable format.|  
|[QPEncodeGetRequiredLength](../VS_csharp/qpencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|  
|[RegistryDataExchange](../VS_csharp/registrydataexchange.md)|This function is called to read from, or write to, the system registry.|  
|[RGBToHtml](../VS_csharp/rgbtohtml.md)|Converts a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value to the HTML text corresponding to that color value.|  
|[Sids::AccountOps](../VS_csharp/sids--accountops.md)|Returns the DOMAIN_ALIAS_RID_ACCOUNT_OPS SID.|  
|[Sids::Admins](../VS_csharp/sids--admins.md)|Returns the DOMAIN_ALIAS_RID_ADMINS SID.|  
|[Sids::AnonymousLogon](../VS_csharp/sids--anonymouslogon.md)|Returns the SECURITY_ANONYMOUS_LOGON_RID SID.|  
|[Sids::AuthenticatedUser](../VS_csharp/sids--authenticateduser.md)|Returns the SECURITY_AUTHENTICATED_USER_RID SID.|  
|[Sids::BackupOps](../VS_csharp/sids--backupops.md)|Returns the DOMAIN_ALIAS_RID_BACKUP_OPS SID.|  
|[Sids::Batch](../VS_csharp/sids--batch.md)|Returns the SECURITY_BATCH_RID SID.|  
|[Sids::CreatorGroupServer](../VS_csharp/sids--creatorgroupserver.md)|Returns the SECURITY_CREATOR_GROUP_SERVER_RID SID.|  
|[Sids::CreatorGroup](../VS_csharp/sids--creatorgroup.md)|Returns the SECURITY_CREATOR_GROUP_RID SID.|  
|[Sids::CreatorOwnerServer](../VS_csharp/sids--creatorownerserver.md)|Returns the SECURITY_CREATOR_OWNER_SERVER_RID SID.|  
|[Sids::CreatorOwner](../VS_csharp/sids--creatorowner.md)|Returns the SECURITY_CREATOR_OWNER_RID SID.|  
|[Sids::Dialup](../VS_csharp/sids--dialup.md)|Returns the SECURITY_DIALUP_RID SID.|  
|[Sids::Guests](../VS_csharp/sids--guests.md)|Returns the DOMAIN_ALIAS_RID_GUESTS SID.|  
|[Sids::Interactive](../VS_csharp/sids--interactive.md)|Returns the SECURITY_INTERACTIVE_RID SID.|  
|[Sids::Local](../VS_csharp/sids--local.md)|Returns the SECURITY_LOCAL_RID SID.|  
|[Sids::Network](../VS_csharp/sids--network.md)|Returns the SECURITY_NETWORK_RID SID.|  
|[Sids::NetworkService](../VS_csharp/sids--networkservice.md)|Returns the SECURITY_NETWORK_SERVICE_RID SID.|  
|[Sids::Null](../VS_csharp/sids--null.md)|Returns the SECURITY_NULL_RID SID.|  
|[Sids::PowerUsers](../VS_csharp/sids--powerusers.md)|Returns the DOMAIN_ALIAS_RID_POWER_USERS SID.|  
|[Sids::PreW2KAccess](../VS_csharp/sids--prew2kaccess.md)|Returns the DOMAIN_ALIAS_RID_PREW2KCOMPACCESS SID.|  
|[Sids::PrintOps](../VS_csharp/sids--printops.md)|Returns the DOMAIN_ALIAS_RID_PRINT_OPS SID.|  
|[Sids::Proxy](../VS_csharp/sids--proxy.md)|Returns the SECURITY_PROXY_RID SID.|  
|[Sids::RasServers](../VS_csharp/sids--rasservers.md)|Returns the DOMAIN_ALIAS_RID_RAS_SERVERS SID.|  
|[Sids::Replicator](../VS_csharp/sids--replicator.md)|Returns the DOMAIN_ALIAS_RID_REPLICATOR SID.|  
|[Sids::RestrictedCode](../VS_csharp/sids--restrictedcode.md)|Returns the SECURITY_RESTRICTED_CODE_RID SID.|  
|[Sids::Self](../VS_csharp/sids--self.md)|Returns the SECURITY_PRINCIPAL_SELF_RID SID.|  
|[Sids::ServerLogon](../VS_csharp/sids--serverlogon.md)|Returns the SECURITY_SERVER_LOGON_RID SID.|  
|[Sids::Service](../VS_csharp/sids--service.md)|Returns the SECURITY_SERVICE_RID SID.|  
|[Sids::SystemOps](../VS_csharp/sids--systemops.md)|Returns the DOMAIN_ALIAS_RID_SYSTEM_OPS SID.|  
|[Sids::System](../VS_csharp/sids--system.md)|Returns the SECURITY_LOCAL_SYSTEM_RID SID.|  
|[Sids::TerminalServer](../VS_csharp/sids--terminalserver.md)|Returns the SECURITY_TERMINAL_SERVER_RID SID.|  
|[Sids::Users](../VS_csharp/sids--users.md)|Returns the DOMAIN_ALIAS_RID_USERS SID.|  
|[Sids::World](../VS_csharp/sids--world.md)|Returns the SECURITY_WORLD_RID SID.|  
|[SystemTimeToHttpDate](../VS_csharp/systemtimetohttpdate.md)|Call this function to convert a system time to a string in a format suitable for using in HTTP headers.|  
|[UUDecode](../VS_csharp/uudecode.md)|Decodes a string of data that has been uuencoded such as by a previous call to [UUEncode](../VS_csharp/uuencode.md).|  
|[UUDecodeGetRequiredLength](../VS_csharp/uudecodegetrequiredlength.md)|Call this function to get the size in bytes of a buffer that could contain data decoded from a uuencoded string of the specified length.|  
|[UUEncode](../VS_csharp/uuencode.md)|Call this function to uuencode some data.|  
|[UUEncodeGetRequiredLength](../VS_csharp/uuencodegetrequiredlength.md)|Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.|