---
title: "allocator::pointer"
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
  - "allocator.pointer"
  - "std.allocator.pointer"
  - "allocator::pointer"
  - "memory/std::allocator::pointer"
  - "pointer"
  - "std::allocator::pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
ms.assetid: 70b8aca0-8eaa-4381-86fb-c8a9091a292a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::pointer
A type that provides a pointer to the type of object managed by the allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any object that an object of template class allocator can allocate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 3 6 9 12 15 18 21 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 12.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)