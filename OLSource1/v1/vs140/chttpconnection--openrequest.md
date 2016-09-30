---
title: "CHttpConnection::OpenRequest"
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
  - "HTTP_VERB_DELETE"
  - "INTERNET_FLAG_SECURE"
  - "HTTP_VERB_UNLINK"
  - "INTERNET_FLAG_DONT_CACHE"
  - "INTERNET_FLAG_MAKE_PERSISTENT"
  - "CHttpConnection::OpenRequest"
  - "HTTP_VERB_LINK"
  - "CHttpConnection.OpenRequest"
  - "HTTP_VERB_GET"
  - "HTTP_VERB_POST"
  - "HTTP_VERB_HEAD"
  - "INTERNET_FLAG_RELOAD"
  - "HTTP_VERB_PUT"
  - "OpenRequest"
  - "INTERNET_FLAG_ASYNC"
  - "INTERNET_FLAG_NO_AUTO_REDIRECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Internet flags"
  - "HTTP servers, opening URLs for"
  - "INTERNET_FLAG_RELOAD"
  - "INTERNET_FLAG_MAKE_PERSISTENT"
  - "OpenRequest method"
  - "HTTP_VERB_GET"
  - "HTTP connections"
  - "INTERNET_FLAG_NO_AUTO_REDIRECT"
  - "HTTP_VERB_LINK"
  - "HTTP_VERB_POST"
  - "HTTP_VERB_HEAD"
  - "dwFlags data member"
  - "HTTP_VERB_DELETE"
  - "HTTP requests, opening server URL"
  - "HTTP_VERB_PUT"
  - "CHttpConnection class, operations"
  - "INTERNET_FLAG_SECURE"
  - "INTERNET_FLAG_DONT_CACHE"
  - "INTERNET_FLAG_ASYNC"
  - "HTTP_VERB_UNLINK"
ms.assetid: 986d9492-b63f-468e-8f67-04b2b20cc896
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpConnection::OpenRequest
Call this member function to open an HTTP connection.  
  
## Syntax  
  
```  
CHttpFile* OpenRequest(  
   LPCTSTR pstrVerb,  
   LPCTSTR pstrObjectName,  
   LPCTSTR pstrReferer = NULL,  
   DWORD_PTR dwContext = 1,  
   LPCTSTR* ppstrAcceptTypes = NULL,  
   LPCTSTR pstrVersion = NULL,  
   DWORD dwFlags = INTERNET_FLAG_EXISTING_CONNECT   
);  
CHttpFile* OpenRequest(  
   int nVerb,  
  LPCTSTR pstrObjectName,  
   LPCTSTR pstrReferer = NULL,  
   DWORD_PTR dwContext = 1,  
   LPCTSTR* ppstrAcceptTypes = NULL,  
   LPCTSTR pstrVersion = NULL,  
   DWORD dwFlags = INTERNET_FLAG_EXISTING_CONNECT   
);  
```  
  
#### Parameters  
 `pstrVerb`  
 A pointer to a string containing the verb to use in the request. If `NULL`, "GET" is used.  
  
 `pstrObjectName`  
 A pointer to a string containing the target object of the specified verb. This is generally a filename, an executable module, or a search specifier.  
  
 `pstrReferer`  
 A pointer to a string that specifies the address (URL) of the document from which the URL in the request (`pstrObjectName`) was obtained. If `NULL`, no HTTP header is specified.  
  
 `dwContext`  
 The context identifier for the `OpenRequest` operation. See the Remarks section for more information about `dwContext`.  
  
 `ppstrAcceptTypes`  
 A pointer to a null-terminated array of `LPCTSTR` pointers to strings indicating content types accepted by the client. If `ppstrAcceptTypes` is `NULL`, the servers interpret that the client only accepts documents of type "text/*" (that is, only text documents and not pictures or other binary files). The content type is equivalent to the CGI variable CONTENT_TYPE, which identifies the type of data for queries that have attached information, such as HTTP POST and PUT.  
  
 `pstrVersion`  
 A pointer to a string defining the HTTP version. If `NULL`, "HTTP/1.0" is used.  
  
 `dwFlags`  
 Any combination of the INTERNET_ FLAG_* flags. See the Remarks section for a description of possible `dwFlags` values.  
  
 `nVerb`  
 A number associated with the HTTP request type. Can be one of the following:  
  
|HTTP request type|`nVerb` value|  
|-----------------------|-------------------|  
|`HTTP_VERB_POST`|0|  
|`HTTP_VERB_GET`|1|  
|`HTTP_VERB_HEAD`|2|  
|`HTTP_VERB_PUT`|3|  
|`HTTP_VERB_LINK`|4|  
|`HTTP_VERB_DELETE`|5|  
|`HTTP_VERB_UNLINK`|6|  
  
## Return Value  
 A pointer to the [CHttpFile](../vs140/chttpfile-class.md) object requested.  
  
## Remarks  
 `dwFlags` can be one of the following:  
  
|Internet flag|Description|  
|-------------------|-----------------|  
|`INTERNET_FLAG_RELOAD`|Forces a download of the requested file, object, or directory listing from the origin server, not from the cache.|  
|`INTERNET_FLAG_DONT_CACHE`|Does not add the returned entity to the cache.|  
|`INTERNET_FLAG_MAKE_PERSISTENT`|Adds the returned entity to the cache as a persistent entity. This means that standard cache cleanup, consistency checking, or garbage collection cannot remove this item from the cache.|  
|`INTERNET_FLAG_SECURE`|Uses secure transaction semantics. This translates to using SSL/PCT and is only meaningful in HTTP requests|  
|`INTERNET_FLAG_NO_AUTO_REDIRECT`|Used only with HTTP, specifies that redirections should not be automatically handled in [CHttpFile::SendRequest](../vs140/chttpfile--sendrequest.md).|  
  
 Override the `dwContext` default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the `CHttpConnection` object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
 Exceptions may be thrown with this function.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)