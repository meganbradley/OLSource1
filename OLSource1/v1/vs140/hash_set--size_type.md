---
title: "hash_set::size_type"
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
  - "std.hash_set.size_type"
  - "stdext.hash_set.size_type"
  - "std::hash_set::size_type"
  - "hash_set.size_type"
  - "hash_set/stdext::hash_set::size_type"
  - "size_type"
  - "stdext::hash_set::size_type"
  - "hash_set::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
ms.assetid: d17d43c9-3730-4ec1-a9fd-cb043e5aab3c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::size_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 An unsigned integer type that can represent the number of elements in a hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::size_type size_type;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [size](../vs140/hash_set--size.md) for an example of how to declare and use `size_type`  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)