---
title: "_cscanf_s, _cscanf_s_l, _cwscanf_s, _cwscanf_s_l"
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
  - "_cwscanf_s_l"
  - "_cwscanf_s"
  - "_cscanf_s"
  - "_cscanf_s_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cscanf_s"
  - "cscanf_s_l"
  - "cwscanf_s"
  - "_cwscanf_s"
  - "_tcscanf_s"
  - "_cscanf_s"
  - "_cwscanf_s_l"
  - "_cscanf_s_l"
  - "cwscanf_s_l"
  - "_tcscanf_s_l"
  - "tcscanf_s"
  - "tcscanf_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cscanf_s function"
  - "_cwscanf_s_l function"
  - "tcscanf_s function"
  - "console [C++], reading from"
  - "_cscanf_s function"
  - "data [C++], reading from the console"
  - "cwscanf_s function"
  - "_tcscanf_s_l function"
  - "_cscanf_s_l function"
  - "cscanf_s_l function"
  - "cwscanf_s_l function"
  - "reading data [C++], from the console"
  - "_cwscanf_s function"
  - "_tcscanf_s function"
  - "tcscanf_s_l function"
ms.assetid: 9ccab74d-916f-42a6-93d8-920525efdf4b
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cscanf_s, _cscanf_s_l, _cwscanf_s, _cwscanf_s_l
Reads formatted data from the console. These more secure versions of [_cscanf, _cscanf_l, _cwscanf, _cwscanf_l](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional parameters.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 The number of fields that were successfully converted and assigned. The return value does not include fields that were read but not assigned. The return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for an attempt to read at end of file. This can occur when keyboard input is redirected at the operating-system command-line level. A return value of 0 means that no fields were assigned.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function reads data directly from the console into the locations given by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The [_getche](../vs140/_getch--_getwch.md) function is used to read characters. Each optional parameter must be a pointer to a variable with a type that corresponds to a type specifier in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The format controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter for the [scanf_s](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) function. While <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> normally echoes the input character, it does not do so if the last call was to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 Like other secure versions of functions in the<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> family,<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> require size arguments for the type field characters <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For more information, see [scanf Width Specification](../vs140/scanf-width-specification.md).  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The versions of these functions with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [fscanf_s, fwscanf_s](../vs140/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)