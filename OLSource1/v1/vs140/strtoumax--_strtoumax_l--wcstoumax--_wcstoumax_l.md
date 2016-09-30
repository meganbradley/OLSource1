---
title: "strtoumax, _strtoumax_l, wcstoumax, _wcstoumax_l"
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
  - "_wcstoumax_l"
  - "_strtoumax_l"
  - "wcstoumax"
  - "strtoumax"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcstoumax"
  - "_tcstoumax"
  - "_strtoumax_l"
  - "_wcstoumax_l"
  - "_tcstoumax_l"
  - "strtoumax"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_strtoumax_l function"
  - "conversion functions"
  - "wcstoumax function"
  - "_wcstoumax_l function"
  - "strtoumax function"
ms.assetid: 566769f9-495b-4508-b9c6-02217a578897
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtoumax, _strtoumax_l, wcstoumax, _wcstoumax_l
Converts strings to an integer value of the largest supported unsigned integer type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the character that stops the scan.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the converted value, if any, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on overflow. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns 0 if no conversion can be performed. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if overflow or underflow occurs.  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions converts the input string <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> integer value.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character that's greater than or equal to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> category setting of the locale determines the recognition of the radix character in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> use the current locale; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are identical except that they instead use the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location that's pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is stored at the location that's pointed to by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The wide-character version of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise, these functions behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> &#124; [<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>]]  
  
 A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are one or more decimal digits; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> are one or more of the letters 'a' through 'z' (or 'A' through 'Z'). The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is 0, the initial characters of the string that's pointed to by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> are used to determine the base. If the first character is '0' and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character would stop the scan. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> allows a plus sign (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) or minus sign (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>) prefix; a leading minus sign indicates that the return value is the two’s complement of the absolute value of the converted string.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
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
 [strtoimax](../vs140/strtoimax--_strtoimax_l--wcstoimax--_wcstoimax_l.md)   
 [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)   
 [strtoul](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [strtoll](../vs140/strtoll--_strtoll_l--wcstoll--_wcstoll_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)