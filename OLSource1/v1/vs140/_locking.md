---
title: "_locking"
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
  - "_locking"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_locking"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "locking function"
  - "bytes [C++], locking file"
  - "files [C++], locking bytes"
  - "files [C++], locking"
  - "_locking function"
ms.assetid: 099aaac1-d4ca-4827-aed6-24dff9844150
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _locking
Locks or unlocks bytes of a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File descriptor.  
  
 *mode*  
 Locking action to perform.  
  
 *nbytes*  
 Number of bytes to lock.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns 0 if successful. A return value of –1 indicates failure, in which case [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is set to one of the following values.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locking violation (file already locked or unlocked).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Invalid file descriptor.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locking violation. Returned when the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flag is specified and the file cannot be locked after 10 attempts.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An invalid argument was given to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 If the failure is due to a bad parameter, such as an invalid file descriptor, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function locks or unlocks *nbytes* bytes of the file specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Locking bytes in a file prevents access to those bytes by other processes. All locking or unlocking begins at the current position of the file pointer and proceeds for the next *nbytes* bytes. It is possible to lock bytes past end of file.  
  
 *mode* must be one of the following manifest constants, which are defined in Locking.h.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Locks the specified bytes. If the bytes cannot be locked, the program immediately tries again after 1 second. If, after 10 attempts, the bytes cannot be locked, the constant returns an error.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Locks the specified bytes. If the bytes cannot be locked, the constant returns an error.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Same as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Same as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Unlocks the specified bytes, which must have been previously locked.  
  
 Multiple regions of a file that do not overlap can be locked. A region being unlocked must have been previously locked. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not merge adjacent regions; if two locked regions are adjacent, each region must be unlocked separately. Regions should be locked only briefly and should be unlocked before closing a file or exiting the program.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<io.h> and \<sys/locking.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_locking.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::FileStream::Lock](https://msdn.microsoft.com/en-us/library/system.io.filestream.lock.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)