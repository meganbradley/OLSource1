---
title: "CAsyncSocket::Detach"
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
  - CAsyncSocket::Detach
  - CAsyncSocket.Detach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Detach method
ms.assetid: 3a7a7efe-f03e-4908-8c05-c238c2d43aa9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncSocket::Detach
Call this member function to detach the **SOCKET** handle in the `m_hSocket` data member from the `CAsyncSocket` object and set `m_hSocket` to **NULL**.  
  
## Syntax  
  
```  
  
SOCKET Detach( );  
```  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Attach](../vs140/casyncsocket--attach.md)