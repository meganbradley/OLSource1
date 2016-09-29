---
title: "unique_ptr::unique_ptr"
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
  - "memory/std::unique_ptr::unique_ptr"
  - "unique_ptr::unique_ptr"
  - "unique_ptr"
  - "std.unique_ptr.unique_ptr"
  - "unique_ptr.unique_ptr"
  - "std::unique_ptr::unique_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique_ptr method, constructor"
ms.assetid: 4c5f6387-7c16-4b7e-a55f-039cb1e59429
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::unique_ptr
There are seven constructors for `unique_ptr`.  
  
## Syntax  
  
```  
unique_ptr();  
unique_ptr(nullptr_t);  
explicit unique_ptr(  
    pointer _Ptr  
);  
unique_ptr(  
    Type *_Ptr,  
    typename conditional<  
        is_reference<Del>::value,   
        Del,  
        typename add_reference<const Del>::type>::type _Deleter  
);  
unique_ptr(  
    pointer ptr,  
    typename remove_reference<Del>::type&& _Deleter  
);  
unique_ptr(  
    unique_ptr&& _Right  
);  
template<class Ty2, Class Del2>  
    unique_ptr(  
        unique_ptr<Ty2, Del2>&& _Right  
    );  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Ptr`|A pointer to the resource to be assigned to a `unique_ptr.`|  
|`_Deleter`|A `deleter` to be assigned to a `unique_ptr`.|  
|`_Right`|An `rvalue reference` to a `unique_ptr` from which `unique_ptr` fields are move assigned to the newly constructed `unique_ptr`.|  
  
## Remarks  
 The first two constructors construct an object that manages no resource. The third constructor stores `ptr` in `stored_ptr`. The fourth constructor stores `ptr` in `stored_ptr` and `deleter` in `stored_deleter`.  
  
 The fifth constructor stores `ptr` in `stored_ptr` and moves `deleter` into `stored_deleter`. The sixth and seventh constructors store `right.reset()` in `stored_ptr` and moves `right.get_deleter()` into `stored_deleter`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [<memory\>](../vs140/-memory-.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)