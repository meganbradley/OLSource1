---
title: "CAsyncSocket::OnSend"
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
  - "OnSend"
  - "CAsyncSocket::OnSend"
  - "CAsyncSocket.OnSend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSend method"
ms.assetid: d2d3fa87-30e2-4dd2-852e-2d509ac93b90
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::OnSend
Called by the framework to notify the socket that it can now send data by calling the **Send** member function.  
  
## Syntax  
  
```  
  
      virtual void OnSend(  
   int nErrorCode   
);  
```  
  
#### Parameters  
 `nErrorCode`  
 The most recent error on a socket. The following error codes apply to the `OnSend` member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
## Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
## Example  
 [!code[NVC_MFCAsyncSocket#3](../vs140/codesnippet/CPP/casyncsocket--onsend_1.cpp)]  
  
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
 [CAsyncSocket::OnReceive](../vs140/casyncsocket--onreceive.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)