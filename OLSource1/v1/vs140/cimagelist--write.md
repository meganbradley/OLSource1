---
title: "CImageList::Write"
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
  - "CImageList.Write"
  - "CImageList::Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Write method"
ms.assetid: 178bcb68-103d-4232-898e-568378fb88be
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Write
Call this function to write an image list object to an archive.  
  
## Syntax  
  
```  
  
      BOOL Write(  
   CArchive* pArchive   
);  
```  
  
#### Parameters  
 `pArchive`  
 A pointer to a `CArchive` object in which the image list is to be stored.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CImageList#17](../vs140/codesnippet/CPP/cimagelist--write_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Read](../vs140/cimagelist--read.md)