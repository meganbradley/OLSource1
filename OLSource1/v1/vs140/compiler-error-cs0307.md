---
title: "Compiler Error CS0307"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0307"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0307"
ms.assetid: 202a9985-ed7a-4e0a-9573-5624e066d314
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0307
The 'construct' 'identifier' is not a generic method. If you intended an expression list, use parentheses around the < expression.  
  
 The construct named was not a type or a method, the only constructs that can take generic arguments. Remove the type arguments in angle brackets. If a generic is needed, declare your generic construct as a generic type or method.  
  
 The following sample generates CS0307:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>