---
title: "_pgmptr, _wpgmptr"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "pgmptr"
  - "_pgmptr"
  - "wpgmptr"
  - "_wpgmptr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wpgmptr function"
  - "_wpgmptr function"
  - "_pgmptr function"
  - "pgmptr function"
ms.assetid: 4d44b515-0eff-4136-8bc4-684195f218f5
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _pgmptr, _wpgmptr
The path of the executable file. Deprecated; use [_get_pgmptr](../vs140/_get_pgmptr.md) and [_get_wpgmptr](../vs140/_get_wpgmptr.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When a program is run from the command interpreter (Cmd.exe), <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is automatically initialized to the full path of the executable file. For example, if Hello.exe is in C:\BIN and C:\BIN is in the path, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to C:\BIN\Hello.exe when you execute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When a program is not run from the command line, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> might be initialized to the program name (the file's base name without the file name extension) or to a file name, relative path, or full path.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the wide-character counterpart of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for use with programs that use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Variable|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
 The following program demonstrates the use of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You could use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> by changing <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)