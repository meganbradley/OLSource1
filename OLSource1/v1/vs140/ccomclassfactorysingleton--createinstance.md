---
title: "CComClassFactorySingleton::CreateInstance"
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
  - "CComClassFactorySingleton.CreateInstance"
  - "CComClassFactorySingleton::CreateInstance"
  - "ATL::CComClassFactorySingleton<T>::CreateInstance"
  - "ATL::CComClassFactorySingleton::CreateInstance"
  - "ATL.CComClassFactorySingleton.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 0a39f3d9-7f09-4e41-a752-8895675079f3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactorySingleton::CreateInstance
Calls `QueryInterface` through [m_spObj](../vs140/ccomclassfactorysingleton--m_spobj.md) to retrieve an interface pointer.  
  
## Syntax  
  
```  
  
      STDMETHOD(CreateInstance)(  
   LPUNKNOWN pUnkOuter,  
   REFIID riid,  
   void** ppvObj   
);  
```  
  
#### Parameters  
 `pUnkOuter`  
 [in] If the object is being created as part of an aggregate, then `pUnkOuter` must be the outer unknown. Otherwise, `pUnkOuter` must be **NULL**.  
  
 `riid`  
 [in] The IID of the requested interface. If `pUnkOuter` is non-**NULL**, `riid` must be **IID_IUnknown**.  
  
 `ppvObj`  
 [out] A pointer to the interface pointer identified by `riid`. If the object does not support this interface, `ppvObj` is set to **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactorySingleton Class](../vs140/ccomclassfactorysingleton-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)