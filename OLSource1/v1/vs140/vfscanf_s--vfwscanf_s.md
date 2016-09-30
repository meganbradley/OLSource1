---
title: "vfscanf_s, vfwscanf_s"
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
  - "vfscanf_s"
  - "vfwscanf_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vfscanf_s"
  - "vfwscanf_s"
  - "_vftscanf_s"
dev_langs: 
  - "C++"
  - "C"
ms.assetid: 9b0133f0-9a18-4581-b24b-3b72683ad432
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vfscanf_s, vfwscanf_s
Reads formatted data from a stream. These versions of vfscanf, vfwscanf have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Variable argument list.  
  
## Return Value  
 Each of these functions returns the number of fields that are successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. If an error occurs, or if the end of the file stream is reached before the first conversion, the return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an invalid file pointer, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function reads data from the current position of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> into the locations that are given by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument list (if any). Each argument in the list must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md) for a description of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; the format argument to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> doesn't currently support input from a UNICODE stream.  
  
 The main difference between the more secure functions (that have the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> suffix) and the other versions is that the more secure functions require the size in characters of each <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> type field to be passed as an argument immediately following the variable. For more information, see [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md) and [scanf Width Specification](../vs140/scanf-width-specification.md).  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **a-string**  
**65000**  
**3.141590**  
**x**   
## .NET Framework Equivalent  
 [System::IO::StreamReader::ReadLine](https://msdn.microsoft.com/en-us/library/system.io.streamreader.readline.aspx). See also <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_cscanf_s, _cwscanf_s](../vs140/_cscanf_s--_cscanf_s_l--_cwscanf_s--_cwscanf_s_l.md)   
 [fprintf_s, fwprintf_s](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)   
 [fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [vfscanf, vfwscanf](../vs140/vfscanf--vfwscanf.md)