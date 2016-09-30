---
title: "_vscprintf, _vscprintf_l, _vscwprintf, _vscwprintf_l"
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
  - "_vscprintf"
  - "_vscprintf_l"
  - "_vscwprintf_l"
  - "_vscwprintf"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vscprintf_l"
  - "vscwpeintf"
  - "_vscwprintf"
  - "_vsctprintf"
  - "_vscprintf"
  - "vscwprintf_l"
  - "vscprintf"
  - "_vscwprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vsctprintf function"
  - "_vscprintf_l function"
  - "_vsctprintf_l function"
  - "_vsctprintf function"
  - "_vscwprintf_l function"
  - "vscwprintf_l function"
  - "_vscprintf function"
  - "_vscwprintf function"
  - "vscwprintf function"
  - "vsctprintf_l function"
  - "formatted text [C++]"
  - "vscprintf function"
  - "vscprintf_l function"
ms.assetid: 1bc67d3d-21d5-49c9-ac8d-69e26b16a3c3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _vscprintf, _vscprintf_l, _vscwprintf, _vscwprintf_l
Returns the number of characters in the formatted string using a pointer to a list of arguments.  
  
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
  
 The versions of these functions with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 Each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (if any) is converted according to the corresponding format specification in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The format consists of ordinary characters and has the same form and function as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument for [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
> [!IMPORTANT]
>  Ensure that if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a user-defined string, it is null terminated and has the correct number and type of parameters. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [vsprintf](../vs140/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, _scanf_l, wscanf, _wscanf_l](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, _sscanf_l, swscanf, _swscanf_l](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)