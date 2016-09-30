---
title: "_sopen, _wsopen"
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
  - "_sopen"
  - "_wsopen"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wsopen"
  - "wsopen"
  - "_sopen"
  - "_tsopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sopen function"
  - "sharing files"
  - "opening files, for sharing"
  - "_sopen function"
  - "wsopen function"
  - "files [C++], opening"
  - "files [C++], sharing"
  - "_wsopen function"
ms.assetid: a9d4cccf-06e9-414d-96fa-453fca88cc1f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _sopen, _wsopen
Opens a file for sharing. More-secure versions of these functions are available—see [_sopen_s, _wsopen_s](../vs140/_sopen_s--_wsopen_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 File name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The kind of operations allowed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The kind of sharing allowed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Permission setting.  
  
## Return Value  
 Each of these functions returns a file descriptor for the opened file.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not within a valid range of values, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to one of the following values.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The given path is a directory, or the file is read-only, but an open-for-writing operation was attempted.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> flags were specified, but <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> already exists.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Invalid <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 No more file descriptors are available.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 File or path is not found.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function opens the file specified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and prepares the file for shared reading or writing, as defined by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 The integer expression <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is formed by combining one or more of the following manifest constants, which are defined in \<fcntl.h>. When two or more constants form the argument <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, they are combined with the bitwise-OR operator ( <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> ).  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Repositions a file pointer to the end of the file before every write operation.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Opens a file in binary (untranslated) mode. (See [fopen](../vs140/fopen--_wfopen.md) for a description of binary mode.)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Creates a file and opens it for writing. Has no effect if the file specified by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> exists. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Creates a file as temporary and if possible does not flush to disk. The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Creates a file as temporary; the file is deleted when the last file descriptor is closed. The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Returns an error value if a file specified by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> exists. Applies only when used with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Prevents creation of a shared file descriptor.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies primarily random access from disk.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Opens a file for reading only. Cannot be specified with <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Opens a file for both reading and writing. Cannot be specified with <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Specifies primarily sequential access from disk.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Opens a file in text (translated) mode. (For more information, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [fopen](../vs140/fopen--_wfopen.md).)  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Opens a file and truncates it to zero length; the file must have write permission. Cannot be specified with <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> used with <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> opens an existing file or creates a file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> flag destroys the contents of the specified file.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Opens a file for writing only. Cannot be specified with <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Opens a file in Unicode UTF-16 mode.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Opens a file in Unicode UTF-8 mode.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Opens a file in Unicode mode.  
  
 To specify the file access mode, you must specify either <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. There is no default value for the access mode.  
  
 When a file is opened in Unicode mode by using <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, input functions translate the data that's read from the file into UTF-16 data stored as type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. Functions that write to a file opened in Unicode mode expect buffers that contain UTF-16 data stored as type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. If the file is encoded as UTF-8, then UTF-16 data is translated into UTF-8 when it is written, and the file's UTF-8-encoded content is translated into UTF-16 when it is read. An attempt to read or write an odd number of bytes in Unicode mode causes a parameter validation error. To read or write data that's stored in your program as UTF-8, use a text or binary file mode instead of a Unicode mode. You are responsible for any required encoding translation.  
  
 If <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is called with <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> (append mode) and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, it first tries to open the file for reading and writing, read the BOM, then reopen it for writing only. If opening the file for reading and writing fails, it opens the file for writing only and uses the default value for the Unicode mode setting.  
  
 The argument <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is a constant expression consisting of one of the following manifest constants, which are defined in \<share.h>.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Denies read and write access to a file.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Denies write access to a file.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Denies read access to a file.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Permits read and write access.  
  
 The <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> argument is required only when <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is specified. If the file does not exist, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> specifies the file's permission settings, which are set when the new file is closed the first time. Otherwise, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is ignored. <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is an integer expression that contains one or both of the manifest constants <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, which are defined in \<sys\stat.h>. When both constants are given, they are combined with the bitwise-OR operator. The meaning of <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is as follows.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Writing permitted.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Reading permitted.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 If write permission is not given, the file is read-only. In the Windows operating system, all files are readable; it is not possible to give write-only permission. Therefore, the modes <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> are equivalent.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> applies the current file-permission mask to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> before the permissions are set. (See [_umask](../vs140/_umask.md).)  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|\<io.h>|\<fcntl.h>, \<sys\types.h>, \<sys\stat.h>, \<share.h>|  
|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|\<fcntl.h>, \<sys\types.h>, \<sys\stat.h>, \<share.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [_locking](../vs140/_locking.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_fsopen, _wfsopen](../vs140/_fsopen--_wfsopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)