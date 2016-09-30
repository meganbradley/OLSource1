---
title: "fscanf, _fscanf_l, fwscanf, _fwscanf_l"
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
  - "fscanf"
  - "_fwscanf_l"
  - "_fscanf_l"
  - "fwscanf"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fscanf"
  - "fwscanf"
  - "_ftscanf_l"
  - "_fwscanf_l"
  - "_ftscanf"
  - "_fscanf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fscanf function"
  - "fwscanf function"
  - "formatted data [C++], reading from streams"
  - "ftscanf_l function"
  - "_ftscanf_l function"
  - "_fwscanf_l function"
  - "data [CRT], reading from streams"
  - "_fscanf_l function"
  - "ftscanf function"
  - "fscanf_l function"
  - "streams [C++], reading formatted data from"
  - "_ftscanf function"
  - "fwscanf_l function"
ms.assetid: 9004e978-6c5f-4bb2-98fd-51e5948933f2
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fscanf, _fscanf_l, fwscanf, _fwscanf_l
Read formatted data from a stream. More secure versions of these functions are available; see [fscanf_s, _fscanf_s_l, fwscanf_s, _fwscanf_s_l](../vs140/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these functions returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. If an error occurs, or if the end of the file stream is reached before the first conversion, the return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function reads data from the current position of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> into the locations given by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (if any). Each <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>; see [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) for a description of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>*.*  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; the format argument to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> doesn't currently support input from a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specification Fields – scanf functions and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **a-string**  
**65000**  
**3.141590**  
**x**   
## .NET Framework Equivalent  
 [System::IO::StreamReader::ReadLine](https://msdn.microsoft.com/en-us/library/system.io.streamreader.readline.aspx). See also <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [fscanf_s, fwscanf_s](../vs140/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md)