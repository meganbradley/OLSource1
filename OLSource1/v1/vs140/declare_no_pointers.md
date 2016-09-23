---
title: "declare_no_pointers"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.declare_no_pointers
  - memory/std::declare_no_pointers
  - declare_no_pointers
  - std::declare_no_pointers
dev_langs: 
  - C++
helpviewer_keywords: 
  - declare_no_pointers function
  - declare_no_pointers
ms.assetid: 46338586-4a35-422e-a77c-9bba0004f3cd
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# declare_no_pointers
Informs a garbage collector that the characters in the memory block defined by a base address pointer and block size contains no traceable pointers.  
  
## Syntax  
  
```  
void declare_no_pointers(  
    char *_Ptr,   
    size_t _Size  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|Address of first character that no longer contains traceable pointers.|  
|`_Size`|Size of block that starts at `_Ptr` that contains no traceable pointers.|  
  
## Remarks  
 The function informs any `garbage collector` that the range of addresses `[``_Ptr``,` `_Ptr` `+` `_Size``)` no longer contain traceable pointers. (Any pointers to allocated storage must not be dereferenced unless made `reachable`.)  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)