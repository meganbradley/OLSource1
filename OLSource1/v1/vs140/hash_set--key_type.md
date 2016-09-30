---
title: "hash_set::key_type"
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
  - "stdext::hash_set::key_type"
  - "hash_set::key_type"
  - "stdext.hash_set.key_type"
  - "std::hash_set::key_type"
  - "std.hash_set.key_type"
  - "hash_set/stdext::hash_set::key_type"
  - "hash_set.key_type"
  - "key_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_type typedef"
ms.assetid: d5e87f7f-ebc4-447d-bbcb-7ff70c377008
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::key_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that describes an object stored as an element of a hash_set in its capacity as sort key.  
  
## Syntax  
  
```  
typedef Key key_type;  
```  
  
## Remarks  
 **key_type** is a synonym for the template parameter `Key`.  
  
 For more information on `Key`, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both `key_type` and [value_type](../vs140/hash_set--value_type.md) are synonyms for the template parameter **Key**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [value_type](../vs140/hash_set--value_type.md) for an example of how to declare and use `key_type`.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)