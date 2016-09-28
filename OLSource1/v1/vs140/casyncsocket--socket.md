---
title: "CASyncSocket::Socket"
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
  - "Socket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Socket method"
ms.assetid: 1aa82fc1-aa46-495b-b727-1c968b27ee03
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CASyncSocket::Socket
Allocates a socket handle.  
  
## Syntax  
  
```  
BOOL Socket(  
   int nSocketType = SOCK_STREAM,  
   long lEvent = FD_READ | FD_WRITE | FD_OOB | FD_ACCEPT | FD_CONNECT | FD_CLOSE,  
   int nProtocolType = 0,  
   int nAddressFormat = PF_INET  
);  
```  
  
#### Parameters  
 `nSocketType`  
 Specifies `SOCK_STREAM` or `SOCK_DGRAM`.  
  
 `lEvent`  
 A bitmask that specifies a combination of network events in which the application is interested.  
  
-   `FD_READ`: Want to receive notification of readiness for reading.  
  
-   `FD_WRITE`: Want to receive notification of readiness for writing.  
  
-   `FD_OOB`: Want to receive notification of the arrival of out-of-band data.  
  
-   `FD_ACCEPT`: Want to receive notification of incoming connections.  
  
-   `FD_CONNECT`: Want to receive notification of completed connection.  
  
-   `FD_CLOSE`: Want to receive notification of socket closure.  
  
 `nProtocolType`  
 Protocol to be used with the socket that is specific to the indicated address family.  
  
 `nAddressFormat`  
 Address family specification.  
  
## Return Value  
 Returns `TRUE` on success, `FALSE` on failure.  
  
## Remarks  
 This method allocates a socket handle. It does not call [Bind](../vs140/casyncsocket--bind.md) to bind the socket to a specified address, so you need to call `Bind` later to bind the socket to a specified address. You can use [SetSockOpt](../vs140/casyncsocket--setsockopt.md) to set the socket option before it is bound.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)