---
title: "_vscprintf_p, _vscprintf_p_l, _vscwprintf_p, _vscwprintf_p_l"
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
  - "_vscprintf_p_l"
  - "_vscprintf_p"
  - "_vscwprintf_p_l"
  - "_vscwprintf_p"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vscprintf_p"
  - "_vscprintf_p_l"
  - "vscwprintf_p"
  - "vscprintf_p"
  - "vscwprintf_p_l"
  - "_vscwprintf_p_l"
  - "vscprintf_p_l"
  - "_vscwprintf_p"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vscprintf_p function"
  - "_vsctprintf_p_l function"
  - "vscwprintf_p_l function"
  - "_vscwprintf_p_l function"
  - "_vscprintf_p function"
  - "vsctprintf_p function"
  - "_vscprintf_p_l function"
  - "_vscwprintf_p function"
  - "vscwprintf_p function"
  - "vsctprintf_p_l function"
  - "_vsctprintf_p function"
  - "vscprintf_p_l function"
ms.assetid: 5da920b3-8652-4ee9-b19e-5aac3ace9d03
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _vscprintf_p, _vscprintf_p_l, _vscwprintf_p, _vscwprintf_p_l
Returns the number of characters in the formatted string using a pointer to a list of arguments, with the ability to specify the order in which the arguments are used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the number of characters that would be generated if the string pointed to by the list of arguments was printed or sent to a file or buffer using the specified formatting codes. The value returned does not include the terminating null character. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> performs the same function for wide characters.  
  
## Remarks  
 These functions differ from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> only in that they support the ability to specify the order in which the arguments are used. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 The versions of these functions with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  Ensure that if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a user-defined string, it is null terminated and has the correct number and type of parameters. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [vsprintf](../vs140/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md).  
  
## See Also  
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [_scprintf_p, _scprintf_p_l, _scwprintf_p, _scwprintf_p_l](../vs140/_scprintf_p--_scprintf_p_l--_scwprintf_p--_scwprintf_p_l.md)   
 [_vscprintf, _vscprintf_l, _vscwprintf, _vscwprintf_l](../vs140/_vscprintf--_vscprintf_l--_vscwprintf--_vscwprintf_l.md)