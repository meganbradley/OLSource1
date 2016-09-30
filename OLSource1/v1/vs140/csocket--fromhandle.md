---
title: "CSocket::FromHandle"
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
  - "CSocket.FromHandle"
  - "CSocket::FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
ms.assetid: b48ab8d0-a99f-4201-a223-bdb73d5bdde3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocket::FromHandle
Returns a pointer to a `CSocket` object.  
  
## Syntax  
  
```  
  
      static CSocket* PASCAL FromHandle(  
   SOCKET hSocket   
);  
```  
  
#### Parameters  
 `hSocket`  
 Contains a handle to a socket.  
  
## Return Value  
 A pointer to a `CSocket` object, or **NULL** if there is no `CSocket` object attached to `hSocket`.  
  
## Remarks  
 When given a **SOCKET** handle, if a `CSocket` object is not attached to the handle, the member function returns **NULL** and does not create a temporary object.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CSocket Class](../vs140/csocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::FromHandle](../vs140/casyncsocket--fromhandle.md)