---
title: "CGopherConnection::GetAttribute"
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
  - GetAttribute
  - CGopherConnection::GetAttribute
  - CGopherConnection.GetAttribute
dev_langs: 
  - C++
helpviewer_keywords: 
  - protocols, gopher
  - gopher protocol
  - CGopherConnection class, operations
  - gopher server
  - GetAttribute method
ms.assetid: e22acbd4-ce0f-4c6e-9fe7-ce61dda130a8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGopherConnection::GetAttribute
Call this member function to retrieve specific attribute information about an item from the gopher server.  
  
## Syntax  
  
```  
  
      BOOL GetAttribute(  
   CGopherLocator& refLocator  
   CString strRequestedAttributes,  
   CString& strResult,  
);  
```  
  
#### Parameters  
 `refLocator`  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 *strRequestedAttributes*  
 A space-delimited string specifying the names of the requested attributes.  
  
 `strResult`  
 A reference to a [CString](../vs140/cstringt-class.md) that receives the locator type.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)