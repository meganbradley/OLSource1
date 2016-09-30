---
title: "_setmode"
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
  - "_setmode"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_setmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "Unicode [C++], console output"
  - "files [C++], modes"
  - "_setmode function"
  - "file translation [C++], setting mode"
  - "files [C++], translation"
  - "setmode function"
ms.assetid: 996ff7cb-11d1-43f4-9810-f6097182642a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _setmode
Sets the file translation mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 File descriptor.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New translation mode.  
  
## Return Value  
 If successful, returns the previous translation mode.  
  
 If invalid parameters are passed to this function, the invalid-parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns –1 and sets <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to either <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which indicates an invalid file descriptor, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which indicates an invalid <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function sets to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> the translation mode of the file given by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Passing <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> sets text (that is, translated) mode. Carriage return–line feed (CR-LF) combinations are translated into a single line feed character on input. Line feed characters are translated into CR-LF combinations on output. Passing <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> sets binary (untranslated) mode, in which these translations are suppressed.  
  
 You can also pass <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or _<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to enable Unicode mode, as demonstrated in the second example later in this document. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is typically used to modify the default translation mode of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, but you can use it on any file. If you apply <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the file descriptor for a stream, call <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> before you perform any input or output operations on the stream.  
  
> [!CAUTION]
>  If you write data to a file stream, explicitly flush the code by using [fflush](../vs140/fflush.md) before you use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to change the mode. If you do not flush the code, you might get unexpected behavior. If you have not written data to the stream, you do not have to flush the code.  
  
## Requirements  
  
|Routine|Required header|Optional Headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<io.h>|\<fcntl.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **'stdin' successfully changed to binary mode**   
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::BinaryReader Class](https://msdn.microsoft.com/en-us/library/system.io.binaryreader.aspx)  
  
-   [System::IO::TextReader Class](https://msdn.microsoft.com/en-us/library/system.io.textreader.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_set_fmode](../vs140/_set_fmode.md)