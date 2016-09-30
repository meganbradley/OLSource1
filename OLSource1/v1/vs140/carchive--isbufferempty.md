---
title: "CArchive::IsBufferEmpty"
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
  - "CArchive.IsBufferEmpty"
  - "CArchive::IsBufferEmpty"
  - "IsBufferEmpty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsBufferEmpty function"
  - "socket archive buffer"
  - "CArchive class, status"
ms.assetid: 75b2007c-4039-4d45-b08d-21b7ce5bba9d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::IsBufferEmpty
Call this member function to determine whether the archive object's internal buffer is empty.  
  
## Syntax  
  
```  
  
BOOL IsBufferEmpty( ) const;  
```  
  
## Return Value  
 Nonzero if the archive's buffer is empty; otherwise 0.  
  
## Remarks  
 This function is supplied to support programming with the MFC Windows Sockets class `CSocketFile`. You do not need to use it for an archive associated with a `CFile` object.  
  
 The reason for using `IsBufferEmpty` with an archive associated with a `CSocketFile` object is that the archive's buffer might contain more than one message or record. After receiving one message, you should use `IsBufferEmpty` to control a loop that continues receiving data until the buffer is empty. For more information, see the [Receive](../vs140/casyncsocket--receive.md) member function of class `CAsyncSocket`, which shows how to use `IsBufferEmpty`.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSocketFile Class](../vs140/csocketfile-class.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)