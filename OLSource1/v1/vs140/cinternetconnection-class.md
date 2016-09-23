---
title: "CInternetConnection Class"
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
  - CInternetConnection
dev_langs: 
  - C++
helpviewer_keywords: 
  - asynchronous connections
  - CInternetConnection class
  - Internet connections
ms.assetid: 62a5d1c3-8471-4e36-a064-48831829b2a7
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetConnection Class
Manages your connection to an Internet server.  
  
## Syntax  
  
```  
class CInternetConnection : public CObject  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetConnection::CInternetConnection](#cinternetconnection__cinternetconnection)|Constructs a `CInternetConnection` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetConnection::GetContext](#cinternetconnection__getcontext)|Gets the context ID for this connection object.|  
|[CInternetConnection::GetServerName](#cinternetconnection__getservername)|Gets the name of the server associated with the connection.|  
|[CInternetConnection::GetSession](#cinternetconnection__getsession)|Gets a pointer to the [CInternetSession](../vs140/cinternetsession-class.md) object associated with the connection.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetConnection::operator HINTERNET](#cinternetconnection__operator_hinternet)|A handle to an Internet session.|  
  
## Remarks  
 It is the base class for MFC classes [CFtpConnection](../vs140/cftpconnection-class.md), [CHttpConnection](../vs140/chttpconnection-class.md), and [CGopherConnection](../vs140/cgopherconnection-class.md). Each of these classes provides additional functionality for communicating with the respective FTP, HTTP, or gopher server.  
  
 To communicate directly with an Internet server, you must have a [CInternetSession](../vs140/cinternetsession-class.md) object and a `CInternetConnection` object.  
  
 To learn more about how the WinInet classes work, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CInternetConnection`  
  
## Requirements  
 **Header:** afxinet.h  
  
##  <a name="cinternetconnection__cinternetconnection"></a>  CInternetConnection::CInternetConnection  
 This member function is called when a `CInternetConnection` object is created.  
  
```  
CInternetConnection(    CInternetSession*  pSession ,    LPCTSTR  pstrServer ,    INTERNET_PORT  nPort  = INTERNET_INVALID_PORT_NUMBER,    DWORD_PTR  dwContext  = 1  );  
  
```  
  
### Parameters  
 `pSession`  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 `pstrServer`  
 A pointer to a string containing the server name.  
  
 `nPort`  
 The number that identifies the Internet port for this connection.  
  
 `dwContext`  
 The context identifier for the `CInternetConnection` object. See **Remarks** for more information about `dwContext`.  
  
### Remarks  
 You never call `CInternetConnection` yourself; instead, call the [CInternetSession](../vs140/cinternetsession-class.md) member function for the type of connection you want to establish:  
  
-   [CInternetSession::GetFtpConnection](../vs140/cinternetsession-class.md#cinternetsession__getftpconnection)  
  
-   [CInternetSession::GetHttpConnection](../vs140/cinternetsession-class.md#cinternetsession__gethttpconnection)  
  
-   [CInternetSession::GetGopherConnection](../vs140/cinternetsession-class.md#cinternetsession__getgopherconnection)  
  
 The default value for `dwContext` is sent by MFC to the `CInternetConnection`-derived object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the **InternetConnection**-derived object. The default is set to 1; however, you can explicitly assign a specific context identifier in the [CInternetSession](../vs140/cinternetsession-class.md#cinternetsession__cinternetsession) constructor for the connection. The object and any work it does will be associated with that context ID. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  <a name="cinternetconnection__getcontext"></a>  CInternetConnection::GetContext  
 Call this member function to get the context ID for this session.  
  
```  
DWORD_PTR GetContext( ) const;  
  
```  
  
### Return Value  
 The application-assigned context ID.  
  
### Remarks  
 The context ID is originally specified in [CInternetSession](../vs140/cinternetsession-class.md) and propagates to `CInternetConnection`- and [CInternetFile](../vs140/cinternetfile-class.md)-derived classes, unless specified differently in the call to a function that opens the connection. The context ID is associated with any operation of the given object and identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback).  
  
 For more information about how **GetContext** works with other WinInet classes to give the user status information, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  <a name="cinternetconnection__getservername"></a>  CInternetConnection::GetServerName  
 Call this member function to get the name of the server associated with this Internet connection.  
  
```  
CString GetServerName( ) const;  
  
```  
  
### Return Value  
 The name of the server this connection object is working with.  
  
##  <a name="cinternetconnection__getsession"></a>  CInternetConnection::GetSession  
 Call this member function to get a pointer to the `CInternetSession` object that's associated with this connection.  
  
```  
CInternetSession* GetSession( ) const;  
  
```  
  
### Return Value  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object associated with this Internet connection object.  
  
##  <a name="cinternetconnection__operator_hinternet"></a>  CInternetConnection::operator HINTERNET  
 Use this operator to get the API-level handle for the current Internet session.  
  
```  
operator HINTERNET( ) const;  
  
```  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)