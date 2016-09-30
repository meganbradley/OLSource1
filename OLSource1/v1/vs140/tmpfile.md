---
title: "tmpfile"
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
  - "tmpfile"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tmpfile"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "temporary files"
  - "tmpfile function"
  - "temporary files, creating"
ms.assetid: c4a4dc24-70da-438d-ae4e-98352d88e375
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tmpfile
Creates a temporary file. This function is deprecated because a more secure version is available; see [tmpfile_s](../vs140/tmpfile_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a stream pointer. Otherwise, it returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function creates a temporary file and returns a pointer to that stream. The temporary file is created in the root directory. To create a temporary file in a directory other than the root, use [tmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md) or [tempnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md) in conjunction with [fopen](../vs140/fopen--_wfopen.md).  
  
 If the file cannot be opened, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer. This temporary file is automatically deleted when the file is closed, when the program terminates normally, or when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called, assuming that the current working directory does not change. The temporary file is opened in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (binary read/write) mode.  
  
 Failure can occur if you attempt more than TMP_MAX (see STDIO.H) calls with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
> [!NOTE]
>  This example requires administrative privileges to run on Windows Vista.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Temporary file 1 was created**  
**Temporary file 2 was created**  
**Temporary file 3 was created**  
**3 temporary files deleted**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_rmtmp](../vs140/_rmtmp.md)   
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)