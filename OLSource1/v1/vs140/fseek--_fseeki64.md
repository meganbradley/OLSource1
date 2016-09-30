---
title: "fseek, _fseeki64"
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
  - "_fseeki64"
  - "fseek"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fseek"
  - "_fseeki64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fseeki64 function"
  - "fseeki64 function"
  - "fseek function"
  - "file pointers [C++], moving"
  - "file pointers [C++]"
  - "seek file pointers"
ms.assetid: f6bb1f8b-891c-426e-9e14-0e7e5c62df70
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fseek, _fseeki64
Moves the file pointer to a specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of bytes from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Initial position.  
  
## Return Value  
 If successful, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns 0. Otherwise, it returns a nonzero value. On devices incapable of seeking, the return value is undefined. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, or if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not one of allowed values described below, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and return -1.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions moves the file pointer (if any) associated with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a new location that is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>*.* The next operation on the stream takes place at the new location. On a stream open for update, the next operation can be either a read or a write. The argument origin must be one of the following constants, defined in STDIO.H:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Current position of file pointer.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 End of file.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Beginning of file.  
  
 You can use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to reposition the pointer anywhere in a file. The pointer can also be positioned beyond the end of the file. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>clears the end-of-file indicator and negates the effect of any prior <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> calls against <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 When a file is opened for appending data, the current file position is determined by the last I/O operation, not by where the next write would occur. If no I/O operation has yet occurred on a file opened for appending, the file position is the start of the file.  
  
 For streams opened in text mode, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>have limited use, because carriage return–linefeed translations can cause <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>to produce unexpected results. The only <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>operations guaranteed to work on streams opened in text mode are:  
  
-   Seeking with an offset of 0 relative to any of the origin values.  
  
-   Seeking from the beginning of the file with an offset value returned from a call to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> when using <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>when using<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 Also in text mode, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading/writing, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and all related routines check for a CTRL+Z at the end of the file and remove it if possible. This is done because using the combination of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>or<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, to move within a file that ends with a CTRL+Z may cause <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to behave improperly near the end of the file.  
  
 When the CRT opens a file that begins with a Byte Order Mark (BOM), the file pointer is positioned after the BOM (that is, at the start of the file's actual content). If you have to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to the beginning of the file, use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to get the initial position and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to it rather than to position 0.  
  
 This function locks out other threads during execution and is therefore thread-safe. For a non-locking version, see [_fseek_nolock](../vs140/_fseek_nolock--_fseeki64_nolock.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **File pointer is set to middle of first line.**  
**This is the file 'fseek.out'.**   
## .NET Framework Equivalent  
  
-   [System::IO::FileStream::Position](https://msdn.microsoft.com/en-us/library/system.io.filestream.position.aspx)  
  
-   [System::IO::FileStream::Seek](https://msdn.microsoft.com/en-us/library/system.io.filestream.seek.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [ftell](../vs140/ftell--_ftelli64.md)   
 [_lseek, _lseeki64](../vs140/_lseek--_lseeki64.md)   
 [rewind](../vs140/rewind.md)