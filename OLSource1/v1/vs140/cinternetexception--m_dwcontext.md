---
title: "CInternetException::m_dwContext"
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
  - "CInternetException.m_dwContext"
  - "CInternetException::m_dwContext"
  - "m_dwContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetException class, data members"
  - "m_dwContext"
ms.assetid: f4d62f9a-f620-4f58-932c-d9cbfea8de27
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetException::m_dwContext
The context value associated with the related Internet operation.  
  
## Syntax  
  
```  
  
DWORD_PTR m_dwContext;  
  
```  
  
## Remarks  
 The context identifier is originally specified in [CInternetSession](../vs140/cinternetsession-class.md) and passed by MFC to [CInternetConnection](../vs140/cinternetconnection-class.md)- and [CInternetFile](../vs140/cinternetfile-class.md)-derived classes. You can override this default and assign any `dwContext` parameter a value of your choosing. `dwContext` is associated with any operation of the given object. `dwContext` identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetException Class](../vs140/cinternetexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException Class](../vs140/cexception-class.md)