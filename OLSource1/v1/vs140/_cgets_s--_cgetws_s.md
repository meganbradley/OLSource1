---
title: "_cgets_s, _cgetws_s"
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
  - "_cgetws_s"
  - "_cgets_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cgets_s"
  - "cgets_s"
  - "cgetws_s"
  - "_cgetws_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], getting from console"
  - "console, getting strings from"
  - "_cgets_s function"
  - "cget_s function"
  - "_cgetws_s function"
  - "cgetws_s function"
ms.assetid: 38b74897-afe6-4dd9-a43f-36a3c0d72c5c
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cgets_s, _cgetws_s
Gets a character string from the console. These versions of [_cgets and _cgetws](../vs140/_cgets--_cgetws.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Storage location for data.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the buffer in single-byte or wide characters, which is also the maximum number of characters to be read.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of characters actually read.  
  
## Return Value  
 The return value is zero if successful; otherwise, an error code if a failure occurs.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Return|Contents of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|--------------|------------------------|-----------------|------------|--------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|n/a|  
|not <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|zero|any|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|not modified|  
|not <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|zero-length string|  
  
## Remarks  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> read a string from the console and copy the string (with a null terminator) into <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is the wide character version of the function; other than the character size, the behavior of these two functions is identical. The maximum size of the string to be read is passed in as the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter. This size should include an extra character for the terminating null. The actual number of characters read is placed in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 If an error occurs during the operation or in the validating of the parameters, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is returned.  
  
 In C++, the use of these functions is simplified by template overloads; the overloads can infer buffer length automatically, thereby eliminating the need to specify a size argument, and they can automatically replace older, less-secure functions with their newer, more secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_getch, _getwch](../vs140/_getch--_getwch.md)