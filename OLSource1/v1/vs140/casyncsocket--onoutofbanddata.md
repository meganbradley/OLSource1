---
title: "CAsyncSocket::OnOutOfBandData"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnOutOfBandData
  - CAsyncSocket::OnOutOfBandData
  - CAsyncSocket.OnOutOfBandData
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnOutOfBandData method
ms.assetid: 410c2ce7-cb1e-42cb-8437-917fec7e6ca2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncSocket::OnOutOfBandData
Called by the framework to notify the receiving socket that the sending socket has out-of-band data to send.  
  
## Syntax  
  
```  
  
      virtual void OnOutOfBandData(  
   int nErrorCode   
);  
```  
  
#### Parameters  
 `nErrorCode`  
 The most recent error on a socket. The following error codes apply to the `OnOutOfBandData` member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
## Remarks  
 Out-of-band data is a logically independent channel that is associated with each pair of connected sockets of type **SOCK_STREAM**. The channel is generally used to send urgent data.  
  
 MFC supports out-of-band data, but users of class `CAsyncSocket` are discouraged from using it. The easier way is to create a second socket for passing such data. For more information about out-of-band data, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [CAsyncSocket::OnAccept](../vs140/casyncsocket--onaccept.md)   
 [CAsyncSocket::OnClose](../vs140/casyncsocket--onclose.md)   
 [CAsyncSocket::OnConnect](../vs140/casyncsocket--onconnect.md)   
 [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md)   
 [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md)