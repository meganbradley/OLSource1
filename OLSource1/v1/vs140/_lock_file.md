---
title: "_lock_file"
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
  - "_lock_file"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_lock_file"
  - "lock_file"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file locking [C++]"
  - "_lock_file function"
  - "lock_file function"
ms.assetid: 75c7e0e6-efff-4747-b6ed-9bcf2b0894c3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lock_file
Locks a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to ensure consistency for threads accessing the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object concurrently.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File handle.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function locks the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The underlying file is not locked by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Use [_unlock_file](../vs140/_unlock_file.md) to release the lock on the file. Calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be matched in a thread.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **...**  
**First**  
**Second**  
**First**  
**Second**  
**Third**  
**Second**  
**Third**  
**Second**  
**...**  
**FSiercsotn**  
**dF**  
**iSrescto**  
**nFdi**  
**rSsetc**  
**oFnidr**  
**sSte**  
**cFoinrds**  
**tS**  
**eFciornsdt**   
## .NET Framework Equivalent  
 [System::IO::FileStream::Lock](https://msdn.microsoft.com/en-us/library/system.io.filestream.lock.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_unlock_file](../vs140/_unlock_file.md)