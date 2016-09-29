---
title: "CSocket::Attach"
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
  - "CSocket::Attach"
  - "CSocket.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [MFC]"
ms.assetid: f4671261-df05-412c-972e-9aeb3c213925
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocket::Attach
Call this member function to attach the `hSocket` handle to a `CSocket` object.  
  
## Syntax  
  
```  
  
      BOOL Attach(  
   SOCKET hSocket   
);  
```  
  
#### Parameters  
 `hSocket`  
 Contains a handle to a socket.  
  
## Return Value  
 Nonzero if the function is successful.  
  
## Remarks  
 The **SOCKET** handle is stored in the object's [m_hSocket](../vs140/casyncsocket--m_hsocket.md) data member.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Example  
 [!code[NVC_MFCSocketThread#1](../vs140/codesnippet/CPP/csocket--attach_1.h)]  
  
 [!code[NVC_MFCSocketThread#2](../vs140/codesnippet/CPP/csocket--attach_2.cpp)]  
  
 [!code[NVC_MFCSocketThread#3](../vs140/codesnippet/CPP/csocket--attach_3.cpp)]  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CSocket Class](../vs140/csocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Attach](../vs140/casyncsocket--attach.md)