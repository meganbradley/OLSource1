---
title: "CCommandLineInfo::m_strDriverName"
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
  - "m_strDriverName"
  - "CCommandLineInfo::m_strDriverName"
  - "CCommandLineInfo.m_strDriverName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_strDriverName"
ms.assetid: e5b6bd3f-85b1-45ec-9426-95f35446ac62
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommandLineInfo::m_strDriverName
Stores the value of the third non-flag parameter on the command line.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This parameter is typically the name of the printer driver for a Print To shell command. The default implementation of [ParseParam](../vs140/ccommandlineinfo--parseparam.md) sets this data member only if the **/pt** flag was found on the command line.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::m_strFileName](../vs140/ccommandlineinfo--m_strfilename.md)   
 [CCommandLineInfo::m_strPrinterName](../vs140/ccommandlineinfo--m_strprintername.md)   
 [CCommandLineInfo::m_strPortName](../vs140/ccommandlineinfo--m_strportname.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)