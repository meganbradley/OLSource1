---
title: "Constant and Literal Data Types (Visual Basic)"
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
  - "declaring constants, literal data types"
  - "data types [Visual Basic], declaring"
  - "constants, declaring"
  - "explicit declarations"
  - "literals, coercing data type"
  - "declarations, data types"
ms.assetid: 057206d2-3a5b-40b9-b3af-57446f9b52fa
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constant and Literal Data Types (Visual Basic)
A literal is a value that is expressed as itself rather than as a variable's value or the result of an expression, such as the number 3 or the string "Hello". A constant is a meaningful name that takes the place of a literal and retains this same value throughout the program, as opposed to a variable, whose value may change.  
  
 When [Option Infer](../vs140/option-infer-statement.md) is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and [Option Strict](../vs140/option-strict-statement.md) is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you must declare all constants explicitly with a data type. In the following example, the data type of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is explicitly declared as data type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrConstants#1](../vs140/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_1.vb)]  
  
 When <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you can declare a constant without specifying a data type with an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause. The compiler determines the type of the constant from the type of the expression. A numeric integer literal is cast by default to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data type. The default data type for floating-point numbers is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and the keywords <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> specify a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> constant.  
  
## Literals and Type Coercion  
 In some cases, you might want to force a literal to a particular data type; for example, when assigning a particularly large integral literal value to a variable of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The following example produces an error:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The error results from the representation of the literal. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> data type can hold a value this large, but the literal is implicitly represented as a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which cannot.  
  
 You can coerce a literal to a particular data type in two ways: by appending a type character to it, or by placing it within enclosing characters. A type character or enclosing characters must immediately precede and/or follow the literal, with no intervening space or characters of any kind.  
  
 To make the previous example work, you can append the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type character to the literal, which causes it to be represented as a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrConstants#2](../vs140/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_2.vb)]  
  
 The following example demonstrates correct usage of type characters and enclosing characters:  
  
 [!code[VbVbalrConstants#3](../vs140/codesnippet/VisualBasic/constant-and-literal-data-types--visual-basic-_3.vb)]  
  
 The following table shows the enclosing characters and type characters available in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
||||  
|-|-|-|  
|Data type|Enclosing character|Appended type character|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|(none)|(none)|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|(none)|(none)|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|"|C|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|#|(none)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|(none)|D or @|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|(none)|R or #|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|(none)|I or %|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|(none)|L or &|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|(none)|S|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|(none)|F or !|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|"|(none)|  
  
## See Also  
 [User-Defined Constants](../vs140/user-defined-constants--visual-basic-.md)   
 [How to: Declare A Constant](../vs140/how-to--declare-a-constant--visual-basic-.md)   
 [Constants Overview (Visual Basic)](../vs140/constants-overview--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)   
 [Enumerations Overview](../vs140/enumerations-overview--visual-basic-.md)   
 [How to: Declare an Enumeration](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)