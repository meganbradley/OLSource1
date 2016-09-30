---
title: "CAsyncSocket::OnClose"
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
  - "CAsyncSocket::OnClose"
  - "CAsyncSocket.OnClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClose method"
ms.assetid: 941a2eec-a428-468e-a33e-d8a2603c2cb2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::OnClose
Called by the framework to notify this socket that the connected socket is closed by its process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAECONNRESET** The connection was reset by the remote side.  
  
-   **WSAECONNABORTED** The connection was aborted due to timeout or other failure.  
  
## Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Close](../vs140/casyncsocket--close.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [CAsyncSocket::OnAccept](../vs140/casyncsocket--onaccept.md)   
 [CAsyncSocket::OnConnect](../vs140/casyncsocket--onconnect.md)   
 [CAsyncSocket::OnOutOfBandData](../vs140/casyncsocket--onoutofbanddata.md)   
 [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md)   
 [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md)