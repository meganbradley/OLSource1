---
title: "Compiler Error C2228"
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
  - "C2228"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2228"
ms.assetid: 901cadb1-ce90-4ae0-a360-547a9ba2ca18
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2228
left of '.identifier' must have class/struct/union  
  
 The operand to the left of the period (.) is not a class, structure, or union.  
  
 The following sample generates C2228:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You will also see this error if you use incorrect syntax when using Managed Extensions. Whereas in other Visual Studio languages, you can use the dot operator to access a member of a managed class, a pointer to the object in C++ means you have to use the -> operator to access the member:  
  
 Wrong: <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 Right: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>