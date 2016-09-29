---
title: "CComClassFactory2::RequestLicKey"
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
  - "ATL.CComClassFactory2.RequestLicKey"
  - "ATL::CComClassFactory2<license>::RequestLicKey"
  - "RequestLicKey"
  - "CComClassFactory2::RequestLicKey"
  - "CComClassFactory2.RequestLicKey"
  - "ATL::CComClassFactory2::RequestLicKey"
  - "CComClassFactory2<license>::RequestLicKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RequestLicKey method"
ms.assetid: ea437311-f428-4e1e-8b81-5c31baa3e298
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2::RequestLicKey
Creates and returns a license key, provided that the `fRuntimeKeyAvail` member of the [LICINFO](http://msdn.microsoft.com/library/windows/desktop/ms690590) structure is **TRUE**.  
  
## Syntax  
  
```  
  
      STDMETHOD(RequestLicKey)(  
   DWORD dwReserved,  
   BSTR* pbstrKey   
);  
```  
  
#### Parameters  
 `dwReserved`  
 [in] Not used. Must be zero.  
  
 `pbstrKey`  
 [out] Pointer to the license key.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 A license key is required for calling [CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md) to create an object on an unlicensed machine. If `fRuntimeKeyAvail` is **FALSE**, then objects can only be created on a fully licensed machine.  
  
 Call [GetLicInfo](../vs140/ccomclassfactory2--getlicinfo.md) to retrieve the value of `fRuntimeKeyAvail`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)