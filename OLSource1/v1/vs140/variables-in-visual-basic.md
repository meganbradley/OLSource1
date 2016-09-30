---
title: "Variables in Visual Basic"
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
  - "variables [Visual Basic]"
  - "values [Visual Basic], storing"
ms.assetid: 4cfaa06d-4ae3-4307-897b-cf599dc24caa
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variables in Visual Basic
You often have to store values when you perform calculations with [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. For example, you might want to calculate several values, compare them, and perform different operations on them, depending on the result of the comparison. You have to retain the values if you want to compare them.  
  
## Usage  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], just like most programming languages, uses variables for storing values. A *variable* has a name (the word that you use to refer to the value that the variable contains). A variable also has a data type (which determines the kind of data that the variable can store). A variable can represent an array if it has to store an indexed set of closely related data items.  
  
 Local type inference enables you to declare variables without explicitly stating a data type. Instead, the compiler infers the type of the variable from the type of the initialization expression. For more information, see [Local Type Inference](../vs140/local-type-inference--visual-basic-.md) and [Option Infer Statement](../vs140/option-infer-statement.md).  
  
## Assigning Values  
 You use assignment statements to perform calculations and assign the result to a variable, as the following example shows.  
  
 [!code[VbVbalrVariables#1](../vs140/codesnippet/VisualBasic/variables-in-visual-basic_1.vb)]  
  
> [!NOTE]
>  The equal sign (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) in this example is an assignment operator, not an equality operator. The value is being assigned to the variable <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 For more information, see [How to: Move Data into and out of a Variable](../vs140/how-to--move-data-into-and-out-of-a-variable--visual-basic-.md).  
  
## Variables and Properties  
 Like a variable, a *property* represents a value that you can access. However, it is more complex than a variable. A property uses code blocks that control how to set and retrieve its value. For more information, see [Differences Between Properties and Variables in Visual Basic](../vs140/differences-between-properties-and-variables-in-visual-basic.md).  
  
## See Also  
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)   
 [Object Variables](../vs140/object-variables-in-visual-basic.md)   
 [Troubleshooting Variables in Visual Basic](../vs140/troubleshooting-variables-in-visual-basic.md)   
 [How to: Move Data into and out of a Variable](../vs140/how-to--move-data-into-and-out-of-a-variable--visual-basic-.md)   
 [Differences Between Properties and Variables in Visual Basic](../vs140/differences-between-properties-and-variables-in-visual-basic.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)