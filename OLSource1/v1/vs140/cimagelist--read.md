---
title: "CImageList::Read"
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
  - CImageList::Read
  - CImageList.Read
dev_langs: 
  - C++
helpviewer_keywords: 
  - Read method
ms.assetid: c56106b6-5dd5-4bd4-9f5d-e56f3486a99c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImageList::Read
Call this function to read an image list from an archive.  
  
## Syntax  
  
```  
  
      BOOL Read(  
   CArchive* pArchive   
);  
```  
  
#### Parameters  
 `pArchive`  
 A pointer to a `CArchive` object from which the image list is to be read.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CImageList#18](../vs140/codesnippet/CPP/cimagelist--read_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Write](../vs140/cimagelist--write.md)