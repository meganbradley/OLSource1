---
title: "hash_set::value_compare"
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
  - "stdext.hash_set.value_compare"
  - "hash_set.value_compare"
  - "hash_set::value_compare"
  - "std.hash_set.value_compare"
  - "value_compare"
  - "stdext::hash_set::value_compare"
  - "hash_set/stdext::hash_set::value_compare"
  - "std::hash_set::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare method"
  - "value_compare typedef"
ms.assetid: d4aacedb-c5b0-4e29-b9fa-7b16df6a5eba
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::value_compare
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides two function objects, a binary predicate of class compare that can compare two element values of a hash_set to determine their relative order and a unary predicate that hashes the elements.  
  
## Syntax  
  
```  
typedef key_compare value_compare;  
```  
  
## Remarks  
 **value_compare** is a synonym for the template parameter `Traits`.  
  
 For more information on `Traits` see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both [key_compare](../vs140/hash_set--key_compare.md) and **value_compare** are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [value_comp](../vs140/hash_set--value_comp.md) for an example of how to declare and use `value_compare`.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)