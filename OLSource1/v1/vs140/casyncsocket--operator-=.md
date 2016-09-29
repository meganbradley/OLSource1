---
title: "CAsyncSocket::operator ="
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
  - "CAsyncSocket::operator="
  - "CAsyncSocket.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, Windows Sockets"
  - "= operator, with specific MFC objects"
  - "operator=, Windows Sockets"
ms.assetid: a49dbf77-4b9f-478d-85f0-fd4168614760
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::operator =
Assigns a new value to a `CAsyncSocket` object.  
  
## Syntax  
  
```  
  
      void operator=(  
   const CAsyncSocket& rSrc  
);  
```  
  
#### Parameters  
 `rSrc`  
 A reference to an existing `CAsyncSocket` object.  
  
## Remarks  
 Call this function to copy an existing `CAsyncSocket` object to another `CAsyncSocket` object.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)