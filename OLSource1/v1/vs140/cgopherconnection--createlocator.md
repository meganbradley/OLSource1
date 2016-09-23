---
title: "CGopherConnection::CreateLocator"
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
  - CGopherConnection::CreateLocator
  - CGopherConnection.CreateLocator
  - CreateLocator
dev_langs: 
  - C++
helpviewer_keywords: 
  - gopher protocol
  - CGopherConnection class, operations
  - CreateLocator method
ms.assetid: 28dfc3d3-117a-4939-b09a-b876a322f349
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGopherConnection::CreateLocator
Call this member function to create a gopher locator to find or identify a file on a gopher server.  
  
## Syntax  
  
```  
  
      CGopherLocator CreateLocator(  
   LPCTSTR pstrDisplayString,  
   LPCTSTR pstrSelectorString,  
   DWORD dwGopherType   
);  
static CGopherLocator CreateLocator(  
   LPCTSTR pstrLocator   
);  
static CGopherLocator CreateLocator(  
   LPCTSTR pstrServerName,  
   LPCTSTR pstrDisplayString,  
   LPCTSTR pstrSelectorString,  
   DWORD dwGopherType,  
   INTERNET_PORT nPort = INTERNET_INVALID_PORT_NUMBER   
);  
```  
  
#### Parameters  
 `pstrDisplayString`  
 A pointer to a string containing the name of the gopher document or directory to be retrieved. If the `pstrDisplayString` parameter is **NULL**, the default directory for the gopher server is returned.  
  
 `pstrSelectorString`  
 A pointer to the selector string to be sent to the gopher server in order to retrieve an item. `pstrSelectorString` can be **NULL**.  
  
 *dwGopherType*  
 This specifies whether `pstrSelectorString` refers to a directory or document, and whether the request is gopher or gopher+. See the attributes for the structure [GOPHER_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa384215) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pstrLocator`  
 A pointer to a string identifying the file to open. Generally, this string is returned from a call to [CGopherFileFind::GetLocator](../vs140/cgopherfilefind--getlocator.md).  
  
 *pstrServerName*  
 A pointer to a string containing the gopher server name.  
  
 `nPort`  
 The number identifying the Internet port for this connection.  
  
## Return Value  
 A [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
## Remarks  
 The static version of the member function requires you to specify a server, while the non-static version uses the server name from the connection object.  
  
 In order to retrieve information from a gopher server, an application must first get a gopher locator. The application must then treat the locator as an opaque token (that is, the application can use the locator but not directly manipulate or compare it). Normally, the application uses the locator for calls to the [CGopherFileFind::FindFile](../vs140/cgopherfilefind--findfile.md) member function to retrieve a specific piece of information.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)