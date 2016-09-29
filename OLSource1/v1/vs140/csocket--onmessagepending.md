---
title: "CSocket::OnMessagePending"
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
  - "CSocket::OnMessagePending"
  - "OnMessagePending"
  - "CSocket.OnMessagePending"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMessagePending method"
ms.assetid: 715e6082-72a7-4d44-8c09-f028d8285288
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocket::OnMessagePending
Override this member function to look for particular messages from Windows and respond to them in your socket.  
  
## Syntax  
  
```  
  
virtual BOOL OnMessagePending( );  
```  
  
## Return Value  
 Nonzero if the message was handled; otherwise 0.  
  
## Remarks  
 This is an advanced overridable.  
  
 The framework calls `OnMessagePending` while the socket is pumping Windows messages to give you an opportunity to deal with messages of interest to your application. For examples of how you might use `OnMessagePending`, see the article [Windows Sockets: Deriving from Socket Classes](../vs140/windows-sockets--deriving-from-socket-classes.md).  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CSocket Class](../vs140/csocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSocket::CancelBlockingCall](../vs140/csocket--cancelblockingcall.md)   
 [CSocket::IsBlocking](../vs140/csocket--isblocking.md)