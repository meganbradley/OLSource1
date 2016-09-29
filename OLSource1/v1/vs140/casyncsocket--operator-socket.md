---
title: "CAsyncSocket::operator SOCKET"
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
  - "CAsyncSocket::operatorSOCKET"
  - "operatorSOCKET"
  - "CAsyncSocket.operatorSOCKET"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SOCKET operator"
  - "operator SOCKET"
ms.assetid: 5b6253f4-f94f-48f4-a972-297eab3a22b4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::operator SOCKET
Use this operator to retrieve the **SOCKET** handle of the `CAsyncSocket` object.  
  
## Syntax  
  
```  
  
operator SOCKET( ) const;  
  
```  
  
## Return Value  
 If successful, the handle of the **SOCKET** object; otherwise, **NULL**.  
  
## Remarks  
 You can use the handle to call Windows APIs directly.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)