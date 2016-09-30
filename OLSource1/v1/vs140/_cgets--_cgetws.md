---
title: "_cgets, _cgetws"
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
  - "_cgetws"
  - "_cgets"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cgetws"
  - "_cgetws"
  - "_cgets"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_cgetws function"
  - "strings [C++], getting from console"
  - "console, getting strings from"
  - "_cgets function"
  - "cgetws function"
  - "cgets function"
ms.assetid: 4d5e134a-58c3-4f62-befd-5d235b0212f4
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cgets, _cgetws
Gets a character string from the console. More secure versions of these functions are available; see [_cgets_s, _cgetws_s](../vs140/_cgets_s--_cgetws_s.md).  
  
> [!IMPORTANT]
>  These functions are obsolete. Beginning in Visual Studio 2015, they are not available in the CRT. The secure versions of these functions,  _cgets_s and _cgetws_s, are still available. For information on these alternative functions, see [_cgets_s, _cgetws_s](../vs140/_cgets_s--_cgetws_s.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for data.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> return a pointer to the start of the string, at <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, they return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 These functions read a string of characters from the console and store the string and its length in the location pointed to by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter must be a pointer to a character array. The first element of the array, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, must contain the maximum length (in characters) of the string to be read. The array must contain enough elements to hold the string, a terminating null character ('\0'), and 2 additional bytes. The function reads characters until a carriage return–line feed (CR-LF) combination or the specified number of characters is read. The string is stored starting at <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If the function reads a CR-LF, it stores the null character ('\0'). The function then stores the actual length of the string in the second array element, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 Because all editing keys are active when <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is called while in a console window, pressing the F3 key repeats the last entered entry.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Input line of text, followed by carriage return:**  
**Line Length = 16**  
**Text = A line of input.**   
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_getch, _getwch](../vs140/_getch--_getwch.md)