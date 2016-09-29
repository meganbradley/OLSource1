---
title: "CAsyncSocket::CAsyncSocket"
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
  - "CAsyncSocket::CAsyncSocket"
  - "CAsyncSocket.CAsyncSocket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAsyncSocket class, constructor"
ms.assetid: 9fee6af3-e9cc-47d6-ba7e-e1759a9c65d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::CAsyncSocket
Constructs a blank socket object.  
  
## Syntax  
  
```  
  
CAsyncSocket( );  
```  
  
## Remarks  
 After constructing the object, you must call its **Create** member function to create the **SOCKET** data structure and bind its address. (On the server side of a Windows Sockets communication, when the listening socket creates a socket to use in the **Accept** call, you do not call **Create** for that socket.)  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)