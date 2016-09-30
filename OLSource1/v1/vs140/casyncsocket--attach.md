---
title: "CAsyncSocket::Attach"
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
  - "CAsyncSocket.Attach"
  - "CAsyncSocket::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [MFC]"
ms.assetid: 2fab3bf8-fd2b-43b4-b57a-42e4e0ca3c99
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Attach
Call this member function to attach the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> handle to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains a handle to a socket.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification when data is available to be read.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of connection results.  
  
-   **FD_CLOSE** Want to receive notification when a socket has been closed by a peer.  
  
## Return Value  
 Nonzero if the function is successful.  
  
## Remarks  
 The **SOCKET** handle is stored in the object's [m_hSocket](../vs140/casyncsocket--m_hsocket.md) data member.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Detach](../vs140/casyncsocket--detach.md)