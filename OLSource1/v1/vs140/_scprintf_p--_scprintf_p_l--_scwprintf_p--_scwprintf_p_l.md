---
title: "_scprintf_p, _scprintf_p_l, _scwprintf_p, _scwprintf_p_l"
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
  - "_scwprintf_p"
  - "_scprintf_p_l"
  - "_scwprintf_p_l"
  - "_scprintf_p"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_scwprintf_p_l"
  - "_sctprintf_p"
  - "scprintf_p_l"
  - "scprintf_p"
  - "_sctprintf_p_l"
  - "scwprintf_p"
  - "_scprintf_p_l"
  - "scwprintf_p_l"
  - "_scprintf_p"
  - "_scwprintf_p"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sctprintf_p_l function"
  - "_scwprintf_p_l function"
  - "scprintf_p_l function"
  - "_scprintf_p function"
  - "_scprintf_p_l function"
  - "scprintf_p function"
  - "sctprintf_p function"
  - "_scwprintf_p function"
  - "_sctprintf_p function"
  - "scwprintf_p function"
  - "scwprintf_p_l function"
  - "_sctprintf_p_l function"
ms.assetid: 8390d1e1-2826-47a4-851f-6635a88087cc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _scprintf_p, _scprintf_p_l, _scwprintf_p, _scwprintf_p_l
Returns the number of characters in the formatted string, with the ability to specify the order in which parameters are used in the format string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the number of characters that would be generated if the string were to be printed or sent to a file or buffer using the specified formatting codes. The value returned does not include the terminating null character. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> performs the same function for wide characters.  
  
 The difference between <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> supports positional parameters, which allows specifying the order in which the arguments are used in the format string. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (if any) is converted according to the corresponding format specification in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The format consists of ordinary characters and has the same form and function as the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument for [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
 The versions of these functions with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a user-defined string.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_scprintf, _scprintf_l, _scwprintf, _scwprintf_l](../vs140/_scprintf--_scprintf_l--_scwprintf--_scwprintf_l.md)   
 [_printf_p, _printf_p_l, _wprintf_p, _wprintf_p_l](../vs140/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)