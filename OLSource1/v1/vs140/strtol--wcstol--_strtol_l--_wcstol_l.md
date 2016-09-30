---
title: "strtol, wcstol, _strtol_l, _wcstol_l"
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
  - "strtol"
  - "wcstol"
  - "_strtol_l"
  - "_wcstol_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wcstol_l"
  - "strtol"
  - "_tcstol"
  - "wcstol"
  - "_strtol_l"
  - "_tcstol_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcstol function"
  - "wcstol_l function"
  - "_tcstol function"
  - "string conversion, to integers"
  - "tcstol function"
  - "strtol_l function"
  - "_wcstol_l function"
  - "_strtol_l function"
  - "strtol function"
ms.assetid: 1787c96a-f283-4a83-9325-33cfc1c7e240
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtol, wcstol, _strtol_l, _wcstol_l
Convert strings to a long-integer value.  
  
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
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the value represented in the string <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, except when the representation would cause an overflow, in which case it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns 0 if no conversion can be performed. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if overflow or underflow occurs.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these and other return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character greater than or equal to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
 The current locale's <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> category setting determines recognition of the radix character in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>*;* for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The functions without the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffix use the current locale; <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> are identical to the corresponding functions without the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> suffix except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location pointed to by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> are one or more decimal digits. The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is 0, the initial characters of the string pointed to by <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> are used to determine the base. If the first character is 0 and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character will stop the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md).  
  
## .NET Framework Equivalent  
 [System::Convert::ToInt64](https://msdn.microsoft.com/en-us/library/system.convert.toint64.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod, _strtod_l, wcstod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)