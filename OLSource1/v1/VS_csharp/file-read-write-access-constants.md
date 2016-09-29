---
title: "File Read-Write Access Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "File Read/Write Access Constants"
f1_keywords: 
  - "c.constants.file"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "read/write access constants"
  - "write access constants"
  - "access constants for file read/write"
  - "constants [C++], file attributes"
  - "file read/write access constants"
ms.assetid: 56cd1d22-39a5-4fcf-bea2-7046d249e8ee
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Read-Write Access Constants
## Syntax  
  
```  
  
#include <stdio.h>  
```  
  
## Remarks  
 These constants specify the access type ("a", "r", or "w") requested for the file. Both the [translation mode](../VS_csharp/file-translation-constants.md) ("b" or "t") and the [commit-to-disk mode](../VS_csharp/commit-to-disk-constants.md) ("c" or "n") can be specified with the type of access.  
  
 The access types are described below.  
  
 **"a"**  
 Opens for writing at the end of the file (appending); creates the file first if it does not exist. All write operations occur at the end of the file. Although the file pointer can be repositioned using `fseek` or **rewind**, it is always moved back to the end of the file before any write operation is carried out.  
  
 **"a+"**  
 Same as above, but also allows reading.  
  
 **"r"**  
 Opens for reading. If the file does not exist or cannot be found, the call to open the file will fail.  
  
 **"r+"**  
 Opens for both reading and writing. If the file does not exist or cannot be found, the call to open the file will fail.  
  
 **"w"**  
 Opens an empty file for writing. If the given file exists, its contents are destroyed.  
  
 **"w+"**  
 Opens an empty file for both reading and writing. If the given file exists, its contents are destroyed.  
  
 When the "r+", "w+", or "a+" type is specified, both reading and writing are allowed (the file is said to be open for "update"). However, when you switch between reading and writing, there must be an intervening `fflush`, `fsetpos`, `fseek`, or **rewind** operation. The current position can be specified for the `fsetpos` or `fseek` operation.  
  
## See Also  
 [_fdopen, _wfdopen](../VS_csharp/_fdopen--_wfdopen.md)   
 [fopen, _wfopen](../VS_csharp/fopen--_wfopen.md)   
 [freopen, _wfreopen](../VS_csharp/freopen--_wfreopen.md)   
 [_fsopen, _wfsopen](../VS_csharp/_fsopen--_wfsopen.md)   
 [_popen, _wpopen](../VS_csharp/_popen--_wpopen.md)   
 [Global Constants](../VS_csharp/global-constants.md)