---
title: "Type Conversion Functions (Visual Basic)"
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
  - "vb.CUShort"
  - "vb.csng"
  - "vb.CDate"
  - "CByte"
  - "CSng"
  - "vb.CDec"
  - "CBool"
  - "CStr"
  - "vb.CULng"
  - "CDec"
  - "CVErr"
  - "CDbl"
  - "CShort"
  - "vb.CObj"
  - "vb.CVErr"
  - "CULng"
  - "vb.cdbl"
  - "vb.cbool"
  - "CObj"
  - "CDate"
  - "CLng"
  - "vb.cstr"
  - "vb.cbyte"
  - "vb.clng"
  - "vb.CChar"
  - "CUShort"
  - "vb.CUInt"
  - "vb.cint"
  - "vb.CShort"
  - "CInt"
  - "CUInt"
  - "CChar"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "CDate function"
  - "CByte function"
  - "Integer data type, converting"
  - "string conversion, conversion functions"
  - "fractions"
  - "data types [Visual Basic], converting"
  - "text, converting"
  - "CDec function"
  - "Char data type, converting"
  - "type conversion, functions for"
  - "Single data type, converting"
  - "numbers, rounding"
  - "rounding numbers, type conversion"
  - "CUShort function"
  - "Long data type, converting"
  - "return values, data types"
  - "single-precision numbers, converting"
  - "data type conversion, functions for"
  - "CStr function"
  - "times, converting"
  - "CSng function"
  - "conversions, type conversion functions"
  - "CBool function"
  - "CDbl function"
  - "CUInt function"
  - "Currency data type, conversion functions"
  - "numbers, converting"
  - "Double data type, converting"
  - "CLng function"
  - "CSByte function"
  - "double-precision numbers"
  - "Decimal data type, converting"
  - "Boolean data type, converting"
  - "integers, type conversion functions"
  - "dates, converting"
  - "CULng function"
  - "CInt function"
  - "Date data type, converting"
  - "Byte data type, converting"
  - "String data type, converting"
  - "CChar function"
  - "banker's rounding"
  - "Short data type, converting"
  - "rounding numbers, banker's rounding"
  - "type conversion, Visual Basic vs. .NET Framework"
ms.assetid: d9d8d165-f967-44ff-a6cd-598e4740a99e
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Conversion Functions (Visual Basic)
These functions are compiled inline, meaning the conversion code is part of the code that evaluates the expression. Sometimes there is no call to a procedure to accomplish the conversion, which improves performance. Each function coerces an expression to a specific data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Part  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any expression of the source data type.  
  
## Return Value Data Type  
 The function name determines the data type of the value it returns, as shown in the following table.  
  
|Function name|Return data type|Range for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument|  
|-------------------|----------------------|-------------------------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)|Any valid <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or numeric expression.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[Byte Data Type (Visual Basic)](../vs140/byte-data-type--visual-basic-.md)|0 through 255 (unsigned); fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md)|Any valid <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression; only first character of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is converted; value can be 0 through 65535 (unsigned).|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md)|Any valid representation of a date and time.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md)|-1.79769313486231570E+308 through -4.94065645841246544E-324 for negative values; 4.94065645841246544E-324 through 1.79769313486231570E+308 for positive values.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md)|+/-79,228,162,514,264,337,593,543,950,335 for zero-scaled numbers, that is, numbers with no decimal places. For numbers with 28 decimal places, the range is +/-7.9228162514264337593543950335. The smallest possible non-zero number is 0.0000000000000000000000000001 (+/-1E-28).|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|[Integer Data Type (Visual Basic)](../vs140/integer-data-type--visual-basic-.md)|-2,147,483,648 through 2,147,483,647; fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|[Long Data Type (Visual Basic)](../vs140/long-data-type--visual-basic-.md)|-9,223,372,036,854,775,808 through 9,223,372,036,854,775,807; fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|[Object Data Type](../vs140/object-data-type.md)|Any valid expression.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|[SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)|-128 through 127; fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|[Short Data Type (Visual Basic)](../vs140/short-data-type--visual-basic-.md)|-32,768 through 32,767; fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|[Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md)|-3.402823E+38 through -1.401298E-45 for negative values; 1.401298E-45 through 3.402823E+38 for positive values.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)|Returns for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> depend on the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument. See [Return Values for the CStr Function](../vs140/return-values-for-the-cstr-function--visual-basic-.md).|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[UInteger Data Type](../vs140/uinteger-data-type.md)|0 through 4,294,967,295 (unsigned); fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|[ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)|0 through 18,446,744,073,709,551,615 (unsigned); fractional parts are rounded.<sup>1\</sup>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|[UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)|0 through 65,535 (unsigned); fractional parts are rounded.<sup>1\</sup>|  
  
 <sup>1\</sup> Fractional parts can be subject to a special type of rounding called *banker's rounding*. See "Remarks" for more information.  
  
## Remarks  
 As a rule, you should use the Visual Basic type conversion functions in preference to the .NET Framework methods such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, either on the \<xref:System.Convert*> class or on an individual type structure or class. The Visual Basic functions are designed for optimal interaction with Visual Basic code, and they also make your source code shorter and easier to read. In addition, the .NET Framework conversion methods do not always produce the same results as the Visual Basic functions, for example when converting <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md).  
  
## Behavior  
  
-   **Coercion.** In general, you can use the data type conversion functions to coerce the result of an operation to a particular data type rather than the default data type. For example, use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to force decimal arithmetic in cases where single-precision, double-precision, or integer arithmetic would normally take place.  
  
-   **Failed Conversions.** If the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> passed to the function is outside the range of the data type to which it is to be converted, an \<xref:System.OverflowException*> occurs.  
  
-   **Fractional Parts.** When you convert a nonintegral value to an integral type, the integer conversion functions (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) remove the fractional part and round the value to the closest integer.  
  
     If the fractional part is exactly 0.5, the integer conversion functions round it to the nearest even integer. For example, 0.5 rounds to 0, and 1.5 and 2.5 both round to 2. This is sometimes called *banker's rounding*, and its purpose is to compensate for a bias that could accumulate when adding many such numbers together.  
  
     <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> differ from the \<xref:Microsoft.VisualBasic.Conversion.Int*> and \<xref:Microsoft.VisualBasic.Conversion.Fix*> functions, which truncate, rather than round, the fractional part of a number. Also, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> always return a value of the same data type as you pass in.  
  
-   **Date/Time Conversions.** Use the \<xref:Microsoft.VisualBasic.Information.IsDate*> function to determine if a value can be converted to a date and time. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> recognizes date literals and time literals but not numeric values. To convert a Visual Basic 6.0 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value to a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value in Visual Basic 2005 or later versions, you can use the \<xref:System.DateTime.FromOADate*?displayProperty=fullName> method.  
  
-   **Neutral Date/Time Values.** The [Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md) always contains both date and time information. For purposes of type conversion, Visual Basic considers 1/1/0001 (January 1 of the year 1) to be a *neutral value* for the date, and 00:00:00 (midnight) to be a neutral value for the time. If you convert a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> value to a string, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> does not include neutral values in the resulting string. For example, if you convert <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to a string, the result is "9:30:00 AM"; the date information is suppressed. However, the date information is still present in the original <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> value and can be recovered with functions such as \<xref:Microsoft.VisualBasic.DateAndTime.DatePart*> function.  
  
-   **Culture Sensitivity.** The type conversion functions involving strings perform conversions based on the current culture settings for the application. For example, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> recognizes date formats according to the locale setting of your system. You must provide the day, month, and year in the correct order for your locale, or the date might not be interpreted correctly. A long date format is not recognized if it contains a day-of-the-week string, such as "Wednesday".  
  
     If you need to convert to or from a string representation of a value in a format other than the one specified by your locale, you cannot use the Visual Basic type conversion functions. To do this, use the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> methods of that value's type. For example, use \<xref:System.Double.Parse*?displayProperty=fullName> when converting a string to a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, and use \<xref:System.Double.ToString*?displayProperty=fullName> when converting a value of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to a string.  
  
## CType Function  
 The [CType Function](../vs140/ctype-function--visual-basic-.md) takes a second argument, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and coerces <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> can be any data type, structure, class, or interface to which there exists a valid conversion.  
  
 For a comparison of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> with the other type conversion keywords, see [DirectCast](../vs140/directcast-operator--visual-basic-.md) and [TryCast](../vs140/trycast-operator--visual-basic-.md).  
  
## CBool Example  
 The following example uses the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> function to convert expressions to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> values. If an expression evaluates to a nonzero value, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>; otherwise, it returns <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#1](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_1.vb)]  
  
## CByte Example  
 The following example uses the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> function to convert an expression to a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#2](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_2.vb)]  
  
## CChar Example  
 The following example uses the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function to convert the first character of a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> expression to a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> type.  
  
 [!code[VbVbalrFunctions#3](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_3.vb)]  
  
 The input argument to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> must be of data type <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. You cannot use <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to convert a number to a character, because <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> cannot accept a numeric data type. The following example obtains a number representing a code point (character code) and converts it to the corresponding character. It uses the \<xref:Microsoft.VisualBasic.Interaction.InputBox*> function to obtain the string of digits, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to convert the string to type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to convert the number to type <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#4](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_4.vb)]  
  
## CDate Example  
 The following example uses the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> function to convert strings to <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> values. In general, hard-coding dates and times as strings (as shown in this example) is not recommended. Use date literals and time literals, such as #Feb 12, 1969# and #4:45:23 PM#, instead.  
  
 [!code[VbVbalrFunctions#5](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_5.vb)]  
  
## CDbl Example  
 [!code[VbVbalrFunctions#6](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_6.vb)]  
  
## CDec Example  
 The following example uses the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#7](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_7.vb)]  
  
## CInt Example  
 The following example uses the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> function to convert a value to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#8](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_8.vb)]  
  
## CLng Example  
 The following example uses the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> function to convert values to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#9](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_9.vb)]  
  
## CObj Example  
 The following example uses the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> variable itself contains only a four-byte pointer, which points to the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> value assigned to it.  
  
 [!code[VbVbalrFunctions#10](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_10.vb)]  
  
## CSByte Example  
 The following example uses the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#11](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_11.vb)]  
  
## CShort Example  
 The following example uses the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#12](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_12.vb)]  
  
## CSng Example  
 The following example uses the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> function to convert values to <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#13](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_13.vb)]  
  
## CStr Example  
 The following example uses the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#14](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_14.vb)]  
  
 The following example uses the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> function to convert <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> values to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> values.  
  
 [!code[VbVbalrFunctions#15](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_15.vb)]  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> always renders a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> value in the standard short format for the current locale, for example, "6/15/2003 4:35:47 PM". However, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> suppresses the *neutral values* of 1/1/0001 for the date and 00:00:00 for the time.  
  
 For more detail on the values returned by <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, see [Return Values for the CStr Function](../vs140/return-values-for-the-cstr-function--visual-basic-.md).  
  
## CUInt Example  
 The following example uses the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#16](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_16.vb)]  
  
## CULng Example  
 The following example uses the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#17](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_17.vb)]  
  
## CUShort Example  
 The following example uses the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> function to convert a numeric value to <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrFunctions#18](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_18.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Strings.Asc*>   
 \<xref:Microsoft.VisualBasic.Strings.AscW*>   
 \<xref:Microsoft.VisualBasic.Strings.Chr*>   
 \<xref:Microsoft.VisualBasic.Strings.ChrW*>   
 \<xref:Microsoft.VisualBasic.Conversion.Int*>   
 \<xref:Microsoft.VisualBasic.Conversion.Fix*>   
 \<xref:Microsoft.VisualBasic.Strings.Format*>   
 \<xref:Microsoft.VisualBasic.Conversion.Hex*>   
 \<xref:Microsoft.VisualBasic.Conversion.Oct*>   
 \<xref:Microsoft.VisualBasic.Conversion.Str*>   
 \<xref:Microsoft.VisualBasic.Conversion.Val*>   
 [Conversion Functions](../vs140/conversion-functions--visual-basic-.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)