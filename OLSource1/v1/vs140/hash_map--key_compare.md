---
title: "hash_map::key_compare"
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
  - "hash_map.key_compare"
  - "stdext.hash_map.key_compare"
  - "stdext::hash_map::key_compare"
  - "hash_map::key_compare"
  - "std.hash_map.key_compare"
  - "std::hash_map::key_compare"
  - "hash_map/stdext::hash_map::key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare method"
  - "key_compare typedef"
ms.assetid: e4833039-0b7f-44f2-a086-81486d4dcc30
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::key_compare
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the map.  
  
## Syntax  
  
```  
typedef Traits key_compare;  
```  
  
## Remarks  
 `key_compare` is a synonym for the template parameter `Traits`.  
  
 For more information on `Traits` see the [hash_map Class](../vs140/hash_map-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [key_comp](../vs140/hash_map--key_comp.md) for an example of how to declare and use `key_compare`.  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)