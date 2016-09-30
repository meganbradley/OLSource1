---
title: "CInternetSession::CInternetSession"
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
  - "INTERNET_FLAG_OFFLINE"
  - "INTERNET_OPEN_FLAG_NO_CACHE"
  - "INTERNET_OPEN_TYPE_PROXY"
  - "CInternetSession::CInternetSession"
  - "INTERNET_OPEN_TYPE_DIRECT"
  - "CInternetSession.CInternetSession"
  - "INTERNET_OPEN_TYPE_PRECONF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERNET_OPEN_TYPE_PROXY"
  - "INTERNET_OPEN_TYPE_PRECONF"
  - "INTERNET_OPEN_FLAG_NO_CACHE"
  - "INTERNET_FLAG_OFFLINE"
  - "CInternetSession class, constructor"
  - "Internet sessions"
  - "INTERNET_OPEN_TYPE_DIRECT"
ms.assetid: df4dbdd0-3ce1-4f5f-8350-cf06b577c5d9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::CInternetSession
This member function is called when a `CInternetSession` object is created.  
  
## Syntax  
  
```  
  
      CInternetSession(  
   LPCTSTR pstrAgent = NULL,  
   DWORD_PTR dwContext = 1,  
   DWORD dwAccessType = PRE_CONFIG_INTERNET_ACCESS,  
   LPCTSTR pstrProxyName = NULL,  
   LPCTSTR pstrProxyBypass = NULL,  
   DWORD dwFlags = 0   
);  
```  
  
#### Parameters  
 `pstrAgent`  
 A pointer to a string that identifies the name of the application or entity calling the Internet functions (for example, "Microsoft Internet Browser"). If `pstrAgent` is **NULL** (the default), the framework calls the global function [AfxGetAppName](../vs140/afxgetappname.md), which returns a null-terminated string containing an application's name. Some protocols use this string to identify your application to the server.  
  
 `dwContext`  
 The context identifier for the operation. `dwContext` identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md). The default is set to 1; however, you can explicitly assign a specific context ID for the operation. The object and any work it does will be associated with that context ID.  
  
 `dwAccessType`  
 The type of access required. The following are valid values, exactly one of which may be supplied:  
  
-   **INTERNET_OPEN_TYPE_PRECONFIG** Connect using preconfigured settings in the registry. This access type is set as the default. To connect through a TIS proxy, set `dwAccessType` to this value; you then set the registry appropriately.  
  
-   `INTERNET_OPEN_TYPE_DIRECT` Connect directly to Internet.  
  
-   `INTERNET_OPEN_TYPE_PROXY` Connect through a CERN proxy.  
  
 For information on connecting with different types of proxies, see [Steps in a Typical FTP Client Application](../vs140/steps-in-a-typical-ftp-client-application.md).  
  
 *pstrProxyName*  
 The name of the preferred CERN proxy if `dwAccessType` is set as `INTERNET_OPEN_TYPE_PROXY`. The default is **NULL**.  
  
 *pstrProxyBypass*  
 A pointer to a string containing an optional list of server addresses. These addresses may be bypassed when using proxy access. If a **NULL** value is supplied, the bypass list will be read from the registry. This parameter is meaningful only if `dwAccessType` is set to `INTERNET_OPEN_TYPE_PROXY`.  
  
 `dwFlags`  
 Indicates various caching options. The default is set to 0. The possible values include:  
  
-   `INTERNET_FLAG_DONT_CACHE` Do not cache the data, either locally or in any gateway servers.  
  
-   `INTERNET_FLAG_OFFLINE` Download operations are satisfied through the persistent cache only. If the item does not exist in the cache, an appropriate error code is returned. This flag may be combined with the bitwise `OR` (**&#124;**) operator.  
  
## Remarks  
 **CInternetSession** is the first Internet function called by an application. It initializes internal data structures and prepares for future calls from the application.  
  
 If no Internet connection can be opened, `CInternetSession` throws an [AfxThrowInternetException](../vs140/afxthrowinternetexception.md).  
  
## Example  
 See the example for [CFtpFileFind](../vs140/cftpfilefind-class.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::Close](../vs140/cinternetsession--close.md)   
 [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md)   
 [CInternetSession::GetContext](../vs140/cinternetsession--getcontext.md)