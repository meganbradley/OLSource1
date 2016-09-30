---
title: "CMap::GetSize"
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
  - "CMap::GetSize"
  - "CMap.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: b3d286f6-5ae5-4643-a054-e45c41745499
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::GetSize
Returns the number of map elements.  
  
## Syntax  
  
```  
  
INT_PTR GetSize( ) const;  
  
```  
  
## Return Value  
 The number of items in the map.  
  
## Remarks  
 Call this method to retrieve the number of elements in the map.  
  
## Example  
 [!code[NVC_MFCCollections#58](../vs140/codesnippet/CPP/cmap--getsize_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::GetCount](../vs140/cmap--getcount.md)