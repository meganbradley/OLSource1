---
title: "CSimpleMap::RemoveAt"
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
  - "CSimpleMap::RemoveAt"
  - "ATL.CSimpleMap.RemoveAt"
  - "CSimpleMap.RemoveAt"
  - "ATL::CSimpleMap::RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAt method"
ms.assetid: be087e2a-a5e8-4777-8e23-59c28b6d7073
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::RemoveAt
Removes a key and associated value at the specified index.  
  
## Syntax  
  
```  
  
      BOOL RemoveAt(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index of the key and associated value to remove.  
  
## Return Value  
 Returns TRUE on success, FALSE if the index specified is an invalid index.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)   
 [CSimpleMap::RemoveAll](../vs140/csimplemap--removeall.md)   
 [CSimpleMap::Remove](../vs140/csimplemap--remove.md)