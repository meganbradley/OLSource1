---
title: "Members of Class Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Visual C++, methods"
  - "members, class template"
  - "member functions, class templates"
  - "class members, class template"
ms.assetid: 8cc44cf3-263e-47b9-8d28-6d083b3eaf80
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Members of Class Templates
Members of class templates are just like members of any class. They can be static or nonstatic, data or function members, or even other templates. They can be defined either inside the template class or outside of it. The members of a template class can refer to the unknown types specified in the template argument list as if they were valid type names, and they can refer to the unknown object values specified in the template argument list as if they were constant expressions.  
  
 When members of templated classes are defined outside of the class declaration, they must be declared differently than those of nontemplated classes. The declaration must be preceded by syntax specifying the template class that the function is a member of.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The declarator for a member function outside the template class must also specify the  template arguments.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 C++ also allows nested templates, referred to as member templates. Member templates can be [nested class templates](../vs140/nested-class-templates.md) or [member function templates](../vs140/member-function-templates.md).  
  
## See Also  
 [Class Templates](../vs140/class-templates.md)