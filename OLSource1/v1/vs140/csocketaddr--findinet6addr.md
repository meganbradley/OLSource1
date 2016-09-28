---
title: "CSocketAddr::FindINET6Addr"
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
  - "CSocketAddr.FindINET6Addr"
  - "FindINET6Addr"
  - "CSocketAddr::FindINET6Addr"
  - "ATL.CSocketAddr.FindINET6Addr"
  - "ATL::CSocketAddr::FindINET6Addr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindINET6Addr method"
ms.assetid: 8c4fa582-3b3d-4cc0-9a34-0be21ef02e8a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketAddr::FindINET6Addr
Call this method to convert the IPv6 host name to the host address.  
  
## Syntax  
  
```  
  
      int FindINET6Addr(   
   const char *szHost,  
   int nPortNo,  
   int flags,  
   int sock_type,  
);  
```  
  
#### Parameters  
 `szHost`  
 The host name or dotted IP address.  
  
 `nPortNo`  
 The port number.  
  
 `flags`  
 0 or combination of AI_PASSIVE, AI_CANONNAME or AI_NUMERICHOST.  
  
 `sock_type`  
 Socket type (such as SOCK_STREAM).  
  
## Return Value  
 Returns zero if the address is calculated successfully. Returns a nonzero Windows Socket error code on failure. If successful, the calculated address is stored in a linked list that may be referenced using `CSocketAddr::GetAddrInfoList` and `CSocketAddr::GetAddrInfo`.  
  
## Remarks  
 This method calls the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520) to perform the conversion.  
  
## Requirements  
 **Header:** atlsocket.h  
  
## See Also  
 [CSocketAddr Class](../vs140/csocketaddr-class.md)   
 [CSocketAddr::FindINET4Addr](../vs140/csocketaddr--findinet4addr.md)