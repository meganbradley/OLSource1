---
title: "allocator::const_pointer"
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
  - "allocator.const_pointer"
  - "std.allocator.const_pointer"
  - "std::allocator::const_pointer"
  - "const_pointer"
  - "allocator::const_pointer"
  - "memory/std::allocator::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer method"
ms.assetid: d8e0320a-ba57-4261-8413-0a78bf09792a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::const_pointer
A type that provides a constant pointer to the type of object managed by the allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any const object that an object of template class allocator can allocate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer's address found has a value of: 10.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)