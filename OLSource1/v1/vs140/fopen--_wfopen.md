---
title: "fopen, _wfopen"
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
  - "_wfopen"
  - "fopen"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-crt-stdio-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fopen"
  - "_wfopen"
  - "_tfopen"
  - "corecrt_wstdio/_wfopen"
  - "stdio/fopen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "opening files, for file I/O"
  - "wfopen function"
  - "tfopen function"
  - "_tfopen function"
  - "_wfopen function"
  - "files [C++], opening"
  - "fopen function"
ms.assetid: e868993f-738c-4920-b5e4-d8f2f41f933d
caps.latest.revision: 58
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fopen, _wfopen
Opens a file. More-secure versions of these functions that perform additional parameter validation and return error codes are available; see [fopen_s, _wfopen_s](../vs140/fopen_s--_wfopen_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 File name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Kind of access that's enabled.  
  
## Return Value  
 Each of these functions returns a pointer to the open file. A null pointer value indicates an error. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or an empty string, these functions trigger the invalid parameter handler, which is described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function opens the file that is specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. By default, a narrow <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> string is interpreted using the ANSI codepage (CP_ACP). In Windows Desktop applications this can be changed to the OEM codepage (CP_OEMCP) by using the [SetFileApisToOEM](https://msdn.microsoft.com/library/windows/desktop/aa365534\(v=vs.85\).aspx) function. You can use the [AreFileApisANSI](https://msdn.microsoft.com/library/windows/desktop/aa363781\(v=vs.85\).aspx) function to determine whether <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is interpreted using the ANSI or the system default OEM codepage. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are wide-character strings. Otherwise, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> behave identically. Just using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not affect the coded character set that is used in the file stream.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> accepts paths that are valid on the file system at the point of execution; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> accepts UNC paths and paths that involve mapped network drives as long as the system that executes the code has access to the share or mapped drive at the time of execution. When you construct paths for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, make sure that drives, paths, or network shares will be available in the execution environment. You can use either forward slashes (/) or backslashes (\\) as the directory separators in a path.  
  
 Always check the return value to see whether the pointer is NULL before you perform any additional operations on the file. If an error occurs, the global variable <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is set and may be used to obtain specific error information. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Unicode Support  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> supports Unicode file streams. To open a Unicode file, pass a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> flag that specifies the desired encoding to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, as follows.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 Allowed values of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 When a file is opened in Unicode mode, input functions translate the data that's read from the file into UTF-16 data stored as type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Functions that write to a file opened in Unicode mode expect buffers that contain UTF-16 data stored as type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. If the file is encoded as UTF-8, then UTF-16 data is translated into UTF-8 when it is written, and the file's UTF-8-encoded content is translated into UTF-16 when it is read. An attempt to read or write an odd number of bytes in Unicode mode causes a [parameter validation](../vs140/parameter-validation.md) error. To read or write data that's stored in your program as UTF-8, use a text or binary file mode instead of a Unicode mode. You are responsible for any required encoding translation.  
  
 If the file already exists and is opened for reading or appending, the Byte Order Mark (BOM), if it present in the file, determines the encoding. The BOM encoding takes precedence over the encoding that is specified by the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> flag. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> encoding is only used when no BOM is present or the file is a new file.  
  
> [!NOTE]
>  BOM detection only applies to files that are opened in Unicode mode (that is, by passing the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> flag).  
  
 The following table summarizes the modes that are used for various <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> flags given to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and Byte Order Marks in the file.  
  
### Encodings Used Based on ccs Flag and BOM  
  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> flag|No BOM (or new file)|BOM: UTF-8|BOM: UTF-16|  
|----------------|----------------------------|-----------------|------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
  
 Files opened for writing in Unicode mode have a BOM written to them automatically.  
  
 If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is "<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>", <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> first tries to open the file by using both read and write access. If this succeeds, the function reads the BOM to determine the encoding for the file; if this fails, the function uses the default encoding for the file. In either case, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> will then re-open the file by using write-only access. (This applies to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> mode only, not to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> mode.)  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
  
 The character string <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> specifies the kind of access that is requested for the file, as follows.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> call fails.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Opens an empty file for writing. If the given file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Opens for writing at the end of the file (appending) without removing the end-of-file (EOF) marker before new data is written to the file. Creates the file if it does not exist.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Opens for both reading and writing. The file must exist.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Opens an empty file for both reading and writing. If the file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Opens for reading and appending. The appending operation includes the removal of the EOF marker before new data is written to the file. The EOF marker is not restored after writing is completed. Creates the file if it does not exist.  
  
 When a file is opened by using the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> access type or the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> access type, all write operations occur at the end of the file. The file pointer can be repositioned by using <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, but is always moved back to the end of the file before any write operation is performed. Therefore, existing data cannot be overwritten.  
  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> mode does not remove the EOF marker before it appends to the file. After appending has occurred, the MS-DOS TYPE command only shows data up to the original EOF marker and not any data appended to the file. Before it appends to the file, the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> mode does remove the EOF marker. After appending, the MS-DOS TYPE command shows all data in the file. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> mode is required for appending to a stream file that is terminated with the CTRL+Z EOF marker.  
  
 When the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> access type is specified, both reading and writing are enabled (the file is said to be open for "update"). However, when you switch from reading to writing, the input operation must encounter an EOF marker. If there is no EOF, you must use an intervening call to a file positioning function. The file positioning functions are <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. When you switch from writing to reading, you must use an intervening call to either <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> or to a file positioning function.  
  
 In addition to the earlier values, the following characters can be appended to <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to specify the translation mode for newline characters.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Open in text (translated) mode. In this mode, CTRL+Z is interpreted as an EOF character on input. In files that are opened for reading/writing by using <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> checks for a CTRL+Z at the end of the file and removes it, if it is possible. This is done because using <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to move within a file that ends with CTRL+Z may cause <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to behave incorrectly near the end of the file.  
  
 In text mode, carriage return–linefeed combinations are translated into single linefeeds on input, and linefeed characters are translated to carriage return–linefeed combinations on output. When a Unicode stream-I/O function operates in text mode (the default), the source or destination stream is assumed to be a sequence of multibyte characters. Therefore, the Unicode stream-input functions convert multibyte characters to wide characters (as if by a call to the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> function). For the same reason, the Unicode stream-output functions convert wide characters to multibyte characters (as if by a call to the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> function).  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Open in binary (untranslated) mode; translations involving carriage-return and linefeed characters are suppressed.  
  
 If <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, the default translation mode is defined by the global variable [_fmode](../vs140/_fmode.md). If <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
 For more information about how to use text and binary modes in Unicode and multibyte stream-I/O, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [Unicode Stream I/O in Text and Binary Modes](../vs140/unicode-stream-i-o-in-text-and-binary-modes.md).  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Enable the commit flag for the associated <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> so that the contents of the file buffer are written directly to disk if either <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is called.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Reset the commit flag for the associated <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to "no-commit." This is the default. It also overrides the global commit flag if you link your program with COMMODE.OBJ. The global commit flag default is "no-commit" unless you explicitly link your program with COMMODE.OBJ (see [Link options](../vs140/link-options.md)).  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Specifies that the file is not inherited by child processes.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, sequential access from disk.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, random access from disk.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Specifies a file as temporary. If possible, it is not flushed to disk.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies a file as temporary. It is deleted when the last file pointer is closed.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the coded character set to use (<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>) for this file. Leave unspecified if you want ANSI encoding.  
  
 Valid characters for the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> string that is used in <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> correspond to <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> arguments that are used in [_open](../vs140/_open--_wopen.md) and [_sopen](../vs140/_sopen--_wsopen.md), as follows.  
  
|Characters in mode string|Equivalent <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> value for <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>|  
|-------------------------------|----------------------------------------------------|  
|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>127\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> )|  
|<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|  
  
 If you are using <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> mode, do not have to port code, and expect to read most of a large file or are not concerned about network performance, you might also consider whether to use memory mapped Win32 files as an option.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is a Microsoft extension. For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
 The <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> options are Microsoft extensions for <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> and should not be used where ANSI portability is desired.  
  
## Example  
 The following program opens two files.  It uses <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> to close the first file and <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> to close all remaining files.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The file 'crt_fopen.c' was opened**  
**The file 'data2' was opened**  
**Number of files closed by _fcloseall: 1**   
## Example  
 The following program creates a file (or overwrites one if it exists), in text mode that has Unicode encoding.  It then writes two strings into the file and closes the file. The output is a file named _wfopen_test.xml, which contains the data from the output section.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [ferror](../vs140/ferror.md)   
 [_fileno](../vs140/_fileno.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmode](../vs140/_setmode.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)