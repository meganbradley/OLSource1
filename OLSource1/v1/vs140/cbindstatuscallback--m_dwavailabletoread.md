---
title: "CBindStatusCallback::m_dwAvailableToRead"
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
  - ATL.CBindStatusCallback.m_dwAvailableToRead
  - CBindStatusCallback::m_dwAvailableToRead
  - ATL::CBindStatusCallback::m_dwAvailableToRead
  - m_dwAvailableToRead
  - CBindStatusCallback.m_dwAvailableToRead
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_dwAvailableToRead
ms.assetid: e5c672d1-7ed8-42fe-a6ee-e2666431c818
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBindStatusCallback::m_dwAvailableToRead
Can be used to store the number of bytes available to be read.  
  
## Syntax  
  
```  
  
DWORD m_dwAvailableToRead;  
  
```  
  
## Remarks  
 Initialized to zero in `StartAsyncDownload`.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)