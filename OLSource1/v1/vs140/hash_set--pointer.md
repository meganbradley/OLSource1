---
title: "hash_set::pointer"
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
  - stdext::hash_set::pointer
  - std::hash_set::pointer
  - hash_set::pointer
  - std.hash_set.pointer
  - pointer
  - stdext.hash_set.pointer
  - hash_set/stdext::hash_set::pointer
  - hash_set.pointer
dev_langs: 
  - C++
helpviewer_keywords: 
  - pointer method
  - pointer typedef
ms.assetid: 2c5254e9-1e3c-4f74-a255-08603fd41ed9
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::pointer
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a pointer to an element in a hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::pointer pointer;  
```  
  
## Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/hash_set--iterator.md) should be used to access the elements in a hash_set object.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)