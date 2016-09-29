---
title: "hash_map::const_pointer"
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
  - "stdext.hash_map.const_pointer"
  - "hash_map/stdext::hash_map::const_pointer"
  - "std::hash_map::const_pointer"
  - "hash_map.const_pointer"
  - "stdext::hash_map::const_pointer"
  - "const_pointer"
  - "std.hash_map.const_pointer"
  - "hash_map::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: b80d4955-611e-412c-ac81-2c8190fe9d73
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::const_pointer
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_map.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::const_pointer const_pointer;  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/hash_map--iterator.md) should be used to access the elements in a hash_map object.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)