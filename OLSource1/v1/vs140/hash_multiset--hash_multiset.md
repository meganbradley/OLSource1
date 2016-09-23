---
title: "hash_multiset::hash_multiset"
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
  - hash_set/stdext::hash_multiset::hash_multiset
  - std.hash_multiset.hash_multiset
  - hash_multiset.hash_multiset
  - hash_multiset::hash_multiset
  - hash_multiset
  - stdext::hash_multiset::hash_multiset
  - stdext.hash_multiset.hash_multiset
  - std::hash_multiset::hash_multiset
dev_langs: 
  - C++
helpviewer_keywords: 
  - hash_multiset class, constructor
  - hash_multiset method
ms.assetid: 24af1025-04a5-4e44-a384-67c23114022c
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::hash_multiset
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Constructs a `hash_multiset` that is empty or that is a copy of all or part of some other `hash_multiset`.  
  
## Syntax  
  
```  
hash_multiset( );  
explicit hash_multiset(  
    const Traits& Comp  
);  
hash_multiset(  
    const Traits& Comp,  
    const Allocator& Al  
);  
hash_multiset(  
    const hash_multiset<Key, Traits, Allocator>& Right  
);  
hash_multiset(  
    hash_multiset&& Right  
};  
hash_multiset (    initializer_list<Type> IList  
);  
hash_multiset(  
     initializer_list<Tu[e> IList,    const Compare& Comp  
):  
hash_multiset(  
    initializer_list<Type> IList,    const Compare& Comp,    const Allocator& Al  
);  
template<class InputIterator>  
    hash_multiset(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    hash_multiset(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp  
    );  
template<class InputIterator>  
    hash_multiset(  
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
|`Al`|The storage allocator class to be used for this `hash_multiset` object, which defaults to `Allocator`.|  
|`Comp`|The comparison function of type `const Traits` used to order the elements in the `hash_multiset`, which defaults to `hash_compare`.|  
|`Right`|The `hash_multiset` of which the constructed `hash_multiset` is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list that contains the elements to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the `hash_multiset` and that can later be returned by calling [hash_multiset::get_allocator](../vs140/hash_multiset--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_multisets.  
  
 All constructors store a function object of type `Traits` that is used to establish an order among the keys of the `hash_multiset` and that can later be returned by calling [hash_multiset::key_comp](../vs140/hash_multiset--key_comp.md). For more information on `Traits` see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 The first three constructors specify an empty initial `hash_multiset`, the second specifying the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (`Al`) to be used. The keyword `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor moves the `hash_multiset``Right`.  
  
 The fifth, sixth, and seventh constructors use an initializer_list.  
  
 The last three constructors copy the range [`First`,`Last`) of a `hash_multiset` with increasing explicitness in specifying the type of comparison function of class Compare and allocator.  
  
 The actual order of elements in a hashed set container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)