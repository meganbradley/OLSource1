---
title: "_strnextc, _wcsnextc, _mbsnextc, _mbsnextc_l"
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
  - "_strnextc"
  - "_mbsnextc_l"
  - "_mbsnextc"
  - "_wcsnextc"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strnextc"
  - "tcsnextc"
  - "_mbsnextc_l"
  - "_mbsnextc"
  - "mbsnextc_l"
  - "ftcsnextc"
  - "mbsnextc"
  - "_tcsnextc"
  - "_wcsnextc"
  - "_ftcsnextc"
  - "_strnextc"
  - "wcsnextc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbsnextc function"
  - "_tcsnextc function"
  - "_wcsnextc function"
  - "tcsnextc function"
  - "strnextc function"
  - "mbsnextc function"
  - "_strnextc function"
  - "_mbsnextc_l function"
  - "mbsnextc_l function"
  - "wcsnextc function"
ms.assetid: e3086173-9eb5-4540-a23a-5d866bd05340
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strnextc, _wcsnextc, _mbsnextc, _mbsnextc_l
Finds the next character in a string.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Source string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these functions returns the integer value of the next character in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*.*  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function returns the integer value of the next multibyte character in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, without advancing the string pointer. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the [multibyte code page](../vs140/code-pages.md) currently in use.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the function returns 0.  
  
 **Security Note** This API incurs a potential threat brought about by a buffer overrun problem. Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are single-byte–character string and wide-character string versions of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns the integer value of the next wide character in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns the integer value of the next single-byte character in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are provided only for this mapping and should not be used otherwise. For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is identical except that it uses the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<tchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsdec, _mbsdec_l, _strdec, _wcsdec](../vs140/_strdec--_wcsdec--_mbsdec--_mbsdec_l.md)   
 [_mbsinc, _mbsinc_l, _strinc, _wcsinc](../vs140/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)   
 [_mbsninc, _mbsninc_l, _strninc, _wcsninc](../vs140/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)