---
title: "CComModule::GetClassObject"
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
  - "ATL::CComModule::GetClassObject"
  - "CComModule::GetClassObject"
  - "CComModule.GetClassObject"
  - "ATL.CComModule.GetClassObject"
  - "GetClassObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClassObject method"
ms.assetid: 587115f5-e820-42c9-aae0-aa351e56e7d7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::GetClassObject
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
      HRESULT GetClassObject(  
   REFCLSID rclsid,  
   REFIID riid,  
   LPVOID* ppv   
) throw( );  
```  
  
#### Parameters  
 `rclsid`  
 [in] The CLSID of the object to be created.  
  
 `riid`  
 [in] The IID of the requested interface.  
  
 `ppv`  
 [out] A pointer to the interface pointer identified by `riid`. If the object does not support this interface, `ppv` is set to **NULL**.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
 `GetClassObject` is only available to DLLs.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)