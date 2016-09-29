---
title: "CMap::RemoveAll"
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
  - "CMap.RemoveAll"
  - "CMap::RemoveAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMap class, operations"
  - "RemoveAll method"
ms.assetid: 285b18f8-b843-4a35-925a-be8100dd625e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap::RemoveAll
Removes all the values from this map by calling the global helper function **DestructElements**.  
  
## Syntax  
  
```  
  
void RemoveAll( );  
```  
  
## Remarks  
 The function works correctly if the map is already empty.  
  
## Example  
 [!code[NVC_MFCCollections#61](../vs140/codesnippet/CPP/cmap--removeall_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CMap Class](../vs140/cmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMap::RemoveKey](../vs140/cmap--removekey.md)