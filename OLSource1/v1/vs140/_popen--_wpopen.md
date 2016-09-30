---
title: "_popen, _wpopen"
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
  - "_popen"
  - "_wpopen"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tpopen"
  - "popen"
  - "wpopen"
  - "_popen"
  - "_wpopen"
  - "_tpopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tpopen function"
  - "pipes, creating"
  - "_popen function"
  - "_tpopen function"
  - "popen function"
  - "wpopen function"
  - "_wpopen function"
ms.assetid: eb718ff2-c87d-4bd4-bd2e-ba317c3d6973
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _popen, _wpopen
Creates a pipe and executes a command.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *command*  
 Command to be executed.  
  
 *mode*  
 Mode of the returned stream.  
  
## Return Value  
 Returns a stream associated with one end of the created pipe. The other end of the pipe is associated with the spawned command's standard input or standard output. The functions return **NULL** on an error. If the error is an invalid parameter, such as if *command* or *mode* is a null pointer, or *mode* is not a valid mode, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. See the Remarks section for valid modes.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function creates a pipe and asynchronously executes a spawned copy of the command processor with the specified string *command*. The character string *mode* specifies the type of access requested, as follows.  
  
 **"r"**  
 The calling process can read the spawned command's standard output using the returned stream.  
  
 **"w"**  
 The calling process can write to the spawned command's standard input using the returned stream.  
  
 **"b"**  
 Open in binary mode.  
  
 **"t"**  
 Open in text mode.  
  
> [!NOTE]
>  If used in a Windows program, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function returns an invalid file pointer that causes the program to stop responding indefinitely. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> works properly in a console application. To create a Windows application that redirects input and output, see [Creating a Child Process with Redirected Input and Output](http://msdn.microsoft.com/library/windows/desktop/ms682499) in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; the *path* argument to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 This output assumes that there is only one file in the current directory with a .c file name extension.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_pclose](../vs140/_pclose.md)   
 [_pipe](../vs140/_pipe.md)