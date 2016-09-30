---
title: "Explicit Specialization of Class Templates"
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
  - "explicit specialization of class templates"
ms.assetid: 7ad67abd-5cb5-4d36-a3df-31a71ca9c49b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Specialization of Class Templates
Class templates can be *specialized*. This means that you define a separate template to handle specific types or values that require special handling or can be optimized. When a user instantiates the template with a type for which it is specialized, the compiler will choose the specialization to generate the class. A specialization has the same name as the original template, but it can have different data members and member functions.  
  
 You can define a *partial specialization* when a template has more than one template argument and you only need to specialize one of them, or when you want to specialize behavior for an entire set of types, such as all pointer types, reference types, or array types. For more information, see [Partial Specialization of Class Templates](../vs140/partial-specialization-of-class-templates-in-visual-c---.net-2003.md).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **157**  
**Char value: s**   
## See Also  
 [Class Template Instantiation](../vs140/class-template-instantiation.md)   
 [Template Specialization](../vs140/template-specialization--c---.md)