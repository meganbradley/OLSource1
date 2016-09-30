---
title: "allocator::address"
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
  - "memory/std::allocator::address"
  - "allocator::address"
  - "allocator.address"
  - "std.allocator.address"
  - "address"
  - "std::allocator::address"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "address function"
ms.assetid: 5e80e4b8-9eef-4566-b774-5ac107126419
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::address
Finds the address of an object whose value is specified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The const or nonconst value of the object whose address is being searched for.  
  
## Return Value  
 A const or nonconst pointer to the object found of, respectively, const or nonconst value.  
  
## Remarks  
 The member functions return the address of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, in the form that pointers must take for allocated elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 8.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)