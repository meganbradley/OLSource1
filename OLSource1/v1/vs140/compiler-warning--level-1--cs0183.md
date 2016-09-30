---
title: "Compiler Warning (level 1) CS0183"
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
  - "CS0183"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0183"
ms.assetid: c8b8eb23-edae-46da-b3ae-2a00f86e56bc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0183
The given expression is always of the provided ('type') type  
  
 If a conditional statement always evaluates to **true**, then you do not need a conditional statement. This warning occurs when you try to evaluate a type using the **is** operator. If the evaluation is a value type, then the check is unnecessary.  
  
 The following sample generates CS0183:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>