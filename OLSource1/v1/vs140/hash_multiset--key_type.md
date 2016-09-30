---
title: "hash_multiset::key_type"
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
  - "stdext.hash_multiset.key_type"
  - "std::hash_multiset::key_type"
  - "hash_set/stdext::hash_multiset::key_type"
  - "hash_multiset.key_type"
  - "key_type"
  - "std.hash_multiset.key_type"
  - "hash_multiset::key_type"
  - "stdext::hash_multiset::key_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_type typedef"
ms.assetid: b77fc4c4-6ae3-4507-ad09-d5a98ee106e3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::key_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a function object that can compare sort keys to determine the relative order of two elements in the hash_multiset.  
  
## Syntax  
  
```  
typedef Key key_type;  
```  
  
## Remarks  
 **key_type** is a synonym for the template parameter `Key`.  
  
 Note that both `key_type` and [value_type](../vs140/hash_set--value_type.md) are synonyms for the template parameter **Key**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
 For more information on `Key`, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [value_type](../vs140/hash_multiset--value_type.md) for an example of how to declare and use `key_type`.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)