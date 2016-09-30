---
title: "strftime, wcsftime, _strftime_l, _wcsftime_l"
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
  - "strftime"
  - "_wcsftime_l"
  - "_strftime_l"
  - "wcsftime"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsftime"
  - "strftime"
  - "wcsftime"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strftime_l function"
  - "strftime function"
  - "tcsftime function"
  - "_wcsftime_l function"
  - "wcsftime function"
  - "_tcsftime function"
  - "time strings"
ms.assetid: 6330ff20-4729-4c4a-82af-932915d893ea
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strftime, wcsftime, _strftime_l, _wcsftime_l
Format a time string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Size of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> buffer, measured in characters (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data structure.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns the number of characters placed in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns the corresponding number of wide characters.  
  
 If the total number of characters, including the terminating null, is more than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, both <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return 0 and the contents of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are indeterminate.  
  
 The number of characters in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is equal to the number of literal characters in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> as well as any characters that may be added to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> via formatting codes. The terminating null of a string is not counted in the return value.  
  
## Remarks  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> functions format the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> time value in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> according to the supplied <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument and store the result in the buffer <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>*.* At most, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> characters are placed in the string. For a description of the fields in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure, see [asctime](../vs140/asctime--_wasctime.md). <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is the wide-character equivalent of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>; its string-pointer argument points to a wide-character string. These functions behave identically otherwise.  
  
> [!NOTE]
>  In versions before Visual C++ 2005, the documentation described the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> as having the data type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, but the actual implementation of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> data type was <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The implementation of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>data type has been updated to reflect the previous and current documentation, that is, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, or<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a null pointer, or if the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> data structure addressed by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is invalid (for example, if it contains out of range values for the time or date), or if the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> string contains an invalid formatting code, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns 0 and sets <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> argument consists of one or more codes; as in <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, the formatting codes are preceded by a percent sign (<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>). Characters that do not begin with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> are copied unchanged to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>*.* The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> category of the current locale affects the output formatting of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. (For more information on <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, see [setlocale](../vs140/setlocale--_wsetlocale.md).) The functions without the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> suffix use the currently set locale. The versions of these functions with the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> suffix are identical except that they take the locale as a parameter and use that instead of the currently set locale. For more information, see [Locale](../vs140/locale.md).  
  
 The formatting codes for <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are listed below:  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Abbreviated weekday name  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Full weekday name  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Abbreviated month name  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Full month name  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Date and time representation appropriate for locale  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Day of month as decimal number (01 – 31)  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Hour in 24-hour format (00 – 23)  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Hour in 12-hour format (01 – 12)  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Day of year as decimal number (001 – 366)  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Month as decimal number (01 – 12)  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Minute as decimal number (00 – 59)  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Current locale's A.M./P.M. indicator for 12-hour clock  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Second as decimal number (00 – 59)  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Week of year as decimal number, with Sunday as first day of week (00 – 53)  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Weekday as decimal number (0 – 6; Sunday is 0)  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Week of year as decimal number, with Monday as first day of week (00 – 53)  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Date representation for current locale  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Time representation for current locale  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Year without century, as decimal number (00 – 99)  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Year with century, as decimal number  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Either the time-zone name or time zone abbreviation, depending on registry settings; no characters if time zone is unknown  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Percent sign  
  
 As in the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> function, the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> flag may prefix any formatting code. In that case, the meaning of the format code is changed as follows.  
  
|Format code|Meaning|  
|-----------------|-------------|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder> flag is ignored.|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Long date and time representation, appropriate for current locale. For example: "Tuesday, March 14, 1995, 12:41:29".|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|Long date representation, appropriate to current locale. For example: "Tuesday, March 14, 1995".|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|Remove leading zeros (if any).|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [time](../vs140/time--_time32--_time64.md).  
  
## .NET Framework Equivalent  
  
-   [System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx)  
  
-   [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx)  
  
-   [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx)  
  
-   [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)  
  
-   [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [Time Management](../vs140/time-management.md)   
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)