---
title: "list::const_pointer"
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
  - "list::const_pointer"
  - "std::list::const_pointer"
  - "list/std::list::const_pointer"
  - "const_pointer"
  - "list.const_pointer"
  - "std.list.const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: e3bea75d-ca75-476f-83e4-a91b17785fd5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::const_pointer
Provides a pointer to a `const` element in a list.  
  
## Syntax  
  
```unstlib  
  
typedef typename Allocator::const  
_  
pointer const  
_  
pointer;  
  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](../vs140/list--iterator.md) should be used to access the elements in a list object.  
  
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)