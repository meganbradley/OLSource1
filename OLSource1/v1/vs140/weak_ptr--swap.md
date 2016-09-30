---
title: "weak_ptr::swap"
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
  - "std.tr1.weak_ptr.swap"
  - "memory/std::tr1::weak_ptr::swap"
  - "std::tr1::weak_ptr::swap"
  - "weak_ptr.swap"
  - "swap"
  - "tr1.weak_ptr.swap"
  - "tr1::weak_ptr::swap"
  - "weak_ptr::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: c7fe1ff8-aec0-4c70-abdd-0dba6ccf8d57
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::swap
Swaps two <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The weak pointer to swap with.  
  
## Remarks  
 The member function leaves the resource originally pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> subsequently pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the resource originally pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> subsequently pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The function does not change the reference counts for the two resources and it does not throw any exceptions.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)   
 [weak_ptr::operator=](../vs140/weak_ptr--operator=.md)