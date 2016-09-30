---
title: "num_get::num_get"
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
  - "num_get::num_get"
  - "std.num_get.num_get"
  - "num_get"
  - "num_get.num_get"
  - "xlocnum/std::num_get::num_get"
  - "std::num_get::num_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "num_get class, constructor"
  - "num_get method"
ms.assetid: 766b3163-fffe-4e6c-be35-a173daf118c1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_get::num_get
The constructor for objects of type `num_get` that are used to extract numerical values from sequences.  
  
## Syntax  
  
```  
explicit num_get(  
    size_t _Refs = 0  
);  
```  
  
#### Parameters  
 `_Refs`  
 Integer value used to specify the type of memory management for the object.  
  
## Remarks  
 The possible values for the `_Refs` parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(`_Refs`).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [num_get Class](../vs140/num_get-class.md)