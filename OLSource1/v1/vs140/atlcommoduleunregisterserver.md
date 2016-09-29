---
title: "AtlComModuleUnregisterServer"
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
  - "AtlComModuleUnregisterServer"
  - "ATL::AtlComModuleUnregisterServer"
  - "ATL.AtlComModuleUnregisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlComModuleUnregisterServer function"
ms.assetid: c4ef3da4-def7-4aaf-b005-573a02e389d5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlComModuleUnregisterServer
This function is called to unregister every object in the object map.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLINLINE ATLAPI AtlComModuleUnregisterServer(  
_ATL_COM_MODULE* pComModule,  
BOOL bUnRegTypeLib,  
const CLSID* pCLSID   
);  
```  
  
#### Parameters  
 `pComModule`  
 Pointer to the COM module.  
  
 `bUnRegTypeLib`  
 TRUE if the type library is to be registered.  
  
 `pCLSID`  
 Points to the CLSID of the object to be unregistered. If NULL all objects in the object map will be unregistered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 `AtlComModuleUnregisterServer` walks the ATL object map and unregisters each object in the map. If `pCLSID` is not NULL, then only the object referred to by `pCLSID` is unregistered; otherwise all of the objects are unregistered.  
  
 This function is called by [CAtlComModule::UnregisterServer](../vs140/catlcommodule--unregisterserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [CAtlComModule::UnregisterServer](../vs140/catlcommodule--unregisterserver.md)