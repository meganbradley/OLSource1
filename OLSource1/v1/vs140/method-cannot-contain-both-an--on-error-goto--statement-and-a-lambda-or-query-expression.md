---
title: "Method cannot contain both an &#39;On Error GoTo&#39; statement and a lambda or query expression"
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
  - "bc36595"
  - "vbc36595"
helpviewer_keywords: 
  - "BC36595"
ms.assetid: 4e7cc11e-f53d-4481-afb4-653a81d54483
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Method cannot contain both an &#39;On Error GoTo&#39; statement and a lambda or query expression
A method contains both an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement and either a lambda expression or a LINQ query. You cannot include an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement with a lambda expression or LINQ query in a method.  
  
 **Error ID:** BC36595  
  
### To correct this error  
  
1.  Replace the exception handling code that uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [Introduction to Exception Handling (Visual Basic)](assetId:///9792f16a-0cd2-40bd-ace2-f7a4344c0e52)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [On Error Statement (Visual Basic)](../vs140/on-error-statement--visual-basic-.md)