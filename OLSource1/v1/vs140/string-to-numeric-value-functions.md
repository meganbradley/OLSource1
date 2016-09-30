---
title: "String to Numeric Value Functions"
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
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcstoui64"
  - "_tcstoi64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "parsing, numeric strings"
  - "string conversion, to numeric values"
ms.assetid: 11cbd9ce-033b-4914-bf66-029070e7e385
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String to Numeric Value Functions
-   [strtod, wcstod, _strtod_l](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)  
  
-   [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)  
  
-   [strtoul, wcstoul, _strtoul_l, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)  
  
-   [_strtoi64, _wcstoi64, _strtoi64_l, _wcstoi64_l](../vs140/_strtoi64--_wcstoi64--_strtoi64_l--_wcstoi64_l.md)  
  
-   [_strtoui64, _wcstoui64, _strtoui64_l, _wcstoui64_l](../vs140/_strtoui64--_wcstoui64--_strtoui64_l--_wcstoui64_l.md)  
  
## Remarks  
 Each function in the **strtod** family converts a null-terminated string to a numeric value. The available functions are listed in the following table.  
  
|Function|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Convert string to double-precision floating point value|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Convert string to long integer|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Convert string to unsigned long integer|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Convert string to 64-bit <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> integer|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Convert string to unsigned 64-bit <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> integer|  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, respectively. The string argument to each of these wide-character functions is a wide-character string; each function behaves identically to its single-byte–character counterpart otherwise.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function takes two arguments: the first is the input string, and the second a pointer to the character which ends the conversion process. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, **_strtoi64** and **_strtoui64** take a third argument as the number base to use in the conversion process.  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. Each function stops reading the string at the first character it cannot recognize as part of a number. This may be the terminating null character. For <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, this terminating character can also be the first numeric character greater than or equal to the user-supplied number base.  
  
 If the user-supplied pointer to an end-of-conversion character is not set to **NULL** at call time, a pointer to the character that stopped the scan will be stored there instead. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of the string pointer is stored at that address.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> expects a string of the following form:  
  
 [*whitespace*] [*sign*] [<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>] [**.**<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>] [ {**d** &#124; **D** &#124; **e** &#124; **E**}[*sign*]<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>]  
  
 A *whitespace* may consist of space or tab characters, which are ignored; *sign* is either plus (**+**) or minus (**–**); and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are one or more decimal digits. If no digits appear before the radix character, at least one must appear after the radix character. The decimal digits can be followed by an exponent, which consists of an introductory letter (**d**, **D**, **e**, or **E**) and an optionally signed integer. If neither an exponent part nor a radix character appears, a radix character is assumed to follow the last digit in the string. The first character that does not fit this form stops the scan.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> functions expect a string of the following form:  
  
 [*whitespace*] [{**+** &#124; **–**}] [**0** [{ **x** &#124; **X** }]] [<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>]  
  
 If the base argument is between 2 and 36, then it is used as the base of the number. If it is 0, the initial characters referenced to by the end-of-conversion pointer are used to determine the base. If the first character is 0 and the second character is not 'x' or 'X', the string is interpreted as an octal integer; otherwise, it is interpreted as a decimal number. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than *base* are permitted. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> allow a plus (**+**) or minus (**–**) sign prefix; a leading minus sign indicates that the return value is negated.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the **_l** suffix use the current locale for this locale-dependent behavior; the versions with the **_l** suffix are identical except that they use the locale parameter passed in instead.  
  
 When the value returned by these functions would cause an overflow or underflow, or when conversion is not possible, special case values are returned as shown:  
  
|Function|Condition|Value returned|  
|--------------|---------------|--------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Overflow|+/- <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Underflow or no conversion|0|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|+ Overflow|**LONG_MAX**|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|- Overflow|**LONG_MIN**|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Underflow or no conversion|0|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|+ Overflow|**_I64_MAX**|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|- Overflow|**_I64_MIN**|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|No conversion|0|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Overflow|**_UI64_MAX**|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|No conversion|0|  
  
 **_I64_MAX**, _**I64_MIN**, and **_UI64_MAX** are defined in LIMITS.H.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, respectively; the pointer to an end-of-conversion argument to each of these wide-character functions is a wide-character string. Otherwise, each of these wide-character functions behaves identically to its single-byte–character counterpart.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)