---
title: "gets, _getws"
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
  - "_getws"
  - "gets"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getts"
  - "gets"
  - "_getws"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "getws function"
  - "getts function"
  - "_getws function"
  - "lines, getting"
  - "streams, getting lines"
  - "_getts function"
  - "gets function"
  - "standard input, reading from"
ms.assetid: 1ec2dd4b-f801-48ea-97c2-892590f16024
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# gets, _getws
Gets a line from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> stream. More secure versions of these functions are available; see [gets_s, _getws_s](../vs140/gets_s--_getws_s.md).  
  
> [!IMPORTANT]
>  These functions are obsolete. Beginning in Visual Studio 2015, they are not available in the CRT. The secure versions of these functions,  gets_s and _getws_s, are still available. For information on these alternative functions, see [gets_s, _getws_s](../vs140/gets_s--_getws_s.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Storage location for input string.  
  
## Return Value  
 Returns its argument if successful. A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer indicates an error or end-of-file condition. Use [ferror](../vs140/ferror.md) or [feof](../vs140/feof.md) to determine which one has occurred. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and set errno to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function reads a line from the standard input stream <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and stores it in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The line consists of all characters up to and including the first newline character ('\n'). <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> then replaces the newline character with a null character ('\0') before returning the line. In contrast, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function retains the newline character. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; its argument and return value are wide-character strings.  
  
> [!IMPORTANT]
>  Because there is no way to limit the number of characters read by gets, untrusted input can easily cause buffer overruns. Use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instead.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that input longer than 20 characters will overrun the line buffer and almost certainly cause the program to crash.  
  
  **<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>The line entered was: Hello there!**   
## .NET Framework Equivalent  
 [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fgets, fgetws](../vs140/fgets--fgetws.md)   
 [fputs, fputws](../vs140/fputs--fputws.md)   
 [puts, _putws](../vs140/puts--_putws.md)