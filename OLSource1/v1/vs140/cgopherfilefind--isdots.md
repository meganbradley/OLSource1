---
title: "CGopherFileFind::IsDots"
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
  - "CGopherFileFind::IsDots"
  - "CGopherFileFind.IsDots"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDots method"
ms.assetid: bc55a7ac-b87a-42cd-971b-763b1f1d528c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::IsDots
Tests for the current directory and parent directory markers while iterating through files.  
  
## Syntax  
  
```  
  
virtual BOOL IsDots( ) const;  
  
```  
  
## Return Value  
 Nonzero if the found file has the name "." or "..", which indicates that the found file is actually a directory. Otherwise 0.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) at least once before calling `IsDots`.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)