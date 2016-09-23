---
title: "How to: Declare Enumerations (Visual Basic)"
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
  - declarations, enumerations
  - enumerations [Visual Basic], declaring
  - declaring enumerations
ms.assetid: db4ca1c3-f429-4c81-ae81-29e0157b29fd
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Declare Enumerations (Visual Basic)
You create an enumeration with the `Enum` statement in the declarations section of a class or module. You cannot declare an enumeration within a method. To specify the appropriate level of access, use `Private`, `Protected`, `Friend`, or `Public`.  
  
 An `Enum` type has a name, an underlying type, and a set of fields, each representing a constant. The name must be a valid [!INCLUDE[vbprvblong](../vs140/includes/vbprvblong_md.md)] qualifier. The underlying type must be one of the integer types—`Byte`, `Short`, `Long` or `Integer`. `Integer` is the default. Enumerations are always strongly typed and are not interchangeable with integer number types.  
  
 Enumerations cannot have floating-point values. If an enumeration is assigned a floating-point value with `Option Strict On`, a compiler error results. If `Option Strict` is `Off`, the value is automatically converted to the `Enum` type.  
  
 For information on names, and how to use the `Imports` statement to make name qualification unnecessary, see [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md).  
  
### To declare an enumeration  
  
1.  Write a declaration that includes a code access level, the `Enum` keyword, and a valid name, as in the following examples, each of which declares a different `Enum`.  
  
     [!code[VbEnumsTask#3](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_1.vb)]
  
  
2.  Define the constants in the enumeration. By default, the first constant in an enumeration is initialized to `0`, and subsequent constants are initialized to a value of one more than the previous constant. For example, the following enumeration, `Days`, contains a constant named `Sunday` with the value `0`, a constant named `Monday` with the value `1`, a constant named `Tuesday` with the value of `2`, and so on.  
  
     [!code[VbEnumsTask#4](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_2.vb)]
  
  
3.  You can explicitly assign values to constants in an enumeration by using an assignment statement. You can assign any integer value, including negative numbers. For example, you may want constants with values less than zero to represent error conditions. In the following enumeration, the constant `Invalid` is explicitly assigned the value `–1`, and the constant `Sunday` is assigned the value `0`. Because it is the first constant in the enumeration, `Saturday` is also initialized to the value `0`. The value of `Monday` is `1` (one more than the value of `Sunday`); the value of `Tuesday` is `2`, and so on.  
  
     [!code[VbEnumsTask#5](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_3.vb)]
  
  
### To declare an enumeration as an explicit type  
  
-   Specify the type of the enum by using the `As` clause, as shown in the following example.  
  
     [!code[VbEnumsTask#6](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_4.vb)]
  
  
## See Also  
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../vs140/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [How to: Iterate Through An Enumeration in Visual Basic](../vs140/how-to--iterate-through-an-enumeration-in-visual-basic.md)   
 [How to: Determine the String Associated with an Enumeration Value](../vs140/how-to--determine-the-string-associated-with-an-enumeration-value--visual-basic-.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)   
 [Constants in Visual Basic](../vs140/constants-overview--visual-basic-.md)   
 [Constant and Literal Data Types](../vs140/constant-and-literal-data-types--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)