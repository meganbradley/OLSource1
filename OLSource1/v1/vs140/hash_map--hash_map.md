---
title: "hash_map::hash_map"
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
  - "stdext.hash_map.hash_map"
  - "hash_map/stdext::hash_map::hash_map"
  - "hash_map::hash_map"
  - "std::hash_map::hash_map"
  - "hash_map.hash_map"
  - "std.hash_map.hash_map"
  - "stdext::hash_map::hash_map"
  - "hash_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_map class, constructor"
  - "hash_map method"
ms.assetid: c11d6729-c571-43a1-96fd-360ec678b23a
caps.latest.revision: 30
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::hash_map
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Constructs a hash_map that is empty or is a copy of all or part of some other hash_map.  
  
## Syntax  
  
```  
hash_map( );  
explicit hash_map(  
    const Traits& Comp  
);  
hash_map(  
    const Traits& Comp,  
    const Allocator& Al  
);  
hash_map(  
    const hash_map& Right  
);  
hash_map(  
    hash_map&& Right  
);  
hash_map(  
     initializer_list<Type> IList  
);hash_map(     initializer_list<Type> IList,  
     const key_compare& Comp  
);  
hash_map(  
     initializer_list<Type> IList,  
     const key_compare& Comp,   
     const allocator_type& Al  
);  
template<class InputIterator>  
   hash_map(  
      InputIterator First,  
      InputIterator Last  
   );  
template<class InputIterator>  
   hash_map(  
      InputIterator First,  
      InputIterator Last,  
      const Traits& Comp  
   );  
template<class InputIterator>  
   hash_map(  
      InputIterator First,  
      InputIterator Last,  
      const Traits& Comp,  
      const Allocator& Al  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this hash_map object, which defaults to **Allocator**.|  
|`Comp`|The comparison function of type const `Traits` used to order the elements in the hash_map, which defaults to `hash_compare`.|  
|`Right`|The hash_map of which the constructed map is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the hash_map and can later be returned by calling [get_allocator](../vs140/hash_map--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_map.  
  
 All constructors store a function object of type `Traits` that is used to establish an order among the keys of the hash_map and that can later be returned by calling [key_comp](../vs140/hash_map--key_comp.md).  
  
 The first three constructors specify an empty initial hash_map, in addition, the second specifies the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifies the allocator type (`Al`) to be used. The keyword `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the hash_map `Right`.  
  
 The next three constructors copy the range `[First, Last)` of a hash_map with increasing explicitness in specifying the type of comparison function of class `Traits` and allocator.  
  
 The last constructor moves the hash_map `Right`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)