---
title: "hash_multimap::pointer"
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
  - "hash_multimap::pointer"
  - "hash_map/stdext::hash_multimap::pointer"
  - "stdext.hash_multimap.pointer"
  - "stdext::hash_multimap::pointer"
  - "pointer"
  - "std::hash_multimap::pointer"
  - "std.hash_multimap.pointer"
  - "hash_multimap.pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
  - "pointer typedef"
ms.assetid: f9f3af04-38a9-4594-a080-a0f11c58f55d
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::pointer
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a pointer to an element in a hash_multimap.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::pointer pointer;  
```  
  
## Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/hash_multimap--iterator.md) should be used to access the elements in a hash_multimap object.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)