---
title: "_commit"
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
  - "_commit"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_commit"
  - "commit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], flushing"
  - "flushing files to disk"
  - "commit function"
  - "_commit function"
  - "committing files to disk"
ms.assetid: d0c74d3a-4f2d-4fb0-b140-2d687db3d233
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _commit
Flushes a file directly to disk.  
  
## Syntax  
  
```  
int _commit(   
   int fd   
);  
```  
  
#### Parameters  
 `fd`  
 File descriptor referring to the open file.  
  
## Return Value  
 `_commit` returns 0 if the file was successfully flushed to disk. A return value of –1 indicates an error.  
  
## Remarks  
 The `_commit` function forces the operating system to write the file associated with `fd` to disk. This call ensures that the specified file is flushed immediately, not at the operating system's discretion.  
  
 If `fd` is an invalid file descriptor, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and `errno` is set to `EBADF`.  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|`_commit`|\<io.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_read](../vs140/_read.md)   
 [_write](../vs140/_write.md)