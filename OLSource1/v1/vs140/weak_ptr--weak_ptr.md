---
title: "weak_ptr::weak_ptr"
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
  - "weak_ptr"
  - "std::tr1::weak_ptr::weak_ptr"
  - "weak_ptr::weak_ptr"
  - "weak_ptr.weak_ptr"
  - "memory/std::tr1::weak_ptr::weak_ptr"
  - "std.tr1.weak_ptr.weak_ptr"
  - "tr1.weak_ptr.weak_ptr"
  - "tr1::weak_ptr::weak_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "weak_ptr constructor [TR1]"
  - "weak_ptr method"
ms.assetid: 6306b77d-2ae4-4201-b21b-9efef89e828d
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::weak_ptr
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type controlled by the argument shared/weak pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The weak pointer to copy.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The shared pointer to copy.  
  
## Remarks  
 The constructors each construct an object that points to the resource named by the operand sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **wp0.expired() == true**  
**\*wp1.lock() == 5**  
**\*wp2.lock() == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)