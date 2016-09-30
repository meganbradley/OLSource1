---
title: "fputs, fputws"
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
  - "fputs"
  - "fputws"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fputs"
  - "fputws"
  - "_fputts"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, writing strings to"
  - "fputws function"
  - "_fputts function"
  - "fputs function"
  - "fputts function"
ms.assetid: d48c82b8-aa17-4830-8c7d-30442ddbb326
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fputs, fputws
Writes a string to a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Output string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns a nonnegative value if it is successful. On an error, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and then <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 Each of these functions copies <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the output <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> at the current position. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> copies the wide-character argument <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> as a multibyte-character string or a wide-character string according to whether <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is opened in text mode or binary mode, respectively. Neither function copies the terminating null character.  
  
 The two functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not currently support output into a UNICODE stream.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Hello world from fputs.**   
## .NET Framework Equivalent  
 [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fgets, fgetws](../vs140/fgets--fgetws.md)   
 [gets, _getws](../vs140/gets--_getws.md)   
 [puts, _putws](../vs140/puts--_putws.md)