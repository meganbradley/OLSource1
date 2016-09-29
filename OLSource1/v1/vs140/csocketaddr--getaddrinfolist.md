---
title: "CSocketAddr::GetAddrInfoList"
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
  - "GetAddrInfoList"
  - "CSocketAddr::GetAddrInfoList"
  - "ATL.CSocketAddr.GetAddrInfoList"
  - "CSocketAddr.GetAddrInfoList"
  - "ATL::CSocketAddr::GetAddrInfoList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAddrInfoList method"
ms.assetid: 0e07dc4e-519f-4633-aa02-0e599750b9e8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketAddr::GetAddrInfoList
Call this method to return a pointer to the **addrinfo** list.  
  
## Syntax  
  
```  
  
addrinfo* const GetAddrInfoList( ) const;  
  
```  
  
## Return Value  
 Pointer to a linked list of one or more `addrinfo` structures containing response information about the host. For more information about the `addrinfo` structure, see the "addrinfo" article in the [MSDN Library](http://go.microsoft.com/fwlink/?linkid=556)  
  
## Requirements  
 **Header:** atlsocket.h  
  
## See Also  
 [CSocketAddr Class](../vs140/csocketaddr-class.md)   
 [CSocketAddr::GetAddrInfo](../vs140/csocketaddr--getaddrinfo.md)