---
title: "hash_set::hash_set"
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
  - "stdext::hash_set::hash_set"
  - "std.hash_set.hash_set"
  - "hash_set/stdext::hash_set::hash_set"
  - "stdext.hash_set.hash_set"
  - "hash_set"
  - "hash_set.hash_set"
  - "hash_set::hash_set"
  - "std::hash_set::hash_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_set class, constructor"
  - "hash_set method"
ms.assetid: 806b4861-f8ff-4a2b-ac69-4d2bc8466c1d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::hash_set
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Constructs a `hash_set` that is empty or that is a copy of all or part of some other `hash_set`.  
  
## Syntax  
  
```  
hash_set( );  
explicit hash_set(  
    const Traits& Comp  
);  
hash_set(  
    const Traits& Comp,  
    const Allocator& Al  
);  
hash_set(  
    const hash_set<Key, Traits, Allocator>& Right  
);  
hash_set(  
    hash_set&& Right  
);  
hash_set(  
     initializer_list<Type> IList  
);  
hash_set(  
      initializer_list<Type> IList,   
     const Compare& Comp  
);  
hash_set(  
      initializer_list<value_type> IList,   
     const Compare& Comp,   
     const Allocator& Al  
);   
template<class InputIterator>  
    hash_set(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    hash_set(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp  
    );  
template<class InputIterator>  
    hash_set(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this `hash_set` object, which defaults to `Allocator`.|  
|`Comp`|The comparison function of type `const Traits` used to order the elements in the `hash_set`, which defaults to `hash_compare`.|  
|`Right`|The `hash_set` of which the constructed `hash_set` is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the `hash_set` and that can later be returned by calling [hash_set::get_allocator](../vs140/hash_set--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_sets.  
  
 All constructors store a function object of type `Traits` that is used to establish an order among the keys of the `hash_set` and that can later be returned by calling [hash_set::key_comp](../vs140/hash_set--key_comp.md). For more information on `Traits` see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 The first constructor creates an empty initial `hash_set` The second specifies the type of comparison function (`Comp`) to be used in establishing the order of the elements, and the third explicitly specifies the allocator type (`Al`) to be used. The key word `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth and fifth constructors specify a copy of the `hash_set``Right`.  
  
 The last sixth, seventh, and eighth constructors use an initializer_list for the elements.  
  
 The last constructors copy the range [`First`, `Last`) of a `hash_set` with increasing explicitness in specifying the type of comparison function of class Traits and allocator.  
  
 The eighth constructor moves the `hash_set``Right`.  
  
 The actual order of elements in a `hash_set` container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)