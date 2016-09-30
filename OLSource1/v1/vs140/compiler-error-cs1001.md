---
title: "Compiler Error CS1001"
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
  - "CS1001"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1001"
ms.assetid: 327ad669-9c20-4fe8-a771-234878dbb90e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1001
Identifier expected  
  
 You did not supply an identifier. An identifier is the name of a class, struct, namespace, method, variable and so on that you provide.  
  
 The following example declares a simple class but does not give the class a name:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates CS1001 because, when declaring an enum, you must specify members:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Parameter names are required even if the compiler doesn't use them, for example, in an interface definition. These parameters are required so that programmers who are consuming the interface know something about the what the parameters mean.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Statements, Expressions, and Operators (C# Programming Guide)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md)   
 [Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)