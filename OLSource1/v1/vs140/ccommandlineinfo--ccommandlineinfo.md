---
title: "CCommandLineInfo::CCommandLineInfo"
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
  - "CCommandLineInfo::CCommandLineInfo"
  - "CCommandLineInfo.CCommandLineInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCommandLineInfo class, constructor"
ms.assetid: 9aba3192-75f5-47b7-9866-bc096a6411ca
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommandLineInfo::CCommandLineInfo
This constructor creates a `CCommandLineInfo` object with default values.  
  
## Syntax  
  
```  
  
CCommandLineInfo( );  
  
```  
  
## Remarks  
 The default is to show the splash screen (`m_bShowSplash` **= TRUE**) and to execute the New command on the File menu (`m_nShellCommand` **= NewFile**).  
  
 The application framework calls [ParseParam](../vs140/ccommandlineinfo--parseparam.md) to fill data members of this object.  
  
## Example  
 [!code[NVC_MFCDocView#54](../vs140/codesnippet/CPP/ccommandlineinfo--ccommandlineinfo_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCommandLineInfo::ParseParam](../vs140/ccommandlineinfo--parseparam.md)