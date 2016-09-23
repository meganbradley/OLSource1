---
title: "CInternetConnection::GetContext"
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
  - CInternetConnection::GetContext
  - CInternetConnection.GetContext
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetContext method
  - application-assigned context ID [C++]
  - context ID
  - CInternetConnection class, operations
ms.assetid: e6384594-622d-4e36-9672-7503b40c2a08
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetConnection::GetContext
Call this member function to get the context ID for this session.  
  
## Syntax  
  
```  
  
DWORD_PTR GetContext( ) const;  
  
```  
  
## Return Value  
 The application-assigned context ID.  
  
## Remarks  
 The context ID is originally specified in [CInternetSession](../vs140/cinternetsession-class.md) and propagates to `CInternetConnection`- and [CInternetFile](../vs140/cinternetfile-class.md)-derived classes, unless specified differently in the call to a function that opens the connection. The context ID is associated with any operation of the given object and identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md).  
  
 For more information about how **GetContext** works with other WinInet classes to give the user status information, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md)