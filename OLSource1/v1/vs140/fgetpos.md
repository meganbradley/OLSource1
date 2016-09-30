---
title: "fgetpos"
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
  - "fgetpos"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fgetpos"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fgetpos function"
  - "streams, file position indicator"
ms.assetid: bfa05c38-1135-418c-bda1-d41be51acb62
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fgetpos
Gets a stream's file-position indicator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Target stream.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Position-indicator storage.  
  
## Return Value  
 If successful, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns 0. On failure, it returns a nonzero value and sets <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to one of the following manifest constants (defined in STDIO.H): <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which means the specified stream is not a valid file pointer or is not accessible, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which means the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value or the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is invalid, such as if either is a null pointer. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function gets the current value of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument's file-position indicator and stores it in the object pointed to by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function can later use information stored in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to reset the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument's pointer to its position at the time <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> was called. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value is stored in an internal format and is intended for use only by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_fgetpos.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output crt_fgetpos.txt  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::FileStream::Position](https://msdn.microsoft.com/en-us/library/system.io.filestream.position.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fsetpos](../vs140/fsetpos.md)