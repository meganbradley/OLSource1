---
title: "fgets, fgetws"
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
  - "fgets"
  - "fgetws"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fgetts"
  - "fgetws"
  - "fgets"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fgetts function"
  - "streams, getting strings from"
  - "streams, reading from"
  - "fgets function"
  - "fgetws function"
  - "fgetts function"
ms.assetid: ad549bb5-df98-4ccd-a53f-95114e60c4fc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fgets, fgetws
Get a string from a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Storage location for data.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Maximum number of characters to read.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned to indicate an error or an end-of-file condition. Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to determine whether an error occurred. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a null pointer, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is less than or equal to zero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function reads a string from the input <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument and stores it in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> reads characters from the current stream position to and including the first newline character, to the end of the stream, or until the number of characters read is equal to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> – 1, whichever comes first. The result stored in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is appended with a null character. The newline character, if read, is included in the string.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> reads the wide-character argument <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as a multibyte-character string or a wide-character string according to whether <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is opened in text mode or binary mode, respectively. For more information about using text and binary modes in Unicode and multibyte stream-I/O, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [Unicode Stream I/O in Text and Binary Modes](../vs140/unicode-stream-i-o-in-text-and-binary-modes.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_fgets.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::StreamReader::ReadLine](https://msdn.microsoft.com/en-us/library/system.io.streamreader.readline.aspx)  
  
-   [System::IO::TextReader::ReadBlock](https://msdn.microsoft.com/en-us/library/system.io.textreader.readblock.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fputs, fputws](../vs140/fputs--fputws.md)   
 [gets, _getws](../vs140/gets--_getws.md)   
 [puts, _putws](../vs140/puts--_putws.md)