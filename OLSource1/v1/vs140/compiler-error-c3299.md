---
title: "Compiler Error C3299"
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
  - "C3299"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3299"
ms.assetid: 7cabdf01-bceb-404f-9401-cdd9c7fc1641
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3299
'member_function' : cannot specify constraints, they are inherited from the base method  
  
 When overriding a generic member function, you cannot specify constraint clauses (repeating the constraints implies that the constraints are not inherited).  
  
 The constraint clauses on the generic function you are overriding will be inherited.  
  
 For more information, see [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md).  
  
## Example  
 The following sample generates C3299.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>