---
title: "How to: Declare an Object Variable and Assign an Object to It in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - object variables, declaring
  - declaring object variables
ms.assetid: 2fa77dde-1fb2-439a-80d4-3e9787649fad
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Declare an Object Variable and Assign an Object to It in Visual Basic
You declare a variable of the [Object Data Type](../vs140/object-data-type.md) by specifying `As Object` in a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md). You assign an object to such a variable by placing the object after the equal sign (`=`) in an assignment statement or initialization clause.  
  
## Example  
 The following example declares an `Object` variable and assigns the current instance to it.  
  
```  
  
      Dim thisObject As Object  
thisObject = "This is an Object"  
```  
  
 You can combine the declaration and assignment by initializing the variable as part of its declaration. The following example is equivalent to the preceding example.  
  
```  
Dim thisObject As Object= "This is an Object"  
```  
  
## Compiling the Code  
 This example requires:  
  
-   A reference to the <xref:System?qualifyHint=False> namespace.  
  
-   A class, structure, or module in which to put the `Dim` statement.  
  
-   A procedure in which to put the assignment statement.  
  
## See Also  
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)