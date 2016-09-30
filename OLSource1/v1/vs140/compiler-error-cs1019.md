---
title: "Compiler Error CS1019"
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
  - "CS1019"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1019"
ms.assetid: 11a3acd8-bcab-4ead-a91b-a1498ea1eab5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1019
Overloadable unary operator expected  
  
 Something that looks like an overloaded unary operator has been declared, but the operator is missing or is in the wrong location in the signature.  
  
 A *unary operator* is an operator that operates on a single operand. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a unary operator. You can overload some unary operators by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword and specifying a single parameter of the type that the operator operates on. For example, if you want to overload the operator <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a user-defined class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> so that you can write <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you can define it in this way:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you receive this error, you have declared something that looks like an overloaded unary operator, except that the operator itself is missing or is in the wrong location in the signature. If you remove the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from the signature in the previous example, you will generate CS1019.  
  
 The following code generates CS1019:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Operators (C# Programming Guide)](../vs140/operators--csharp-programming-guide-.md)