---
title: "CBindStatusCallback::m_dwTotalRead"
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
  - "ATL.CBindStatusCallback.m_dwTotalRead"
  - "CBindStatusCallback.m_dwTotalRead"
  - "m_dwTotalRead"
  - "CBindStatusCallback::m_dwTotalRead"
  - "ATL::CBindStatusCallback::m_dwTotalRead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwTotalRead"
ms.assetid: 105e2250-5c03-4719-b48e-defef0cbb31f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::m_dwTotalRead
The cumulative total of bytes read in the asynchronous data transfer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Incremented every time <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is called by the number of bytes actually read. Initialized to zero in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)   
 [CBindStatusCallback::OnDataAvailable](../vs140/cbindstatuscallback--ondataavailable.md)