---
title: "_mbsnbcpy, _mbsnbcpy_l"
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
  - "_mbsnbcpy"
  - "_mbsnbcpy_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcpy"
  - "_ftcsncpy"
  - "_mbsnbcpy"
  - "mbsnbcpy_l"
  - "_mbsnbcpy_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsnbcpy function"
  - "_mbsnbcpy_l function"
  - "_mbsnbcpy function"
  - "_tcsncpy function"
  - "tcsncpy_l function"
  - "_tcsncpy_l function"
  - "mbsnbcpy_l function"
  - "tcsncpy function"
ms.assetid: 83d17b50-3cbf-4df9-bce8-3b6d52f85d04
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcpy, _mbsnbcpy_l
Copies <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bytes of a string to a destination string. More secure versions of these functions are available—see [_mbsnbcpy_s, _mbsnbcpy_s_l](../vs140/_mbsnbcpy_s--_mbsnbcpy_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/en-us/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Destination for the character string to be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Character string to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of bytes to be copied.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a pointer to the destination character string. No return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function copies <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> exceeds the size of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or the source and destination strings overlap, the behavior of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is undefined.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a null pointer, this function invokes the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that those that don't have the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> suffix use the current locale and the versions that do have the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used to execute arbitrary attacker code, which can cause an unwarranted elevation of privilege and compromise the system. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 In C++, these functions have template overloads that invoke the newer, more secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|[strncpy](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[wcsncpy](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)   
 [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)