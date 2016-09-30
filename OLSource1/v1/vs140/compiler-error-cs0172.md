---
title: "Compiler Error CS0172"
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
  - "CS0172"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0172"
ms.assetid: 1272c575-3580-4897-95fb-83f45d7435ae
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0172
Type of conditional expression cannot be determined because 'type1' and 'type2' implicitly convert to one another  
  
 In a conditional statement, you must be able to convert the types on either side of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator. Also, there cannot be mutual conversion routines; you only need one conversion. For more information, see [Conversion Operators (C# Programmers Reference)](../vs140/conversion-operators--csharp-programming-guide-.md).  
  
 The following sample generates CS0172:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>