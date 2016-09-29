---
title: "vprintf Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vprintf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vprintf function"
  - "formatted text [C++]"
ms.assetid: 02ac7c51-eab1-4bf0-bf4c-77065e3fa744
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vprintf Functions
Each of the `vprintf` functions takes a pointer to an argument list, then formats and writes the given data to a particular destination. The functions differ in the parameter validation performed, whether the functions take wide or single-byte character strings, the output destination, and the support for specifying the order in which parameters are used in the format string.  
  
|||  
|-|-|  
|[_vcprintf, _vcwprintf](../VS_csharp/_vcprintf--_vcprintf_l--_vcwprintf--_vcwprintf_l.md)|[vfprintf, vfwprintf](../VS_csharp/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)|  
|[vfprintf_p, vfwprintf_p](../VS_csharp/_vfprintf_p--_vfprintf_p_l--_vfwprintf_p--_vfwprintf_p_l.md)|[vfprintf_s, vfwprintf_s](../VS_csharp/vfprintf_s--_vfprintf_s_l--vfwprintf_s--_vfwprintf_s_l.md)|  
|[vprintf, vwprintf](../VS_csharp/vprintf--_vprintf_l--vwprintf--_vwprintf_l.md)|[vprintf_p, vwprintf_p](../VS_csharp/_vprintf_p--_vprintf_p_l--_vwprintf_p--_vwprintf_p_l.md)|  
|[vprintf_s, vwprintf_s](../VS_csharp/vprintf_s--_vprintf_s_l--vwprintf_s--_vwprintf_s_l.md)|[vsprintf, vswprintf](../VS_csharp/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md)|  
|[vsprintf_p, vswprintf_p](../VS_csharp/_vsprintf_p--_vsprintf_p_l--_vswprintf_p--_vswprintf_p_l.md)|[vsprintf_s, vswprintf_s](../VS_csharp/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md)|  
|[_vscprintf, _vscwprintf](../VS_csharp/_vscprintf--_vscprintf_l--_vscwprintf--_vscwprintf_l.md)|[_vsnprintf, _vsnwprintf](../VS_csharp/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md)|  
  
## Remarks  
 The `vprintf` functions are similar to their counterpart functions as listed in the following table. However, each `vprintf` function accepts a pointer to an argument list, whereas each of the counterpart functions accepts an argument list.  
  
 These functions format data for output to destinations as follows.  
  
|Function|Counterpart function|Output destination|Parameter Validation|Positional Parameter Support|  
|--------------|--------------------------|------------------------|--------------------------|----------------------------------|  
|`_vcprintf`|[_cprintf](../VS_csharp/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)|console|Check for null.|no|  
|`_vcwprintf`|[_cwprintf](../VS_csharp/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)|console|Check for null.|no|  
|`vfprintf`|[fprintf](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|*Stream*|Check for null.|no|  
|**vfprintf_p**|[fprintf_p](../VS_csharp/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)|*Stream*|Check for null and valid format.|yes|  
|`vfprintf_s`|[fprintf_s](../VS_csharp/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)|*Stream*|Check for null and valid format.|no|  
|`vfwprintf`|[fwprintf](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|*Stream*|Check for null.|no|  
|**vfwprintf_p**|[fwprintf_p](../VS_csharp/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)|*Stream*|Check for null and valid format.|yes|  
|`vfwprintf_s`|[fwprintf_s](../VS_csharp/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)|*Stream*|Check for null and valid format.|no|  
|`vprintf`|[printf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)|`Stdout`|Check for null.|no|  
|**vprintf_p**|[printf_p](../VS_csharp/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)|`Stdout`|Check for null and valid format.|yes|  
|`vprintf_s`|[printf_s](../VS_csharp/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)|`Stdout`|Check for null and valid format.|no|  
|`vwprintf`|[wprintf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)|`Stdout`|Check for null.|no|  
|**vwprintf_p**|[wprintf_p](../VS_csharp/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)|`Stdout`|Check for null and valid format.|yes|  
|`vwprintf_s`|[wprintf_s](../VS_csharp/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)|`Stdout`|Check for null and valid format.|no|  
|**vsprintf**|[sprintf](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
|**vsprintf_p**|[sprintf_p](../VS_csharp/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)|memory pointed to by *buffer*|Check for null and valid format.|yes|  
|`vsprintf_s`|[sprintf_s](../VS_csharp/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)|memory pointed to by *buffer*|Check for null and valid format.|no|  
|`vswprintf`|[swprintf](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
|**vswprintf_p**|[swprintf_p](../VS_csharp/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)|memory pointed to by *buffer*|Check for null and valid format.|yes|  
|`vswprintf_s`|[swprintf_s](../VS_csharp/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)|memory pointed to by *buffer*|Check for null and valid format.|no|  
|`_vscprintf`|[_vscprintf](../VS_csharp/_vscprintf--_vscprintf_l--_vscwprintf--_vscwprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
|`_vscwprintf`|[_vscwprintf](../VS_csharp/_vscprintf--_vscprintf_l--_vscwprintf--_vscwprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
|`_vsnprintf`|[_snprintf](../VS_csharp/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
|`_vsnwprintf`|[_snwprintf](../VS_csharp/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)|memory pointed to by *buffer*|Check for null.|no|  
  
 The `argptr` argument has type `va_list`, which is defined in VARARGS.H and STDARG.H. The `argptr` variable must be initialized by **va_start,** and may be reinitialized by subsequent `va_arg` calls; `argptr` then points to the beginning of a list of arguments that are converted and transmitted for output according to the corresponding specifications in the *format* argument. *format* has the same form and function as the *format* argument for [printf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md). None of these functions invokes `va_end`. For a more complete description of each `vprintf` function, see the description of its counterpart function as listed in the preceding table.  
  
 `_vsnprintf` differs from **vsprintf** in that it writes no more than *count* bytes to *buffer*.  
  
 The versions of these functions with the **w** infix in the name are wide-character versions of the corresponding functions without the **w** infix; in each of these wide-character functions, *buffer* and *format* are wide-character strings. Otherwise, each wide-character function behaves identically to its SBCS counterpart function.  
  
 The versions of these functions with **_s** and **_p** suffixes are the more secure versions. These versions validate the format strings and will generate an exception if the format string is not well formed (for example, if invalid formatting characters are used).  
  
 The versions of these functions with the **_p** suffix provide the ability to specify the order in which the supplied arguments are substituted in the format string. For more information, see [printf_p Positional Parameters](../VS_csharp/printf_p-positional-parameters.md).  
  
 For **vsprintf**, `vswprintf`, `_vsnprintf` and `_vsnwprintf`, if copying occurs between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  Ensure that *format* is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795). If using the secure versions of these functions (either the **_s** or **_p** suffixes), a user-supplied format string could trigger an invalid parameter exception if the user-supplied string contains invalid formatting characters.  
  
## See Also  
 [Stream I/O](../VS_csharp/stream-i-o.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../VS_csharp/va_arg--va_copy--va_end--va_start.md)