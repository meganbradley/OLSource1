---
title: "shared_ptr::operator*"
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
  - "shared_ptr::operator*"
  - "tr1::shared_ptr::operator*"
  - "std.tr1.shared_ptr.operator*"
  - "operator*"
  - "shared_ptr.operator*"
  - "tr1.shared_ptr.operator*"
  - "std::tr1::shared_ptr::operator*"
  - "memory/std::tr1::shared_ptr::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator*"
  - "operator* operator [TR1]"
ms.assetid: 4fa7630c-b036-4a46-bd0f-d661b90cd97e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator*
Gets the designated value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The indirection operator returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Hence, the stored pointer must not be null.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp0 == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::get](../vs140/shared_ptr--get.md)