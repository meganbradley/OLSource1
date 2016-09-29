---
title: "tiled_index::operator const index&lt;rank&gt; Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::tiled_index::operator const index<rank>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator const index"
ms.assetid: a56cc467-3dd8-4b21-940e-077d7c5e77b7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_index::operator const index&lt;rank&gt; Operator
Implicitly converts a [tiled_index](../VS_csharp/tiled_index-class.md) object into an [index](../VS_csharp/index-class.md) object.  
  
## Syntax  
  
```  
operator const index<rank>() const restrict(cpu, amp)  
  
```  
  
#### Parameters  
 `rank`  
 The rank of the `tiled_index` object.  
  
## Return Value  
 An object of type `index` that contains a copy of the data that is contained in the `tiled_index` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_index Class](../VS_csharp/tiled_index-class.md)