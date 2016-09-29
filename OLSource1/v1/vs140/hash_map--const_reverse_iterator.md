---
title: "hash_map::const_reverse_iterator"
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
  - "stdext.hash_map.const_reverse_iterator"
  - "hash_map.const_reverse_iterator"
  - "stdext::hash_map::const_reverse_iterator"
  - "std::hash_map::const_reverse_iterator"
  - "std.hash_map.const_reverse_iterator"
  - "hash_map::const_reverse_iterator"
  - "const_reverse_iterator"
  - "hash_map/stdext::hash_map::const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator method"
  - "const_reverse_iterator typedef"
ms.assetid: 92cb79cc-3501-4afb-8174-8deeb83ab0ac
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::const_reverse_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_map.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::const_reverse)iterator const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is use to iterate through the hash_map in reverse.  
  
 The `const_reverse_iterator` defined by hash_map points to elements that are objects of [value_type](../vs140/hash_map--value_type.md), that is of type `pair`<**const Key, Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a `const_reverse_iterator` `crIter` pointing to an element in a hash_map, use the **->** operator.  
  
 To access the value of the key for the element, use `crIter` -> **first**, which is equivalent to (\*`crIter`)**.first**. To access the value of the mapped datum for the element, use `crIter` -> **second**, which is equivalent to (\*`crIter`).**first**.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [rend](../vs140/hash_map--rend.md) for an example of how to declare and use the `const_reverse_iterator`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)