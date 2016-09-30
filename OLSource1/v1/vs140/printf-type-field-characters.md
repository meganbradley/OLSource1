---
title: "printf Type Field Characters"
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
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "printf function, format specification fields"
  - "printf function, type field characters"
ms.assetid: 699cb438-cd14-402e-9f81-c7a32acc3317
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# printf Type Field Characters
In a format specification, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> character is a conversion specifier that specifies whether the corresponding argument is to be interpreted as a character, a string, a pointer, an integer, or a floating-point number. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> character is the only required format specification field, and it appears after any optional fields.  
  
 The arguments that follow the format string are interpreted according to the corresponding <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> character and the optional [size](../vs140/size-specification.md) prefix. Conversions for character types <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are specified by using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and single-byte and multi-byte or wide character strings are specified by using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, depending on which formatting function is being used. Character and string arguments that are specified by using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are interpreted as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> family functions, or as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> family functions. Character and string arguments that are specified by using <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are interpreted as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> family functions, or as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> family functions.  
  
 Integer types such as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and their <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> variants, are specified by using <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. Floating-point types such as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, are specified by using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. By default, unless they are modified by a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> field length prefix, integer arguments are coerced to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> type, and floating-point arguments are coerced to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. On 64-bit systems, an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a 32-bit value; therefore, 64-bit integers will be truncated when they are formatted for output unless a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> prefix of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is used. Pointer types that are specified by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> use the default length for the platform.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> type characters, and the behavior of the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> type characters when they are used with the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> functions, are Microsoft extensions and are not ANSI compatible. [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] does not support the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> type character.  
  
### printf Type Field Characters  
  
|Type Character|Argument|Output format|  
|--------------------|--------------|-------------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Character|When used with <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> functions, specifies a single-byte character; when used with <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> functions, specifies a wide character.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Character|When used with <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> functions, specifies a wide character; when used with <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> functions, specifies a single-byte character.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Integer|Signed decimal integer.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Integer|Signed decimal integer.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Integer|Unsigned octal integer.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Integer|Unsigned decimal integer.|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|Integer|Unsigned hexadecimal integer; uses "abcdef."|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Integer|Unsigned hexadecimal integer; uses "ABCDEF."|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Floating-point|Signed value that has the form [ – ]<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>**.**<CodeContentPlaceHolder>76\</CodeContentPlaceHolder> e [*sign*]<CodeContentPlaceHolder>77\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is one decimal digit, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is one or more decimal digits, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is two or three decimal digits depending on the [output format](../vs140/_set_output_format.md) and size of the exponent, and *sign* is + or –.|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Floating-point|Identical to the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> format except that **E** rather than **e** introduces the exponent.|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Floating-point|Signed value that has the form [ – ]<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>**.**<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is one or more decimal digits. The number of digits before the decimal point depends on the magnitude of the number, and the number of digits after the decimal point depends on the requested precision.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|Floating-point|Signed values are displayed in <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> format, whichever is more compact for the given value and precision. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> format is used only when the exponent of the value is less than –4 or greater than or equal to the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> argument. Trailing zeros are truncated, and the decimal point appears only if one or more digits follow it.|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Floating-point|Identical to the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> format, except that **E**, rather than **e**, introduces the exponent (where appropriate).|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Floating-point|Signed hexadecimal double-precision floating-point value that has the form [−]0x*h.hhhh* **p±**<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, where *h.hhhh* are the hex digits (using lower case letters) of the mantissa, and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> are one or more digits for the exponent. The precision specifies the number of digits after the point.|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Floating-point|Signed hexadecimal double-precision floating-point value that has the form [−]0X*h.hhhh* **P±**<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, where *h.hhhh* are the hex digits (using capital letters) of the mantissa, and <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> are one or more digits for the exponent. The precision specifies the number of digits after the point.|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|Pointer to integer|Number of characters that are successfully written so far to the stream or buffer. This value is stored in the integer whose address is given as the argument. See the Security Note later in this article.|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|Pointer type|Displays the argument as an address in hexadecimal digits.|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|String|When used with <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> functions, specifies a single-byte or multi-byte character string; when used with <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> functions, specifies a wide-character string. Characters are displayed up to the first null character or until the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> value is reached.|  
|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|String|When used with <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> functions, specifies a wide-character string; when used with <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> functions, specifies a single-byte or multi-byte character string. Characters are displayed up to the first null character or until the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> value is reached.|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> structure|When the address of an [ANSI_STRING](http://msdn.microsoft.com/library/windows/hardware/ff540605.aspx) or [UNICODE_STRING](http://msdn.microsoft.com/library/windows/hardware/ff564879.aspx) structure is passed as the argument, displays the string that's contained in the buffer that's pointed to by the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> field of the structure. Use a length modifier prefix of <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to specify a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> argument—for example, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> field of the structure must be set to the length, in bytes, of the string. The <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> field of the structure must be set to the length, in bytes, of the buffer.\<br />\<br /> Typically, the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> type character is used only in driver debugging functions that use a format specification, such as <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
  
 If the argument that corresponds to a floating-point conversion specifier is infinite, indefinite, or NAN, the following table lists the formatted output.  
  
|Value|Output|  
|-----------|------------|  
|+ infinity|<CodeContentPlaceHolder>122\</CodeContentPlaceHolder> *random-digits*|  
|– infinity|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder> *random-digits*|  
|Indefinite (same as quiet NaN)|*digit* <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> *random-digits*|  
|NAN|*digit* <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> *random-digits*|  
  
> [!NOTE]
>  If the the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> field of the argument that corresponds to <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, or of the argument that corresponds to <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, is a null pointer, "(null)" will be displayed.  
  
> [!NOTE]
>  In all exponential formats, the default number of digits of exponent to display is three. By using the [_set_output_format](../vs140/_set_output_format.md) function, you can set the number of digits displayed to two but expanding to three if demanded by the size of exponent.  
  
> [!IMPORTANT]
>  Because the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> format is inherently insecure, it is disabled by default. If <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is encountered in a format string, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). To enable <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> support, see [_set_printf_count_output](../vs140/_set_printf_count_output.md).  
  
## See Also  
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [Flag Directives](../vs140/flag-directives.md)   
 [Width Specification](../vs140/printf-width-specification.md)   
 [Precision Specification](../vs140/precision-specification.md)   
 [Size Specification](../vs140/size-specification.md)   
 [_set_output_format](../vs140/_set_output_format.md)