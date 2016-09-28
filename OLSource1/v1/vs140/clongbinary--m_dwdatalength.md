---
title: "CLongBinary::m_dwDataLength"
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
  - "CLongBinary::m_dwDataLength"
  - "m_dwDataLength"
  - "CLongBinary.m_dwDataLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwDataLength"
ms.assetid: ef3e9471-1a3b-49a7-92e8-5f29ded135b2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLongBinary::m_dwDataLength
Stores the actual size in bytes of the data stored in the `HGLOBAL` handle in `m_hData`.  
  
## Syntax  
  
```  
  
SQLULEN m_dwDataLength;  
  
```  
  
## Remarks  
 This size may be smaller than the size of the memory block allocated for the data. Call the Win32 [GLobalSize](http://msdn.microsoft.com/library/windows/desktop/aa366593) function to get the allocated size.  
  
## Requirements  
 **Header:** afxdb_.h  
  
## See Also  
 [CLongBinary Class](../vs140/clongbinary-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)