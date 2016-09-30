---
title: "_strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l"
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
  - "_strlwr_l"
  - "_strlwr"
  - "_wcslwr_l"
  - "_mbslwr_l"
  - "_wcslwr"
  - "_mbslwr"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strlwr"
  - "wcslwr_l"
  - "_ftcslwr"
  - "mbslwr_l"
  - "_mbslwr"
  - "_wcslwr"
  - "strlwr_l"
  - "_tcslwr"
  - "mbslwr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcslwr function"
  - "_strlwr function"
  - "converting case"
  - "string conversion [C++], case"
  - "mbslwr function"
  - "_strlwr_l function"
  - "strlwr_l function"
  - "_wcslwr function"
  - "ftcslwr function"
  - "strings [C++], case"
  - "_tcslwr_l function"
  - "_wcslwr_l function"
  - "wcslwr_l function"
  - "mbslwr_l function"
  - "tcslwr_l function"
  - "_tcslwr function"
  - "converting case, CRT functions"
  - "_ftcslwr function"
  - "_mbslwr function"
  - "case, converting"
  - "strings [C++], converting case"
  - "_mbslwr_l function"
ms.assetid: d279181d-2e7d-401f-ab44-6e7c2786a046
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l
Converts a string to lowercase. More secure versions of these functions are available; see [_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../vs140/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated string to convert to lowercase.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these functions returns a pointer to the converted string. Because the modification is done in place, the pointer returned is the same as the pointer passed as the input argument. No return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts any uppercase letters in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to lowercase as determined by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> category setting of the locale. Other characters are not affected. For more information on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, see [setlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions without the<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix use the current locale for their locale-dependent behavior; the versions with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions are wide-character and multibyte-character versions of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The argument and return value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions return the original string and set <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Mixed: The String to End All Strings!**  
**Lower: the string to end all strings!**  
**Upper: THE STRING TO END ALL STRINGS!**   
## .NET Framework Equivalent  
 [System::String::ToLower](https://msdn.microsoft.com/en-us/library/system.string.tolower.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr](../vs140/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md)