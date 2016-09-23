---
title: "CCommandLineInfo::m_bShowSplash"
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
  - CCommandLineInfo.m_bShowSplash
  - m_bShowSplash
  - CCommandLineInfo::m_bShowSplash
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bShowSplash
ms.assetid: 05aae7de-240b-4c11-9b5f-90dd82352e77
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCommandLineInfo::m_bShowSplash
Indicates that the splash screen should be displayed.  
  
## Syntax  
  
```  
  
BOOL m_bShowSplash;  
  
```  
  
## Remarks  
 If **TRUE**, this means the splash screen for this application should be displayed during startup. The default implementation of [ParseParam](../vs140/ccommandlineinfo--parseparam.md) sets this data member to **TRUE** if [m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md) is equal to **CCommandLineInfo::FileNew**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::m_bRunAutomated](../vs140/ccommandlineinfo--m_brunautomated.md)   
 [CCommandLineInfo::m_bRunEmbedded](../vs140/ccommandlineinfo--m_brunembedded.md)   
 [CCommandLineInfo::m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md)   
 [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md)   
 [CWinApp::ProcessShellCommand](../vs140/cwinapp--processshellcommand.md)