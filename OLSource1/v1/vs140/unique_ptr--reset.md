---
title: "unique_ptr::reset"
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
  - "std.unique_ptr.reset"
  - "unique_ptr.reset"
  - "memory/std::unique_ptr::reset"
  - "unique_ptr::reset"
  - "reset"
  - "std::unique_ptr::reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method"
ms.assetid: ad3bc68d-add1-40a3-9427-40a1fbaf8cbb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::reset
Takes ownership of the pointer parameter, and then deletes the original stored pointer. If the new pointer is the same as the original stored pointer, `reset` deletes the pointer and sets the stored pointer to `nullptr`.  
  
## Syntax  
  
```  
void reset(pointer ptr = pointer());  
void reset(nullptr_t ptr);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ptr`|A pointer to the resource to take ownership of.|  
  
## Remarks  
 Use `reset` to change the stored [pointer](../vs140/pointer.md) owned by the `unique_ptr` to `ptr` and then delete the original stored pointer. If the `unique_ptr` was not empty, `reset` invokes the deleter function returned by [get_deleter](../vs140/unique_ptr--get_deleter.md) on the original stored pointer.  
  
 Because `reset` first stores the new pointer `ptr`, and then deletes the original stored pointer, it's possible for `reset` to immediately delete `ptr` if it is the same as the original stored pointer.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [\<memory>](../vs140/-memory-.md)