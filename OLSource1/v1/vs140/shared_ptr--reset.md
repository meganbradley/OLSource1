---
title: "shared_ptr::reset"
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
  - "shared_ptr.reset"
  - "tr1::shared_ptr::reset"
  - "shared_ptr::reset"
  - "memory/std::tr1::shared_ptr::reset"
  - "std.tr1.shared_ptr.reset"
  - "reset"
  - "tr1.shared_ptr.reset"
  - "std::tr1::shared_ptr::reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method [TR1]"
  - "reset method"
ms.assetid: b1bc65d6-d613-495b-b46e-da59164afc56
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::reset
Replace owned resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type controlled by the argument pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The pointer to copy.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The deleter to copy.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the allocator.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The allocator to copy.  
  
## Remarks  
 The operators all decrement the reference count for the resource currently owned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released. If an operator fails it leaves <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> unchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp == 5**  
**(bool)sp == false**  
**\*sp == 10**  
**\*sp == 15**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator=](../vs140/shared_ptr--operator=.md)