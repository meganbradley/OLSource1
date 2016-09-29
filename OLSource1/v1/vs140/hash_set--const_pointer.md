---
title: "hash_set::const_pointer"
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
  - "hash_set.const_pointer"
  - "hash_set/stdext::hash_set::const_pointer"
  - "std.hash_set.const_pointer"
  - "stdext::hash_set::const_pointer"
  - "stdext.hash_set.const_pointer"
  - "const_pointer"
  - "hash_set::const_pointer"
  - "std::hash_set::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: 2ae02ccb-b6f0-4824-b37a-b7d113448bc0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::const_pointer
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::const_pointer const_pointer;  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, a [const_iterator](../vs140/hash_set--const_iterator.md) should be used to access the elements in a **const** hash_set object.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)