---
title: "allocator::const_reference"
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
  - "allocator.const_reference"
  - "const_reference"
  - "std.allocator.const_reference"
  - "memory/std::allocator::const_reference"
  - "std::allocator::const_reference"
  - "allocator::const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
ms.assetid: 03a87636-c4dd-4b56-baec-dc7fc0c359a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::const_reference
A type that provides a constant reference to type of object managed by the allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The reference type describes an object that can designate any const object that an object of template class allocator can allocate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The value of the element referred to by vcref,**  
 **after nofication through its nonconst iterator, is: 175.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)