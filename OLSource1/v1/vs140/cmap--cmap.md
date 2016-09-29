---
title: "CMap::CMap"
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
  - "CMap.CMap"
  - "CMap::CMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, constructor"
ms.assetid: 3808d760-ffef-4b5d-9281-ccf65b6a1ccf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::CMap
Constructs an empty map.  
  
## Syntax  
  
```  
  
      CMap(  
   INT_PTR nBlockSize = 10   
);  
```  
  
#### Parameters  
 `nBlockSize`  
 Specifies the memory-allocation granularity for extending the map.  
  
## Remarks  
 As the map grows, memory is allocated in units of `nBlockSize` entries.  
  
## Example  
 [!code[NVC_MFCCollections#56](../vs140/codesnippet/CPP/cmap--cmap_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)