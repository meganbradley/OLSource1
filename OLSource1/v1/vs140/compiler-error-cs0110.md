---
title: "Compiler Error CS0110"
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
  - "CS0110"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0110"
ms.assetid: 0bfe7071-1194-4142-a1a1-6190ee92b1d4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0110
The evaluation of the constant value for 'const declaration' involves a circular definition  
  
 The declaration of a [const](../vs140/const--csharp-reference-.md) variable (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) cannot reference another const variable (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) that also references (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 The following sample generates CS0110:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Constants (C# Programmer's Reference)](../vs140/constants--csharp-programming-guide-.md)