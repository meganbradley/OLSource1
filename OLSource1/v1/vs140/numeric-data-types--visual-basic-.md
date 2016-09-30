---
title: "Numeric Data Types (Visual Basic)"
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
  - "integral types, Visual Basic"
  - "Short data type, numeric data types"
  - "Double data type, numeric data types"
  - "Long data type, Visual Basic numeric data types"
  - "numbers, whole"
  - "fractions"
  - "numbers"
  - "whole numbers"
  - "integer numbers"
  - "numbers, integer"
  - "fractional data types"
  - "mantissas, of fractional numbers"
  - "mantissas"
  - "data types [Visual Basic], numeric"
  - "Integer data type, numeric data types"
  - "exponent, of fractional numbers"
  - "integers"
  - "numeric data types, Visual Basic"
  - "Single data type, numeric types"
  - "Decimal data type, numeric data types"
ms.assetid: a27bd4d0-7e14-43eb-9cc4-b42eaab323c9
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Numeric Data Types (Visual Basic)
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supplies several *numeric data types* for handling numbers in various representations. *Integral* types represent only whole numbers (positive, negative, and zero), and *nonintegral* types represent numbers with both integer and fractional parts.  
  
 For a table showing a side-by-side comparison of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md).  
  
## Integral Numeric Types  
 *Integral data types* are those that represent only numbers without fractional parts.  
  
 The *signed* integral data types are [SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md) (8-bit), [Short Data Type (Visual Basic)](../vs140/short-data-type--visual-basic-.md) (16-bit), [Integer Data Type (Visual Basic)](../vs140/integer-data-type--visual-basic-.md) (32-bit), and [Long Data Type (Visual Basic)](../vs140/long-data-type--visual-basic-.md) (64-bit). If a variable always stores integers rather than fractional numbers, declare it as one of these types.  
  
 The *unsigned* integral types are [Byte Data Type (Visual Basic)](../vs140/byte-data-type--visual-basic-.md) (8-bit), [UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md) (16-bit), [UInteger Data Type](../vs140/uinteger-data-type.md) (32-bit), and [ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md) (64-bit). If a variable contains binary data, or data of unknown nature, declare it as one of these types.  
  
### Performance  
 Arithmetic operations are faster with integral types than with other data types. They are fastest with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> types in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
### Large Integers  
 If you need to hold an integer larger than the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data type can hold, you can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data type instead. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variables can hold numbers from -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807. Operations with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are slightly slower than with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 If you need even larger values, you can use the [Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md). You can hold numbers from -79,228,162,514,264,337,593,543,950,335 through 79,228,162,514,264,337,593,543,950,335 in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable if you do not use any decimal places. However, operations with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> numbers are considerably slower than with any other numeric data type.  
  
### Small Integers  
 If you do not need the full range of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> data type, you can use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data type, which can hold integers from -32,768 through 32,767. For the smallest integer range, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> data type holds integers from -128 through 127. If you have a very large number of variables that hold small integers, the common language runtime can sometimes store your <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> variables more efficiently and save memory consumption. However, operations with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are somewhat slower than with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Unsigned Integers  
 If you know that your variable never needs to hold a negative number, you can use the *unsigned types*<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Each of these data types can hold a positive integer twice as large as its corresponding signed type (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>). In terms of performance, each unsigned type is exactly as efficient as its corresponding signed type. In particular, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> shares with <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> the distinction of being the most efficient of all the elementary numeric data types.  
  
## Nonintegral Numeric Types  
 *Nonintegral data types* are those that represent numbers with both integer and fractional parts.  
  
 The nonintegral numeric data types are <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (128-bit fixed point), [Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md) (32-bit floating point), and [Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md) (64-bit floating point). They are all signed types. If a variable can contain a fraction, declare it as one of these types.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is not a floating-point data type. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> numbers have a binary integer value and an integer scaling factor that specifies what portion of the value is a decimal fraction.  
  
 You can use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> variables for money values. The advantage is the precision of the values. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> data type is faster and requires less memory, but it is subject to rounding errors. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> data type retains complete accuracy to 28 decimal places.  
  
 Floating-point (<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) numbers have larger ranges than <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> numbers but can be subject to rounding errors. Floating-point types support fewer significant digits than <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> but can represent values of greater magnitude.  
  
 Nonintegral number values can be expressed as mmmEeee, in which mmm is the *mantissa* (the significant digits) and eee is the *exponent* (a power of 10). The highest positive values of the nonintegral types are 7.9228162514264337593543950335E+28 for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, 3.4028235E+38 for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and 1.79769313486231570E+308 for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Performance  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is the most efficient of the fractional data types, because the processors on current platforms perform floating-point operations in double precision. However, operations with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> are not as fast as with the integral types such as <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Small Magnitudes  
 For numbers with the smallest possible magnitude (closest to 0), <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> variables can hold numbers as small as -4.94065645841246544E-324 for negative values and 4.94065645841246544E-324 for positive values.  
  
### Small Fractional Numbers  
 If you do not need the full range of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> data type, you can use the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> data type, which can hold floating-point numbers from -3.4028235E+38 through 3.4028235E+38. The smallest magnitudes for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> variables are -1.401298E-45 for negative values and 1.401298E-45 for positive values. If you have a very large number of variables that hold small floating-point numbers, the common language runtime can sometimes store your <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> variables more efficiently and save memory consumption.  
  
## See Also  
 [Elementary Data Types](../vs140/elementary-data-types--visual-basic-.md)   
 [Character Data Types](../vs140/character-data-types--visual-basic-.md)   
 [Miscellaneous Data Types](../vs140/miscellaneous-data-types--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [How to: Call a Windows Function that Takes Unsigned Types](../vs140/how-to--call-a-windows-function-that-takes-unsigned-types--visual-basic-.md)