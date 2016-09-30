---
title: "allocator::construct"
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
  - "allocator::construct"
  - "memory/std::allocator::construct"
  - "allocator.construct"
  - "std.allocator.construct"
  - "std::allocator::construct"
  - "Construct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "construct method"
ms.assetid: 4155f804-02b8-44c0-b5ee-e31287e2c328
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# allocator::construct
Constructs a specific type of object at a specified address that is initialized with a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value with which the object being constructed is to be initialized.  
  
## Remarks  
 The first member function is equivalent to **new** ( (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> \*) <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ) **Type** ( <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> ).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 3 6 9 12 15 18 21 ).**  
**The modified vector v1 is:**  
 **( 3 7 9 12 15 18 21 ).**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Lvalue Reference Declarator: &](../vs140/lvalue-reference-declarator---.md)   
 [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md)