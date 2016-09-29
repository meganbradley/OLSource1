---
title: "CInternetConnection::GetSession"
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
  - "CInternetConnection.GetSession"
  - "GetSession"
  - "CInternetConnection::GetSession"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sessions, retrieving Internet"
  - "GetSession method"
  - "CInternetConnection class, operations"
  - "Internet sessions"
ms.assetid: 582b0bb5-4ed9-401a-976e-f3ded15158b0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetConnection::GetSession
Call this member function to get a pointer to the `CInternetSession` object that's associated with this connection.  
  
## Syntax  
  
```  
  
CInternetSession* GetSession( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object associated with this Internet connection object.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)