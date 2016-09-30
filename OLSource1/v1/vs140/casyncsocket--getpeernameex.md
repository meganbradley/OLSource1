---
title: "CAsyncSocket::GetPeerNameEx"
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
  - "CAsyncSocket.GetPeerNameEx"
  - "ATL::CAsyncSocket::GetPeerNameEx"
  - "CAsyncSocket::GetPeerNameEx"
  - "ATL.CAsyncSocket.GetPeerNameEx"
  - "GetPeerNameEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSockPeerEx method"
ms.assetid: 0b145607-487c-4f6a-90c9-66afe48f8ad4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::GetPeerNameEx
Call this member function to get the address of the peer socket to which this socket is connected (handles IPv6 addresses).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 This function is the same as [CAsyncSocket::GetPeerName](../vs140/casyncsocket--getpeername.md) except that it handles IPv6 addresses as well as older protocols.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md)