---
title: "CHttpConnection Class"
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
  - "CHttpConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "servers, connecting to"
  - "protocols, HTTP"
  - "connecting to servers, HTTP servers"
  - "Internet protocols, HTTP"
  - "HTTP connections"
  - "Internet protocols"
  - "CHttpConnection class"
  - "HTTP servers, connecting to"
  - "connecting to servers"
  - "Internet connections, HTTP"
  - "connections [C++], HTTP"
  - "Internet server, HTTP"
ms.assetid: a402b662-c445-4988-800d-c8278551babe
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpConnection Class
Manages your connection to an HTTP server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHttpConnection::CHttpConnection](#chttpconnection__chttpconnection)|Creates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHttpConnection::OpenRequest](#chttpconnection__openrequest)|Opens an HTTP request.|  
  
## Remarks  
 HTTP is one of three Internet server protocols implemented by the MFC WinInet classes.  
  
 The class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains a constructor and one member function, [OpenRequest](#chttpconnection__openrequest), that manages connections to a server with an HTTP protocol.  
  
 To communicate with an HTTP server, you must first create an instance of [CInternetSession](../vs140/cinternetsession-class.md), and then create a [CHttpConnection](#_mfc_chttpconnection) object. You never create a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object directly; rather, call [CInternetSession::GetHttpConnection](../vs140/cinternetsession-class.md#cinternetsession__gethttpconnection), which creates the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object and returns a pointer to it.  
  
 To learn more about how <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md). For more information about connecting to servers using the other two supported Internet protocols, gopher and FTP, see the classes [CGopherConnection](../vs140/cgopherconnection-class.md) and [CFtpConnection](../vs140/cftpconnection-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CInternetConnection](../vs140/cinternetconnection-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="chttpconnection__chttpconnection">\</a>  CHttpConnection::CHttpConnection  
 This member function is called to construct a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A handle to an Internet connection.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A pointer to a string containing the server name.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. See **Remarks** for more information about <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The number that identifies the Internet port for this connection.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non- **NULL** String|**NULL** or " "|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|" "|  
|**NULL** Non- **NULL** String|**ERROR**|**ERROR**||  
|Non- **NULL** String|Non- **NULL** String|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Any combination of the **INTERNET_ FLAG_\*** flags. See the table in the **Remarks** section of [CHttpConnection::OpenRequest](#chttpconnection__openrequest) for a description of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> values.  
  
### Remarks  
 You never create a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> directly. Rather, you create an object by calling [CInternetSession::GetHttpConnection](../vs140/cinternetsession-class.md#cinternetsession__gethttpconnection).  
  
##  \<a name="chttpconnection__openrequest">\</a>  CHttpConnection::OpenRequest  
 Call this member function to open an HTTP connection.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to a string containing the verb to use in the request. If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, "GET" is used.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A pointer to a string containing the target object of the specified verb. This is generally a filename, an executable module, or a search specifier.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to a string that specifies the address (URL) of the document from which the URL in the request ( <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) was obtained. If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, no HTTP header is specified.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> operation. See the Remarks section for more information about <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a null-terminated array of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> pointers to strings indicating content types accepted by the client. If <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, the servers interpret that the client only accepts documents of type "text/*" (that is, only text documents and not pictures or other binary files). The content type is equivalent to the CGI variable CONTENT_TYPE, which identifies the type of data for queries that have attached information, such as HTTP POST and PUT.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to a string defining the HTTP version. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, "HTTP/1.0" is used.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Any combination of the INTERNET_ FLAG_* flags. See the Remarks section for a description of possible <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> values.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A number associated with the HTTP request type. Can be one of the following:  
  
|HTTP request type|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> value|  
|-----------------------|-------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|0|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|1|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|2|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|3|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|4|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|5|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|6|  
  
### Return Value  
 A pointer to the [CHttpFile](../vs140/chttpfile-class.md) object requested.  
  
### Remarks  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> can be one of the following:  
  
|Internet flag|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Forces a download of the requested file, object, or directory listing from the origin server, not from the cache.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Does not add the returned entity to the cache.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Adds the returned entity to the cache as a persistent entity. This means that standard cache cleanup, consistency checking, or garbage collection cannot remove this item from the cache.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Uses secure transaction semantics. This translates to using SSL/PCT and is only meaningful in HTTP requests|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Used only with HTTP, specifies that redirections should not be automatically handled in [CHttpFile::SendRequest](../vs140/chttpfile-class.md#chttpfile__sendrequest).|  
  
 Override the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
 Exceptions may be thrown with this function.  
  
## See Also  
 [Base Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection](../vs140/cinternetconnection-class.md)   
 [CHttpFile](../vs140/chttpfile-class.md)