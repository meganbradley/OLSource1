---
title: "CAtlServiceModuleT Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CAtlServiceModuleT"
  - "ATL.CAtlServiceModuleT"
  - "CAtlServiceModuleT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlServiceModuleT class"
ms.assetid: 8fc753ce-4a50-402b-9b4a-0a4ce5dd496c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT Class
This class implements a service.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Your class derived from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 *nServiceNameID*  
 The resource identifier of the service.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlServiceModuleT::CAtlServiceModuleT](../vs140/catlservicemodulet--catlservicemodulet.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlServiceModuleT::Handler](../vs140/catlservicemodulet--handler.md)|The handler routine for the service.|  
|[CAtlServiceModuleT::InitializeSecurity](../vs140/catlservicemodulet--initializesecurity.md)|Provides the default security settings for the service.|  
|[CAtlServiceModuleT::Install](../vs140/catlservicemodulet--install.md)|Installs and creates the service.|  
|[CAtlServiceModuleT::IsInstalled](../vs140/catlservicemodulet--isinstalled.md)|Confirms that the service has been installed.|  
|[CAtlServiceModuleT::LogEvent](../vs140/catlservicemodulet--logevent.md)|Writes to the event log.|  
|[CAtlServiceModuleT::OnContinue](../vs140/catlservicemodulet--oncontinue.md)|Override this method to continue the service.|  
|[CAtlServiceModuleT::OnInterrogate](../vs140/catlservicemodulet--oninterrogate.md)|Override this method to interrogate the service.|  
|[CAtlServiceModuleT::OnPause](../vs140/catlservicemodulet--onpause.md)|Override this method to pause the service.|  
|[CAtlServiceModuleT::OnShutdown](../vs140/catlservicemodulet--onshutdown.md)|Override this method to shut down the service|  
|[CAtlServiceModuleT::OnStop](../vs140/catlservicemodulet--onstop.md)|Override this method to stop the service|  
|[CAtlServiceModuleT::OnUnknownRequest](../vs140/catlservicemodulet--onunknownrequest.md)|Override this method to handle unknown requests to the service|  
|[CAtlServiceModuleT::ParseCommandLine](../vs140/catlservicemodulet--parsecommandline.md)|Parses the command line and performs registration if necessary.|  
|[CAtlServiceModuleT::PreMessageLoop](../vs140/catlservicemodulet--premessageloop.md)|This method is called immediately before entering the message loop.|  
|[CAtlServiceModuleT::RegisterAppId](../vs140/catlservicemodulet--registerappid.md)|Registers the service in the registry.|  
|[CAtlServiceModuleT::Run](../vs140/catlservicemodulet--run.md)|Runs the service.|  
|[CAtlServiceModuleT::ServiceMain](../vs140/catlservicemodulet--servicemain.md)|The method called by the Service Control Manager.|  
|[CAtlServiceModuleT::SetServiceStatus](../vs140/catlservicemodulet--setservicestatus.md)|Updates the service status.|  
|[CAtlServiceModuleT::Start](../vs140/catlservicemodulet--start.md)|Called by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> when the service starts.|  
|[CAtlServiceModuleT::Uninstall](../vs140/catlservicemodulet--uninstall.md)|Stops and removes the service.|  
|[CAtlServiceModuleT::Unlock](../vs140/catlservicemodulet--unlock.md)|Decrements the service's lock count.|  
|[CAtlServiceModuleT::UnregisterAppId](../vs140/catlservicemodulet--unregisterappid.md)|Removes the service from the registry.|  
|[CAtlServiceModuleT::WinMain](../vs140/catlservicemodulet--winmain.md)|This method implements the code required to run the service.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlServiceModuleT::m_bService](../vs140/catlservicemodulet--m_bservice.md)|Flag indicating the program is running as a service.|  
|[CAtlServiceModuleT::m_dwThreadID](../vs140/catlservicemodulet--m_dwthreadid.md)|Member variable storing the thread identifier.|  
|[CAtlServiceModuleT::m_hServiceStatus](../vs140/catlservicemodulet--m_hservicestatus.md)|Member variable storing a handle to the status information structure for the current service.|  
|[CAtlServiceModuleT::m_status](../vs140/catlservicemodulet--m_status.md)|Member variable storing the status information structure for the current service.|  
|[CAtlServiceModuleT::m_szServiceName](../vs140/catlservicemodulet--m_szservicename.md)|The name of the service being registered.|  
  
## Remarks  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, derived from [CAtlExeModuleT](../vs140/catlexemodulet-class.md), implements a ATL Service module. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> provides methods for command-line processing, installation, registering, and removal. If extra functionality is required, these and other methods can be overridden.  
  
 This class replaces the obsolete [CComModule Class](../vs140/ccommodule-class.md) used in earlier versions of ATL. See [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 [CAtlModule](../vs140/catlmodule-class.md)  
  
 [CAtlModuleT](../vs140/catlmodulet-class.md)  
  
 [CAtlExeModuleT](../vs140/catlexemodulet-class.md)  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="catlservicemodulet__catlservicemodulet">\</a>  CAtlServiceModuleT::CAtlServiceModuleT  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the data members and sets the initial service status.  
  
##  \<a name="catlservicemodulet__handler">\</a>  CAtlServiceModuleT::Handler  
 The handler routine for the service.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *dwOpcode*  
 A switch that defines the handler operation. For details, see the Remarks.  
  
### Remarks  
 This is the code that the Service Control Manager (SCM) calls to retrieve the status of the service and issue instructions such as stop or pause. The SCM passes an operation code, shown below, to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to indicate what the service should do.  
  
|Operation code|Meaning|  
|--------------------|-------------|  
|SERVICE_CONTROL_STOP|Stops the service. Override the method [CAtlServiceModuleT::OnStop](../vs140/catlservicemodulet--onstop.md) in atlbase.h to change the behavior.|  
|SERVICE_CONTROL_PAUSE|User implemented. Override the empty method [CAtlServiceModuleT::OnPause](../vs140/catlservicemodulet--onpause.md) in atlbase.h to pause the service.|  
|SERVICE_CONTROL_CONTINUE|User implemented. Override the empty method [CAtlServiceModuleT::OnContinue](../vs140/catlservicemodulet--oncontinue.md) in atlbase.h to continue the service.|  
|SERVICE_CONTROL_INTERROGATE|User implemented. Override the empty method [CAtlServiceModuleT::OnInterrogate](../vs140/catlservicemodulet--oninterrogate.md) in atlbase.h to interrogate the service.|  
|SERVICE_CONTROL_SHUTDOWN|User implemented. Override the empty method [CAtlServiceModuleT::OnShutdown](../vs140/catlservicemodulet--onshutdown.md) in atlbase.h to shutdown the service.|  
  
 If the operation code isn't recognized, the method [CAtlServiceModuleT::OnUnknownRequest](../vs140/catlservicemodulet--onunknownrequest.md) is called.  
  
 A default ATL-generated service only handles the stop instruction. If the SCM passes the stop instruction, the service tells the SCM that the program is about to stop. The service then calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to post a quit message to itself. This terminates the message loop and the service will ultimately close.  
  
##  \<a name="catlservicemodulet__initializesecurity">\</a>  CAtlServiceModuleT::InitializeSecurity  
 Provides the default security settings for the service.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 In Visual Studio .NET 2003, this method is not implemented in the base class. The Visual Studio project wizard includes this method in the generated code, but a compilation error will occur if a project created in an earlier version of Visual C++ is compiled using ATL 7.1. Any class that derives from <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> must implement this method in the derived class.  
  
 Use PKT-level authentication, impersonation level of RPC_C_IMP_LEVEL_IDENTIFY and an appropriate non-null security descriptor in the call to **CoInitializeSecurity**.  
  
 For wizard-generated nonattributed service projects, this would be in  
  
 [!code[NVC_ATL_Service#1](../vs140/codesnippet/CPP/catlservicemodulet-class_1.cpp)]  
  
 For attributed service projects, this would be in  
  
 [!code[NVC_ATL_ServiceAttrib#1](../vs140/codesnippet/CPP/catlservicemodulet-class_2.cpp)]  
  
##  \<a name="catlservicemodulet__install">\</a>  CAtlServiceModuleT::Install  
 Installs and creates the service.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 Installs the service into the Service Control Manager (SCM) database and then creates the service object. If the service could not be created, a message box is displayed and the method returns FALSE.  
  
##  \<a name="catlservicemodulet__isinstalled">\</a>  CAtlServiceModuleT::IsInstalled  
 Confirms that the service has been installed.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the service is installed, FALSE otherwise.  
  
##  \<a name="catlservicemodulet__logevent">\</a>  CAtlServiceModuleT::LogEvent  
 Writes to the event log.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The string to write to the event log.  
  
 ...  
 Optional extra strings to be written to the event log.  
  
### Remarks  
 This method writes details out to an event log, using the function [ReportEvent](http://msdn.microsoft.com/library/windows/desktop/aa363679). If no service is running, the string is sent to the console.  
  
##  \<a name="catlservicemodulet__m_bservice">\</a>  CAtlServiceModuleT::m_bService  
 Flag indicating the program is running as a service.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Used to distinguish a Service EXE from an Application EXE.  
  
##  \<a name="catlservicemodulet__m_dwthreadid">\</a>  CAtlServiceModuleT::m_dwThreadID  
 Member variable storing the thread identifier of the Service.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 This variable stores the thread identifier of the current thread.  
  
##  \<a name="catlservicemodulet__m_hservicestatus">\</a>  CAtlServiceModuleT::m_hServiceStatus  
 Member variable storing a handle to the status information structure for the current service.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The [SERVICE_STATUS](http://msdn.microsoft.com/library/windows/desktop/ms685996) structure contains information about a service.  
  
##  \<a name="catlservicemodulet__m_status">\</a>  CAtlServiceModuleT::m_status  
 Member variable storing the status information structure for the current service.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The [SERVICE_STATUS](http://msdn.microsoft.com/library/windows/desktop/ms685996) structure contains information about a service.  
  
##  \<a name="catlservicemodulet__m_szservicename">\</a>  CAtlServiceModuleT::m_szServiceName  
 The name of the service being registered.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A null-terminated string which stores the name of the service.  
  
##  \<a name="catlservicemodulet__oncontinue">\</a>  CAtlServiceModuleT::OnContinue  
 Override this method to continue the service.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="catlservicemodulet__oninterrogate">\</a>  CAtlServiceModuleT::OnInterrogate  
 Override this method to interrogate the service.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="catlservicemodulet__onpause">\</a>  CAtlServiceModuleT::OnPause  
 Override this method to pause the service.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="catlservicemodulet__onshutdown">\</a>  CAtlServiceModuleT::OnShutdown  
 Override this method to shut down the service.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="catlservicemodulet__onstop">\</a>  CAtlServiceModuleT::OnStop  
 Override this method to stop the service.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="catlservicemodulet__onunknownrequest">\</a>  CAtlServiceModuleT::OnUnknownRequest  
 Override this method to handle unknown requests to the service.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 */\* dwOpcode \*/*  
 Reserved.  
  
##  \<a name="catlservicemodulet__parsecommandline">\</a>  CAtlServiceModuleT::ParseCommandLine  
 Parses the command line and performs registration if necessary.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The command line.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The HRESULT corresponding to the registration (if it took place).  
  
### Return Value  
 Returns true on success, or false if the RGS file supplied in the command line could not be registered.  
  
### Remarks  
 Parses the command line and registers or unregisters the supplied RGS file if necessary. This method calls [CAtlExeModuleT::ParseCommandLine](../vs140/catlexemodulet--parsecommandline.md) to check for **/RegServer** and **/UnregServer**. Adding the argument **-/Service** will register the service.  
  
##  \<a name="catlservicemodulet__premessageloop">\</a>  CAtlServiceModuleT::PreMessageLoop  
 This method is called immediately before entering the message loop.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 This parameter is passed to [CAtlExeModuleT::PreMessageLoop](../vs140/catlexemodulet--premessageloop.md).  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Override this method to add custom initialization code for the Service.  
  
##  \<a name="catlservicemodulet__registerappid">\</a>  CAtlServiceModuleT::RegisterAppId  
 Registers the service in the registry.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *bService*  
 Must be true to register as a service.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlservicemodulet__run">\</a>  CAtlServiceModuleT::Run  
 Runs the service.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section. The default value is SW_HIDE.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 After being called,                         **Run** calls [CAtlServiceModuleT::PreMessageLoop](../vs140/catlservicemodulet--premessageloop.md), [CAtlExeModuleT::RunMessageLoop](../vs140/catlexemodulet--runmessageloop.md), and [CAtlExeModuleT::PostMessageLoop](../vs140/catlexemodulet--postmessageloop.md).  
  
##  \<a name="catlservicemodulet__servicemain">\</a>  CAtlServiceModuleT::ServiceMain  
 This method is called by the Service Control Manager.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *dwArgc*  
 The argc argument.  
  
 *lpszArgv*  
 The argv argument.  
  
### Remarks  
 The Service Control Manager (SCM) calls <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> when you open the Services application in the Control Panel, select the service, and click Start.  
  
 After the SCM calls <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, a service must give the SCM a handler function. This function lets the SCM obtain the service's status and pass specific instructions (such as pausing or stopping). Subsequently, [CAtlServiceModuleT::Run](../vs140/catlservicemodulet--run.md) is called to perform the main work of the service. **Run** continues to execute until the service is stopped.  
  
##  \<a name="catlservicemodulet__setservicestatus">\</a>  CAtlServiceModuleT::SetServiceStatus  
 This method updates the service status.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The new status. See [SetServiceStatus](http://msdn.microsoft.com/library/windows/desktop/ms686241) for possible values.  
  
### Remarks  
 Updates the Service Control Manager's status information for the service. It is called by [CAtlServiceModuleT::Run](../vs140/catlservicemodulet--run.md), [CAtlServiceModuleT::ServiceMain](../vs140/catlservicemodulet--servicemain.md) and other handler methods. The status is also stored in the member variable [CAtlServiceModuleT::m_status](../vs140/catlservicemodulet--m_status.md).  
  
##  \<a name="catlservicemodulet__start">\</a>  CAtlServiceModuleT::Start  
 Called by <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> when the service starts.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The [CAtlServiceModuleT::WinMain](../vs140/catlservicemodulet--winmain.md) method handles both registration and installation, as well as tasks involved in removing registry entries and uninstalling the module. When the service is run, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> calls **Start**.  
  
##  \<a name="catlservicemodulet__uninstall">\</a>  CAtlServiceModuleT::Uninstall  
 Stops and removes the service.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 Stops the service from running and removes it from the Service Control Manager database.  
  
##  \<a name="catlservicemodulet__unlock">\</a>  CAtlServiceModuleT::Unlock  
 Decrements the service's lock count.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns the lock count, which may be useful for diagnostics and debugging.  
  
##  \<a name="catlservicemodulet__unregisterappid">\</a>  CAtlServiceModuleT::UnregisterAppId  
 Removes the service from the registry.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlservicemodulet__winmain">\</a>  CAtlServiceModuleT::WinMain  
 This method implements the code required to start the service.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section.  
  
### Return Value  
 Returns the service's return value.  
  
### Remarks  
 This method processes the command line (with [CAtlServiceModuleT::ParseCommandLine](../vs140/catlservicemodulet--parsecommandline.md)) and then starts the service (using [CAtlServiceModuleT::Start](../vs140/catlservicemodulet--start.md)).  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)