---
title: "Compiler Warning (level 4) C4130"
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
  - "C4130"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4130"
ms.assetid: 45e4c7b2-6b51-41c7-ba5e-941aa5c7d3dc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4130
'operator' : logical operation on address of string constant  
  
 Using the operator with the address of a string literal produces unexpected code.  
  
 The following sample generates C4130:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The **if** statement compares the value stored in the pointer <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the address of the string "Hello", which is allocated separately each time the string occurs in code. The **if** statement does not compare the string pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the string "Hello".  
  
 To compare strings, use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.