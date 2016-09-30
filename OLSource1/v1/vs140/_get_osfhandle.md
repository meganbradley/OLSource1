---
title: "_get_osfhandle"
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
  - "_get_osfhandle"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "get_osfhandle"
  - "_get_osfhandle"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "operating systems, getting file handles"
  - "get_osfhandle function"
  - "_get_osfhandle function"
  - "file handles [C++], operating system"
ms.assetid: 0bdd728a-4fd8-410b-8c9f-01a121135196
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_osfhandle
Retrieves the operating-system file handle that is associated with the specified file descriptor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An existing file descriptor.  
  
## Return Value  
 An operating-system file handle if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is valid. Otherwise, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (–1) and sets <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, indicating an invalid file handle.  
  
## Remarks  
 To close a file opened with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The underlying handle is also closed by a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, so it is not necessary to call the Win32 function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on the original handle.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<io.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_dup, _dup2](../vs140/_dup--_dup2.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)