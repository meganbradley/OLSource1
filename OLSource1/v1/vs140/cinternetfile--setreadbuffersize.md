---
title: "CInternetFile::SetReadBufferSize"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CInternetFile::SetReadBufferSize
  - SetReadBufferSize
  - CInternetFile.SetReadBufferSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - buffers, size
  - CInternetFile class, operations
  - Internet files, buffer size
  - SetReadBufferSize method
ms.assetid: 9d7d5df2-3cc2-42ea-818e-fce38526827c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetFile::SetReadBufferSize
Call this member function to set the size of the temporary read buffer used by a `CInternetFile`-derived object.  
  
## Syntax  
  
```  
  
      BOOL SetReadBufferSize(  
  UINT nReadSize   
);  
```  
  
#### Parameters  
 *nReadSize*  
 The desired buffer size in bytes.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 The underlying WinInet APIs do not perform buffering, so choose a buffer size that allows your application to read data efficiently, regardless of the amount of data to be read. If each call to [Read](../vs140/cinternetfile--read.md) normally involves a large aount of data (for example, four or more kilobytes), you should not need a buffer. However, if you call **Read** to get small chunks of data, or if you use [ReadString](../vs140/cinternetfile--readstring.md) to read individual lines at a time, then a read buffer improves application performance.  
  
 By default, a `CInternetFile` object does not provide any buffering for reading. If you call this member function, you must be sure that the file has been opened for read access.  
  
 You can increase the buffer size at any time, but shrinking the buffer will have no effect. If you call [ReadString](../vs140/cinternetfile--readstring.md) without first calling `SetReadBufferSize`, you will get a buffer of 4096 bytes.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)