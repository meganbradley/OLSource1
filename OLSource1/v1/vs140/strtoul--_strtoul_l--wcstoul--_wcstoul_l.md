---
title: "strtoul, _strtoul_l, wcstoul, _wcstoul_l"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_wcstoul_l"
  - "_strtoul_l"
  - "strtoul"
  - "wcstoul"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strtoul"
  - "_tcstoul"
  - "wcstoul"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcstoul_l function"
  - "_tcstoul function"
  - "_strtoul_l function"
  - "string conversion, to integers"
  - "wcstoul function"
  - "strtoul function"
  - "wcstoul_l function"
  - "strtoul_l function"
  - "tcstoul function"
ms.assetid: 38f2afe8-8178-4e0b-8bbe-d5c6ad66e3ab
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtoul, _strtoul_l, wcstoul, _wcstoul_l
Convert strings to an unsigned long-integer value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to character that stops scan.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the converted value, if any, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on overflow. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns 0 if no conversion can be performed. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if overflow or underflow occurs.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on this, and other, return codes.  
  
## Remarks  
 Each of these functions converts the input string <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character greater than or equal to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> category setting of the locale determines recognition of the radix character in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> use the current locale; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are identical except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location pointed to by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise these functions behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are one or more decimal digits. The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is 0, the initial characters of the string pointed to by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> are used to determine the base. If the first character is 0 and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character will stop the scan. <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> allows a plus (<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>) or minus (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) sign prefix; a leading minus sign indicates that the return value is negated.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md).  
  
## .NET Framework Equivalent  
 [System::Convert::ToUInt64](https://msdn.microsoft.com/en-us/library/system.convert.touint32.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod, _strtod_l, wcstod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)