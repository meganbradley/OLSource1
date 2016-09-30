---
title: "CCommandLineInfo::m_nShellCommand"
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
  - "FileDDE"
  - "FilePrint"
  - "FileNew"
  - "m_nShellCommand"
  - "CCommandLineInfo.m_nShellCommand"
  - "FilePrintTo"
  - "CCommandLineInfo::m_nShellCommand"
  - "FileOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nShellCommand"
  - "FileDDE method"
  - "FileOpen method"
  - "FilePrint method"
  - "FileNew method"
  - "FilePrintTo method"
ms.assetid: dea603a1-93c1-42b1-baf5-3c19207321b3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommandLineInfo::m_nShellCommand
Indicates the shell command for this instance of the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type for this data member is the following enumerated type, which is defined in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 For a brief description of these values, see the following list.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> Indicates that no file name was found on the command line.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Indicates that a file name was found on the command line and that none of the following flags were found on the command line: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> Indicates that the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> flag was found on the command line.  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Indicates that the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> flag was found on the command line.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Indicates that the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> flag was found on the command line.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Indicates that the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> flag was found on the command line and the application was asked to register.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> Indicates that the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> application was asked to unregister.  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> Indicates that the application was restarted by the restart manager.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> Turns off the display of a new MDI child window on startup. By design, Application Wizard-generated MDI applications display a new child window on startup. To turn off this feature, an application can use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> as the shell command when it calls [ProcessShellCommand](../vs140/cwinapp--processshellcommand.md). <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is called by the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> of all <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> derived classes.  
  
## Example  
 [!code[NVC_MFCDocView#55](../vs140/codesnippet/CPP/ccommandlineinfo--m_nshellcommand_1.cpp)]  
  
## Requirements  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::m_strFileName](../vs140/ccommandlineinfo--m_strfilename.md)   
 [CCommandLineInfo::m_strPrinterName](../vs140/ccommandlineinfo--m_strprintername.md)   
 [CCommandLineInfo::m_strDriverName](../vs140/ccommandlineinfo--m_strdrivername.md)   
 [CCommandLineInfo::m_strPortName](../vs140/ccommandlineinfo--m_strportname.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)