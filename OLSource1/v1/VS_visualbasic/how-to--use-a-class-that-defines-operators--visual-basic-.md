---
title: "How to: Use a Class that Defines Operators (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operator procedures, calling"
  - "procedures, operator"
  - "procedures, calling"
  - "examples [Visual Basic], CType"
  - "syntax, Operator procedures"
  - "operators [Visual Basic], overloading"
  - "return values, Operator procedures"
  - "operator overloading"
ms.assetid: 7ccce94a-6ca0-47d1-9f3f-13385d34f5d5
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use a Class that Defines Operators (Visual Basic)
If you are using a class or structure that defines its own operators, you can access those operators from [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)].  
  
 Defining an operator on a class or structure is also called *overloading* the operator.  
  
## Example  
 The following example accesses the SQL structure <xref:System.Data.SqlTypes.SqlString*>, which defines the conversion operators ([CType Function](../VS_csharp/ctype-function--visual-basic-.md)) in both directions between a SQL string and a [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] string. Use `CType(`*SQL string expression*, `String)` to convert a SQL string to a [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] string, and `CType(`*Visual Basic string expression*, <xref:System.Data.SqlTypes.SqlString*>`)` to convert in the other direction.  
  
 [!code[VbVbcnProcedures#30](../VS_csharp/codesnippet/VisualBasic/how-to--use-a-class-that-defines-operators--visual-basic-_1.vb)]  
  
 [!code[VbVbcnProcedures#31](../VS_csharp/codesnippet/VisualBasic/how-to--use-a-class-that-defines-operators--visual-basic-_2.vb)]  
  
 The <xref:System.Data.SqlTypes.SqlString*> structure defines a conversion operator ([CType Function](../VS_csharp/ctype-function--visual-basic-.md)) from `String` to <xref:System.Data.SqlTypes.SqlString*> and another from <xref:System.Data.SqlTypes.SqlString*> to `String`. The statement that assigns `title` to `jobTitle` makes use of the first operator, and the <xref:Microsoft.VisualBasic.Interaction.MsgBox*> function call uses the second.  
  
## Compiling the Code  
 Be sure the class or structure you are using defines the operator you want to use. Do not assume that the class or structure has defined every operator available for overloading. For a list of available operators, see [Operator Statement](../VS_csharp/operator-statement.md).  
  
 Include the appropriate `Imports` statement for the SQL string at the beginning of your source file (in this case <xref:System.Data.SqlTypes*>).  
  
 Your project must have references to System.Data and System.XML.  
  
## See Also  
 [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../VS_csharp/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../VS_csharp/how-to--define-a-conversion-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../VS_csharp/how-to--call-an-operator-procedure--visual-basic-.md)   
 [Widening](../VS_csharp/widening--visual-basic-.md)   
 [Narrowing](../VS_csharp/narrowing--visual-basic-.md)   
 [Structure Statement](../VS_csharp/structure-statement.md)   
 [How to: Declare a Structure](../VS_csharp/how-to--declare-a-structure--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_csharp/implicit-and-explicit-conversions--visual-basic-.md)   
 [Widening and Narrowing Conversions](../VS_csharp/widening-and-narrowing-conversions--visual-basic-.md)