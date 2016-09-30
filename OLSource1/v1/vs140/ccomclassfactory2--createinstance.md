---
title: "CComClassFactory2::CreateInstance"
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
  - "ATL::CComClassFactory2::CreateInstance"
  - "ATL::CComClassFactory2<license>::CreateInstance"
  - "ATL.CComClassFactory2.CreateInstance"
  - "CComClassFactory2::CreateInstance"
  - "CComClassFactory2<license>::CreateInstance"
  - "CComClassFactory2.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: d56ef6ca-b508-43c7-8b10-5dc07854636c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2::CreateInstance
Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
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
  
## Remarks  
 Requires the machine to be fully licensed. If a full machine license does not exist, call [CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)