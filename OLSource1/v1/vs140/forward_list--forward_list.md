---
title: "forward_list::forward_list"
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
  - std.forward_list.forward_list
  - forward_list/std::forward_list::forward_list
  - forward_list::forward_list
  - forward_list
  - forward_list.forward_list
  - std::forward_list::forward_list
dev_langs: 
  - C++
helpviewer_keywords: 
  - forward_list method
  - forward_list class, constructor
ms.assetid: bd90a932-35a1-4338-9ad2-a39708933e16
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# forward_list::forward_list
Constructs an object of type `forward_list`.  
  
## Syntax  
  
```  
forward_list();  
explicit forward_list(const Allocator& Al);  
explicit forward_list(size_type Count);  
forward_list(size_type Count, const Type& Val);  
forward_list(size_type Count, const Type& Val,  
    const Allocator& Al);  
forward_list(const forward_list& Right);  
forward_list(const forward_list& Right, const Allocator& Al);  
forward_list(forward_list&& Right);   
forward_list(forward_list&& Right, const Allocator& Al);  
forward_list(  
initializer_list<Type> IList,  
    const Alloc& Al  
);  
template<class InputIterator>  
    forward_list(InputIterator First, InputIterator Last);  
template<class InputIterator>  
    forward_list(InputIterator First, InputIterator Last,  
    const Allocator& Al  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Al`|The allocator class to use with this object.|  
|`Count`|The number of elements in the list constructed.|  
|`Val`|The value of the elements in the list constructed.|  
|`Right`|The list of which the constructed list is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list to copy.|  
  
## Remarks  
 All constructors store an [allocator](../vs140/allocator-class.md) and initialize the controlled sequence. The allocator object is the argument `Al`, if present. For the copy constructor, it is `_Right.get_allocator()`. Otherwise, it is `Allocator()`.  
  
 The first two constructors specify an empty initial controlled sequence.  
  
 The third constructor specifies a repetition of `Count` elements of value `Type()`.  
  
 The fourth and fifth constructors specify a repetition of `Count` elements of value `Val`.  
  
 The sixth constructor specifies a copy of the sequence controlled by `Right`. If `InputIterator` is an integer type, the next two constructors specify a repetition of `(size_type)First` elements of value `(Type)Last`. Otherwise, the next two constructors specify the sequence `[First, Last)`.  
  
 The ninth and tenth constructors are the same as the sixth, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 The last constructor specifies the initial controlled sequence with an object of class `initializer_list<Type>`.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)