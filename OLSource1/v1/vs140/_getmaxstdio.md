---
title: "_getmaxstdio"
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
  - "_getmaxstdio"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getmaxstdio"
  - "getmaxstdio"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], number open"
  - "_getmaxstdio function"
  - "getmaxstdio function"
  - "open files, getting number"
ms.assetid: 700ca8ce-4a8c-4e00-9467-dfa9d6b831a0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getmaxstdio
Returns the number of simultaneously open files permitted at the stream I/O level.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a number that represents the number of simultaneously open files currently permitted at the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> level.  
  
## Remarks  
 Use [_setmaxstdio](../vs140/_setmaxstdio.md) to configure the number of simultaneously open files permitted at the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> level.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **512**  
**2048**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)