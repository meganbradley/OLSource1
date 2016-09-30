---
title: "_pipe"
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
  - "_pipe"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "pipe"
  - "_pipe"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pipes, creating"
  - "_pipe function"
  - "pipes"
  - "pipe function"
ms.assetid: 8d3e9800-4041-44b5-9e93-2df0b0354a75
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _pipe
Creates a pipe for reading and writing.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[2]  
 Array to hold read and write file descriptors.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Amount of memory to reserve.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 File mode.  
  
## Return Value  
 Returns 0 if successful. Returns –1 to indicate an error. On error, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to one of these values:  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which indicates that no more file descriptors are available.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which indicates a system-file-table overflow.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which indicates that either the array <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a null pointer or that an invalid value for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> was passed in.  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function creates a *pipe*, which is an artificial I/O channel that a program uses to pass information to other programs. A pipe resembles a file because it has a file pointer, a file descriptor, or both, and it can be read from or written to by using the Standard Library input and output functions. However, a pipe does not represent a specific file or device. Instead, it represents temporary storage in memory that is independent of the program's own memory and is controlled entirely by the operating system.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> resembles <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> but opens the pipe for reading and writing and returns two file descriptors instead of one. The program can use both sides of the pipe or close the one that it doesn't need. For example, the command processor in Windows creates a pipe when it executes a command such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The standard output descriptor of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is attached to the pipe's write descriptor. The standard input descriptor of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is attached to the pipe's read descriptor. This eliminates the need to create temporary files to pass information to other programs.  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function returns two file descriptors to the pipe in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument. The element <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>[0] contains the read descriptor, and the element <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>[1] contains the write descriptor. Pipe file descriptors are used in the same way as other file descriptors. (The low-level input and output functions <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> can read from and write to a pipe.) To detect the end-of-pipe condition, check for a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> request that returns 0 as the number of bytes read.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> argument specifies the amount of memory, in bytes, to reserve for the pipe. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> argument specifies the translation mode for the pipe. The manifest constant <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> specifies a text translation, and the constant <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> specifies binary translation. (See [fopen, _wfopen](../vs140/fopen--_wfopen.md) for a description of text and binary modes.) If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument is 0, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> uses the default translation mode that's specified by the default-mode variable [_fmode](../vs140/_fmode.md).  
  
 In multithreaded programs, no locking is performed. The file descriptors that are returned are newly opened and should not be referenced by any thread until after the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> call is complete.  
  
 To use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> function to communicate between a parent process and a child process, each process must have only one descriptor open on the pipe. The descriptors must be opposites: if the parent has a read descriptor open, then the child must have a write descriptor open. The easiest way to do this is to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> flag with <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. Then, use <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to create an inheritable copy of the pipe descriptor that you want to pass to the child. Close the original descriptor, and then spawn the child process. On returning from the spawn call, close the duplicate descriptor in the parent process. For more information, see example 2 later in this article.  
  
 In the Windows operating system, a pipe is destroyed when all of its descriptors have been closed. (If all read descriptors on the pipe have been closed, then writing to the pipe causes an error.) All read and write operations on the pipe wait until there is enough data or enough buffer space to complete the I/O request.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|\<io.h>|\<fcntl.h>,1 \<errno.h>2|  
  
 1 For <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> definitions.  
  
 2 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> definitions.  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example 1  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example 2  
 This is a basic filter application. It spawns the application crt_pipe_beeper after it creates a pipe that directs the spawned application's stdout to the filter. The filter removes ASCII 7 (beep) characters.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The actual filter application:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)