---
title: "CAsyncSocket::GetSockNameEx"
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
  - "ATL.CAsyncSocket.GetSockNameEx"
  - "GetSockNameEx"
  - "CAsyncSocket.GetSockNameEx"
  - "ATL::CAsyncSocket::GetSockNameEx"
  - "CAsyncSocket::GetSockNameEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSockNameEx method"
ms.assetid: 29c2c595-bd4b-4b42-bda5-b021c987b209
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::GetSockNameEx
Call this member function to get the local name for a socket (handles IPv6 addresses).  
  
## Syntax  
  
```  
  
      BOOL GetSockNameEx(  
   CString& rSocketAddress,  
   UINT& rSocketPort   
);  
```  
  
#### Parameters  
 `rSocketAddress`  
 Reference to a `CString` object that receives a dotted number IP address.  
  
 `rSocketPort`  
 Reference to a **UINT** that stores a port.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The `lpSockAddrLen` argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEINVAL** The socket has not been bound to an address with **Bind**.  
  
## Remarks  
 This call is the same as [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md) except that it handles IPv6 addresses as well as older protocols.  
  
 This call is especially useful when a **Connect** call has been made without doing a **Bind** first; this call provides the only means by which you can determine the local association which has been set by the system.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::GetPeerName](../vs140/casyncsocket--getpeername.md)