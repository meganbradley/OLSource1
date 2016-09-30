---
title: "shared_ptr::operator="
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
  - "memory/std::tr1::shared_ptr::operator="
  - "operator="
  - "shared_ptr.operator="
  - "shared_ptr::operator="
  - "tr1::shared_ptr::operator="
  - "std::tr1::shared_ptr::operator="
  - "tr1.shared_ptr.operator="
  - "std.tr1.shared_ptr.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 99be34c1-2c13-4119-964d-ce0a7e341337
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator=
Replaces the owned resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The auto pointer to copy.  
  
## Remarks  
 The operators all decrement the reference count for the resource currently owned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the reference count falls to zero, the resource is released. If an operator fails it leaves <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> unchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp0 == 5**  
**\*sp0 == 10**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::reset](../vs140/shared_ptr--reset.md)