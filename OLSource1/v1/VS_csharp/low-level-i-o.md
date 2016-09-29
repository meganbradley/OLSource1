---
title: "Low-Level I-O"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Low-Level I/O"
f1_keywords: 
  - "c.io"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "I/O [CRT], low-level"
  - "I/O [CRT], functions"
  - "low-level I/O routines"
  - "file handles [C++]"
  - "file handles [C++], I/O functions"
ms.assetid: 53e11bdd-6720-481c-8b2b-3a3a569ed534
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Low-Level I-O
These functions invoke the operating system directly for lower-level operation than that provided by stream I/O. Low-level input and output calls do not buffer or format data.  
  
 Low-level routines can access the standard streams opened at program startup using the following predefined file descriptors.  
  
|Stream|File Descriptor|  
|------------|---------------------|  
|`stdin`|0|  
|`stdout`|1|  
|`stderr`|2|  
  
 Low-level I/O routines set the [errno](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) global variable when an error occurs. You must include STDIO.H when you use low-level functions only if your program requires a constant that is defined in STDIO.H, such as the end-of-file indicator (`EOF`).  
  
### Low-Level I/O Functions  
  
|Function|Use|  
|--------------|---------|  
|[_close](../VS_csharp/_close.md)|Close file|  
|[_commit](../VS_csharp/_commit.md)|Flush file to disk|  
|[_creat, _wcreat](../VS_csharp/_creat--_wcreat.md)|Create file|  
|[_dup](../VS_csharp/_dup--_dup2.md)|Return next available file descriptor for given file|  
|[_dup2](../VS_csharp/_dup--_dup2.md)|Create second descriptor for given file|  
|[_eof](../VS_csharp/_eof.md)|Test for end of file|  
|[_lseek, _lseeki64](../VS_csharp/_lseek--_lseeki64.md)|Reposition file pointer to given location|  
|[_open, _wopen](../VS_csharp/_open--_wopen.md)|Open file|  
|[_read](../VS_csharp/_read.md)|Read data from file|  
|[_sopen, _wsopen](../VS_csharp/_sopen--_wsopen.md), [_sopen_s, _wsopen_s](../VS_csharp/_sopen_s--_wsopen_s.md)|Open file for file sharing|  
|[_tell, _telli64](../VS_csharp/_tell--_telli64.md)|Get current file-pointer position|  
|[_umask](../VS_csharp/_umask.md), [_umask_s](../VS_csharp/_umask_s.md)|Set file-permission mask|  
|[_write](../VS_csharp/_write.md)|Write data to file|  
  
 `_dup` and `_dup2` are typically used to associate the predefined file descriptors with different files.  
  
## See Also  
 [Input and Output](../VS_csharp/input-and-output.md)   
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)   
 [System Calls](../VS_csharp/system-calls.md)