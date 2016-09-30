---
title: "freopen_s, _wfreopen_s"
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
  - "_wfreopen_s"
  - "freopen_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "freopen_s"
  - "_tfreopen_s"
  - "_wfreopen_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tfreopen_s function"
  - "_wfreopen_s function"
  - "file pointers [C++], reassigning"
  - "tfreopen_s function"
  - "wfreopen_s function"
  - "freopen_s function"
ms.assetid: ad25a4da-6ad4-476b-a86d-660b221ca84d
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# freopen_s, _wfreopen_s
Reassigns a file pointer. These versions of [freopen, _wfreopen](../vs140/freopen--_wfreopen.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the file pointer to be provided by the call.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Path of new file.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type of access permitted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns an error code. If an error occurs, the original file is closed.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function closes the file currently associated with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and reassigns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the file specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> arguments to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> behave identically otherwise.  
  
 If any of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is an empty string, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is typically used to redirect the pre-opened files <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to files specified by the user. The new file associated with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is opened with <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>*,* which is a character string specifying the type of access requested for the file, as follows:  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> call fails.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Opens an empty file for writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Opens for writing at the end of the file (appending) without removing the EOF marker before writing new data to the file; creates the file first if it does not exist.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Opens for both reading and writing. (The file must exist.)  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Opens an empty file for both reading and writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Opens for reading and appending; the appending operation includes the removal of the EOF marker before new data is written to the file and the EOF marker is restored after writing is complete; creates the file first if it does not exist.  
  
 Use the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> types with care, as they can destroy existing files.  
  
 When a file is opened with the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> access type, all write operations take place at the end of the file. Although the file pointer can be repositioned using <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, the file pointer is always moved back to the end of the file before any write operation is carried out. Thus, existing data cannot be overwritten.  
  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> mode does not remove the EOF marker before appending to the file. After appending has occurred, the MS-DOS TYPE command only shows data up to the original EOF marker and not any data appended to the file. The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> mode does remove the EOF marker before appending to the file. After appending, the MS-DOS TYPE command shows all data in the file. The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> mode is required for appending to a stream file that is terminated with the CTRL+Z EOF marker.  
  
 When the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> access type is specified, both reading and writing are allowed (the file is said to be open for "update"). However, when you switch between reading and writing, there must be an intervening [fsetpos](../vs140/fsetpos.md), [fseek](../vs140/fseek--_fseeki64.md), or [rewind](../vs140/rewind.md) operation. The current position can be specified for the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> operation, if desired. In addition to the above values, one of the following characters may be included in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> string to specify the translation mode for new lines.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Open in text (translated) mode; carriage return–linefeed (CR-LF) combinations are translated into single linefeed (LF) characters on input; LF characters are translated to CR-LF combinations on output. Also, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading or for writing and reading with <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, the run-time library checks for a CTRL+Z at the end of the file and removes it, if possible. This is done because using <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to move within a file may cause <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to behave improperly near the end of the file. The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> option is a Microsoft extension that should not be used where ANSI portability is desired.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Open in binary (untranslated) mode; the above translations are suppressed.  
  
 If <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, the default translation mode is defined by the global variable [_fmode](../vs140/_fmode.md). If <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 For a discussion of text and binary modes, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **successfully reassigned**  
**This will go to the file 'freopen.out'**   
## .NET Framework Equivalent  
  
-   [System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx)  
  
-   \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [_fileno](../vs140/_fileno.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmode](../vs140/_setmode.md)