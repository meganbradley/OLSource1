---
title: "CFile::hFileNull"
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
  - "hFileNull"
  - "CFile.hFileNull"
  - "CFile::hFileNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hFileNull data member"
ms.assetid: a12b872c-8cff-46f8-b1f7-2784ce0a027d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::hFileNull
Determines the presence of a valid file handle for the `CFile` object.  
  
## Syntax  
  
```  
  
static AFX_DATA const HANDLE hFileNull;  
  
```  
  
## Remarks  
 This constant is used to determine if the `CFile` object has a valid file handle.  
  
 The following example demonstrates this operation:  
  
 [!code[NVC_MFCFiles#22](../vs140/codesnippet/CPP/cfile--hfilenull_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)