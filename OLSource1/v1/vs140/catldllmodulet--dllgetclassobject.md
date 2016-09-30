---
title: "CAtlDllModuleT::DllGetClassObject"
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
  - "CAtlDllModuleT<T>::DllGetClassObject"
  - "ATL.CAtlDllModuleT.DllGetClassObject"
  - "ATL::CAtlDllModuleT<T>::DllGetClassObject"
  - "CAtlDllModuleT::DllGetClassObject"
  - "DllGetClassObject"
  - "CAtlDllModuleT.DllGetClassObject"
  - "ATL::CAtlDllModuleT::DllGetClassObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DllGetClassObject method"
ms.assetid: 79073d82-5765-4096-b5fc-567d97091f7b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlDllModuleT::DllGetClassObject
Returns the class factory.  
  
## Syntax  
  
```  
  
      HRESULT DllGetClassObject(  
   REFCLSID rclsid,  
   REFIID riid,  
   LPVOID* ppv   
) throw( );  
```  
  
#### Parameters  
 `rclsid`  
 The CLSID of the object to be created.  
  
 `riid`  
 The IID of the requested interface.  
  
 `ppv`  
 A pointer to the interface pointer identified by `riid`. If the object does not support this interface, `ppv` is set to NULL.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlDllModuleT Class](../vs140/catldllmodulet-class.md)