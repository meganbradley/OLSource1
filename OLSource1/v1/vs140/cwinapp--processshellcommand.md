---
title: "CWinApp::ProcessShellCommand"
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
  - "CWinApp.ProcessShellCommand"
  - "ProcessShellCommand"
  - "CWinApp::ProcessShellCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "ProcessShellCommand method"
  - "command line, management"
ms.assetid: 684ea1bb-0c56-4039-9532-a072e8476f47
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::ProcessShellCommand
This member function is called by [InitInstance](../vs140/cwinapp--initinstance.md) to accept the parameters passed from the `CCommandLineInfo` object identified by `rCmdInfo`, and perform the indicated action.  
  
## Syntax  
  
```  
  
      BOOL ProcessShellCommand(  
   CCommandLineInfo& rCmdInfo   
);  
```  
  
#### Parameters  
 `rCmdInfo`  
 A reference to a [CCommandLineInfo](../vs140/ccommandlineinfo-class.md) object.  
  
## Return Value  
 Nonzero if the shell command is processed successfully. If 0, return **FALSE** from [InitInstance](../vs140/cwinapp--initinstance.md).  
  
## Remarks  
 When you start a new MFC project using the Application Wizard, the Application Wizard will create a local instance of `CCommandLineInfo`, and then call `ProcessShellCommand` and [ParseCommandLine](../vs140/cwinapp--parsecommandline.md) in the `InitInstance` member function. A command line follows the route described below:  
  
1.  After being created in `InitInstance`, the `CCommandLineInfo` object is passed to `ParseCommandLine`.  
  
2.  `ParseCommandLine` then calls [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md) repeatedly, once for each parameter.  
  
3.  `ParseParam` fills the `CCommandLineInfo` object, which is then passed to `ProcessShellCommand`.  
  
4.  `ProcessShellCommand` handles the command-line arguments and flags.  
  
 The data members of the `CCommandLineInfo` object, identified by [CCommandLineInfo::m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md), are of the following enumerated type, which is defined within the `CCommandLineInfo` class.  
  
 `enum {`  
  
 `FileNew,`  
  
 `FileOpen,`  
  
 `FilePrint,`  
  
 `FilePrintTo,`  
  
 `FileDDE,`  
  
 `};`  
  
 For a brief description of each of these values, see `CCommandLineInfo::m_nShellCommand`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::ParseCommandLine](../vs140/cwinapp--parsecommandline.md)   
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md)   
 [CCommandLineInfo::m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md)