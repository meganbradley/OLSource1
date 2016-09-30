---
title: "Member Functions of Template Classes"
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
  - "member function templates"
  - "templates, member function"
ms.assetid: 296430a6-c6a5-4c83-8569-4d85433eb8a1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Member Functions of Template Classes
Member functions can be defined inside or outside of a class template. They are defined like function templates if defined outside the class template.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that just as with any template class member function, the definition of the class's constructor member function includes the template argument list twice.  
  
## Example  
 Member functions can themselves be function templates, specifying additional parameters, as in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Class Templates](../vs140/class-templates.md)