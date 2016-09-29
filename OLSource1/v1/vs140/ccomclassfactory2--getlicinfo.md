---
title: "CComClassFactory2::GetLicInfo"
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
  - "GetLicInfo"
  - "ATL::CComClassFactory2<license>::GetLicInfo"
  - "ATL::CComClassFactory2::GetLicInfo"
  - "ATL.CComClassFactory2.GetLicInfo"
  - "CComClassFactory2<license>::GetLicInfo"
  - "CComClassFactory2::GetLicInfo"
  - "CComClassFactory2.GetLicInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLicInfo method"
ms.assetid: 457d8d06-4fee-4521-bdf1-6571a08e10b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2::GetLicInfo
Fills a [LICINFO](http://msdn.microsoft.com/library/windows/desktop/ms690590) structure with information that describes the class factory's licensing capabilities.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetLicInfo)(  
   LICINFO* pLicInfo   
);  
```  
  
#### Parameters  
 *pLicInfo*  
 [out] Pointer to a **LICINFO** structure.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The `fRuntimeKeyAvail` member of this structure indicates whether, given a license key, the class factory allows objects to be created on an unlicensed machine. The *fLicVerified* member indicates whether a full machine license exists.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)   
 [CComClassFactory2::RequestLicKey](../vs140/ccomclassfactory2--requestlickey.md)   
 [CComClassFactory2::CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md)