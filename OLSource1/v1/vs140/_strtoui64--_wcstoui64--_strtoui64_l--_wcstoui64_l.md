---
title: "_strtoui64, _wcstoui64, _strtoui64_l, _wcstoui64_l"
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
  - "_strtoui64"
  - "_strtoui64_l"
  - "_wcstoui64"
  - "_wcstoui64_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wcstoui64_l"
  - "strtoui64_l"
  - "wcstoui64"
  - "_wcstoui64"
  - "_strtoui64_l"
  - "strtoui64"
  - "_strtoui64"
  - "wcstoui64_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strtoui64_l function"
  - "_wcstoui64_l function"
  - "string conversion, to integers"
  - "wcstoui64_l function"
  - "_strtoui64 function"
  - "_wcstoui64 function"
  - "wcstoui64 function"
  - "strtoui64_l function"
  - "strtoui64 function"
ms.assetid: 7fcb537e-4554-4ceb-a5b6-bc09244e72ef
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strtoui64, _wcstoui64, _strtoui64_l, _wcstoui64_l
Convert a string to an unsigned <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to character that stops scan.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns the value represented in the string <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, except when the representation would cause an overflow, in which case it returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. _<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>will return 0 if no conversion can be performed.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is defined in LIMITS.H.  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is nonzero and either less than 2 or greater than 36, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>function converts <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise these functions behave identically.  
  
 Both functions stop reading the string <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> at the first character they cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character greater than or equal to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
 The current locale's <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> category setting determines recognition of the radix character in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The functions without the _l suffix use the current locale; <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> are identical to the corresponding functions without the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> suffix except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location pointed to by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> are one or more decimal digits. The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is 0, the initial characters of the string pointed to by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are used to determine the base. If the first character is 0 and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character will stop the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **u = 18446744073709551615**   
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod, _strtod_l, wcstod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)