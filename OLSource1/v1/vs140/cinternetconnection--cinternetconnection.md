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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetConnection::CInternetConnection
This member function is called when a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is created.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string containing the server name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number that identifies the Internet port for this connection.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. See **Remarks** for more information about <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 You never call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> yourself; instead, call the [CInternetSession](../vs140/cinternetsession-class.md) member function for the type of connection you want to establish:  
  
-   [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md)  
  
-   [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md)  
  
-   [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md)  
  
 The default value for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-derived object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the **InternetConnection**-derived object. The default is set to 1; however, you can explicitly assign a specific context identifier in the [CInternetSession](../vs140/cinternetsession--cinternetsession.md) constructor for the connection. The object and any work it does will be associated with that context ID. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)