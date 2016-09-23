---
title: "CComClassFactorySingleton::m_spObj"
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
  - ATL::CComClassFactorySingleton::m_spObj
  - m_spObj
  - ATL::CComClassFactorySingleton<T>::m_spObj
  - CComClassFactorySingleton::m_spObj
  - CComClassFactorySingleton.m_spObj
  - CComClassFactorySingleton<T>::m_spObj
  - ATL.CComClassFactorySingleton.m_spObj
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_spObj
ms.assetid: 4af7d8bf-a721-40d0-af42-855897db4ce6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComClassFactorySingleton::m_spObj
The [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) object constructed by `CComClassFactorySingleton`.  
  
## Syntax  
  
```  
  
CComPtr<IUnknown> m_spObj;  
  
```  
  
## Remarks  
 Each call to the [CreateInstance](../vs140/ccomclassfactorysingleton--createinstance.md) method simply queries this object for an interface pointer.  
  
 Note that the current form of `m_spObj` presents a breaking change from the way that `CComClassFactorySingleton` worked in previous versions of ATL. In previous versions the `CComClassFactorySingleton` object was created at the same time as the class factory, during server initialization. In Visual C++.NET 2003, the object is created lazily, on the first request. This change could cause errors in programs that rely on early initialization.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactorySingleton Class](../vs140/ccomclassfactorysingleton-class.md)