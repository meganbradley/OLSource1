---
title: "How to: Declare Enumerations (Visual Basic)"
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
  - "declarations, enumerations"
  - "enumerations [Visual Basic], declaring"
  - "declaring enumerations"
ms.assetid: db4ca1c3-f429-4c81-ae81-29e0157b29fd
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Enumerations (Visual Basic)
You create an enumeration with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement in the declarations section of a class or module. You cannot declare an enumeration within a method. To specify the appropriate level of access, use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type has a name, an underlying type, and a set of fields, each representing a constant. The name must be a valid [!INCLUDE[vbprvblong](../vs140/includes/vbprvblong_md.md)] qualifier. The underlying type must be one of the integer types—<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the default. Enumerations are always strongly typed and are not interchangeable with integer number types.  
  
 Enumerations cannot have floating-point values. If an enumeration is assigned a floating-point value with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, a compiler error results. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the value is automatically converted to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type.  
  
 For information on names, and how to use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement to make name qualification unnecessary, see [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md).  
  
### To declare an enumeration  
  
1.  Write a declaration that includes a code access level, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword, and a valid name, as in the following examples, each of which declares a different <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
     [!code[VbEnumsTask#3](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_1.vb)]  
  
2.  Define the constants in the enumeration. By default, the first constant in an enumeration is initialized to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and subsequent constants are initialized to a value of one more than the previous constant. For example, the following enumeration, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, contains a constant named <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with the value <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, a constant named <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with the value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, a constant named <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> with the value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and so on.  
  
     [!code[VbEnumsTask#4](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_2.vb)]  
  
3.  You can explicitly assign values to constants in an enumeration by using an assignment statement. You can assign any integer value, including negative numbers. For example, you may want constants with values less than zero to represent error conditions. In the following enumeration, the constant <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is explicitly assigned the value <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and the constant <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is assigned the value <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Because it is the first constant in the enumeration, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is also initialized to the value <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The value of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (one more than the value of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>); the value of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and so on.  
  
     [!code[VbEnumsTask#5](../vs140/codesnippet/VisualBasic/how-to--declare-enumerations--visual-basic-_3.vb)]  
  
### To declare an enumeration as an explicit type  
  
-   Specify the type of the enum by using the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> clause, as shown in the following example.  
  
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