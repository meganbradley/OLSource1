---
title: "CWinApp::ParseCommandLine"
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
  - "CWinApp.ParseCommandLine"
  - "CWinApp::ParseCommandLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "command line, parsing"
  - "parsing, command-line arguments"
  - "startup code, parsing command-line arguments"
  - "ParseCommandLine method"
ms.assetid: 7ee5b480-7cb1-4ce5-91a0-a99ae5aa8417
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::ParseCommandLine
Call this member function to parse the command line and send the parameters, one at a time, to [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [CCommandLineInfo](../vs140/ccommandlineinfo-class.md) object.  
  
## Remarks  
 When you start a new MFC project using the Application Wizard, the Application Wizard will create a local instance of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and then call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the [InitInstance](../vs140/cwinapp--initinstance.md) member function. A command line follows the route described below:  
  
1.  After being created in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is passed to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
2.  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> then calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> repeatedly, once for each parameter.  
  
3.  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fills the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, which is then passed to [ProcessShellCommand](../vs140/cwinapp--processshellcommand.md).  
  
4.  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> handles the command-line arguments and flags.  
  
 Note that you can call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directly as needed.  
  
 For a description of the command-line flags, see [CCommandLineInfo::m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)   
 [CCommandLineInfo::m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md)