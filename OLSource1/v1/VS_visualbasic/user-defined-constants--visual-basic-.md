---
title: "User-Defined Constants (Visual Basic)"
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
  - "constants, circular references"
  - "Const statement [Visual Basic], user-defined constants"
  - "user-defined constants"
  - "scope, constants"
  - "constants, user-defined"
  - "circular references between constants"
ms.assetid: a1206d5c-c45e-4ac2-970a-4a0be6a05fdd
caps.latest.revision: 19
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
# User-Defined Constants (Visual Basic)
A constant is a meaningful name that takes the place of a number or string that does not change. Constants store values that, as the name implies, remain constant throughout the execution of an application. You can use constants that are defined by the controls or components you work with, or you can create your own. Constants you create yourself are described as *user-defined*.  
  
 You declare a constant with the `Const` statement, using the same guidelines you would for creating a variable name. If `Option Strict` is `On`, you must explicitly declare the constant type.  
  
## Const Statement Usage  
 A `Const` statement can represent a mathematical or date/time quantity:  
  
 [!code[VbEnumsTask#10](../VS_visualbasic/codesnippet/VisualBasic/user-defined-constants--visual-basic-_1.vb)]  
  
 It also can define `String` constants:  
  
 [!code[VbEnumsTask#13](../VS_visualbasic/codesnippet/VisualBasic/user-defined-constants--visual-basic-_2.vb)]  
  
 The expression on the right side of the equal sign ( `=` ) is often a number or literal string, but it also can be an expression that results in a number or string (although that expression cannot contain calls to functions). You can even define constants in terms of previously defined constants:  
  
 [!code[VbEnumsTask#15](../VS_visualbasic/codesnippet/VisualBasic/user-defined-constants--visual-basic-_3.vb)]  
  
## Scope of User-Defined Constants  
 A `Const` statement's scope is the same as that of a variable declared in the same location. You can specify scope in any of the following ways:  
  
-   To create a constant that exists only within a procedure, declare it within that procedure.  
  
-   To create a constant available to all procedures within a class, but not to any code outside that module, declare it in the declarations section of the class.  
  
-   To create a constant that is available to all members of an assembly, but not to outside clients of the assembly, declare it using the `Friend` keyword in the declarations section of the class.  
  
-   To create a constant available throughout the application, declare it using the `Public` keyword in the declarations section the class.  
  
 For more information, see [How to: Declare A Constant](../VS_visualbasic/how-to--declare-a-constant--visual-basic-.md).  
  
### Avoiding Circular References  
 Because constants can be defined in terms of other constants, it is possible to inadvertently create a *cycle*, or circular reference, between two or more constants. A cycle occurs when you have two or more public constants, each of which is defined in terms of the other, as in the following example:  
  
 [!code[VbEnumsTask#16](../VS_visualbasic/codesnippet/VisualBasic/user-defined-constants--visual-basic-_4.vb)]  
[!code[VbEnumsTask#17](../VS_visualbasic/codesnippet/VisualBasic/user-defined-constants--visual-basic-_5.vb)]  
  
 If a cycle occurs, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] generates a compiler error.  
  
## See Also  
 [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)   
 [Constant and Literal Data Types](../VS_visualbasic/constant-and-literal-data-types--visual-basic-.md)   
 [Constants and Enumerations](../VS_visualbasic/constants-and-enumerations-in-visual-basic.md)   
 [Constants and Enumerations](../VS_visualbasic/constants-and-enumerations--visual-basic-.md)   
 [Enumerations Overview](../VS_visualbasic/enumerations-overview--visual-basic-.md)   
 [Constants Overview](../VS_visualbasic/constants-overview--visual-basic-.md)   
 [How to: Declare an Enumeration](../VS_visualbasic/how-to--declare-enumerations--visual-basic-.md)   
 [Enumerations and Name Qualification](../VS_visualbasic/enumerations-and-name-qualification--visual-basic-.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)