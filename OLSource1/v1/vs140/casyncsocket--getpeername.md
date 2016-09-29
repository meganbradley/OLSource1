---
title: "CAsyncSocket::GetPeerName"
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
  - "CAsyncSocket.GetPeerName"
  - "CAsyncSocket::GetPeerName"
  - "GetPeerName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPeerName method"
ms.assetid: 9dd6ca6e-aed7-4dfe-b469-e356ba99612d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::GetPeerName
Call this member function to get the address of the peer socket to which this socket is connected.  
  
## Syntax  
  
```  
  
      BOOL GetPeerName(  
   CString& rPeerAddress,  
   UINT& rPeerPort   
);  
BOOL GetPeerName(  
   SOCKADDR* lpSockAddr,  
   int* lpSockAddrLen   
);  
```  
  
#### Parameters  
 `rPeerAddress`  
 Reference to a `CString` object that receives a dotted number IP address.  
  
 `rPeerPort`  
 Reference to a **UINT** that stores a port.  
  
 `lpSockAddr`  
 A pointer to the [SOCKADDR](../vs140/sockaddr-structure.md) structure that receives the name of the peer socket.  
  
 `lpSockAddrLen`  
 A pointer to the length of the address in `lpSockAddr` in bytes. On return, the `lpSockAddrLen` argument contains the actual size of `lpSockAddr` returned in bytes.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The `lpSockAddrLen` argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 To handle IPv6 addresses, use [CAsyncSocket::GetPeerNameEx](../vs140/casyncsocket--getpeernameex.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md)