---
title: "CInternetConnection::CInternetConnection"
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
  - "CInternetConnection.CInternetConnection"
  - "CInternetConnection::CInternetConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetConnection class, constructor"
ms.assetid: 22aca50b-9ea5-4d8a-8d51-3253867e3679
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetConnection::CInternetConnection
This member function is called when a `CInternetConnection` object is created.  
  
## Syntax  
  
```  
  
      CInternetConnection(  
   CInternetSession* pSession,  
   LPCTSTR pstrServer,  
   INTERNET_PORT nPort = INTERNET_INVALID_PORT_NUMBER,  
   DWORD_PTR dwContext = 1   
);  
```  
  
#### Parameters  
 `pSession`  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 `pstrServer`  
 A pointer to a string containing the server name.  
  
 `nPort`  
 The number that identifies the Internet port for this connection.  
  
 `dwContext`  
 The context identifier for the `CInternetConnection` object. See **Remarks** for more information about `dwContext`.  
  
## Remarks  
 You never call `CInternetConnection` yourself; instead, call the [CInternetSession](../vs140/cinternetsession-class.md) member function for the type of connection you want to establish:  
  
-   [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md)  
  
-   [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md)  
  
-   [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md)  
  
 The default value for `dwContext` is sent by MFC to the `CInternetConnection`-derived object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the **InternetConnection**-derived object. The default is set to 1; however, you can explicitly assign a specific context identifier in the [CInternetSession](../vs140/cinternetsession--cinternetsession.md) constructor for the connection. The object and any work it does will be associated with that context ID. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)