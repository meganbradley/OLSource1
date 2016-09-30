---
title: "pointer_safety Enumeration"
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
  - "std::pointer_safety"
  - "pointer_safety::pointer_safety"
  - "std::pointer_safety::pointer_safety"
  - "memory/std::pointer_safety::pointer_safety"
  - "std.pointer_safety.pointer_safety"
  - "std.pointer_safety"
  - "memory/std::pointer_safety"
  - "pointer_safety"
  - "pointer_safety.pointer_safety"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer_safety enum"
  - "pointer_safety function"
  - "pointer_safety namespace"
ms.assetid: b4a611f0-c2b1-47b1-9dd9-d74bae6468bf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pointer_safety Enumeration
The enumeration of possible values returned by `get_pointer_safety`.  
  
## Syntax  
  
```  
enum class pointer_safety {  
    relaxed,   
    preferred,   
    strict  
    };  
```  
  
## Remarks  
 The scoped `enum` defines the values that can be returned by `get_pointer_safety``()`:  
  
 `relaxed` -- pointers not safely derived (obviously pointers to declared or allocated objects) are treated the same as those safely derived.  
  
 `preferred` -- as before, but pointers not safely derived should not be dereferenced.  
  
 `strict` -- pointers not safely derived might be treated differently than those safely derived.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)