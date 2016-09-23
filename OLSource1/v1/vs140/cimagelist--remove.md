---
title: "CImageList::Remove"
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
  - CImageList.Remove
  - CImageList::Remove
dev_langs: 
  - C++
helpviewer_keywords: 
  - Remove method
ms.assetid: c8240071-32df-4e17-a5ee-82996a4dc4e6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImageList::Remove
Call this function to remove an image from an image list object.  
  
## Syntax  
  
```  
  
      BOOL Remove(  
   int nImage   
);  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image to remove.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 All items following `nImage` now move down one position. For example, if an image list contains two items, deleting the first item will cause the remaining item to now be in the first position. `nImage`=0 for the item in the first position.  
  
## Example  
 [!code[NVC_MFC_CImageList#19](../vs140/codesnippet/CPP/cimagelist--remove_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::DeleteImageList](../vs140/cimagelist--deleteimagelist.md)