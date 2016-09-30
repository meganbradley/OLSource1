---
title: "CAsyncSocket::Accept"
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
  - "Accept"
  - "CAsyncSocket::Accept"
  - "CAsyncSocket.Accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Accept method"
ms.assetid: 12d6d079-a187-43b8-afe8-906b048d7a90
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Accept
Call this member function to accept a connection on a socket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference identifying a new socket that is available for connection.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that receives the address of the connecting socket, as known on the network. The exact format of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument is determined by the address family established when the socket was created. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and/or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are equal to **NULL**, then no information about the remote address of the accepted socket is returned.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the length of the address in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in bytes. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a value-result parameter: it should initially contain the amount of space pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; on return it will contain the actual length (in bytes) of the address returned.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> was not invoked prior to accept.  
  
-   **WSAEMFILE** The queue is empty upon entry to accept and there are no descriptors available.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> No buffer space is available.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP** The referenced socket is not a type that supports connection-oriented service.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and no connections are present to be accepted.  
  
## Remarks  
 This routine extracts the first connection in the queue of pending connections, creates a new socket with the same properties as this socket, and attaches it to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If no pending connections are present on the queue, **Accept** returns zero and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns an error. The accepted socket (*rConnectedSocket)* cannot be used to accept more connections. The original socket remains open and listening.  
  
 The argument <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a result parameter that is filled in with the address of the connecting socket, as known to the communications layer. **Accept** is used with connection-based socket types such as **SOCK_STREAM**.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::Listen](../vs140/casyncsocket--listen.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [WSAAsyncSelect](http://msdn.microsoft.com/library/windows/desktop/ms741540)