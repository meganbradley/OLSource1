---
title: "CFtpConnection::CFtpConnection"
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
  - CFtpConnection::CFtpConnection
  - CFtpConnection.CFtpConnection
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFtpConnection class, constructor
  - CFtpConnection class, construction
ms.assetid: be98309f-1242-4f8a-a95e-bcf4c2dcf1de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFtpConnection::CFtpConnection
This member function is called to construct a `CFtpConnection` object.  
  
## Syntax  
  
```  
  
      CFtpConnection(  
   CInternetSession* pSession,  
   HINTERNET hConnected,  
   LPCTSTR pstrServer,  
   DWORD_PTR dwContext  
);  
CFtpConnection(  
   CInternetSession* pSession,  
   LPCTSTR pstrServer,  
   LPCTSTR pstrUserName = NULL,  
   LPCTSTR pstrPassword = NULL,  
   DWORD_PTR dwContext = 0,  
   INTERNET_PORT nPort = INTERNET_INVALID_PORT_NUMBER,  
   BOOL bPassive = FALSE  
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
  
 `bPassive`  
 Specifies passive or active mode for this FTP session. If set to **TRUE**, it sets the Win32 API `dwFlag` to **INTERNET_FLAG_PASSIVE**.  
  
## Remarks  
 You never create a `CFtpConnection` object directly. Instead, call [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md), which creates the **CFptConnection** object.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md)   
 [CFtpFileFind Class](../vs140/cftpfilefind-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)