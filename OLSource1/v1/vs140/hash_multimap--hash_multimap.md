---
title: "hash_multimap::hash_multimap"
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
  - stdext::hash_multimap::hash_multimap
  - hash_multimap
  - std.hash_multimap.hash_multimap
  - hash_multimap::hash_multimap
  - stdext.hash_multimap.hash_multimap
  - hash_multimap.hash_multimap
  - hash_map/stdext::hash_multimap::hash_multimap
  - std::hash_multimap::hash_multimap
dev_langs: 
  - C++
helpviewer_keywords: 
  - hash_multimap class, constructor
  - hash_multimap method
ms.assetid: e8cab38b-b081-46a0-abcf-1213469fd65b
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multimap::hash_multimap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Constructs a hash_multimap that is empty or is a copy of all or part of some other hash_multimap.  
  
## Syntax  
  
```  
hash_multimap( );  
explicit hash_multimap(  
    const Compare& Comp  
);  
hash_multimap(  
    const Compare& Comp,  
    const Allocator& Al  
);  
hash_multimap(  
    const hash_multimap& Right  
);  
hash_multimap(  
    hash_multimap&& Right  
);  
hash_multimap(  
    initializer_list<Type> IList  
);  
hash_multimap(  
    initializer_list<Type> IList,  
    const Compare& Comp  
);  
  
hash_multimap(  
    initializer_list<Type> IList,  
    const Compare& Comp,  
    const Allocator& Al  
);  
template<class InputIterator>  
    hash_multimap(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    hash_multimap(  
        InputIterator First,  
        InputIterator Last,  
        const Compare& Comp  
    );  
template<class InputIterator>  
    hash_multimap(  
        InputIterator First,  
        InputIterator Last,  
        const Compare& Comp,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this hash_multimap object, which defaults to `Allocator`.|  
|`Comp`|The comparison function of type `const``Traits` used to order the elements in the map, which defaults to `Traits`.|  
|`Right`|The map of which the constructed set is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list to copy from.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the hash_multimap and that can later be returned by calling [get_allocator](../vs140/hash_multimap--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros are used to substitute alternative allocators.  
  
 All constructors initialize their hash_multimap.  
  
 All constructors store a function object of type `Traits` that is used to establish an order among the keys of the hash_multimap and can later be returned by calling [key_comp](../vs140/hash_multimap--key_comp.md).  
  
 The first three constructors specify an empty initial hash_multimap; the second specifies the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifies the allocator type (`_Al`) to be used. The keyword `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the hash_multimap `Right`.  
  
 The next three constructors copy the range `First, Last)` of a map with increasing explicitness in specifying the type of comparison function of class **Traits** and allocator.  
  
 The eighth constructor moves the hash_multimap `Right`.  
  
 The final three constructors use an initializer_list.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [stdext Namespace](../vs140/stdext-namespace.md)   
 [Standard Template Library](../vs140/standard-template-library.md)