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
  
```  
CBool(expression)  
CByte(expression)  
CChar(expression)  
CDate(expression)  
CDbl(expression)  
CDec(expression)  
CInt(expression)  
CLng(expression)  
CObj(expression)  
CSByte(expression)  
CShort(expression)  
CSng(expression)  
CStr(expression)  
CUInt(expression)  
CULng(expression)  
CUShort(expression)  
```  
  
## Part  
 `expression`  
 Required. Any expression of the source data type.  
  
## Return Value Data Type  
 The function name determines the data type of the value it returns, as shown in the following table.  
  
|Function name|Return data type|Range for `expression` argument|  
|-------------------|----------------------|-------------------------------------|  
|`CBool`|[Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)|Any valid `Char` or `String` or numeric expression.|  
|`CByte`|[Byte Data Type (Visual Basic)](../vs140/byte-data-type--visual-basic-.md)|0 through 255 (unsigned); fractional parts are rounded.<sup>1</sup>|  
|`CChar`|[Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md)|Any valid `Char` or `String` expression; only first character of a `String` is converted; value can be 0 through 65535 (unsigned).|  
|`CDate`|[Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md)|Any valid representation of a date and time.|  
|`CDbl`|[Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md)|-1.79769313486231570E+308 through -4.94065645841246544E-324 for negative values; 4.94065645841246544E-324 through 1.79769313486231570E+308 for positive values.|  
|`CDec`|[Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md)|+/-79,228,162,514,264,337,593,543,950,335 for zero-scaled numbers, that is, numbers with no decimal places. For numbers with 28 decimal places, the range is +/-7.9228162514264337593543950335. The smallest possible non-zero number is 0.0000000000000000000000000001 (+/-1E-28).|  
|`CInt`|[Integer Data Type (Visual Basic)](../vs140/integer-data-type--visual-basic-.md)|-2,147,483,648 through 2,147,483,647; fractional parts are rounded.<sup>1</sup>|  
|`CLng`|[Long Data Type (Visual Basic)](../vs140/long-data-type--visual-basic-.md)|-9,223,372,036,854,775,808 through 9,223,372,036,854,775,807; fractional parts are rounded.<sup>1</sup>|  
|`CObj`|[Object Data Type](../vs140/object-data-type.md)|Any valid expression.|  
|`CSByte`|[SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)|-128 through 127; fractional parts are rounded.<sup>1</sup>|  
|`CShort`|[Short Data Type (Visual Basic)](../vs140/short-data-type--visual-basic-.md)|-32,768 through 32,767; fractional parts are rounded.<sup>1</sup>|  
|`CSng`|[Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md)|-3.402823E+38 through -1.401298E-45 for negative values; 1.401298E-45 through 3.402823E+38 for positive values.|  
|`CStr`|[String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)|Returns for `CStr` depend on the `expression` argument. See [Return Values for the CStr Function](../vs140/return-values-for-the-cstr-function--visual-basic-.md).|  
|`CUInt`|[UInteger Data Type](../vs140/uinteger-data-type.md)|0 through 4,294,967,295 (unsigned); fractional parts are rounded.<sup>1</sup>|  
|`CULng`|[ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)|0 through 18,446,744,073,709,551,615 (unsigned); fractional parts are rounded.<sup>1</sup>|  
|`CUShort`|[UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)|0 through 65,535 (unsigned); fractional parts are rounded.<sup>1</sup>|  
  
 <sup>1</sup> Fractional parts can be subject to a special type of rounding called *banker's rounding*. See "Remarks" for more information.  
  
## Remarks  
 As a rule, you should use the Visual Basic type conversion functions in preference to the .NET Framework methods such as `ToString()`, either on the <xref:System.Convert*> class or on an individual type structure or class. The Visual Basic functions are designed for optimal interaction with Visual Basic code, and they also make your source code shorter and easier to read. In addition, the .NET Framework conversion methods do not always produce the same results as the Visual Basic functions, for example when converting `Boolean` to `Integer`. For more information, see [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md).  
  
## Behavior  
  
-   **Coercion.** In general, you can use the data type conversion functions to coerce the result of an operation to a particular data type rather than the default data type. For example, use `CDec` to force decimal arithmetic in cases where single-precision, double-precision, or integer arithmetic would normally take place.  
  
-   **Failed Conversions.** If the `expression` passed to the function is outside the range of the data type to which it is to be converted, an <xref:System.OverflowException*> occurs.  
  
-   **Fractional Parts.** When you convert a nonintegral value to an integral type, the integer conversion functions (`CByte`, `CInt`, `CLng`, `CSByte`, `CShort`, `CUInt`, `CULng`, and `CUShort`) remove the fractional part and round the value to the closest integer.  
  
     If the fractional part is exactly 0.5, the integer conversion functions round it to the nearest even integer. For example, 0.5 rounds to 0, and 1.5 and 2.5 both round to 2. This is sometimes called *banker's rounding*, and its purpose is to compensate for a bias that could accumulate when adding many such numbers together.  
  
     `CInt` and `CLng` differ from the <xref:Microsoft.VisualBasic.Conversion.Int*> and <xref:Microsoft.VisualBasic.Conversion.Fix*> functions, which truncate, rather than round, the fractional part of a number. Also, `Fix` and `Int` always return a value of the same data type as you pass in.  
  
-   **Date/Time Conversions.** Use the <xref:Microsoft.VisualBasic.Information.IsDate*> function to determine if a value can be converted to a date and time. `CDate` recognizes date literals and time literals but not numeric values. To convert a Visual Basic 6.0 `Date` value to a `Date` value in Visual Basic 2005 or later versions, you can use the <xref:System.DateTime.FromOADate*?displayProperty=fullName> method.  
  
-   **Neutral Date/Time Values.** The [Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md) always contains both date and time information. For purposes of type conversion, Visual Basic considers 1/1/0001 (January 1 of the year 1) to be a *neutral value* for the date, and 00:00:00 (midnight) to be a neutral value for the time. If you convert a `Date` value to a string, `CStr` does not include neutral values in the resulting string. For example, if you convert `#January 1, 0001 9:30:00#` to a string, the result is "9:30:00 AM"; the date information is suppressed. However, the date information is still present in the original `Date` value and can be recovered with functions such as <xref:Microsoft.VisualBasic.DateAndTime.DatePart*> function.  
  
-   **Culture Sensitivity.** The type conversion functions involving strings perform conversions based on the current culture settings for the application. For example, `CDate` recognizes date formats according to the locale setting of your system. You must provide the day, month, and year in the correct order for your locale, or the date might not be interpreted correctly. A long date format is not recognized if it contains a day-of-the-week string, such as "Wednesday".  
  
     If you need to convert to or from a string representation of a value in a format other than the one specified by your locale, you cannot use the Visual Basic type conversion functions. To do this, use the `ToString(IFormatProvider)` and `Parse(String, IFormatProvider)` methods of that value's type. For example, use <xref:System.Double.Parse*?displayProperty=fullName> when converting a string to a `Double`, and use <xref:System.Double.ToString*?displayProperty=fullName> when converting a value of type `Double` to a string.  
  
## CType Function  
 The [CType Function](../vs140/ctype-function--visual-basic-.md) takes a second argument, `typename`, and coerces `expression` to `typename`, where `typename` can be any data type, structure, class, or interface to which there exists a valid conversion.  
  
 For a comparison of `CType` with the other type conversion keywords, see [DirectCast](../vs140/directcast-operator--visual-basic-.md) and [TryCast](../vs140/trycast-operator--visual-basic-.md).  
  
## CBool Example  
 The following example uses the `CBool` function to convert expressions to `Boolean` values. If an expression evaluates to a nonzero value, `CBool` returns `True`; otherwise, it returns `False`.  
  
 [!code[VbVbalrFunctions#1](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_1.vb)]  
  
## CByte Example  
 The following example uses the `CByte` function to convert an expression to a `Byte`.  
  
 [!code[VbVbalrFunctions#2](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_2.vb)]  
  
## CChar Example  
 The following example uses the `CChar` function to convert the first character of a `String` expression to a `Char` type.  
  
 [!code[VbVbalrFunctions#3](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_3.vb)]  
  
 The input argument to `CChar` must be of data type `Char` or `String`. You cannot use `CChar` to convert a number to a character, because `CChar` cannot accept a numeric data type. The following example obtains a number representing a code point (character code) and converts it to the corresponding character. It uses the <xref:Microsoft.VisualBasic.Interaction.InputBox*> function to obtain the string of digits, `CInt` to convert the string to type `Integer`, and `ChrW` to convert the number to type `Char`.  
  
 [!code[VbVbalrFunctions#4](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_4.vb)]  
  
## CDate Example  
 The following example uses the `CDate` function to convert strings to `Date` values. In general, hard-coding dates and times as strings (as shown in this example) is not recommended. Use date literals and time literals, such as #Feb 12, 1969# and #4:45:23 PM#, instead.  
  
 [!code[VbVbalrFunctions#5](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_5.vb)]  
  
## CDbl Example  
 [!code[VbVbalrFunctions#6](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_6.vb)]  
  
## CDec Example  
 The following example uses the `CDec` function to convert a numeric value to `Decimal`.  
  
 [!code[VbVbalrFunctions#7](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_7.vb)]  
  
## CInt Example  
 The following example uses the `CInt` function to convert a value to `Integer`.  
  
 [!code[VbVbalrFunctions#8](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_8.vb)]  
  
## CLng Example  
 The following example uses the `CLng` function to convert values to `Long`.  
  
 [!code[VbVbalrFunctions#9](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_9.vb)]  
  
## CObj Example  
 The following example uses the `CObj` function to convert a numeric value to `Object`. The `Object` variable itself contains only a four-byte pointer, which points to the `Double` value assigned to it.  
  
 [!code[VbVbalrFunctions#10](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_10.vb)]  
  
## CSByte Example  
 The following example uses the `CSByte` function to convert a numeric value to `SByte`.  
  
 [!code[VbVbalrFunctions#11](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_11.vb)]  
  
## CShort Example  
 The following example uses the `CShort` function to convert a numeric value to `Short`.  
  
 [!code[VbVbalrFunctions#12](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_12.vb)]  
  
## CSng Example  
 The following example uses the `CSng` function to convert values to `Single`.  
  
 [!code[VbVbalrFunctions#13](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_13.vb)]  
  
## CStr Example  
 The following example uses the `CStr` function to convert a numeric value to `String`.  
  
 [!code[VbVbalrFunctions#14](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_14.vb)]  
  
 The following example uses the `CStr` function to convert `Date` values to `String` values.  
  
 [!code[VbVbalrFunctions#15](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_15.vb)]  
  
 `CStr` always renders a `Date` value in the standard short format for the current locale, for example, "6/15/2003 4:35:47 PM". However, `CStr` suppresses the *neutral values* of 1/1/0001 for the date and 00:00:00 for the time.  
  
 For more detail on the values returned by `CStr`, see [Return Values for the CStr Function](../vs140/return-values-for-the-cstr-function--visual-basic-.md).  
  
## CUInt Example  
 The following example uses the `CUInt` function to convert a numeric value to `UInteger`.  
  
 [!code[VbVbalrFunctions#16](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_16.vb)]  
  
## CULng Example  
 The following example uses the `CULng` function to convert a numeric value to `ULong`.  
  
 [!code[VbVbalrFunctions#17](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_17.vb)]  
  
## CUShort Example  
 The following example uses the `CUShort` function to convert a numeric value to `UShort`.  
  
 [!code[VbVbalrFunctions#18](../vs140/codesnippet/VisualBasic/type-conversion-functions--visual-basic-_18.vb)]  
  
## See Also  
 <xref:Microsoft.VisualBasic.Strings.Asc*>   
 <xref:Microsoft.VisualBasic.Strings.AscW*>   
 <xref:Microsoft.VisualBasic.Strings.Chr*>   
 <xref:Microsoft.VisualBasic.Strings.ChrW*>   
 <xref:Microsoft.VisualBasic.Conversion.Int*>   
 <xref:Microsoft.VisualBasic.Conversion.Fix*>   
 <xref:Microsoft.VisualBasic.Strings.Format*>   
 <xref:Microsoft.VisualBasic.Conversion.Hex*>   
 <xref:Microsoft.VisualBasic.Conversion.Oct*>   
 <xref:Microsoft.VisualBasic.Conversion.Str*>   
 <xref:Microsoft.VisualBasic.Conversion.Val*>   
 [Conversion Functions](../vs140/conversion-functions--visual-basic-.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)