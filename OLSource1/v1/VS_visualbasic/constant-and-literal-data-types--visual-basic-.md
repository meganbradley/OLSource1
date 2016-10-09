---
title: "Constant and Literal Data Types (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "declaring constants, literal data types"
  - "data types [Visual Basic], declaring"
  - "constants, declaring"
  - "explicit declarations"
  - "literals, coercing data type"
  - "declarations, data types"
ms.assetid: 057206d2-3a5b-40b9-b3af-57446f9b52fa
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
# Constant and Literal Data Types (Visual Basic)
A literal is a value that is expressed as itself rather than as a variable's value or the result of an expression, such as the number 3 or the string "Hello". A constant is a meaningful name that takes the place of a literal and retains this same value throughout the program, as opposed to a variable, whose value may change.  
  
 When [Option Infer](../VS_visualbasic/option-infer-statement.md) is `Off` and [Option Strict](../VS_visualbasic/option-strict-statement.md) is `On`, you must declare all constants explicitly with a data type. In the following example, the data type of `MyByte` is explicitly declared as data type `Byte`:  
  
 [!code[VbVbalrConstants#1](../VS_visualbasic/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_1.vb)]  
  
 When `Option Infer` is `On` or `Option Strict` is `Off`, you can declare a constant without specifying a data type with an `As` clause. The compiler determines the type of the constant from the type of the expression. A numeric integer literal is cast by default to the `Integer` data type. The default data type for floating-point numbers is `Double`, and the keywords `True` and `False` specify a `Boolean` constant.  
  
## Literals and Type Coercion  
 In some cases, you might want to force a literal to a particular data type; for example, when assigning a particularly large integral literal value to a variable of type `Decimal`. The following example produces an error:  
  
```  
Dim myDecimal as Decimal  
myDecimal = 100000000000000000000   ' This causes a compiler error.  
```  
  
 The error results from the representation of the literal. The `Decimal` data type can hold a value this large, but the literal is implicitly represented as a `Long`, which cannot.  
  
 You can coerce a literal to a particular data type in two ways: by appending a type character to it, or by placing it within enclosing characters. A type character or enclosing characters must immediately precede and/or follow the literal, with no intervening space or characters of any kind.  
  
 To make the previous example work, you can append the `D` type character to the literal, which causes it to be represented as a `Decimal`:  
  
 [!code[VbVbalrConstants#2](../VS_visualbasic/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_2.vb)]  
  
 The following example demonstrates correct usage of type characters and enclosing characters:  
  
 [!code[VbVbalrConstants#3](../VS_visualbasic/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_3.vb)]  
  
 The following table shows the enclosing characters and type characters available in [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)].  
  
||||  
|-|-|-|  
|Data type|Enclosing character|Appended type character|  
|`Boolean`|(none)|(none)|  
|`Byte`|(none)|(none)|  
|`Char`|"|C|  
|`Date`|#|(none)|  
|`Decimal`|(none)|D or @|  
|`Double`|(none)|R or #|  
|`Integer`|(none)|I or %|  
|`Long`|(none)|L or &|  
|`Short`|(none)|S|  
|`Single`|(none)|F or !|  
|`String`|"|(none)|  
  
## See Also  
 [User-Defined Constants](../VS_visualbasic/user-defined-constants--visual-basic-.md)   
 [How to: Declare A Constant](../VS_visualbasic/how-to--declare-a-constant--visual-basic-.md)   
 [Constants Overview](../VS_visualbasic/constants-overview--visual-basic-.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)   
 [Option Explicit Statement](../VS_visualbasic/option-explicit-statement--visual-basic-.md)   
 [Enumerations Overview](../VS_visualbasic/enumerations-overview--visual-basic-.md)   
 [How to: Declare an Enumeration](../VS_visualbasic/how-to--declare-enumerations--visual-basic-.md)   
 [Enumerations and Name Qualification](../VS_visualbasic/enumerations-and-name-qualification--visual-basic-.md)   
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Constants and Enumerations](../VS_visualbasic/constants-and-enumerations--visual-basic-.md)