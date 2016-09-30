---
title: "CAsyncSocket::Close"
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
  - "CAsyncSocket::Close"
  - "CAsyncSocket.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
ms.assetid: 41a847bd-1e7b-4edb-97e3-64f1df7adf1b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Close
Closes the socket.  
  
## Syntax  
  
```  
  
virtual void Close( );  
```  
  
## Remarks  
 This function releases the socket descriptor so that further references to it will fail with the error **WSAENOTSOCK**. If this is the last reference to the underlying socket, the associated naming information and queued data are discarded. The socket object's destructor calls **Close** for you.  
  
 For `CAsyncSocket`, but not for `CSocket`, the semantics of **Close** are affected by the socket options **SO_LINGER** and **SO_DONTLINGER**. For further information, see member function `GetSockOpt`.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Accept](../vs140/casyncsocket--accept.md)   
 [CAsyncSocket::CAsyncSocket](../vs140/casyncsocket--casyncsocket.md)   
 [CAsyncSocket::IOCtl](../vs140/casyncsocket--ioctl.md)   
 [CAsyncSocket::GetSockOpt](../vs140/casyncsocket--getsockopt.md)   
 [CAsyncSocket::SetSockOpt](../vs140/casyncsocket--setsockopt.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)