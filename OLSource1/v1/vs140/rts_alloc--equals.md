---
title: "rts_alloc::equals"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "rts_alloc::equals"
  - "stdext.rts_alloc.equals"
  - "allocators/stdext::rts_alloc::equals"
  - "rts_alloc.equals"
  - "stdext::rts_alloc::equals"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equals method"
ms.assetid: fe858e56-72e9-4328-bef3-e3d03b29535c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rts_alloc::equals
Compares two caches for equality.  
  
## Syntax  
  
```  
bool equals(const sync<_Cache>& _Other) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Cache`|The cache object associated with the filter.|  
|`_Other`|The cache object to compare for equality.|  
  
## Remarks  
 `true` if the result of `caches[0].equals(other.caches[0])`; otherwise, `false`. `caches` represents the array of cache objects.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext