---
title: "__getmainargs, __wgetmainargs"
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
  - "__wgetmainargs"
  - "__getmainargs"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__wgetmainargs"
  - "__getmainargs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__wgetmainargs"
  - "__getmainargs"
ms.assetid: f72f54eb-9509-4bdf-8752-40fc49055439
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __getmainargs, __wgetmainargs
Invokes command-line parsing and copies the arguments to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> back through the passed pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer that contains the number of arguments that follow in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is always greater than or equal to 1.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An array of null-terminated strings representing command-line arguments entered by the user of the program. By convention, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the command with which the program is invoked, argv[1] is the first command-line argument, and so on, until argv[argc], which is always NULL. The first command-line argument is always <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the last one is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An array of strings that represent the variables set in the user's environment. This array is terminated by a NULL entry.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An integer that if set to 1 expands the wildcards in the command line arguments, or if set to 0 does nothing.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Other information to be passed to the CRT DLL.  
  
## Return Value  
 0 if successful; a negative value if unsuccessful.  
  
## Remarks  
 Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on non-wide character platforms, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on wide-character (Unicode) platforms.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|__getmainargs|internal.h|  
|__wgetmainargs|internal.h|