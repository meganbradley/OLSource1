---
title: "CAsyncSocket::FromHandle"
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
  - "CAsyncSocket::FromHandle"
  - "CAsyncSocket.FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
ms.assetid: be56a081-b640-4030-88c7-54722021a8d2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::FromHandle
Returns a pointer to a `CAsyncSocket` object.  
  
## Syntax  
  
```  
  
      static CAsyncSocket* PASCAL FromHandle(  
   SOCKET hSocket   
);  
```  
  
#### Parameters  
 `hSocket`  
 Contains a handle to a socket.  
  
## Return Value  
 A pointer to an `CAsyncSocket` object, or **NULL** if there is no `CAsyncSocket` object attached to `hSocket`.  
  
## Remarks  
 When given a **SOCKET** handle, if a `CAsyncSocket` object is not attached to the handle, the member function returns **NULL**.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSocket::FromHandle](../vs140/csocket--fromhandle.md)   
 [CAsyncSocket::Attach](../vs140/casyncsocket--attach.md)   
 [CAsyncSocket::Detach](../vs140/casyncsocket--detach.md)