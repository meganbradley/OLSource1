---
title: "CInternetSession::GetContext"
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
  - GetContext
  - CInternetSession.GetContext
  - CInternetSession::GetContext
dev_langs: 
  - C++
helpviewer_keywords: 
  - Internet status, callback
  - CInternetSession class, operations
  - GetContext method
  - asynchronous Internet operations
  - Internet status
  - status callback for Internet sessions
ms.assetid: 923e626c-0332-436c-a830-83888f50ae2e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetSession::GetContext
Call this member function to get the context value for a particular application session.  
  
## Syntax  
  
```  
  
DWORD_PTR GetContext( ) const;  
  
```  
  
## Return Value  
 The application-defined context Identifier.  
  
## Remarks  
 [OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) uses the context ID returned by **GetContext** to report the status of a particular application. For example, when a user activates an Internet request that involves returning status information, the status callback uses the context ID to report status on that particular request. If the user activates two separate Internet requests that both involve returning status information, `OnStatusCallback` uses the context identifiers to return status about their corresponding requests. Consequently, the context identifier is used for all status callback operations, and it is associated with the session until the session is ended.  
  
 For more information about asynchronous operations, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md)   
 [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md)