---
title: "_dup, _dup2"
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
  - "_dup"
  - "_dup2"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_dup2"
  - "_dup"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_dup2 function"
  - "dup function"
  - "file handles [C++], duplicating"
  - "file handles [C++], reassigning"
  - "dup2 function"
  - "_dup function"
ms.assetid: 4d07e92c-0d76-4832-a770-dfec0e7a0cfa
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _dup, _dup2
Creates a second file descriptor for an open file (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>), or reassigns a file descriptor (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 File descriptors referring to open file.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Any file descriptor.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a new file descriptor. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns 0 to indicate success. If an error occurs, each function returns –1 and sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the file descriptor is invalid or to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if no more file descriptors are available. In the case of an invalid file descriptor, the function also invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions associate a second file descriptor with a currently open file. These functions can be used to associate a predefined file descriptor, such as that for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, with a different file. Operations on the file can be carried out using either file descriptor. The type of access allowed for the file is unaffected by the creation of a new descriptor. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns the next available file descriptor for the given file. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> forces <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to refer to the same file as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is associated with an open file at the time of the call, that file is closed.  
  
 Both <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> accept file descriptors as parameters. To pass a stream <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to either of these functions, use [_fileno](../vs140/_fileno.md). The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> routine returns the file descriptor currently associated with the given stream. The following example shows how to associate <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (defined as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in Stdio.h) with a file descriptor:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<io.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<io.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **This goes to stdout first**  
**This goes to stdout**  
**The file 'data' contains:**  
**This goes to file 'data'**   
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)