---
title: "_fdopen, _wfdopen"
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
  - "_fdopen"
  - "_wfdopen"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tfdopen"
  - "_fdopen"
  - "_wfdopen"
  - "wfdopen"
  - "tfdopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wfdopen function"
  - "_fdopen function"
  - "_wfdopen function"
  - "tfdopen function"
  - "fdopen function"
  - "_tfdopen function"
  - "streams, associating with files"
ms.assetid: 262757ff-1e09-4472-a5b6-4325fc28f971
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fdopen, _wfdopen
Associates a stream with a file that was previously opened for low-level I/O.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File descriptor of the open file.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type of file access.  
  
## Return Value  
 Each of these functions returns a pointer to the open stream. A null pointer value indicates an error. When an error occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set either to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which indicates a bad file descriptor, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which indicates that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> was a null pointer.  
  
 For more information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function associates an I/O stream with the file that is identified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and thus allows a file that is opened for low-level I/O to be buffered and formatted. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> otherwise behave identically.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> character string specifies the type of file and file access.  
  
 The character string <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> specifies the type of access requested for the file, as shown in the following table.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> call fails.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Opens an empty file for writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Opens for writing, at the end of the file (appending). Creates the file if it does not exist.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Opens for both reading and writing. (The file must exist.)  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Opens an empty file for both reading and writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Opens for reading and appending. Creates the file if it does not exist.  
  
 When a file is opened with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> access type, all write operations occur at the end of the file. The file pointer can be repositioned by using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, but it is always moved back to the end of the file before any write operation is carried out. Thus, existing data cannot be overwritten. When the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> access type is specified, both reading and writing are allowed (the file is said to be open for "update"). However, when you switch between reading and writing, there must be an intervening <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> operation. You can specify the current position for the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> operation, if you want to.  
  
 In addition to the above values, the following characters can also be included in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to specify the translation mode for newline characters.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Open in text (translated) mode. In this mode, carriage return-line feed (CR-LF) combinations are translated into one-line feeds (LF) on input, and LF characters are translated to CR-LF combinations on output. Also, Ctrl+Z is interpreted as an end-of-file character on input. In files opened for reading/writing, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> checks for a Ctrl+Z at the end of the file and removes it, if possible. This is done because using the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> functions to move within a file that ends with a Ctrl+Z might cause <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to behave incorrectly near the end of the file.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Open in binary (untranslated) mode. Any translations from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> mode are suppressed.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Enable the commit flag for the associated <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> so that the contents of the file buffer are written directly to disk if either <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is called.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Reset the commit flag for the associated <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to "no-commit." This is the default. It also overrides the global commit flag if you link your program with Commode.obj. The global commit flag default is "no-commit" unless you explicitly link your program with Commode.obj.  
  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> options are Microsoft extensions for <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. Do not use them if you want to preserve ANSI portability.  
  
 If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the default translation mode is defined by the global variable [_fmode](../vs140/_fmode.md). If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. For a discussion of text and binary modes, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md).  
  
 Valid characters for the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> string used in <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> correspond to <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> arguments used in [_open](../vs140/_open--_wopen.md) and [_sopen](../vs140/_sopen--_wsopen.md), as follows.  
  
|Characters in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> string|Equivalent <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>value for <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|  
|---------------------------------|---------------------------------------------------|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> )|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|None|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_fdopen.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_dup, _dup2](../vs140/_dup--_dup2.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)