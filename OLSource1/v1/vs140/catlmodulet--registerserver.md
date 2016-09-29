---
title: "CAtlModuleT::RegisterServer"
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
  - "ATL::CAtlModuleT<T>::RegisterServer"
  - "CAtlModuleT<T>::RegisterServer"
  - "CAtlModuleT.RegisterServer"
  - "ATL.CAtlModuleT.RegisterServer"
  - "CAtlModuleT::RegisterServer"
  - "ATL.CAtlModuleT<T>.RegisterServer"
  - "ATL::CAtlModuleT::RegisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterServer method"
ms.assetid: 147c842f-3cf1-4cf6-8d65-ddfbfb1f6a49
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModuleT::RegisterServer
Adds the service to the registry.  
  
## Syntax  
  
```  
  
      HRESULT RegisterServer(  
   BOOL bRegTypeLib = FALSE,  
   const CLSID* pCLSID = NULL   
) throw( );  
```  
  
#### Parameters  
 `bRegTypeLib`  
 TRUE if the type library is to be registered. The default value is FALSE.  
  
 `pCLSID`  
 Points to the CLSID of the object to be registered. If NULL (the default value), all objects in the object map will be registered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModuleT Class](../vs140/catlmodulet-class.md)   
 [CAtlModuleT::UnregisterServer](../vs140/catlmodulet--unregisterserver.md)