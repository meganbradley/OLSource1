---
title: "hash_multimap::iterator"
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
  - "std::hash_multimap::iterator"
  - "hash_multimap.iterator"
  - "stdext::hash_multimap::iterator"
  - "iterator"
  - "hash_map/stdext::hash_multimap::iterator"
  - "stdext.hash_multimap.iterator"
  - "hash_multimap::iterator"
  - "std.hash_multimap.iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator method"
  - "iterator typedef"
ms.assetid: 256c2bb9-03f8-43fa-922c-4080336f2f75
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_multimap.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::iterator iterator;  
```  
  
## Remarks  
 The **iterator** defined by hash_multimap points to objects of [value_type](../vs140/hash_multimap--value_type.md), which are of type `pair`<**const Key, Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference an **iterator** `Iter` pointing to an element in a hash_multimap, use the **->** operator.  
  
 To access the value of the key for the element, use `Iter` -> **first**, which is equivalent to (\*`Iter`).**first**. To access the value of the mapped datum for the element, use `Iter` -> **second**, which is equivalent to (\*`Iter`).**first**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [begin](../vs140/hash_multimap--begin.md) for an example of how to declare and use **iterator**.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)