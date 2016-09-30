---
title: "setbuf"
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
  - "setbuf"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "setbuf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "setbuf function"
  - "stream buffering"
ms.assetid: 13beda22-7b56-455d-8a6c-f2eb636885b9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setbuf
Controls stream buffering. This function is deprecated; use [setvbuf](../vs140/setvbuf.md) instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-allocated buffer.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function controls buffering for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument must refer to an open file that has not been read or written. If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the stream is un-buffered. If not, the buffer must point to a character array of length <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the buffer size as defined in STDIO.H. The user-specified buffer, instead of the default system-allocated buffer for the given stream, is used for I/O buffering. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> stream is un-buffered by default, but you can use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to assign buffers to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> has been replaced by [setvbuf](../vs140/setvbuf.md), which is the preferred routine for new code. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is retained for compatibility with existing code.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **stream1 set to user-defined buffer at: 0012FCDC**  
**stream2 buffering disabled**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [fflush](../vs140/fflush.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [setvbuf](../vs140/setvbuf.md)