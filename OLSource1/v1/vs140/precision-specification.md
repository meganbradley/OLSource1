---
title: "Precision Specification"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "c.math"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "printf function, format specification fields"
ms.assetid: dc59ea4e-d23a-4f1f-9881-2c919ebefb82
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Precision Specification
In a format specification, the third optional field is the precision specification. It consists of a period (.) followed by a non-negative decimal integer that, depending on the conversion type, specifies the number of string characters, the number of decimal places, or the number of significant digits to be output.  
  
 Unlike the width specification, the precision specification can cause either truncation of the output value or rounding of a floating-point value. If <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is specified as 0 and the value to be converted is 0, the result is no characters output, as shown in this example:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 If the precision specification is an asterisk (*), an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument from the argument list supplies the value. In the argument list, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument must precede the value that's being formatted, as shown in this example:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The type determines either the interpretation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or the default precision when <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is omitted, as shown in the following table.  
  
### How Precision Values Affect Type  
  
|Type|Meaning|Default|  
|----------|-------------|-------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The precision specifies the number of digits after the point.|Default precision is 6. If precision is 0, no decimal point is printed unless the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> flag is used.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The precision has no effect.|Character is printed.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The precision specifies the minimum number of digits to be printed. If the number of digits in the argument is less than <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the output value is padded on the left with zeros. The value is not truncated when the number of digits exceeds <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|Default precision is 1.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The precision specifies the number of digits to be printed after the decimal point. The last printed digit is rounded.|Default precision is 6. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is 0 or the period (.) appears without a number following it, no decimal point is printed.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The precision value specifies the number of digits after the decimal point. If a decimal point appears, at least one digit appears before it. The value is rounded to the appropriate number of digits.|Default precision is 6. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is 0, or if the period (.) appears without a number following it, no decimal point is printed.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|The precision specifies the maximum number of significant digits printed.|Six significant digits are printed, and any trailing zeros are truncated.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|The precision specifies the maximum number of characters to be printed. Characters in excess of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are not printed.|Characters are printed until a null character is encountered.|  
  
## See Also  
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [Flag Directives](../vs140/flag-directives.md)   
 [Width Specification](../vs140/printf-width-specification.md)   
 [Size Specification](../vs140/size-specification.md)   
 [printf Type Field Characters](../vs140/printf-type-field-characters.md)