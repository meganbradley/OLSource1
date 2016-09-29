---
title: "hash_multimap::size_type"
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
  - "hash_map/stdext::hash_multimap::size_type"
  - "stdext.hash_multimap.size_type"
  - "hash_multimap::size_type"
  - "std::hash_multimap::size_type"
  - "size_type"
  - "std.hash_multimap.size_type"
  - "hash_multimap.size_type"
  - "stdext::hash_multimap::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
ms.assetid: 4e185c62-52fd-4f48-bbae-e2ffb3afcb43
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::size_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 An unsigned integer type that counts the number of elements in a hash_multimap.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::size_type size_type;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [size](../vs140/hash_multimap--size.md) for an example of how to declare and use `size_type`  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)