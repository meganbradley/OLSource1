---
title: "_write"
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
  - "_write"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_write"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_write function"
  - "write function"
  - "files [C++], writing to"
ms.assetid: 7b868c33-766f-4e1a-95a7-e8d25f0604c4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _write
Writes data to a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 File descriptor of file into which data is written.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Data to be written.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of bytes.  
  
## Return Value  
 If successful, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the number of bytes actually written. If the actual space remaining on the disk is less than the size of the buffer the function is trying to write to the disk, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> fails and does not flush any of the buffer's contents to the disk. A return value of –1 indicates an error. If invalid parameters are passed, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to one of three values: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which means the file descriptor is invalid or the file is not opened for writing; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which means there is not enough space left on the device for the operation; or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which means that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> was a null pointer or that an odd <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of bytes was passed to be written to a file in Unicode mode.  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 If the file is opened in text mode, each linefeed character is replaced with a carriage return – linefeed pair in the output. The replacement does not affect the return value.  
  
 When the file is opened in Unicode translation mode—for example, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is opened by using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and a mode parameter that includes <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or if it is opened by using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and a mode parameter that includes <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or if the mode is changed to a Unicode translation mode by using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>—<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is interpreted as a pointer to an array of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> that contains **UTF-16** data. An attempt to write an odd number of bytes in this mode causes a parameter validation error.  
  
## Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function writes <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> into the file associated with <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The write operation begins at the current position of the file pointer (if any) associated with the given file. If the file is open for appending, the operation begins at the current end of the file. After the write operation, the file pointer is increased by the number of bytes actually written.  
  
 When writing to files opened in text mode, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> treats a CTRL+Z character as the logical end-of-file. When writing to a device, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> treats a CTRL+Z character in the buffer as an output terminator.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<io.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Wrote 36 bytes to file.**   
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [fwrite](../vs140/fwrite.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_read](../vs140/_read.md)   
 [_setmode](../vs140/_setmode.md)