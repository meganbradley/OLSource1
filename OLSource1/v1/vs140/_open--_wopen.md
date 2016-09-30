---
title: "_open, _wopen"
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
  - "_open"
  - "_wopen"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wopen"
  - "_topen"
  - "_open"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "opening files, for file I/O"
  - "topen function"
  - "_open function"
  - "_topen function"
  - "_wopen function"
  - "files [C++], opening"
  - "wopen function"
  - "open function"
ms.assetid: 13f6a0c3-d1aa-450d-a7aa-74abc91b163e
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _open, _wopen
Opens a file. These functions are deprecated because more-secure versions are available; see [_sopen_s, _wsopen_s](../vs140/_sopen_s--_wsopen_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 File name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The kind of operations allowed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Permission mode.  
  
## Return Value  
 Each of these functions returns a file descriptor for the opened file. A return value of -1 indicates an error; in that case <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to one of the following values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Tried to open a read-only file for writing, file's sharing mode does not allow the specified operations, or the given path is a directory.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flags specified, but <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> already exists.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Invalid <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 No more file descriptors are available (too many files are open).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 File or path not found.  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function opens the file specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and prepares it for reading or writing, as specified by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is an integer expression formed from one or more of the following manifest constants or constant combinations, which are defined in \<fcntl.h>.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Moves the file pointer to the end of the file before every write operation.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Opens the file in binary (untranslated) mode. (See [fopen](../vs140/fopen--_wfopen.md) for a description of binary mode.)  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Creates a file and opens it for writing. Has no effect if the file specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> exists. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Creates a file as temporary and if possible does not flush to disk. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Creates a file as temporary; the file is deleted when the last file descriptor is closed. The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> argument is required when <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is specified.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Returns an error value if the file specified by <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> exists. Applies only when used with <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Prevents creation of a shared file descriptor.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, random access from disk.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Opens a file for reading only. Cannot be specified with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Opens file for both reading and writing. Cannot be specified with <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, sequential access from disk.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Opens a file in text (translated) mode. (For more information, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [fopen](../vs140/fopen--_wfopen.md).)  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Opens a file and truncates it to zero length; the file must have write permission. Cannot be specified with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> used with <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> opens an existing file or creates a file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> flag destroys the contents of the specified file.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Opens the file for writing only. Cannot be specified with <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Opens the file in Unicode UTF-16 mode.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Opens the file in Unicode UTF-8 mode.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Opens the file in Unicode mode.  
  
 To specify the file access mode, you must specify either <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. There is no default value for the access mode.  
  
 If <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is used to open a file for reading, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> reads the beginning of the file and checks for a byte order mark (BOM). If there is a BOM, the file is treated as UTF-8 or UTF-16LE, depending on the BOM. If no BOM is present, the file is treated as ANSI. When a file is opened for writing by using <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, UTF-16 is used. Regardless of any previous setting or byte order mark, if <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is used, the file is always opened as UTF-8; if <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is used, the file is always opened as UTF-16.  
  
 When a file is opened in Unicode mode by using <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, input functions translate the data that's read from the file into UTF-16 data stored as type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. Functions that write to a file opened in Unicode mode expect buffers that contain UTF-16 data stored as type <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. If the file is encoded as UTF-8, then UTF-16 data is translated into UTF-8 when it is written, and the file's UTF-8-encoded content is translated into UTF-16 when it is read. An attempt to read or write an odd number of bytes in Unicode mode causes a parameter validation error. To read or write data that's stored in your program as UTF-8, use a text or binary file mode instead of a Unicode mode. You are responsible for any required encoding translation.  
  
 If <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is called with <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> (append mode) and <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, it first tries to open the file for reading and writing, read the BOM, then reopen it for writing only. If opening the file for reading and writing fails, it opens the file for writing only and uses the default value for the Unicode mode setting.  
  
 When two or more manifest constants are used to form the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> argument, the constants are combined with the bitwise-OR operator ( <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> ). For a discussion of binary and text modes, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md).  
  
 The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> argument is required only when <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is specified. If the file already exists, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is ignored. Otherwise, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> specifies the file permission settings, which are set when the new file is closed the first time. <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> applies the current file-permission mask to <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> before the permissions are set. (For more information, see [_umask](../vs140/_umask.md).) <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is an integer expression that contains one or both of the following manifest constants, which are defined in \<sys\stat.h>.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Only reading permitted.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Writing permitted. (In effect, permits reading and writing.)  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 When both constants are given, they are joined with the bitwise-OR operator ( <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> ). In Windows, all files are readable; write-only permission is not available. Therefore, the modes <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> are equivalent.  
  
 If a value other than some combination of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is specified for <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>—even if it would specify a valid <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> in another operating system—or if any value other than the allowed <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> values is specified, the function generates an assertion in Debug mode and invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and sets <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|\<io.h>|\<fcntl.h>, \<sys\types.h>, \<sys\stat.h>|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|\<fcntl.h>, \<sys\types.h>, \<sys\stat.h>|  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> are Microsoft extensions. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx)  
  
-   \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_dup, _dup2](../vs140/_dup--_dup2.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)