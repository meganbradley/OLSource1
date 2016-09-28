---
title: "CAsyncSocket::ShutDown"
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
  - "CAsyncSocket::ShutDown"
  - "ShutDown"
  - "CAsyncSocket.ShutDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShutDown method"
ms.assetid: bf918cc9-1b7d-44f7-92f2-5cfef7fa5f6f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::ShutDown
Call this member function to disable sends, receives, or both on the socket.  
  
## Syntax  
  
```  
  
      BOOL ShutDown(  
   int nHow = sends   
);  
```  
  
#### Parameters  
 `nHow`  
 A flag that describes what types of operation will no longer be allowed, using the following enumerated values:  
  
-   **receives = 0**  
  
-   **sends = 1**  
  
-   **both = 2**  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** `nHow` is not valid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTCONN** The socket is not connected (**SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 `ShutDown` is used on all types of sockets to disable reception, transmission, or both. If `nHow` is 0, subsequent receives on the socket will be disallowed. This has no effect on the lower protocol layers.  
  
 For Transmission Control Protocol (TCP), the TCP window is not changed and incoming data will be accepted (but not acknowledged) until the window is exhausted. For User Datagram Protocol (UDP), incoming datagrams are accepted and queued. In no case will an ICMP error packet be generated. If `nHow` is 1, subsequent sends are disallowed. For TCP sockets, a FIN will be sent. Setting `nHow` to 2 disables both sends and receives as described above.  
  
 Note that `ShutDown` does not close the socket, and resources attached to the socket will not be freed until **Close** is called. An application should not rely on being able to reuse a socket after it has been shut down. In particular, a Windows Sockets implementation is not required to support the use of **Connect** on such a socket.  
  
## Example  
 See the example for [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)