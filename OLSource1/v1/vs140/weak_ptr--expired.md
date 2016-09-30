---
title: "weak_ptr::expired"
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
  - "tr1.weak_ptr.expired"
  - "std.tr1.weak_ptr.expired"
  - "tr1::weak_ptr::expired"
  - "expired"
  - "weak_ptr::expired"
  - "memory/std::tr1::weak_ptr::expired"
  - "weak_ptr.expired"
  - "std::tr1::weak_ptr::expired"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "expired method"
  - "expired method [TR1]"
ms.assetid: 3db1efb2-2c7f-4845-bca7-e664a36fdc38
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::expired
Tests if ownership has expired.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has expired, otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **wp.expired() == false**  
**\*wp.lock() == 10**  
**wp.expired() == true**  
**(bool)wp.lock() == false**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [weak_ptr](../vs140/weak_ptr-class.md)