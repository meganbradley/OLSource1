---
title: "Compiler Error CS0650"
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
  - "CS0650"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0650"
ms.assetid: c81719ad-343d-4622-8130-41fcb24e3fb5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0650
Bad array declarator: To declare a managed array the rank specifier precedes the variable's identifier. To declare a fixed size buffer field, use the fixed keyword before the field type.  
  
 An array was declared incorrectly. In C#, unlike in C and C++, the square brackets follow the type, not the variable name. Also, realize that the syntax for a fixed size buffer differs from that of an array.  
  
## Example  
 The following example code generates CS0650.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword when you create a fixed size buffer:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Fixed Size Buffers (C# Programming Guide)](../vs140/fixed-size-buffers--csharp-programming-guide-.md)   
 [fixed Statement (C# Reference)](../vs140/fixed-statement--csharp-reference-.md)   
 [Arrays (C# Programming Guide)](../vs140/arrays--csharp-programming-guide-.md)