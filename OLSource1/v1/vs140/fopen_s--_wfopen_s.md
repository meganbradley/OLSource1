---
title: "fopen_s, _wfopen_s"
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
  - "_wfopen_s"
  - "fopen_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fopen_s"
  - "_tfopen_s"
  - "_wfopen_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wfopen_s function"
  - "opening files, for file I/O"
  - "_tfopen_s function"
  - "tfopen_s function"
  - "wfopen_s function"
  - "fopen_s function"
  - "Unicode [C++], creating files"
  - "Unicode [C++], writing files"
  - "files [C++], opening"
  - "Unicode [C++], files"
ms.assetid: c534857e-39ee-4a3f-bd26-dfe551ac96c3
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fopen_s, _wfopen_s
Opens a file. These versions of [fopen, _wfopen](../vs140/fopen--_wfopen.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the file pointer that will receive the pointer to the opened file.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Filename.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type of access permitted.  
  
## Return Value  
 Zero if successful; an error code on failure. See [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information about these error codes.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Return Value|Contents of<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|-------------|----------------|------------|------------------|------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|unchanged|  
|any|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|unchanged|  
|any|any|NULL|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|unchanged|  
  
## Remarks  
 Files that are opened by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are not sharable. If you require that a file be sharable, use [_fsopen, _wfsopen](../vs140/_fsopen--_wfsopen.md) with the appropriate sharing mode constant—for example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for read/write sharing.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function opens the file that's specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> behave identically otherwise.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> accepts paths that are valid on the file system at the point of execution; UNC paths and paths that involve mapped network drives are accepted by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> as long as the system that's executing the code has access to the share or mapped network drive at the time of execution. When you construct paths for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, don't make assumptions about the availability of drives, paths, or network shares in the execution environment. You can use either forward slashes (/) or backslashes (\\) as the directory separators in a path.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a null pointer, these functions generate an invalid parameter exception, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 Always check the return value to see if the function succeeded before you perform any further operations on the file. If an error occurs, the error code is returned and the global variable <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is set. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Unicode support  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> supports Unicode file streams. To open a new or existing Unicode file, pass a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> flag that specifies the desired encoding to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 Allowed values of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. If there no value is specified for <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> uses ANSI encoding.  
  
 If the file already exists and is opened for reading or appending, the Byte Order Mark (BOM), if present in the file, determines the encoding. The BOM encoding takes precedence over the encoding that's specified by the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> flag. The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> encoding is only used when no BOM is present or if the file is a new file.  
  
> [!NOTE]
>  BOM-detection only applies to files that are opened in Unicode mode; that is, by passing the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> flag.  
  
 The following table summarizes the modes for various <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> flags that are given to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and for Byte Order Marks in the file.  
  
### Encodings Used Based on ccs Flag and BOM  
  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> flag|No BOM (or new file)|BOM: UTF-8|BOM: UTF-16|  
|----------------|----------------------------|-----------------|------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
  
 Files that are opened for writing in Unicode mode have a BOM written to them automatically.  
  
 If <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is "<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>", <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> first tries to open the file with both read access and write access. If successful, the function reads the BOM to determine the encoding for the file; if unsuccessful, the function uses the default encoding for the file. In either case, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> then re-opens the file with write-only access. (This applies to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> mode only, not <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.)  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|  
  
 The character string <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> specifies the kind of access that's requested for the file, as follows.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Opens for reading. If the file does not exist or cannot be found, the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> call fails.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Opens an empty file for writing. If the file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Opens for writing at the end of the file (appending) without removing the EOF marker before writing new data to the file. Creates the file if it doesn't exist.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Opens for both reading and writing. (The file must exist.)  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Opens an empty file for both reading and writing. If the file exists, its contents are destroyed.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Opens for reading and appending. The appending operation includes the removal of the EOF marker before new data is written to the file and the EOF marker is restored after writing is complete. Creates the file if it doesn't exist.  
  
 When a file is opened by using the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> access type, all write operations occur at the end of the file. The file pointer can be repositioned by using <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, but it's always moved back to the end of the file before any write operation is carried out so that existing data cannot be overwritten.  
  
 The <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> mode does not remove the EOF marker before appending to the file. After appending has occurred, the MS-DOS TYPE command only shows data up to the original EOF marker and not any data that's appended to the file. The <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> mode does remove the EOF marker before appending to the file. After appending, the MS-DOS TYPE command shows all data in the file. The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> mode is required for appending to a stream file that is terminated by using the CTRL+Z EOF marker.  
  
 When the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> access type is specified, both reading and writing are allowed. (The file is said to be open for "update".) However, when you switch from reading to writing, the input operation must encounter an EOF marker. If there is no EOF, you must use an intervening call to a file-positioning function. The file-positioning functions are <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. When you switch from writing to reading, you must use an intervening call to either <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> or to a file-positioning function.  
  
 In addition to the above values, the following characters can be included in <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> to specify the translation mode for newline characters:  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Open in text (translated) mode. In this mode, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading/writing with <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> checks for a CTRL+Z at the end of the file and removes it, if possible. This is done because using <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to move within a file that ends with a CTRL+Z, may cause <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to behave improperly near the end of the file.  
  
 Also, in text mode, carriage return–linefeed combinations are translated into single linefeeds on input, and linefeed characters are translated to carriage return–linefeed combinations on output. When a Unicode stream-I/O function operates in text mode (the default), the source or destination stream is assumed to be a sequence of multibyte characters. Therefore, the Unicode stream-input functions convert multibyte characters to wide characters (as if by a call to the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> function). For the same reason, the Unicode stream-output functions convert wide characters to multibyte characters (as if by a call to the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> function).  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Open in binary (untranslated) mode; translations involving carriage-return and linefeed characters are suppressed.  
  
 If <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is not given in <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, the default translation mode is defined by the global variable [_fmode](../vs140/_fmode.md). If <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is prefixed to the argument, the function fails and returns <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 For more information about using text and binary modes in Unicode and multibyte stream-I/O, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [Unicode Stream I/O in Text and Binary Modes](../vs140/unicode-stream-i-o-in-text-and-binary-modes.md).  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Enable the commit flag for the associated <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> so that the contents of the file buffer are written directly to disk if either <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is called.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Reset the commit flag for the associated <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to "no-commit." This is the default. It also overrides the global commit flag if you link your program with COMMODE.OBJ. The global commit flag default is "no-commit" unless you explicitly link your program with COMMODE.OBJ (see [Link options](../vs140/link-options.md)).  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Specifies that the file is not inherited by child processes.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, sequential access from disk.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Specifies that caching is optimized for, but not restricted to, random access from disk.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Specifies a file as temporary. If possible, it is not flushed to disk.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Specifies a file as temporary. It is deleted when the last file pointer is closed.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Specify the coded character set to use (UTF-8, UTF-16LE, and UNICODE) for this file. Leave this unspecified if you want ANSI encoding.  
  
 Valid characters for the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> string used in <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> correspond to <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> arguments used in [_open](../vs140/_open--_wopen.md) and [_sopen](../vs140/_sopen--_wsopen.md), as follows.  
  
|Characters in mode string|Equivalent <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> value for <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>|  
|-------------------------------|----------------------------------------------------|  
|<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>129\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> )|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>142\</CodeContentPlaceHolder> (usually <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>)|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>|  
  
 If you are using <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> mode, won't need to port your code, and expect to read a lot of the file and/or don't care about network performance, memory mapped Win32 files might also be an option.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
 The <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> options are Microsoft extensions for <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> and should not be used where ANSI portability is desired.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The file 'crt_fopen_s.c' was opened**  
**The file 'data2' was opened**  
**Number of files closed by _fcloseall: 1**   
## .NET Framework Equivalent  
  
-   [System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx)  
  
-   \<xref:System.IO.FileStream.#ctor*>  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [ferror](../vs140/ferror.md)   
 [_fileno](../vs140/_fileno.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmode](../vs140/_setmode.md)