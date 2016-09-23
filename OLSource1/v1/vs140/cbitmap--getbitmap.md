---
title: "CBitmap::GetBitmap"
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
  - CBitmap::GetBitmap
  - CBitmap.GetBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetBitmap method
  - CBitmap class, attributes
ms.assetid: 0ae87099-cbdd-4a97-a431-f0633a622d3b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::GetBitmap
Retrieves image properties for the attached bitmap.  
  
## Syntax  
  
```  
int GetBitmap(  
   BITMAP* pBitMap  
);  
```  
  
#### Parameters  
 `pBitMap`  
 Pointer to a [BITMAP Structure](../vs140/bitmap-structure.md) structure that will receive the image properties. This parameter must not be `NULL`.  
  
## Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [BITMAP Structure](../vs140/bitmap-structure.md)