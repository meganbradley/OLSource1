---
title: "weak_ptr::reset"
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
  - "std.tr1.weak_ptr.reset"
  - "std::tr1::weak_ptr::reset"
  - "memory/std::tr1::weak_ptr::reset"
  - "reset"
  - "weak_ptr::reset"
  - "tr1.weak_ptr.reset"
  - "weak_ptr.reset"
  - "tr1::weak_ptr::reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method [TR1]"
  - "reset method"
ms.assetid: c6eac0ce-b5c3-41f4-a19f-c75a3f3f55d7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::reset
Releases owned resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function releases the resource pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and converts <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to an empty weak_ptr object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*wp.lock() == 5**  
**wp.expired() == false**  
**wp.expired() == true**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::operator=](../vs140/weak_ptr--operator=.md)