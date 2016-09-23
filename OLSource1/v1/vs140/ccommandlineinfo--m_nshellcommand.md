---
title: "CCommandLineInfo::m_nShellCommand"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - FileDDE
  - FilePrint
  - FileNew
  - m_nShellCommand
  - CCommandLineInfo.m_nShellCommand
  - FilePrintTo
  - CCommandLineInfo::m_nShellCommand
  - FileOpen
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_nShellCommand
  - FileDDE method
  - FileOpen method
  - FilePrint method
  - FileNew method
  - FilePrintTo method
ms.assetid: dea603a1-93c1-42b1-baf5-3c19207321b3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCommandLineInfo::m_nShellCommand
Indicates the shell command for this instance of the application.  
  
## Syntax  
  
```  
m_nShellCommand;  
```  
  
## Remarks  
 The type for this data member is the following enumerated type, which is defined in the `CCommandLineInfo` class.  
  
 `enum{`  
  
 `FileNew,`  
  
 `FileOpen,`  
  
 `FilePrint,`  
  
 `FilePrintTo,`  
  
 `FileDDE,`  
  
 `AppRegister,`  
  
 `AppUnregister,`  
  
 `RestartByRestartManager,`  
  
 `FileNothing = -1`  
  
 `};`  
  
 For a brief description of these values, see the following list.  
  
-   `CCommandLineInfo::FileNew` Indicates that no file name was found on the command line.  
  
-   `CCommandLineInfo::FileOpen` Indicates that a file name was found on the command line and that none of the following flags were found on the command line: `/p`, `/pt`, `/dde`.  
  
-   `CCommandLineInfo::FilePrint` Indicates that the `/p` flag was found on the command line.  
  
-   `CCommandLineInfo::FilePrintTo` Indicates that the `/pt` flag was found on the command line.  
  
-   `CCommandLineInfo::FileDDE` Indicates that the `/dde` flag was found on the command line.  
  
-   `CCommandLineInfo::AppRegister` Indicates that the `/Register` or `/Regserver` flag was found on the command line and the application was asked to register.  
  
-   `CCommandLineInfo::AppUnregister` Indicates that the `/Unregister` or `/Unregserver` application was asked to unregister.  
  
-   `CCommandLineInfo::RestartByRestartManager` Indicates that the application was restarted by the restart manager.  
  
-   `CCommandLineInfo::FileNothing` Turns off the display of a new MDI child window on startup. By design, Application Wizard-generated MDI applications display a new child window on startup. To turn off this feature, an application can use `CCommandLineInfo::FileNothing` as the shell command when it calls [ProcessShellCommand](../vs140/cwinapp--processshellcommand.md). `ProcessShellCommand` is called by the `InitInstance( )` of all `CWinApp` derived classes.  
  
## Example  
 [!code[NVC_MFCDocView#55](../vs140/codesnippet/CPP/ccommandlineinfo--m_nshellcommand_1.cpp)]
  
  
## Requirements  
 `Header:` afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::m_strFileName](../vs140/ccommandlineinfo--m_strfilename.md)   
 [CCommandLineInfo::m_strPrinterName](../vs140/ccommandlineinfo--m_strprintername.md)   
 [CCommandLineInfo::m_strDriverName](../vs140/ccommandlineinfo--m_strdrivername.md)   
 [CCommandLineInfo::m_strPortName](../vs140/ccommandlineinfo--m_strportname.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)