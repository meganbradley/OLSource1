---
title: "CAsyncSocket::AsyncSelect"
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
  - "CAsyncSocket.AsyncSelect"
  - "CAsyncSocket::AsyncSelect"
  - "AsyncSelect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AsyncSelect method"
ms.assetid: 4713f26e-621c-47bd-a140-e3886d141cbd
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::AsyncSelect
Call this member function to request event notification for a socket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification when data is available to be read.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of connection results.  
  
-   **FD_CLOSE** Want to receive notification when a socket has been closed by a peer.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** Indicates that one of the specified parameters was invalid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
## Remarks  
 This function is used to specify which MFC callback notification functions will be called for the socket. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> automatically sets this socket to nonblocking mode. For more information, see the article [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [WSAAsyncSelect](http://msdn.microsoft.com/library/windows/desktop/ms741540)