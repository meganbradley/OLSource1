---
title: "freopen, _wfreopen"
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
  - "freopen"
  - "_wfreopen"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wfreopen"
  - "_tfreopen"
  - "freopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wfreopen function"
  - "file pointers [C++], reassigning"
  - "_tfreopen function"
  - "freopen function"
  - "tfreopen function"
  - "wfreopen function"
ms.assetid: de4b73f8-1043-4d62-98ee-30d2022da885
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# freopen, _wfreopen
Reassigns a file pointer. More secure versions of these functions are available; see [freopen_s, _wfreopen_s](../vs140/freopen_s--_wfreopen_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Path of new file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type of access permitted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns a pointer to the newly opened file. If an error occurs, the original file is closed and the function returns a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer value. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, or if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is an empty string, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 More secure versions of these functions exist, see [freopen_s, _wfreopen_s](../vs140/freopen_s--_wfreopen_s.md).  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function closes the file currently associated with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and reassigns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the file specified by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>*.* <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> arguments to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is typically used to redirect the pre-opened files <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to files specified by the user. The new file associated with <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is opened with <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>*,* which is a character string specifying the type of access requested for the file, as follows:  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> call fails.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Opens an empty file for writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Opens for writing at the end of the file (appending) without removing the EOF marker before writing new data to the file; creates the file first if it does not exist.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Opens for both reading and writing. (The file must exist.)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Opens an empty file for both reading and writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Opens for reading and appending; the appending operation includes the removal of the EOF marker before new data is written to the file and the EOF marker is restored after writing is complete; creates the file first if it does not exist.  
  
 Use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> types with care, as they can destroy existing files.  
  
 When a file is opened with the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> access type, all write operations take place at the end of the file. Although the file pointer can be repositioned using <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, the file pointer is always moved back to the end of the file before any write operation is carried out. Thus, existing data cannot be overwritten.  
  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> mode does not remove the EOF marker before appending to the file. After appending has occurred, the MS-DOS TYPE command only shows data up to the original EOF marker and not any data appended to the file. The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> mode does remove the EOF marker before appending to the file. After appending, the MS-DOS TYPE command shows all data in the file. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> mode is required for appending to a stream file that is terminated with the CTRL+Z EOF marker.  
  
 When the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> access type is specified, both reading and writing are allowed (the file is said to be open for "update"). However, when you switch between reading and writing, there must be an intervening [fsetpos](../vs140/fsetpos.md), [fseek](../vs140/fseek--_fseeki64.md), or [rewind](../vs140/rewind.md) operation. The current position can be specified for the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> operation, if desired. In addition to the above values, one of the following characters may be included in the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> string to specify the translation mode for new lines.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Open in text (translated) mode; carriage return–linefeed (CR-LF) combinations are translated into single linefeed (LF) characters on input; LF characters are translated to CR-LF combinations on output. Also, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading or for writing and reading with <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, the run-time library checks for a CTRL+Z at the end of the file and removes it, if possible. This is done because using <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to move within a file may cause <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to behave improperly near the end of the file. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> option is a Microsoft extension that should not be used where ANSI portability is desired.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Open in binary (untranslated) mode; the above translations are suppressed.  
  
 If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the default translation mode is defined by the global variable [_fmode](../vs140/_fmode.md). If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 For a discussion of text and binary modes, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **successfully reassigned**  
**This will go to the file 'freopen.out'**   
## .NET Framework Equivalent  
  
-   \<xref:System.IO.File.Open*>  
  
-   \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [_fileno](../vs140/_fileno.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmode](../vs140/_setmode.md)