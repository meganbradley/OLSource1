---
title: "CBindStatusCallback::CBindStatusCallback"
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
  - "ATL::CBindStatusCallback::CBindStatusCallback"
  - "ATL.CBindStatusCallback.CBindStatusCallback"
  - "CBindStatusCallback::CBindStatusCallback"
  - "CBindStatusCallback.CBindStatusCallback"
  - "CBindStatusCallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBindStatusCallback constructor"
  - "CBindStatusCallback class, constructor"
ms.assetid: e64974f7-6a0f-49bd-8dbd-cb22df7f26ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::CBindStatusCallback
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Creates an object to receive notifications concerning the asynchronous data transfer. Typically, one object is created for each bind operation.  
  
 The constructor also initializes [m_pT](../vs140/cbindstatuscallback--m_pt.md) and [m_pFunc](../vs140/cbindstatuscallback--m_pfunc.md) to **NULL**.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)