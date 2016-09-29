---
title: "COleObjectFactory::GetLicenseKey"
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
  - "GetLicenseKey"
  - "COleObjectFactory.GetLicenseKey"
  - "COleObjectFactory::GetLicenseKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLicenseKey method"
ms.assetid: 53892166-7d67-48af-bdb4-6bd58f8040c0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::GetLicenseKey
Requests a unique license key from the control's DLL and stores it in the `BSTR` pointed to by `pbstrKey`.  
  
## Syntax  
  
```  
  
      virtual BOOL GetLicenseKey(  
   DWORD dwReserved,  
   BSTR *pbstrKey   
);  
```  
  
#### Parameters  
 `dwReserved`  
 Reserved for future use.  
  
 `pbstrKey`  
 Pointer to a `BSTR` that will store the license key.  
  
## Return Value  
 Nonzero if the license-key string is not **NULL**; otherwise 0.  
  
## Remarks  
 The default implementation of this function returns 0 and stores nothing in the `BSTR`. If you use MFC ActiveX ControlWizard to create your project, ControlWizard supplies an override that retrieves the control's license key.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::VerifyUserLicense](../vs140/coleobjectfactory--verifyuserlicense.md)   
 [COleObjectFactory::VerifyLicenseKey](../vs140/coleobjectfactory--verifylicensekey.md)