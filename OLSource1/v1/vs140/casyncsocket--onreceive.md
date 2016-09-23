---
title: "CAsyncSocket::OnReceive"
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
  - CAsyncSocket::OnReceive
  - OnReceive
  - CAsyncSocket.OnReceive
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnReceive method
ms.assetid: 4a056dd8-8987-4476-b394-6e298313606c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncSocket::OnReceive
Called by the framework to notify this socket that there is data in the buffer that can be retrieved by calling the **Receive** member function.  
  
## Syntax  
  
```  
  
      virtual void OnReceive(  
   int nErrorCode   
);  
```  
  
#### Parameters  
 `nErrorCode`  
 The most recent error on a socket. The following error codes apply to the `OnReceive` member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
## Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Example  
 [!code[NVC_MFCAsyncSocket#2](../vs140/codesnippet/CPP/casyncsocket--onreceive_1.cpp)]
  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::GetLastError](../vs140/casyncsocket--getlasterror.md)   
 [CAsyncSocket::OnAccept](../vs140/casyncsocket--onaccept.md)   
 [CAsyncSocket::OnClose](../vs140/casyncsocket--onclose.md)   
 [CAsyncSocket::OnConnect](../vs140/casyncsocket--onconnect.md)   
 [CAsyncSocket::OnOutOfBandData](../vs140/casyncsocket--onoutofbanddata.md)   
 [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)