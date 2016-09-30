---
title: "Compiler Error CS0269"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0269"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0269"
ms.assetid: 7ef8374c-6f82-4096-bf4b-70080d4ddf88
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0269
Use of unassigned out parameter 'parameter'  
  
 The compiler could not verify that the out parameter was assigned a value before it was used; its value may be undefined when assigned. Be sure to assign a value to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameters in the called method before accessing the value. If you need to use the value of the variable passed in, use a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter instead. For more information, see [Passing Parameters (C# Programmer's Reference)](../vs140/passing-parameters--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0269:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This could also occur if the initialization of a variable occurs in a try block, which the compiler is unable to verify will execute successfully:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>