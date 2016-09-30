---
title: "CAsyncSocket::GetLastError"
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
  - "CAsyncSocket.GetLastError"
  - "CAsyncSocket::GetLastError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLastError method"
ms.assetid: ff1a1772-5abb-426b-afc6-6cdef8442c70
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::GetLastError
Call this member function to get the error status for the last operation that failed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The return value indicates the error code for the last Windows Sockets API routine performed by this thread.  
  
## Remarks  
 When a particular member function indicates that an error has occurred, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> should be called to retrieve the appropriate error code. See the individual member function descriptions for a list of applicable error codes.  
  
 For more information about the error codes, see [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WSASetLastError](http://msdn.microsoft.com/library/windows/desktop/ms742209)