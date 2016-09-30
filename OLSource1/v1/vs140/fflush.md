---
title: "fflush"
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
  - "fflush"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fflush"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, flushing"
  - "flushing"
  - "fflush function"
ms.assetid: 8bbc753f-dc74-4e77-b563-74da2835e92b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fflush
Flushes a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns 0 if the buffer was successfully flushed. The value 0 is also returned in cases in which the specified stream has no buffer or is open for reading only. A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> indicates an error.  
  
> [!NOTE]
>  If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, data may have been lost due to a write failure. When setting up a critical error handler, it is safest to turn buffering off with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function or to use low-level I/O routines such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instead of the stream I/O functions.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function flushes the stream <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If the stream was opened in write mode, or it was opened in update mode and the last operation was a write, the contents of the stream buffer are written to the underlying file or device and the buffer is discarded. If the stream was opened in read mode, or if the stream has no buffer, the call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has no effect, and any buffer is retained. A call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> negates the effect of any prior call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for the stream. The stream remains open after the call.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the behavior is the same as a call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> on each open stream. All streams opened in write mode and all streams opened in update mode where the last operation was a write are flushed. The call has no effect on other streams.  
  
 Buffers are normally maintained by the operating system, which determines the optimal time to write the data automatically to disk: when a buffer is full, when a stream is closed, or when a program terminates normally without closing the stream. The commit-to-disk feature of the run-time library lets you ensure that critical data is written directly to disk rather than to the operating-system buffers. Without rewriting an existing program, you can enable this feature by linking the program's object files with COMMODE.OBJ. In the resulting executable file, calls to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> write the contents of all buffers to disk. Only <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are affected by COMMODE.OBJ.  
  
 For information about controlling the commit-to-disk feature, see [Stream I/O](../vs140/stream-i-o.md), [fopen](../vs140/fopen--_wfopen.md), and [_fdopen](../vs140/_fdopen--_wfdopen.md).  
  
 This function locks the calling thread and is therefore thread-safe. For a non-locking version, see <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Enter a sentence of four words with scanf: This is a test**  
**This**  
**is**  
**a**  
**test**  
**Enter the same sentence with gets: This is a test**  
**This is a test**   
## .NET Framework Equivalent  
 [System::IO::FileStream::Flush](https://msdn.microsoft.com/en-us/library/2bw4h516.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_flushall](../vs140/_flushall.md)   
 [setvbuf](../vs140/setvbuf.md)