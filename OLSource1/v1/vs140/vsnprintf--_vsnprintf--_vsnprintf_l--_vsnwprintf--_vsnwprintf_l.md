---
title: "vsnprintf, _vsnprintf, _vsnprintf_l, _vsnwprintf, _vsnwprintf_l"
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
  - "_vsnprintf"
  - "_vsnprintf_l"
  - "_vsnwprintf"
  - "_vsnwprintf_l"
  - "_vsnprintf"
  - "_vsnprintf;"
  - "vsnprintf; _vsnprintf"
  - "_vsnwprintf;"
  - "_vsnprintf_l;"
  - "_vsnwprintf_l;"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "_vsnprintf"
  - "_vsnwprintf"
  - "_vsntprintf"
  - "vsnprintf"
  - "stdio/vsnprintf"
  - "stdio/_vsnprintf"
  - "stdio/_vsnprintf_l"
  - "stdio/_vsnwprintf"
  - "stdio/_vsnwprintf_l"
  - "_vsnprintf_l"
  - "_vsnwprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vsntprintf function"
  - "_vsnwprintf_l function"
  - "vsnwprintf_l function"
  - "vsntprintf_l function"
  - "_vsntprintf function"
  - "_vsnprintf_l function"
  - "vsnprintf function"
  - "_vsntprintf_l function"
  - "vsnprintf_l function"
  - "_vsnwprintf function"
  - "_vsnprintf function"
  - "formatted text [C++]"
  - "vsnwprintf function"
ms.assetid: a97f92df-c2f8-4ea0-9269-76920d2d566a
caps.latest.revision: 37
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# vsnprintf, _vsnprintf, _vsnprintf_l, _vsnwprintf, _vsnwprintf_l
Write formatted output using a pointer to a list of arguments. More secure versions of these functions are available; see [vsnprintf_s, _vsnprintf_s, _vsnprintf_s_l, _vsnwprintf_s, _vsnwprintf_s_l](../vs140/vsnprintf_s--_vsnprintf_s--_vsnprintf_s_l--_vsnwprintf_s--_vsnwprintf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Storage location for output.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Maximum number of characters to write.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function returns the number of characters written, not counting the terminating null character. If the buffer size specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not sufficiently large to contain the output specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the return value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the number of characters that would be written, not counting the null character, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> were sufficiently large. If the return value is greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> - 1, the output has been truncated. A return value of -1 indicates that an encoding error has occurred.  
  
 Both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions return the number of characters written if the number of characters to write is less than or equal to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; if the number of characters to write is greater than <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, these functions return -1 indicating that output has been truncated.  
  
 The value returned by all these functions does not include the terminating null, whether one is written or not. When <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is zero, the value returned is the number of characters the functions would write, not including any terminating null. You can use this result to allocate sufficient buffer space for the string and its terminating null, and then call the function again to fill the buffer.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is NULL and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not equal to zero, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, then formats the data, and writes up to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> characters  to the memory pointed to by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function always writes a null terminator, even if it truncates the output. When using <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the buffer will be null-terminated only if there is room at the end (that is, if the number of characters to write is less than <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>).  
  
> [!IMPORTANT]
>  To prevent certain kinds of security risks, ensure that <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
> [!NOTE]
>  To ensure that there is room for the terminating null when calling <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, be sure that <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is strictly less than the buffer length and initialize the buffer to null prior to calling the function.  
>   
>  Because <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> always writes the terminating null, the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter may be equal to the size of the buffer.  
  
 Beginning with the UCRT in Visual Studio 2015 and Windows 10,         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is no longer identical to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function complies with the C99 standard; <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is retained for backward compatibility with older Visual Studio code.  
  
 The versions of these functions with the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header (C)|Required header (C++)|  
|-------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|\<stdio.h>|\<stdio.h> or  \<cstdio>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|\<stdio.h>, \<wchar.h>, \<cstdio>, or \<cwchar>|  
  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> functions are Microsoft specific. For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **nSize: 8, buff: Hi there**  
**nSize: 9, buff: Hi there!**  
**nSize: -1, buff: Hi there!** The behavior changes if you use vsnprintf instead, along with narrow-string parameters. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter can be the entire size of the buffer, and the return value is the number of characters that would have been written if <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> was large enough:  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **nSize: 8, buff: Hi there**  
**nSize: 9, buff: Hi there!**  
**nSize: 10, buff: Hi there!**   
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)