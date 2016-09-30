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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CASyncSocket::Socket
Allocates a socket handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bitmask that specifies a combination of network events in which the application is interested.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: Want to receive notification of readiness for reading.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>: Want to receive notification of readiness for writing.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>: Want to receive notification of the arrival of out-of-band data.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>: Want to receive notification of incoming connections.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>: Want to receive notification of completed connection.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>: Want to receive notification of socket closure.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Protocol to be used with the socket that is specific to the indicated address family.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Address family specification.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 This method allocates a socket handle. It does not call [Bind](../vs140/casyncsocket--bind.md) to bind the socket to a specified address, so you need to call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> later to bind the socket to a specified address. You can use [SetSockOpt](../vs140/casyncsocket--setsockopt.md) to set the socket option before it is bound.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)