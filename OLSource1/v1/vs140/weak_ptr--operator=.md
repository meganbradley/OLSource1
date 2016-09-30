---
title: "weak_ptr::operator="
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
  - "operator="
  - "tr1.weak_ptr.operator="
  - "std::tr1::weak_ptr::operator="
  - "std.tr1.weak_ptr.operator="
  - "memory/std::tr1::weak_ptr::operator="
  - "weak_ptr::operator="
  - "weak_ptr.operator="
  - "tr1::weak_ptr::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 1ffb152e-0f54-4376-9ed3-10cf7588a036
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::operator=
Replaces owned resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type controlled by the argument shared/weak pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The weak pointer to copy.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
## Remarks  
 The operators all release the resource currently pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and assign ownership of the resource named by the operand sequence to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If an operator fails it leaves <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> unchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*wp0.lock() == 5**  
**\*wp0.lock() == 10**  
**\*wp1.lock() == 10**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::reset](../vs140/weak_ptr--reset.md)