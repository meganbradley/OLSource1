---
title: "_sopen_s, _wsopen_s"
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
  - "_sopen_s"
  - "_wsopen_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sopen_s"
  - "wsopen_s"
  - "_wsopen_s"
  - "sopen_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sopen_s function"
  - "_wsopen_s function"
  - "wsopen_s function"
  - "opening files, for sharing"
  - "files [C++], opening"
  - "_sopen_s function"
  - "files [C++], sharing"
ms.assetid: 059a0084-d08c-4973-9174-55e391b72aa2
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _sopen_s, _wsopen_s
Opens a file for sharing. These versions of [_sopen and _wsopen](../vs140/_sopen--_wsopen.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The file handle, or -1 in the case of an error.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 File name.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The kind of operations allowed.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The kind of sharing allowed.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Permission setting.  
  
## Return Value  
 A nonzero return value indicates an error; in that case <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to one of the following values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The given path is a directory, or the file is read-only, but an open-for-writing operation was attempted.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flags were specified, but <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> already exists.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Invalid <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> was a null pointer.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 No more file descriptors available.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 File or path not found.  
  
 If an invalid argument is passed to the function, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is returned.  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 In the case of an error, -1 is returned through <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (unless <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer).  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function opens the file specified by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and prepares the file for shared reading or writing, as defined by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
 The integer expression <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is formed by combining one or more manifest constants, which are defined in \<fcntl.h>. When two or more constants form the argument <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, they are combined with the bitwise-OR operator ( <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> ).  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Repositions a file pointer to the end of the file before every write operation.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Opens a file in binary (untranslated) mode. (See [fopen](../vs140/fopen--_wfopen.md) for a description of binary mode.)  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Creates a file and opens it for writing. Has no effect if the file specified by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> exists.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Creates a file as temporary and if possible does not flush to disk.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Creates a file as temporary; the file is deleted when the last file descriptor is closed.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Returns an error value if the file specified by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> exists. Applies only when used with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Prevents creation of a shared file descriptor.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies primarily random access from disk.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Opens a file for reading only. Cannot be specified with <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Opens a file for both reading and writing. Cannot be specified with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies primarily sequential access from disk.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Opens a file in text (translated) mode. (For more information, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [fopen](../vs140/fopen--_wfopen.md).)  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Opens a file and truncates it to zero length; the file must have write permission. Cannot be specified with <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> used with <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> opens an existing file or creates a file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> flag destroys the contents of the specified file.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Opens a file for writing only. Cannot be specified with <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Opens a file in Unicode UTF-16 mode.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Opens a file in Unicode UTF-8 mode.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Opens a file in Unicode mode.  
  
 To specify the file access mode, you must specify either <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. There is no default value for the access mode.  
  
 When a file is opened in Unicode mode by using <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, input functions translate the data that's read from the file into UTF-16 data stored as type <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. Functions that write to a file opened in Unicode mode expect buffers that contain UTF-16 data stored as type <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. If the file is encoded as UTF-8, then UTF-16 data is translated into UTF-8 when it is written, and the file's UTF-8-encoded content is translated into UTF-16 when it is read. An attempt to read or write an odd number of bytes in Unicode mode causes a parameter validation error. To read or write data that's stored in your program as UTF-8, use a text or binary file mode instead of a Unicode mode. You are responsible for any required encoding translation.  
  
 If <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is called with <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> (append mode) and <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, it first tries to open the file for reading and writing, read the BOM, then reopen it for writing only. If opening the file for reading and writing fails, it opens the file for writing only and uses the default value for the Unicode mode setting.  
  
 The argument <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is a constant expression that consists of one of the following manifest constants, which are defined in \<share.h>.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Denies read and write access to a file.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Denies write access to a file.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Denies read access to a file.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Permits read and write access.  
  
 The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> argument is always required, unlike in <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. When you specify <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, if the file does not exist, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> specifies the file's permission settings, which are set when the new file is closed the first time. Otherwise, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is ignored. <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is an integer expression that contains one or both of the manifest constants <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, which are defined in \<sys\stat.h>. When both constants are given, they are combined with the bitwise-OR operator. The meaning of <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is as follows.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Writing permitted.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Reading permitted.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 If write permission is not given, the file is read-only. In the Windows operating system, all files are readable; it is not possible to give write-only permission. Therefore, the modes <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> are equivalent.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> applies the current file-permission mask to <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> before the permissions are set. (See [_umask](../vs140/_umask.md).)  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|\<io.h>|\<fcntl.h>, \<sys\types.h>, \<sys\stat.h>, \<share.h>|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|\<fcntl.h>, \<sys/types.h>, \<sys/stat.h>, \<share.h>|  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> are Microsoft extensions. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [_locking](../vs140/_locking.md).  
  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_fsopen, _wfsopen](../vs140/_fsopen--_wfsopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)