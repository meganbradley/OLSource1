---
title: "shared_ptr::shared_ptr"
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
  - "shared_ptr"
  - "memory/std::tr1::shared_ptr::shared_ptr"
  - "tr1::shared_ptr::shared_ptr"
  - "shared_ptr::shared_ptr"
  - "shared_ptr.shared_ptr"
  - "tr1.shared_ptr.shared_ptr"
  - "std.tr1.shared_ptr.shared_ptr"
  - "std::tr1::shared_ptr::shared_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared_ptr method"
  - "shared_ptr constructor [TR1]"
ms.assetid: 054bdc0c-b055-42e4-b0e2-dcb097bf83cf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::shared_ptr
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type controlled by the argument pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The pointer to copy.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the allocator.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The deleter.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The allocator.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The smart pointer to copy.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The weak pointer.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The auto pointer to copy.  
  
## Remarks  
 The constructors each construct an object that owns the resource named by the operand sequence. The constructor <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> throws an exception object of type [bad_weak_ptr](../vs140/bad_weak_ptr-class.md) if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **(bool)sp0 == false**  
**\*sp1 == 5**  
**\*sp2 == 10**  
**\*sp3 == 10**  
**\*sp4 == 10**  
**\*sp5 == 15**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)