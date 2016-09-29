---
title: "_unlock_file"
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
  - "_unlock_file"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_unlock_file"
  - "unlock_file"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], unlocking"
  - "unlock_file function"
  - "_unlock_file function"
  - "unlocking files"
ms.assetid: cf380a51-6d3a-4f38-bd64-2d4fb57b4369
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _unlock_file
Unlocks a file, allowing other processes to access the file.  
  
## Syntax  
  
```  
void _unlock_file(  
   FILE* file  
);  
```  
  
#### Parameters  
 `file`  
 File handle.  
  
## Remarks  
 The `_unlock_file` function unlocks the file specified by `file`. Unlocking a file allows access to the file by other processes. This function should not be called unless `_lock_file` was previously called on the `file` pointer. Calling `_unlock_file` on a file that isn't locked may result in a deadlock. For an example, see [_lock_file](../vs140/_lock_file.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_unlock_file`|<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Lock](https://msdn.microsoft.com/en-us/library/system.io.filestream.lock.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_lock_file](../vs140/_lock_file.md)