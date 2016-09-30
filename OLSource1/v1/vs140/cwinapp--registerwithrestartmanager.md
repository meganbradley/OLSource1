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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> indicates that this instance of the application uses a recovery callback function; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> indicates that it does not. The framework calls the recovery callback function when the application exits unexpectedly. For more information, see [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The unique string that identifies this instance of the restart manager. The restart manager identifier is unique for each instance of an application.|  
|[in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A string that contains any extra arguments from the command line.|  
|[in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional flags for the restart manager. For more information, see the Remarks section.|  
|[in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The recovery callback function. This function must take a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter as input and return a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The default recovery callback function is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The input parameter for the recovery callback function. For more information, see [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).|  
|[in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The length of time that the restart manager waits for the recovery callback function to return. This parameter is in milliseconds.|  
|[in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Flags passed to the recovery callback function. Reserved for future use.|  
  
## Return Value  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the method is successful; otherwise an error code.  
  
## Remarks  
 If your application uses the default MFC implementation for autosaving files, you should use the simple version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Use the complex version of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if you want to customize the autosave behavior of your application.  
  
 If you call this method with an empty string for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> creates a unique identifier string for this instance of the restart manager.  
  
 When an application exits unexpectedly, the restart manager restarts the application from the command line and provides the unique restart identifier as an optional argument. In this scenario, the framework calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> two times. The first call comes from [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) with an empty string for the string identifier. Then, the method [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md) calls <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with the unique restart identifier.  
  
 After you register an application with the restart manager, the restart manager monitors the application. If the application exits unexpectedly, the restart manager calls the recovery callback function during the shut down process. The restart manager waits the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for a response from the recovery callback function. If the recovery callback function does not respond within this time, the application exits without executing the recovery callback function.  
  
 By default, the dwRestartFlags are not supported but are provided for future use. The possible values for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are as follows:  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)