---
title: "allocator::reference"
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
  - "Reference"
  - "memory/std::allocator::reference"
  - "std.allocator.reference"
  - "std::allocator::reference"
  - "allocator.reference"
  - "allocator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
ms.assetid: 4c4afb05-5232-44a4-abc2-031d942d6cad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::reference
A type that provides a reference to the type of object managed by the allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The reference type describes an object that can designate any object that an object of template class allocator can allocate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The element referred to by vref after being modified is: 150.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)