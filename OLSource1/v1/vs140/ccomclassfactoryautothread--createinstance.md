---
title: "CComClassFactoryAutoThread::CreateInstance"
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
  - "ATL.CComClassFactoryAutoThread.CreateInstance"
  - "CComClassFactoryAutoThread.CreateInstance"
  - "ATL::CComClassFactoryAutoThread::CreateInstance"
  - "CComClassFactoryAutoThread::CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 4a42c68e-163e-4186-872b-d6835ec03ad3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactoryAutoThread::CreateInstance
Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
## Syntax  
  
```  
  
      STDMETHODIMP CreateInstance(  
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
  
## Remarks  
 If your module derives from [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md), `CreateInstance` first selects a thread to create the object in the associated apartment.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactoryAutoThread Class](../vs140/ccomclassfactoryautothread-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)