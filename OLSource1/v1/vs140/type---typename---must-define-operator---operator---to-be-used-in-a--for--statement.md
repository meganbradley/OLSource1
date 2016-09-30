---
title: "Type &#39;&lt;typename&gt;&#39; must define operator &#39;&lt;operator&gt;&#39; to be used in a &#39;For&#39; statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc33038"
  - "BC33038"
helpviewer_keywords: 
  - "BC33038"
ms.assetid: b1c9d87f-80f9-4c8c-8908-f8400b9fe4c5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; must define operator &#39;&lt;operator&gt;&#39; to be used in a &#39;For&#39; statement
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> loop specifies a counter variable of a type that does not support a required operator.  
  
 The counter variable in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loop can be of any data type that supports all of the following operators:  
  
-   Greater than or equal (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>)  
  
-   Less than or equal (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>)  
  
-   Addition (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>)  
  
-   Subtraction (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>)  
  
 If you use a numeric data type for the counter variable, all the preceding operators are supported. If you use a user-defined class or structure, you must define all the preceding operators on that class or structure.  
  
 Note also that the data types of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expressions in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement must widen to the data type of the counter variable. If the counter variable is a user-defined class or structure and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> expression is of a different type, you must define the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> conversion operator to accomplish the necessary conversion.  
  
 **Error ID:** BC33038  
  
### To correct this error  
  
1.  Make sure the spelling of the counter-variable data type is correct.  
  
2.  If you are using a user-defined class or structure for the counter variable, define all the required operators on that class or structure.  
  
3.  Depending on the data types of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> expressions, you might have to define one or more <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> conversion operators to convert them to the counter variable data type.  
  
## See Also  
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)