---
title: "strcpy, wcscpy, _mbscpy"
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
  - "strcpy"
  - "wcscpy"
  - "_mbscpy"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbscpy"
  - "_ftcscpy"
  - "wcscpy"
  - "_tcscpy"
  - "strcpy"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strcpy function"
  - "tcscpy function"
  - "ftcscpy function"
  - "mbscpy function"
  - "wcscpy function"
  - "copying strings"
  - "strings [C++], copying"
  - "_tcscpy function"
  - "_ftcscpy function"
  - "_mbscpy function"
ms.assetid: f97a4f81-e9ee-4f15-888a-0fa5d7094c5a
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strcpy, wcscpy, _mbscpy
Copies a string. More secure versions of these functions are available; see [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated source string.  
  
## Return Value  
 Each of these functions returns the destination string. No return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function copies <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, including the terminating null character, to the location that's specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The behavior of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is undefined if the source and destination strings overlap.  
  
> [!IMPORTANT]
>  Because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not check for sufficient space in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> before it copies <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, it is a potential cause of buffer overruns. Therefore, we recommend that you use [strcpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md) instead.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are, respectively, wide-character and multibyte-character versions of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String = Hello world from strcpy and strcat!**   
## .NET Framework Equivalent  
 [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat, _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)