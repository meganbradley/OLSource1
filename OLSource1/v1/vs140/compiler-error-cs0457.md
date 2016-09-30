---
title: "Compiler Error CS0457"
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
  - "CS0457"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0457"
ms.assetid: 5d5cf762-c817-4468-9455-59e966b8c140
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0457
Ambiguous user defined conversions 'Conversion method name 1' and 'Conversion method name 2' when converting from 'type name 1' to 'type name 2'  
  
 Two conversion methods are applicable, and the compiler is unable to decide which one to use.  
  
 One scenario that can cause this error is as follows:  
  
-   You want to convert class A to class B where A and B are unrelated.  
  
-   A is derived from A0, and there is a method that converts from A0 to B.  
  
-   B has a subclass B1 and there is a method that converts from A to B1.  
  
 The compiler will weight the two conversion methods equally, because the first conversion provides the best destination type, and the second conversion provides the best source type. Since the compiler will be unable to choose, this error will be generated. To resolve, write a new explicit method converting A to B.  
  
 Another scenario that causes this error is if there are two methods that convert A to B. To fix, specify which conversion to use through an explicit cast.  
  
## Example  
 The following sample generates CS0457.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>