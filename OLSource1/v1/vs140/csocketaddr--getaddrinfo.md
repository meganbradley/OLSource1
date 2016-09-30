---
title: "CSocketAddr::GetAddrInfo"
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
  - "GetAddrInfo"
  - "CSocketAddr::GetAddrInfo"
  - "ATL.CSocketAddr.GetAddrInfo"
  - "CSocketAddr.GetAddrInfo"
  - "ATL::CSocketAddr::GetAddrInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAddrInfo method"
ms.assetid: b4875d55-71c1-46a9-aa66-42a62b17b0ce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketAddr::GetAddrInfo
Call this method to return a pointer to a specific element in the **addrinfo** list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a specific element in the [addrinfo](http://msdn.microsoft.com/library/windows/desktop/ms737530) list.  
  
## Return Value  
 Returns a pointer to the **addrinfo** structure referenced by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the linked list containing response information about the host.  
  
## Requirements  
 **Header:** atlsocket.h  
  
## See Also  
 [CSocketAddr Class](../vs140/csocketaddr-class.md)   
 [CSocketAddr::GetAddrInfoList](../vs140/csocketaddr--getaddrinfolist.md)