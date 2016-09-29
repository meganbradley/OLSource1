---
title: "CComClassFactory2::CreateInstanceLic"
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
  - "ATL::CComClassFactory2<license>::CreateInstanceLic"
  - "CComClassFactory2.CreateInstanceLic"
  - "ATL::CComClassFactory2::CreateInstanceLic"
  - "CComClassFactory2::CreateInstanceLic"
  - "ATL.CComClassFactory2.CreateInstanceLic"
  - "CreateInstanceLic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstanceLic method"
ms.assetid: ceccacf8-bf06-49fa-be71-fe8addb2256c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2::CreateInstanceLic
Similar to [CreateInstance](../vs140/ccomclassfactory2--createinstance.md), except that `CreateInstanceLic` requires a license key.  
  
## Syntax  
  
```  
  
      STDMETHOD(CreateInstanceLic)(  
   IUnknown* pUnkOuter,  
   IUnknown* /* pUnkReserved */,  
   REFIID riid,  
   BSTR bstrKey,  
   void** ppvObject   
);  
```  
  
#### Parameters  
 `pUnkOuter`  
 [in] If the object is being created as part of an aggregate, then `pUnkOuter` must be the outer unknown. Otherwise, `pUnkOuter` must be **NULL**.  
  
 *pUnkReserved*  
 [in] Not used. Must be **NULL**.  
  
 `riid`  
 [in] The IID of the requested interface. If `pUnkOuter` is non-**NULL**, `riid` must be **IID_IUnknown**.  
  
 `bstrKey`  
 [in] The run-time license key previously obtained from a call to `RequestLicKey`. This key is required to create the object.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer specified by `riid`. If the object does not support this interface, `ppvObject` is set to **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 You can obtain a license key using [RequestLicKey](../vs140/ccomclassfactory2--requestlickey.md). In order to create an object on an unlicensed machine, you must call `CreateInstanceLic`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)   
 [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615)   
 [CoGetClassObject](http://msdn.microsoft.com/library/windows/desktop/ms684007)