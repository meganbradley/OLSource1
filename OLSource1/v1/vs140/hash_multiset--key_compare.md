---
title: "hash_multiset::key_compare"
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
  - "key_compare"
  - "std.hash_multiset.key_compare"
  - "hash_multiset::key_compare"
  - "stdext.hash_multiset.key_compare"
  - "std::hash_multiset::key_compare"
  - "hash_multiset.key_compare"
  - "hash_set/stdext::hash_multiset::key_compare"
  - "stdext::hash_multiset::key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare method"
  - "key_compare typedef"
ms.assetid: 55e9ab92-cb95-4360-ad3f-1efd46ba542d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::key_compare
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides two function objects, a binary predicate of class compare that can compare two element values of a hash_multiset to determine their relative order and a unary predicate that hashes the elements.  
  
## Syntax  
  
```  
typedef Traits key_compare;  
```  
  
## Remarks  
 **key_compare** is a synonym for the template parameter `Traits`.  
  
 For more information on `Traits` see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 Note that both `key_compare` and [value_compare](../vs140/hash_set--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [key_comp](../vs140/hash_multiset--key_comp.md) for an example of how to declare and use `key_compare`.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)