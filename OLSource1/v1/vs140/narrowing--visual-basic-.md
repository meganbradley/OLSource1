---
title: "Narrowing (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.narrowing"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "conversions, type"
  - "type conversion"
  - "conversions, data type"
  - "Narrowing keyword"
  - "data type conversion"
ms.assetid: a207ee91-aca4-4771-b4e2-713f029bf2bb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Narrowing (Visual Basic)
Indicates that a conversion operator (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) converts a class or structure to a type that might not be able to hold some of the possible values of the original class or structure.  
  
## Converting with the Narrowing Keyword  
 The conversion procedure must specify <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in addition to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 Narrowing conversions do not always succeed at run time, and can fail or incur data loss. Examples are <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and a base type to a derived type. This last conversion is narrowing because the base type might not contain all the members of the derived type and thus is not an instance of the derived type.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the consuming code must use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for all narrowing conversions.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword can be used in this context:  
  
 [Operator Statement](../vs140/operator-statement.md)  
  
## See Also  
 [Operator Statement](../vs140/operator-statement.md)   
 [Widening](../vs140/widening--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)