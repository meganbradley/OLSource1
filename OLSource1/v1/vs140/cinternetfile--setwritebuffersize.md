---
title: "CInternetFile::SetWriteBufferSize"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CInternetFile.SetWriteBufferSize"
  - "CInternetFile::SetWriteBufferSize"
  - "SetWriteBufferSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "buffers, size"
  - "SetWriteBufferSize method"
  - "CInternetFile class, operations"
  - "Internet files, buffer size"
ms.assetid: 5e7ddaf5-35b6-4012-8b52-ffcf86d86fb6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::SetWriteBufferSize
Call this member function to set the size of the temporary write buffer used by a `CInternetFile`-derived object.  
  
## Syntax  
  
```  
  
      BOOL SetWriteBufferSize(  
  UINT nWriteSize   
);  
```  
  
#### Parameters  
 *nWriteSize*  
 The size of the buffer in bytes.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 The underlying WinInet APIs don't perform buffering, so choose a buffer size that allows your application to write data efficiently regardless of the amount of data to be written. If each call to [Write](../vs140/cinternetfile--write.md) normally involves a large amount of data (for example, four or more kilobytes at a time), you should not need a buffer. However, if you call [Write](../vs140/cinternetfile--write.md) to write small chunks of data, a write buffer improves your application's performance.  
  
 By default, a `CInternetFile` object does not provide any buffering for writing. If you call this member function, you must be sure that the file has been opened for write access. You can change the size of the write buffer at any time, but doing so causes an implicit call to [Flush](../vs140/cinternetfile--flush.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)