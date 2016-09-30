---
title: "Conversions Between Strings and Other Types (Visual Basic)"
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
  - "data type conversion, string"
  - "conversions, type"
  - "string conversion"
  - "conversions, data type"
  - "type conversion, string"
  - "regional options"
ms.assetid: c3a99596-f09a-44a5-81dd-1b89a094f1df
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversions Between Strings and Other Types (Visual Basic)
You can convert a numeric, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or date/time value to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You can also convert in the reverse direction — from a string value to numeric, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> — provided the contents of the string can be interpreted as a valid value of the destination data type. If they cannot, a run-time error occurs.  
  
 The conversions for all these assignments, in either direction, are narrowing conversions. You should use the type conversion keywords (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>). The \<xref:Microsoft.VisualBasic.Strings.Format*> and \<xref:Microsoft.VisualBasic.Conversion.Val*> functions give you additional control over conversions between strings and numbers.  
  
 If you have defined a class or structure, you can define type conversion operators between <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the type of your class or structure. For more information, see [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md).  
  
## Conversion of Numbers to Strings  
 You can use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function to convert a number to a formatted string, which can include not only the appropriate digits but also formatting symbols such as a currency sign (such as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>), thousands separators or *digit grouping symbols* (such as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>), and a decimal separator (such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>). <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> automatically uses the appropriate symbols according to the **Regional Options** settings specified in the Windows **Control Panel**.  
  
 Note that the concatenation (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) operator can convert a number to a string implicitly, as the following example shows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Conversion of Strings to Numbers  
 You can use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function to explicitly convert the digits in a string to a number. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> reads the string until it encounters a character other than a digit, space, tab, line feed, or period. The sequences "&O" and "&H" alter the base of the number system and terminate the scanning. Until it stops reading, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> converts all appropriate characters to a numeric value. For example, the following statement returns the value <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 When [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] converts a string to a numeric value, it uses the **Regional Options** settings specified in the Windows **Control Panel** to interpret the thousands separator, decimal separator, and currency symbol. This means that a conversion might succeed under one setting but not another. For example, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is acceptable in the English (United States) locale but not in any French locale.  
  
## See Also  
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [How to: Convert an Object to Another Type in Visual Basic](../vs140/how-to--convert-an-object-to-another-type-in-visual-basic.md)   
 [Array Conversions](../vs140/array-conversions--visual-basic-.md)   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Introduction to International Applications Based on the .NET Framework](../vs140/introduction-to-international-applications-based-on-the-.net-framework.md)