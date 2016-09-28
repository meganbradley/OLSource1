---
title: "CSocketAddr::FindAddr"
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
  - "CSocketAddr::FindAddr"
  - "ATL.CSocketAddr.FindAddr"
  - "FindAddr"
  - "CSocketAddr.FindAddr."
  - "ATL::CSocketAddr::FindAddr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindAddr method"
ms.assetid: 47e941c9-51a8-41fe-8588-6eb1ffe16d71
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketAddr::FindAddr
Call this method to convert the provided host name to the host address.  
  
## Syntax  
  
```  
  
      int FindAddr(  
   const char *szHost,  
   const char *szPortOrServiceName,  
   int flags,  
   int addr_family,  
   int sock_type,  
   int ai_proto  
   );  
int FindAddr(  
   const char *szHost,  
   int nPortNo,  
   int flags,  
   int addr_family,  
   int sock_type,  
   int ai_proto  
   );  
```  
  
#### Parameters  
 `szHost`  
 The host name or dotted IP address.  
  
 *szPortOrServiceName*  
 The port number or name of service on host.  
  
 `nPortNo`  
 The port number.  
  
 `flags`  
 0 or combination of AI_PASSIVE, AI_CANONNAME or AI_NUMERICHOST.  
  
 *addr_family*  
 Address family (such as PF_INET).  
  
 `sock_type`  
 Socket type (such as SOCK_STREAM).  
  
 *ai_proto*  
 Protocol (such as IPPROTO_IP or IPPROTO_IPV6).  
  
## Return Value  
 Returns zero if the address is calculated successfully. Returns a nonzero Windows Socket error code on failure. If successful, the calculated address is stored in a linked list that may be referenced using `CSocketAddr::GetAddrInfoList` and `CSocketAddr::GetAddrInfo`.  
  
## Remarks  
 The host name parameter may be in either IPv4 or IPv6 format. This method calls the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520) to perform the conversion.  
  
## Requirements  
 **Header:** atlsocket.h  
  
## See Also  
 [CSocketAddr Class](../vs140/csocketaddr-class.md)   
 [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520)   
 [CSocketAddr::GetAddrInfoList](../vs140/csocketaddr--getaddrinfolist.md)   
 [CSocketAddr::GetAddrInfo](../vs140/csocketaddr--getaddrinfo.md)