---
title: "CAsyncSocket::OnAccept"
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
  - "OnAccept"
  - "CAsyncSocket.OnAccept"
  - "CAsyncSocket::OnAccept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAccept method"
ms.assetid: 4272a1bf-4cc9-4246-8e46-d3398ea15fca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::OnAccept
Called by the framework to notify a listening socket that it can accept pending connection requests by calling the [Accept](../vs140/casyncsocket--accept.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes applies to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
## Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Accept](../vs140/casyncsocket--accept.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [CAsyncSocket::OnClose](../vs140/casyncsocket--onclose.md)   
 [CAsyncSocket::OnConnect](../vs140/casyncsocket--onconnect.md)   
 [CAsyncSocket::OnOutOfBandData](../vs140/casyncsocket--onoutofbanddata.md)   
 [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md)   
 [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md)