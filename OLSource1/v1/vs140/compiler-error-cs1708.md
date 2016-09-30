---
title: "Compiler Error CS1708"
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
  - "CS1708"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1708"
ms.assetid: df2fc580-2de5-4dd0-9ba3-b41248de5f41
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1708
Fixed size buffers can only be accessed through locals or fields  
  
 A new feature in C# 2.0 is the ability to define an in-line array inside of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Such arrays can only be accessed via local variables or fields, and may not be referenced as intermediate values on the left-hand side of an expression. Also, the arrays cannot be accessed by fields that are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 To resolve this error, define an array variable, and assign the in-line array to the variable. Or, remove the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier from the field representing the in-line array.  
  
## Example  
 The following sample generates CS1708.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>