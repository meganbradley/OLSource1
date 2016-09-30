---
title: "CBindStatusCallback::m_spStream"
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
  - "CBindStatusCallback.m_spStream"
  - "CBindStatusCallback::m_spStream"
  - "ATL::CBindStatusCallback::m_spStream"
  - "ATL.CBindStatusCallback.m_spStream"
  - "m_spStream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spStream"
ms.assetid: c3b5a125-ea17-4c4d-8717-27b6f0964682
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::m_spStream
A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface of the current bind operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Initialized in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> from the **STGMEDIUM** structure when the **BCSF** flag is **BCSF_FIRSTDATANOTIFICATION** and released when the **BCSF** flag is **BCSF_LASTDATANOTIFICATION**.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::OnDataAvailable](../vs140/cbindstatuscallback--ondataavailable.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)