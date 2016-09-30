---
title: "shared_ptr::operator boolean-type"
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
  - "memory/std::tr1::shared_ptr::operator boolean_type"
  - "shared_ptr::operator boolean-type"
  - "operator boolean-type"
  - "std::tr1::shared_ptr::operator boolean-type"
  - "shared_ptr.operator boolean-type"
  - "std.tr1.shared_ptr.operator boolean-type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator boolean-type operator [TR1]"
ms.assetid: d206b994-37bd-4e10-a7ee-7019340cfe8a
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator boolean-type
Tests if an owned resource exists.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The operator returns a value of a type that is convertible to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The result of the conversion to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **(bool)sp0 == false**  
**(bool)sp1 == true**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::get](../vs140/shared_ptr--get.md)