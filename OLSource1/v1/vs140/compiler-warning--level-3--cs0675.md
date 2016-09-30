---
title: "Compiler Warning (level 3) CS0675"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0675"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0675"
ms.assetid: 7465dd8d-2543-44f6-b76b-fcae0ef2580d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS0675
Bitwise-or operator used on a sign-extended operand; consider casting to a smaller unsigned type first  
  
 The compiler implicitly widened and sign-extended a variable, and then used the resulting value in a bitwise OR operation. This can result in unexpected behavior.  
  
 The following sample generates CS0675:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>