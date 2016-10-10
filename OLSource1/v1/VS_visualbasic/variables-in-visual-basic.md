---
title: "Variables in Visual Basic"
ms.custom: na
ms.date: "10/10/2016"
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
caps.latest.revision: 27
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Variables in Visual Basic
You often have to store values when you perform calculations with [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)]. For example, you might want to calculate several values, compare them, and perform different operations on them, depending on the result of the comparison. You have to retain the values if you want to compare them.  
  
## Usage  
 [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)], just like most programming languages, uses variables for storing values. A *variable* has a name (the word that you use to refer to the value that the variable contains). A variable also has a data type (which determines the kind of data that the variable can store). A variable can represent an array if it has to store an indexed set of closely related data items.  
  
 Local type inference enables you to declare variables without explicitly stating a data type. Instead, the compiler infers the type of the variable from the type of the initialization expression. For more information, see [Local Type Inference](../VS_visualbasic/local-type-inference--visual-basic-.md) and [Option Infer Statement](../VS_visualbasic/option-infer-statement.md).  
  
## Assigning Values  
 You use assignment statements to perform calculations and assign the result to a variable, as the following example shows.  
  
 [!code[VbVbalrVariables#1](../VS_visualbasic/codesnippet/VisualBasic/variables-in-visual-basic_1.vb)]  
  
> [!NOTE]
>  The equal sign (`=`) in this example is an assignment operator, not an equality operator. The value is being assigned to the variable `applesSold`.  
  
 For more information, see [How to: Move Data Into and Out of a Variable](../VS_visualbasic/how-to--move-data-into-and-out-of-a-variable--visual-basic-.md).  
  
## Variables and Properties  
 Like a variable, a *property* represents a value that you can access. However, it is more complex than a variable. A property uses code blocks that control how to set and retrieve its value. For more information, see [Differences Between Properties and Variables in Visual Basic](../VS_visualbasic/differences-between-properties-and-variables-in-visual-basic.md).  
  
## See Also  
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)   
 [Object Variables](../VS_visualbasic/object-variables-in-visual-basic.md)   
 [Troubleshooting Variables](../VS_visualbasic/troubleshooting-variables-in-visual-basic.md)   
 [How to: Move Data Into and Out of a Variable](../VS_visualbasic/how-to--move-data-into-and-out-of-a-variable--visual-basic-.md)   
 [Differences Between Properties and Variables in Visual Basic](../VS_visualbasic/differences-between-properties-and-variables-in-visual-basic.md)   
 [Local Type Inference](../VS_visualbasic/local-type-inference--visual-basic-.md)