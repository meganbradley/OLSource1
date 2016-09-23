---
title: "CBindStatusCallback::m_spBinding"
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
  - m_spBinding
  - ATL::CBindStatusCallback::m_spBinding
  - CBindStatusCallback::m_spBinding
  - ATL.CBindStatusCallback.m_spBinding
  - CBindStatusCallback.m_spBinding
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_spBinding
ms.assetid: fc3cb827-c93f-4e1c-abaf-e3763aa18e0d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBindStatusCallback::m_spBinding
A pointer to the `IBinding` interface of the current bind operation.  
  
## Syntax  
  
```  
  
CComPtr<IBinding> m_spBinding;  
  
```  
  
## Remarks  
 Initialized in `OnStartBinding` and released in `OnStopBinding`.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::OnStartBinding](../vs140/cbindstatuscallback--onstartbinding.md)   
 [CBindStatusCallback::OnStopBinding](../vs140/cbindstatuscallback--onstopbinding.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)