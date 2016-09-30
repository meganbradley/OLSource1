---
title: "Nested Class Templates"
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
  - "class templates, nested"
  - "nested class templates"
ms.assetid: b3b53e03-950d-4699-b07b-41219dbc2d9f
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nested Class Templates
Templates can be defined within classes or class templates, in which case they are referred to as member templates. Member templates that are classes are referred to as nested class templates. Member templates that are functions are discussed in [Member Function Templates](../vs140/member-function-templates.md).  
  
 Nested class templates are declared as class templates inside the scope of the outer class. They can be defined inside or outside of the enclosing class.  
  
## Example  
 The following code demonstrates a nested class template inside an ordinary class.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 When nested class templates are defined outside of their enclosing class, they must be prefaced by the template parameters for both the class template (if they are members of a class template) and template parameters for the member template.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Local classes are not allowed to have member templates.  
  
## See Also  
 [Class Templates](../vs140/class-templates.md)   
 [Member Function Templates](../vs140/member-function-templates.md)