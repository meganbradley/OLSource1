---
title: "CAsyncSocket::OnConnect"
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
  - "CAsyncSocket::OnConnect"
  - "OnConnect"
  - "CAsyncSocket.OnConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnConnect method"
ms.assetid: b20a26af-d80f-4dad-b720-3c1cac59d0c0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::OnConnect
Called by the framework to notify this connecting socket that its connection attempt is completed, whether successfully or in error.  
  
## Syntax  
  
```  
  
      virtual void OnConnect(  
   int nErrorCode   
);  
```  
  
#### Parameters  
 `nErrorCode`  
 The most recent error on a socket. The following error codes apply to the `OnConnect` member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAEADDRINUSE** The specified address is already in use.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAECONNREFUSED** The attempt to connect was forcefully rejected.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAEFAULT** The `lpSockAddrLen` argument is incorrect.  
  
-   **WSAEINVAL** The socket is already bound to an address.  
  
-   **WSAEISCONN** The socket is already connected.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
-   `WSAENOBUFS` No buffer space is available. The socket cannot be connected.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is a file, not a socket.  
  
-   **WSAETIMEDOUT** The attempt to connect timed out without establishing a connection.  
  
## Remarks  
  
> [!NOTE]
>  In [CSocket](../vs140/csocket-class.md), the `OnConnect` notification function is never called. For connections, you simply call **Connect**, which will return when the connection is completed (either successfully or in error). How connection notifications are handled is an MFC implementation detail.  
  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Example  
 [!code[NVC_MFCAsyncSocket#1](../vs140/codesnippet/CPP/casyncsocket--onconnect_1.cpp)]  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [CAsyncSocket::OnAccept](../vs140/casyncsocket--onaccept.md)   
 [CAsyncSocket::OnClose](../vs140/casyncsocket--onclose.md)   
 [CAsyncSocket::OnOutOfBandData](../vs140/casyncsocket--onoutofbanddata.md)   
 [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md)   
 [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md)