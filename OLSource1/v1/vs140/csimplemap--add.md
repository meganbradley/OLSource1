---
title: "CSimpleMap::Add"
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
  - "CSimpleMap::Add"
  - "ATL::CSimpleMap::Add"
  - "CSimpleMap.Add"
  - "ATL.CSimpleMap.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 1e5fd8a5-04a6-4f3b-9e70-687e9a20d48c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::Add
Adds a key and associated value to the map array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The key.  
  
 *val*  
 The associated value.  
  
## Return Value  
 Returns TRUE if the key and value were successfully added, FALSE otherwise.  
  
## Remarks  
 Each key and value pair added causes the mapping array memory to be freed and reallocated, in order to ensure the data for each is always stored contiguously. That is, the second key element always directly follows the first key element in memory and so on.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)