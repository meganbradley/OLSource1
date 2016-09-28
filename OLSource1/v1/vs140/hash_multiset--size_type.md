---
title: "hash_multiset::size_type"
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
  - "stdext::hash_multiset::size_type"
  - "hash_set/stdext::hash_multiset::size_type"
  - "std::hash_multiset::size_type"
  - "hash_multiset::size_type"
  - "hash_multiset.size_type"
  - "size_type"
  - "stdext.hash_multiset.size_type"
  - "std.hash_multiset.size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
ms.assetid: 07e18cd7-da92-4834-be96-96947b75bf6d
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::size_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 An unsigned integer type that can represent the number of elements in a hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::size_type size_type;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [size](../vs140/hash_multiset--size.md) for an example of how to declare and use `size_type`  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)