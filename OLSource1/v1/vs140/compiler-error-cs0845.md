---
title: "Compiler Error CS0845"
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
  - "CS0845"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0845"
ms.assetid: ed1d5fd1-d525-416e-91ab-2ce1aff0f83b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0845
An expression tree lambda may not contain a coalescing operator with a null literal left-hand side.  
  
 Because null by itself does not have a type, the null coalescing operator cannot operate on it.  
  
### To correct this error  
  
1.  Cast the null literal to an object.  
  
## Example  
 The following code generates CS0845:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>