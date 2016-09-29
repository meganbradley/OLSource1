---
title: "CSimpleMap::Remove"
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
  - "CSimpleMap::Remove"
  - "CSimpleMap.Remove"
  - "ATL.CSimpleMap.Remove"
  - "ATL::CSimpleMap::Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: a191c55e-a3f6-4eaa-9918-f14a2ebb75a1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::Remove
Removes a key and matching value.  
  
## Syntax  
  
```  
  
      BOOL Remove(  
   const TKey& key   
);  
```  
  
#### Parameters  
 `key`  
 The key.  
  
## Return Value  
 Returns TRUE if the key, and matching value, were successfully removed, FALSE otherwise.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)   
 [CSimpleMap::RemoveAll](../vs140/csimplemap--removeall.md)   
 [CSimpleMap::RemoveAt](../vs140/csimplemap--removeat.md)