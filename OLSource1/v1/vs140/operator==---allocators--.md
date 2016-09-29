---
title: "operator== (&lt;allocators&gt;)"
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
  - "allocators/stdext::operator=="
  - "stdext.=="
  - "stdext.operator=="
  - "stdext::=="
  - "operator=="
  - "stdext::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, allocators objects"
  - "== operator"
  - "operator==, allocators objects"
ms.assetid: 0636dd3b-377f-4e57-b83c-1c71dac88edc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;allocators&gt;)
Tests for equality between allocator objects of a specified class.  
  
## Syntax  
  
```  
template <class Type, class Sync>  
    bool operator==(  
        const allocator_base<Type, Sync>& _Left,  
        const allocator_base<Type, Sync>& _Right  
    );  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|One of the allocator objects to be tested for equality.|  
|`_Right`|One of the allocator objects to be tested for equality.|  
  
## Return Value  
 **true** if the allocator objects are equal; **false** if allocator objects are not equal.  
  
## Remarks  
 This template operator returns `_Left.equals(_Right)`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [<allocators\>](../vs140/-allocators-.md)