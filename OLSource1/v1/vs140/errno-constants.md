---
title: "errno Constants"
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
  - "ENOEXEC"
  - "ENOMEM"
  - "E2BIG"
  - "STRUNCATE"
  - "ENOENT"
  - "EMFILE"
  - "EBADF"
  - "EDEADLOCK"
  - "EXDEV"
  - "EILSEQ"
  - "EINVAL"
  - "EDOM"
  - "EACCES"
  - "ERANGE"
  - "ENOSPC"
  - "EAGAIN"
  - "EEXIST"
  - "ECHILD"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ENOEXEC constant"
  - "EBADF constant"
  - "EAGAIN constant"
  - "EINVAL constant"
  - "ENOENT constant"
  - "errno constants"
  - "E2BIG constant"
  - "EMFILE constant"
  - "EDEADLOCK constant"
  - "ENOSPC constant"
  - "EDOM constant"
  - "ENOMEM constant"
  - "EACCES constant"
  - "EEXIST constant"
  - "STRUNCATE constant"
  - "ERANGE constant"
  - "ECHILD constant"
  - "EXDEV constant"
  - "EILSEQ constant"
ms.assetid: 47089258-d5a5-4cd8-b193-223894dea0cf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# errno Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **errno** values are constants assigned to [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) in the event of various error conditions.  
  
 ERRNO.H contains the definitions of the **errno** values. However, not all the definitions given in ERRNO.H are used in 32-bit Windows operating systems. Some of the values in ERRNO.H are present to maintain compatibility with the UNIX family of operating systems.  
  
 The **errno** values in a 32-bit Windows operating system are a subset of the values for **errno** in XENIX systems. Thus, the **errno** value is not necessarily the same as the actual error code returned by a system call from the Windows operating systems. To access the actual operating system error code, use the [_doserrno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) variable, which contains this value.  
  
 The following **errno** values are supported:  
  
 **ECHILD**  
 No spawned processes.  
  
 **EAGAIN**  
 No more processes. An attempt to create a new process failed because there are no more process slots, or there is not enough memory, or the maximum nesting level has been reached.  
  
 **E2BIG**  
 Argument list too long.  
  
 **EACCES**  
 Permission denied. The file's permission setting does not allow the specified access. This error signifies that an attempt was made to access a file (or, in some cases, a directory) in a way that is incompatible with the file's attributes.  
  
 For example, the error can occur when an attempt is made to read from a file that is not open, to open an existing read-only file for writing, or to open a directory instead of a file. Under MS-DOS operating system versions 3.0 and later, **EACCES** may also indicate a locking or sharing violation.  
  
 The error can also occur in an attempt to rename a file or directory or to remove an existing directory.  
  
 **EBADF**  
 Bad file number. There are two possible causes: 1) The specified file descriptor is not a valid value or does not refer to an open file. 2) An attempt was made to write to a file or device opened for read-only access.  
  
 **EDEADLOCK**  
 Resource deadlock would occur. The argument to a math function is not in the domain of the function.  
  
 **EDOM**  
 Math argument.  
  
 **EEXIST**  
 Files exist. An attempt has been made to create a file that already exists. For example, the **_O_CREAT** and **_O_EXCL** flags are specified in an **_open** call, but the named file already exists.  
  
 **EILSEQ**  
 Illegal sequence of bytes (for example, in an MBCS string).  
  
 **EINVAL**  
 Invalid argument. An invalid value was given for one of the arguments to a function. For example, the value given for the origin when positioning a file pointer (by means of a call to **fseek**) is before the beginning of the file.  
  
 **EMFILE**  
 Too many open files. No more file descriptors are available, so no more files can be opened.  
  
 **ENOENT**  
 No such file or directory. The specified file or directory does not exist or cannot be found. This message can occur whenever a specified file does not exist or a component of a path does not specify an existing directory.  
  
 **ENOEXEC**  
 Exec format error. An attempt was made to execute a file that is not executable or that has an invalid executable-file format.  
  
 **ENOMEM**  
 Not enough core. Not enough memory is available for the attempted operator. For example, this message can occur when insufficient memory is available to execute a child process, or when the allocation request in a **_getcwd** call cannot be satisfied.  
  
 **ENOSPC**  
 No space left on device. No more space for writing is available on the device (for example, when the disk is full).  
  
 **ERANGE**  
 Result too large. An argument to a math function is too large, resulting in partial or total loss of significance in the result. This error can also occur in other functions when an argument is larger than expected (for example, when the *buffer* argument to **_getcwd** is longer than expected).  
  
 **EXDEV**  
 Cross-device link. An attempt was made to move a file to a different device (using the **rename** function).  
  
 **STRUNCATE**  
 A string copy or concatenation resulted in a truncated string. See [_TRUNCATE](../vs140/_truncate.md).  
  
 The following values are supported for compatibility with Posix. They are required values on non-Posix systems.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Global Constants](../vs140/global-constants.md)