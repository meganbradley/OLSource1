---
title: "CGopherConnection::CGopherConnection"
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
  - "CGopherConnection::CGopherConnection"
  - "CGopherConnection.CGopherConnection"
  - "CGopherConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CGopherConnection class, constructor"
ms.assetid: 8aa48104-ccaf-497a-aaac-bd2a69df3ea2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherConnection::CGopherConnection
This member function is called to construct a `CGopherConnection` object.  
  
## Syntax  
  
```  
  
      CGopherConnection(  
   CInternetSession* pSession,  
   HINTERNET hConnected,  
   LPCTSTR pstrServer,  
   DWORD_PTR dwContext  
);  
CGopherConnection(  
   CInternetSession* pSession,  
   LPCTSTR pstrServer,  
   LPCTSTR pstrUserName = NULL,  
   LPCTSTR pstrPassword = NULL,  
   DWORD_PTR dwContext = 0,  
   INTERNET_PORT nPort = INTERNET_INVALID_PORT_NUMBER  
);  
```  
  
#### Parameters  
 `pSession`  
 A pointer to the related [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 `hConnected`  
 The Windows handle of the current Internet session.  
  
 `pstrServer`  
 A pointer to a string containing the FTP server name.  
  
 `dwContext`  
 The context identifier for the operation. `dwContext` identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md). The default is set to 1; however, you can explicitly assign a specific context ID for the operation. The object and any work it does will be associated with that context ID.  
  
 `pstrUserName`  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 `pstrPassword`  
 A pointer to a null-terminated string that specifies the password to use to log in. If both `pstrPassword` and `pstrUserName` are **NULL**, the default anonymous password is the user's email name. If `pstrPassword` is **NULL** (or an empty string) but `pstrUserName` is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of `pstrUserName` and `pstrPassword`:  
  
|`pstrUserName`|`pstrPassword`|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non-**NULL** String|**NULL** or " "|`pstrUserName`|" "|  
|**NULL** Non-**NULL** String|**ERROR**|**ERROR**||  
|Non-**NULL** String|Non-**NULL** String|`pstrUserName`|`pstrPassword`|  
  
 `nPort`  
 A number that identifies the TCP/IP port to use on the server.  
  
## Remarks  
 You never create a `CGopherConnection` directly. Rather, call [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md), which creates a `CGopherConnection` object and returns a pointer to it.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)