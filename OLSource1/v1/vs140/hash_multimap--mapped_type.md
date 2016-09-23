---
title: "hash_multimap::mapped_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.hash_multimap.mapped_type
  - hash_map/stdext::hash_multimap::mapped_type
  - mapped_type
  - hash_multimap.mapped_type
  - stdext::hash_multimap::mapped_type
  - std::hash_multimap::mapped_type
  - stdext.hash_multimap.mapped_type
  - hash_multimap::mapped_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - mapped_type typedef
ms.assetid: bceff540-fb18-4587-ad07-de5938cfaf93
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multimap::mapped_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the data type stored in a hash_multimap.  
  
## Syntax  
  
```  
typedef Type mapped_type;  
```  
  
## Remarks  
 `mapped_type` is a synonym for the template parameter `Type`.  
  
 For more information on `Type` see the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [value_type](../vs140/hash_multimap--value_type.md) for an example of how to declare and use `key_type`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)