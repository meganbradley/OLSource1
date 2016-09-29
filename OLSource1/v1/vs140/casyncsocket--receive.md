---
title: "CAsyncSocket::Receive"
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
  - "Receive"
  - "CAsyncSocket.Receive"
  - "CAsyncSocket::Receive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Receive method"
ms.assetid: 0806dd45-93f1-4e7f-af4d-63cc3f12cb85
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Receive
Call this member function to receive data from a socket.  
  
## Syntax  
  
```  
  
      virtual int Receive(  
   void* lpBuf,  
   int nBufLen,  
   int nFlags = 0   
);  
```  
  
#### Parameters  
 `lpBuf`  
 A buffer for the incoming data.  
  
 `nBufLen`  
 The length of `lpBuf` in bytes.  
  
 `nFlags`  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the `nFlags` parameter. The latter is constructed by combining any of the following values with the C++ `OR` operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
## Return Value  
 If no error occurs, **Receive** returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call **Receive** on a socket after `ShutDown` has been invoked with `nHow` set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the **Receive** operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
## Remarks  
 This function is used for connected stream or datagram sockets and is used to read incoming data.  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtl SIOCATMARK** option or [OnOutOfBandData](../vs140/casyncsocket--onoutofbanddata.md) to determine whether any more out-of-band data remains to be read.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the datagram, the excess data is lost, and **Receive** returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**. If no incoming data is available at the socket, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The [OnReceive](../vs140/casyncsocket--onreceive.md) callback function can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a **Receive** will complete immediately with 0 bytes received. If the connection has been reset, a **Receive** will fail with the error **WSAECONNRESET**.  
  
 **Receive** should be called only once for each time [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md) is called.  
  
## Example  
 See the example for [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::ReceiveFrom](../vs140/casyncsocket--receivefrom.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)