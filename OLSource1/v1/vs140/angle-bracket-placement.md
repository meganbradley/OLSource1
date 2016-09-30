---
title: "Angle Bracket Placement"
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
  - "templates, angle bracket placement"
ms.assetid: 7927df35-94e0-4143-b6f1-13fac12b0f58
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Angle Bracket Placement
The first opening bracket after a template name is interpreted as part of the template's argument list, not as a greater-than operator. The first > after the opening angle bracket is interpreted as the end of the template's argument list, unless it is enclosed in parentheses, is part of a nested template, or is part of a template-style cast expression such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Bad placement of angle brackets (<>) causes many template syntax errors. Make sure that you use proper spacing and parentheses to distinguish angle brackets from operators such as **>**, **>>** and **->**. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 should be rewritten as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Similarly, pay extra attention when using macros that use angle brackets as template arguments.  
  
 In Visual Studio 2013 and later (C++11), the compiler can distinguish the difference between the >> operator and adjacent closing angle brackets in a nested template argument. For example, this is now OK:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Templates](../vs140/templates--c---.md)