---
title: "_rmtmp"
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
  - "_rmtmp"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "rmtmp"
  - "_rmtmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "removing temporary files"
  - "_rmtmp function"
  - "files [C++], temporary"
  - "rmtmp function"
  - "files [C++], removing"
  - "temporary files [C++], removing"
ms.assetid: 7419501e-2587-4f2a-b469-0dca07f84736
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _rmtmp
Removes temporary files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns the number of temporary files closed and deleted.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function cleans up all temporary files in the current directory. The function removes only those files created by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; use it only in the same directory in which the temporary files were created.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 See the example for [tmpfile](../vs140/tmpfile.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_flushall](../vs140/_flushall.md)   
 [tmpfile](../vs140/tmpfile.md)   
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)