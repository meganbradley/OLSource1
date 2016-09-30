---
title: "Compiler Warning (level 4) C4706"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4706"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4706"
ms.assetid: 89cd3f4f-812c-4a4b-9426-65a5a6d1b99c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4706
assignment within conditional expression  
  
 The test value in a conditional expression was the result of an assignment.  
  
 An assignment has a value (the value on the left side of the assignment) that can be used legally in another expression, including a test expression.  
  
 The following sample generates C4706:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The warning will occur even if you double the parentheses around the test condition:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If your intention is to test a relation and not to make an assignment, use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator. For example, the following line tests whether a and b are equal:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you intend to make your test value the result of an assignment, test to ensure that the assignment is non-zero or not null. For example, the following code will not generate this warning:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>