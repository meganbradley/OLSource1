---
title: "shared_ptr::operator-&gt;"
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
  - "shared_ptr.operator->"
  - "memory/std::tr1::shared_ptr::operator->"
  - "std::tr1::shared_ptr::operator->"
  - "tr1::shared_ptr::operator->"
  - "operator->"
  - "shared_ptr::operator->"
  - "tr1.shared_ptr.operator->"
  - "std.tr1.shared_ptr.operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-> operator [TR1]"
  - "operator->"
ms.assetid: 1fbefacf-ad63-4c2e-887a-8218023a6a36
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::operator-&gt;
Gets a pointer to the designated value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The selection operator returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, so that the expression <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> behaves the same as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an object of class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Hence, the stored pointer must not be null, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be a class, structure, or union type with a member <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sp0->first == 1**  
**sp0->second == 2**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [shared_ptr::get](../vs140/shared_ptr--get.md)   
 [shared_ptr::operator*](../vs140/shared_ptr--operator-.md)