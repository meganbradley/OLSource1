---
title: "CComModule::UpdateRegistryClass"
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
  - UpdateRegistryClass
  - CComModule.UpdateRegistryClass
  - CComModule::UpdateRegistryClass
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateRegistryClass method
ms.assetid: 46001300-844f-4f74-8a4d-f13fdfec8a88
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComModule::UpdateRegistryClass
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
      ATL_DEPRECATED HRESULT UpdateRegistryClass(  
   const CLSID& clsid,  
   LPCTSTR lpszProgID,  
   LPCTSTR lpszVerIndProgID,  
   UINT nDescID,  
   DWORD dwFlags,  
   BOOL bRegister   
);  
ATL_DEPRECATED HRESULT UpdateRegistryClass(  
   const CLSID& clsid,  
   LPCTSTR lpszProgID,  
   LPCTSTR lpszVerIndProgID,  
   LPCTSTR szDesc,  
   DWORD dwFlags,  
   BOOL bRegister   
);  
```  
  
#### Parameters  
 `clsid`  
 The CLSID of the object to be registered or unregistered.  
  
 `lpszProgID`  
 The ProgID associated with the object.  
  
 `lpszVerIndProgID`  
 The version-independent ProgID associated with the object.  
  
 `nDescID`  
 The identifier of the string resource for the object's description.  
  
 `szDesc`  
 A string containing the object's description.  
  
 `dwFlags`  
 Specifies the threading model to enter in the registry. Possible values are **THREADFLAGS_APARTMENT**, **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
 `bRegister`  
 Indicates whether the object should be registered.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 If `bRegister` is **TRUE**, this method enters the object's standard class registration in the system registry.  
  
 If `bRegister` is **FALSE**, it removes the object's registration.  
  
 Depending on the value of `bRegister`, `UpdateRegistryClass` calls either [RegisterClassHelper](../vs140/ccommodule--registerclasshelper.md) or [UnregisterClassHelper](../vs140/ccommodule--unregisterclasshelper.md).  
  
 By specifying the [DECLARE_REGISTRY](../vs140/declare_registry.md) macro, `UpdateRegistryClass` will be invoked automatically when your object map is processed.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)