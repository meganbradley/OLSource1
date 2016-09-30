---
title: "weak_ptr::lock"
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
  - "tr1.weak_ptr.lock"
  - "weak_ptr.lock"
  - "std.tr1.weak_ptr.lock"
  - "tr1::weak_ptr::lock"
  - "memory/std::tr1::weak_ptr::lock"
  - "lock"
  - "std::tr1::weak_ptr::lock"
  - "weak_ptr::lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock method [TR1]"
  - "lock method"
ms.assetid: e60c5e09-2160-4f4a-8ace-66e1b987c68a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# weak_ptr::lock
Obtains exclusive ownership of a resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns an empty shared_ptr object if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has expired; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that owns the resource that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> points to.  
  
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