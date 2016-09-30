---
title: "__argc, __argv, __wargv"
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
  - "__wargv"
  - "__argv"
  - "__argc"
apilocation: 
  - "msvcrt120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__argv"
  - "__argc"
  - "__wargv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__argv"
  - "__wargv"
  - "__argc"
ms.assetid: 17001b0a-04ad-4762-b3a6-c54847f02d7c
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __argc, __argv, __wargv
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> global variable is a count of the number of command-line arguments passed to the program. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a pointer to an array of single-byte-character or multi-byte-character strings that contain the program arguments, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a pointer to an array of wide-character strings that contain the program arguments. These global variables provide the arguments to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In a program that uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function,  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are initialized at program startup by using the command line that's used to start the program. The command line is parsed into individual arguments, and wildcards are expanded. The count of arguments is assigned to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the argument strings are allocated on the heap, and a pointer to the array of arguments is assigned to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. In a program compiled to use wide characters and a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, the arguments are parsed and wildcards are expanded as wide-character strings, and a pointer to the array of argument strings is assigned to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For portable code, we recommend you use the arguments passed to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to get the command-line arguments in your program.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE not defined|_UNICODE defined|  
|---------------------|---------------------------|-----------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Global variable|Required header|  
|---------------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<stdlib.h>, \<cstdlib> (C++)|  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are Microsoft extensions. For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)   
 [main: Program Startup](../vs140/main--program-startup.md)   
 [Using wmain Instead of main](../vs140/using-wmain-instead-of-main.md)