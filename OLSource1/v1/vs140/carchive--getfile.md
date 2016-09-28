---
title: "CArchive::GetFile"
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
  - "CArchive::GetFile"
  - "CArchive.GetFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFile method"
  - "CArchive class, status"
ms.assetid: e2edf044-538b-4dfe-bc0e-7608d1dce179
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::GetFile
Gets the `CFile` object pointer for this archive.  
  
## Syntax  
  
```  
  
CFile* GetFile( ) const;  
```  
  
## Return Value  
 A constant pointer to the `CFile` object in use.  
  
## Remarks  
 You must flush the archive before using `GetFile`.  
  
## Example  
 [!code[NVC_MFCSerialization#14](../vs140/codesnippet/CPP/carchive--getfile_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Flush](../vs140/carchive--flush.md)