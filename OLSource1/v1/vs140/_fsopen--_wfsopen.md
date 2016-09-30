---
title: "_fsopen, _wfsopen"
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
  - "_wfsopen"
  - "_fsopen"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wfsopen"
  - "fsopen"
  - "tfsopen"
  - "_tfsopen"
  - "_wfsopen"
  - "_fsopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "opening files, streams"
  - "fsopen function"
  - "tfsopen function"
  - "wfsopen function"
  - "_fsopen function"
  - "files [C++], opening"
  - "_tfsopen function"
  - "_wfsopen function"
  - "file sharing [C++]"
ms.assetid: 5e4502ab-48a9-4bee-a263-ebac8d638dec
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fsopen, _wfsopen
Opens a stream with file sharing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the file to open.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type of access permitted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type of sharing allowed.  
  
## Return Value  
 Each of these functions returns a pointer to the stream. A null pointer value indicates an error. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an empty string, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For more information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function opens the file specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as a stream and prepares the file for subsequent shared reading or writing, as defined by the mode and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> arguments. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> arguments to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> behave identically otherwise.  
  
 The character string <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> specifies the type of access requested for the file, as shown in the following table.  
  
|Term|Definition|  
|----------|----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> call fails.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Opens an empty file for writing. If the given file exists, its contents are destroyed.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Opens for writing at the end of the file (appending); creates the file first if it does not exist.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Opens for both reading and writing. (The file must exist.)|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Opens an empty file for both reading and writing. If the given file exists, its contents are destroyed.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Opens for reading and appending; creates the file first if it does not exist.|  
  
 Use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> types with care, as they can destroy existing files.  
  
 When a file is opened with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> access type, all write operations occur at the end of the file. The file pointer can be repositioned using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, but it is always moved back to the end of the file before any write operation is carried out. Thus, existing data cannot be overwritten. When the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> access type is specified, both reading and writing are allowed (the file is said to be open for update). However, when switching between reading and writing, there must be an intervening [fsetpos](../vs140/fsetpos.md), [fseek](../vs140/fseek--_fseeki64.md), or [rewind](../vs140/rewind.md) operation. The current position can be specified for the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operation, if desired. In addition to the above values, one of the following characters can be included in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to specify the translation mode for new lines, and for file management.  
  
|Term|Definition|  
|----------|----------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Opens a file in text (translated) mode. In this mode, carriage return–line feed (CR-LF) combinations are translated into single line feeds (LF) on input and LF characters are translated to CR-LF combinations on output. Also, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading or reading/writing, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> checks for a CTRL+Z at the end of the file and removes it, if possible. This is done because using <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to move within a file that ends with a CTRL+Z might cause <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to behave improperly near the end of the file.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Opens a file in binary (untranslated) mode; the above translations are suppressed.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Specifies that caching is optimized for, but not restricted to, sequential access from disk.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Specifies that caching is optimized for, but not restricted to, random access from disk.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Specifies a file as temporary. If possible, it is not flushed to disk.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Specifies a file as temporary. It is deleted when the last file pointer is closed.|  
  
 If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, the translation mode is defined by the default-mode variable <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. For a discussion of text and binary modes, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md).  
  
 The argument <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is a constant expression consisting of one of the following manifest constants, defined in Share.h.  
  
|Term|Definition|  
|----------|----------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Sets Compatibility mode for 16-bit applications.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Permits read and write access.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Denies read access to the file.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Denies read and write access to the file.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Denies write access to the file.|  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|Optional headers|  
|--------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|\<stdio.h>|\<share.h>\<br />\<br /> For manifest constant for <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> parameter.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|\<share.h>\<br />\<br /> For manifest constant for <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameter.|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **No one else in the network can write to this file until we are done.**   
## .NET Framework Equivalent  
  
-   [System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx)  
  
-   \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [ferror](../vs140/ferror.md)   
 [_fileno](../vs140/_fileno.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmode](../vs140/_setmode.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)