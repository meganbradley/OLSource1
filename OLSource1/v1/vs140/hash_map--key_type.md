---
title: "hash_map::key_type"
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
  - "stdext.hash_map.key_type"
  - "hash_map.key_type"
  - "std::hash_map::key_type"
  - "hash_map::key_type"
  - "key_type"
  - "std.hash_map.key_type"
  - "hash_map/stdext::hash_map::key_type"
  - "stdext::hash_map::key_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_type typedef"
ms.assetid: 19cb118d-9375-4353-8ce5-0332a1a7a108
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::key_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type describes the sort key object that constitutes each element of the hash_map.  
  
## Syntax  
  
```  
typedef Key key_type;  
```  
  
## Remarks  
 `key_type` is a synonym for the template parameter `Key`.  
  
 For more information on `Key`, see the Remarks section of the [hash_map Class](../vs140/hash_map-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [value_type](../vs140/hash_map--value_type.md) for an example of how to declare and use `key_type`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)