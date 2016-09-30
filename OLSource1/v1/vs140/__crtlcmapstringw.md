---
title: "__crtLCMapStringW"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "__crtLCMapStringW"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__crtLCMapStringW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__crtLCMapStringW"
ms.assetid: 45b4ac0e-438c-4fa3-b4d1-34195f4467d9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __crtLCMapStringW
Maps one character string to another, performing a specified locale-dependent transformation. This function can also be used to generate a sort key for the input string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Locale identifier. The locale provides a context for the string mapping or sort key generation. An application can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro to create a locale identifier.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of transformation to be used during string mapping or sort key generation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a source string that the function maps or uses for sort key generation. This parameter is assumed to be a Unicode string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size, in characters, of the string pointed to by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter. This count can include the NULL terminator, or not include it.  
  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value of –1 specifies that the string pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is null-terminated. If this is the case, and this function is being used in its string-mapping mode, the function calculates the string's length itself, and null-terminates the mapped string stored into <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Long pointer to a buffer into which the function stores the mapped string or sort key.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Size, in characters, of the buffer pointed to by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 If the value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is nonzero, the number of characters, or bytes if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is specified, written to the buffer indicates success. This count includes room for a NULL terminator.  
  
 If the value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is zero, the size of the buffer in characters, or bytes if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is specified, required to receive the translated string or sort key indicates success. This size includes room for a NULL terminator.  
  
 Zero indicates failure. To get extended error information, call the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function.  
  
## Remarks  
 If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is greater than zero and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a null-terminated string, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the length of the string. Then <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> calls the wide string (Unicode) version of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function with the specified parameters. For more information about the parameters and return value of this function, see the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function at [MSDN Library](http://go.microsoft.com/fwlink/?linkID=150542).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|__crtLCMapStringW|awint.h|