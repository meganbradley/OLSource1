---
title: "CBindStatusCallback::m_pFunc"
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
  - "ATL.CBindStatusCallback.m_pFunc"
  - "ATL::CBindStatusCallback::m_pFunc"
  - "m_pFunc"
  - "CBindStatusCallback::m_pFunc"
  - "CBindStatusCallback.m_pFunc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "callback functions, ATL"
  - "m_pFunc"
ms.assetid: 9e27e2a0-68e6-4ece-89d9-5b029e25e23b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::m_pFunc
The function pointed to by `m_pFunc` is called by `OnDataAvailable` after it reads the available data (for example, to store the data or print it to the screen).  
  
## Syntax  
  
```  
  
ATL_PDATAAVAILABLE m_pFunc;  
  
```  
  
## Remarks  
 The function pointed to by `m_pFunc` is a member of your object's class and has the following syntax:  
  
 `void Function_Name(`  
  
 `CBindStatusCallback<T>* pbsc,`  
  
 `BYTE* pBytes,`  
  
 `DWORD dwSize`  
  
 `);`  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)   
 [CBindStatusCallback::OnDataAvailable](../vs140/cbindstatuscallback--ondataavailable.md)