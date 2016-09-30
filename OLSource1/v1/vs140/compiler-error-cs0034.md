---
title: "Compiler Error CS0034"
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
  - "CS0034"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0034"
ms.assetid: cb72ec9b-3a6b-40f3-b2ad-2ea122920edd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0034
Operator 'operator' is ambiguous on operands of type 'type1' and 'type2'  
  
 An operator was used on two objects and the compiler found more than one conversion. Because conversions have to be unique, you either have to make a cast or to make one of the conversions explicit. For more information, see [Conversion Operators (C# Programmers Reference)](../vs140/conversion-operators--csharp-programming-guide-.md).  
  
 The following sample generates CS0034:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In C# 1.1 a compiler bug made it possible to define a class that has implicit user-defined conversions to both <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and to use a bitwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) on objects of that type. In C# 2.0, this bug was fixed to bring the compiler into compliance with the C# specification, and therefore the following code will now cause CS0034:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>