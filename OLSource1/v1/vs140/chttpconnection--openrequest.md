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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the verb to use in the request. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, "GET" is used.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string containing the target object of the specified verb. This is generally a filename, an executable module, or a search specifier.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a string that specifies the address (URL) of the document from which the URL in the request (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) was obtained. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, no HTTP header is specified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operation. See the Remarks section for more information about <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to a null-terminated array of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pointers to strings indicating content types accepted by the client. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the servers interpret that the client only accepts documents of type "text/*" (that is, only text documents and not pictures or other binary files). The content type is equivalent to the CGI variable CONTENT_TYPE, which identifies the type of data for queries that have attached information, such as HTTP POST and PUT.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to a string defining the HTTP version. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, "HTTP/1.0" is used.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Any combination of the INTERNET_ FLAG_* flags. See the Remarks section for a description of possible <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> values.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A number associated with the HTTP request type. Can be one of the following:  
  
|HTTP request type|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value|  
|-----------------------|-------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|0|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|1|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|2|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|3|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|4|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|5|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|6|  
  
## Return Value  
 A pointer to the [CHttpFile](../vs140/chttpfile-class.md) object requested.  
  
## Remarks  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> can be one of the following:  
  
|Internet flag|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Forces a download of the requested file, object, or directory listing from the origin server, not from the cache.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Does not add the returned entity to the cache.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Adds the returned entity to the cache as a persistent entity. This means that standard cache cleanup, consistency checking, or garbage collection cannot remove this item from the cache.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Uses secure transaction semantics. This translates to using SSL/PCT and is only meaningful in HTTP requests|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Used only with HTTP, specifies that redirections should not be automatically handled in [CHttpFile::SendRequest](../vs140/chttpfile--sendrequest.md).|  
  
 Override the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
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