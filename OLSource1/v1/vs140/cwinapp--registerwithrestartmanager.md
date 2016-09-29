---
title: "CWinApp::RegisterWithRestartManager"
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
  - "CWinApp::RegisterWithRestartManager"
  - "RegisterWithRestartManager"
  - "CWinApp.RegisterWithRestartManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterWithRestartManager method"
ms.assetid: 102e3032-2f93-464e-87b4-d6941301a1c4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::RegisterWithRestartManager
Registers the application with the restart manager.  
  
## Syntax  
  
```  
virtual HRESULT RegisterWithRestartManager(  
   BOOL bRegisterRecoveryCallback,  
   const CString &strRestartIdentifier  
);  
  
virtual HRESULT RegisterWithRestartManager(  
   LPCWSTR pwzCommandLineArgs,  
   DWORD dwRestartFlags,  
   APPLICATION_RECOVERY_CALLBACK pRecoveryCallback,  
   LPVOID lpvParam,  
   DWORD dwPingInterval,  
   DWORD dwCallbackFlags  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `bRegisterRecoveryCallback`|`TRUE` indicates that this instance of the application uses a recovery callback function; `FALSE` indicates that it does not. The framework calls the recovery callback function when the application exits unexpectedly. For more information, see [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).|  
|[in] `strRestartIdentifier`|The unique string that identifies this instance of the restart manager. The restart manager identifier is unique for each instance of an application.|  
|[in] `pwzCommandLineArgs`|A string that contains any extra arguments from the command line.|  
|[in] `dwRestartFlags`|Optional flags for the restart manager. For more information, see the Remarks section.|  
|[in] `pRecoveryCallback`|The recovery callback function. This function must take a `LPVOID` parameter as input and return a `DWORD`. The default recovery callback function is `CWinApp::ApplicationRecoveryCallback`.|  
|[in] `lpvParam`|The input parameter for the recovery callback function. For more information, see [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).|  
|[in] `dwPingInterval`|The length of time that the restart manager waits for the recovery callback function to return. This parameter is in milliseconds.|  
|[in] `dwCallbackFlags`|Flags passed to the recovery callback function. Reserved for future use.|  
  
## Return Value  
 `S_OK` if the method is successful; otherwise an error code.  
  
## Remarks  
 If your application uses the default MFC implementation for autosaving files, you should use the simple version of `RegisterWithRestartManager`. Use the complex version of `RegisterWithRestartManager` if you want to customize the autosave behavior of your application.  
  
 If you call this method with an empty string for `strRestartIdentifier`, `RegisterWithRestartManager` creates a unique identifier string for this instance of the restart manager.  
  
 When an application exits unexpectedly, the restart manager restarts the application from the command line and provides the unique restart identifier as an optional argument. In this scenario, the framework calls `RegisterWithRestartManager` two times. The first call comes from [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) with an empty string for the string identifier. Then, the method [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md) calls `RegisterWithRestartManager` with the unique restart identifier.  
  
 After you register an application with the restart manager, the restart manager monitors the application. If the application exits unexpectedly, the restart manager calls the recovery callback function during the shut down process. The restart manager waits the `dwPingInterval` for a response from the recovery callback function. If the recovery callback function does not respond within this time, the application exits without executing the recovery callback function.  
  
 By default, the dwRestartFlags are not supported but are provided for future use. The possible values for `dwRestartFlags` are as follows:  
  
-   `RESTART_NO_CRASH`  
  
-   `RESTART_NO_HANG`  
  
-   `RESTART_NO_PATCH`  
  
-   `RESTART_NO_REBOOT`  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)