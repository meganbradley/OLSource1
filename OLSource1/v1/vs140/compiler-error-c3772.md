---
title: "Compiler Error C3772"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3772"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3772"
ms.assetid: 63e938d4-088d-41cc-a562-5881a05b5710
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3772
"name" : invalid friend template declaration  
  
 It is invalid to declare a friend of a class template specialization. You cannot declare an explicit or partial specialization of a class template and in the same statement declare a friend of that specialization. The *name* placeholder identifies the invalid declaration.  
  
### To correct this error  
  
-   Do not declare a friend of a class template specialization.  
  
-   If appropriate for your application, declare a friend of the class template, or declare a friend of a particular partial or explicit specialization.  
  
## Example  
 The following code example fails because it declares a friend of a partial specialization of a class template.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Template Specifications](../vs140/template-specifications.md)   
 [Partial Specialization of Class Templates (C++)](../vs140/template-specialization--c---.md)   
 [Explicit Specialization of Class Templates](../vs140/explicit-specialization-of-class-templates.md)