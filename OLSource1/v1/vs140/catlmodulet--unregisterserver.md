---
title: "CAtlModuleT::UnregisterServer"
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
  - "ATL::CAtlModuleT::UnregisterServer"
  - "ATL.CAtlModuleT.UnregisterServer"
  - "ATL::CAtlModuleT<T>::UnregisterServer"
  - "UnregisterServer"
  - "ATL.CAtlModuleT<T>.UnregisterServer"
  - "CAtlModuleT::UnregisterServer"
  - "CAtlModuleT<T>::UnregisterServer"
  - "CAtlModuleT.UnregisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterServer method"
ms.assetid: 91142fb4-1ebb-4c5b-9396-33891e2059a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModuleT::UnregisterServer
Removes the service from the registry.  
  
## Syntax  
  
```  
  
      HRESULT UnregisterServer(  
   BOOL bUnRegTypeLib,  
   const CLSID* pCLSID = NULL  
) throw( );  
```  
  
#### Parameters  
 `bUnRegTypeLib`  
 TRUE if the type library is also to be unregistered.  
  
 `pCLSID`  
 Points to the CLSID of the object to be unregistered. If NULL (the default value), all objects in the object map will be unregistered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModuleT Class](../vs140/catlmodulet-class.md)   
 [CAtlModuleT::RegisterServer](../vs140/catlmodulet--registerserver.md)