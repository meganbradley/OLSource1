---
title: "fwrite"
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
  - "fwrite"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fwrite"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, writing data to"
  - "fwrite function"
ms.assetid: 7afacf3a-72d7-4a50-ba2e-bea1ab9f4124
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fwrite
Writes data to a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to data to be written.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Item size, in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum number of items to be written.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the number of full items actually written, which may be less than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if an error occurs. Also, if an error occurs, the file-position indicator cannot be determined. If either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, or if an odd number of bytes to be written is specified in Unicode mode, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and returns 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function writes up to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> items, of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> length each, from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to the output <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The file pointer associated with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (if there is one) is incremented by the number of bytes actually written. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is opened in text mode, each linefeed is replaced with a carriage-return – linefeed pair. The replacement has no effect on the return value.  
  
 When <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is opened in Unicode translation mode—for example, if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is opened by calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and using a mode parameter that includes <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or if the mode is changed to a Unicode translation mode by using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and a mode parameter that includes <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>—<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is interpreted as a pointer to an array of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that contains UTF-16 data. An attempt to write an odd number of bytes in this mode causes a parameter validation error.  
  
 Because this function locks the calling thread, it is thread-safe. For a non-locking version, see <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [fread](../vs140/fread.md).  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Write](https://msdn.microsoft.com/en-us/library/system.io.filestream.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_setmode](../vs140/_setmode.md)   
 [fread](../vs140/fread.md)   
 [_fwrite_nolock](../vs140/_fwrite_nolock.md)   
 [_write](../vs140/_write.md)