---
title: "allocator::difference_type"
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
  - "allocator::difference_type"
  - "std.allocator.difference_type"
  - "difference_type"
  - "memory/std::allocator::difference_type"
  - "allocator.difference_type"
  - "std::allocator::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 8f8f2845-4794-459f-be4f-f6adf4eb12eb
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::difference_type
A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in a sequence that an object of template class allocator can allocate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 0 2 4 6 8 10 12 14 ).**  
**Pointer v1PtrA addresses 4.**  
**Pointer v1PtrB addresses 12.**  
**The difference between the integer's addresses is: 8.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)