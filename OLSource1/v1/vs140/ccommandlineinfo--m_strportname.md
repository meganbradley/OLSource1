---
title: "CCommandLineInfo::m_strPortName"
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
  - "CCommandLineInfo::m_strPortName"
  - "CCommandLineInfo.m_strPortName"
  - "m_strPortName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_strPortName"
ms.assetid: f2e32d03-615f-48e9-bc84-0700a283ba17
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommandLineInfo::m_strPortName
Stores the value of the fourth non-flag parameter on the command line.  
  
## Syntax  
  
```  
  
CString m_strPortName;  
  
```  
  
## Remarks  
 This parameter is typically the name of the printer port for a Print To shell command. The default implementation of [ParseParam](../vs140/ccommandlineinfo--parseparam.md) sets this data member only if the **/pt** flag was found on the command line.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::m_strFileName](../vs140/ccommandlineinfo--m_strfilename.md)   
 [CCommandLineInfo::m_strPrinterName](../vs140/ccommandlineinfo--m_strprintername.md)   
 [CCommandLineInfo::m_strDriverName](../vs140/ccommandlineinfo--m_strdrivername.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)