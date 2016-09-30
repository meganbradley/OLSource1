---
title: "How to: Declare A Constant (Visual Basic)"
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
  - "vb.constant"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Integer data type, declaring constants"
  - "Single data type, declaring constants"
  - "Const statement [Visual Basic], declaring constants"
  - "procedures, declaration"
  - "data types [Visual Basic], constants"
  - "Long data type, declaring constants"
  - "Visual Basic code, declaring variables and constants"
  - "Double data type, declaring constants"
  - "Boolean data type, declaring constants"
  - "modules, declaring constants"
  - "Byte data type, declaring constants"
  - "constants, declaring"
  - "Date data type, declaring constants"
  - "String data type, declaring constants"
  - "declaring constants, const keyword"
  - "Currency data type, declaring constants and variants"
  - "module-level constants and variables"
  - "Object data type, declaring constants"
ms.assetid: f901b4fa-481f-4621-822e-427060577ad1
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare A Constant (Visual Basic)
You use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement to declare a constant and set its value. By declaring a constant, you assign a meaningful name to a value. Once a constant is declared, it cannot be modified or assigned a new value.  
  
 You declare a constant within a procedure or in the declarations section of a module, class, or structure. Class or structure-level constants are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by default, but may also be declared as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the appropriate level of code access.  
  
 The constant must have a valid symbolic name (the rules are the same as those for creating variable names) and an expression composed of numeric or string constants and operators (but no function calls).  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To declare a constant  
  
-   Write a declaration that includes an access specifier, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword, and an expression, as in the following examples:  
  
     [!code[VbEnumsTask#8](../vs140/codesnippet/VisualBasic/how-to--declare-a-constant--visual-basic-_1.vb)]  
  
     When [Option Infer](../vs140/option-infer-statement.md) is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and [Option Strict](../vs140/option-strict-statement.md) is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, you must declare a constant explicitly by specifying a data type (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>).  
  
     When <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, you can declare a constant without specifying a data type with an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause. The compiler determines the type of the constant from the type of the expression. For more information, see [Constant and Literal Data Types](../vs140/constant-and-literal-data-types--visual-basic-.md).  
  
### To declare a constant that has an explicitly stated data type  
  
-   Write a declaration that includes the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> keyword and an explicit data type, as in the following examples:  
  
     [!code[VbEnumsTask#9](../vs140/codesnippet/VisualBasic/how-to--declare-a-constant--visual-basic-_2.vb)]  
  
     You can declare multiple constants on a single line, although your code is more readable if you declare only a single constant per line. If you declare multiple constants on a single line, they must all have the same access level (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>).  
  
### To declare multiple constants on a single line  
  
-   Separate the declarations with a comma and a space, as in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Const Statement](../vs140/const-statement--visual-basic-.md)   
 [Constant and Literal Data Types](../vs140/constant-and-literal-data-types--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations-in-visual-basic.md)   
 [Enumerations Overview](../vs140/enumerations-overview--visual-basic-.md)   
 [Constants Overview (Visual Basic)](../vs140/constants-overview--visual-basic-.md)   
 [How to: Declare an Enumeration](../vs140/how-to--declare-enumerations--visual-basic-.md)   
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)