---
title: "CAtlDllModuleT::DllRegisterServer"
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
  - "CAtlDllModuleT::DllRegisterServer"
  - "ATL::CAtlDllModuleT::DllRegisterServer"
  - "CAtlDllModuleT.DllRegisterServer"
  - "ATL.CAtlDllModuleT.DllRegisterServer"
  - "DllRegisterServer"
  - "CAtlDllModuleT<T>::DllRegisterServer"
  - "ATL::CAtlDllModuleT<T>::DllRegisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DllRegisterServer method"
ms.assetid: ccce6d40-7739-4352-a1e7-e494ca65d62e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlDllModuleT::DllRegisterServer
Adds entries to the system registry for objects in the DLL.  
  
## Syntax  
  
```  
  
      HRESULT DllRegisterServer(  
   BOOL bRegTypeLib = TRUE   
) throw( );  
```  
  
#### Parameters  
 `bRegTypeLib`  
 TRUE if the type library is to be registered. The default value is TRUE.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlDllModuleT Class](../vs140/catldllmodulet-class.md)   
 [CAtlDllModuleT::DllUnregisterServer](../vs140/catldllmodulet--dllunregisterserver.md)