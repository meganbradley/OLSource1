---
title: "AtlModuleRegisterServer"
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
  - "ATL::AtlModuleRegisterServer"
  - "AtlModuleRegisterServer"
  - "ATL.AtlModuleRegisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlModuleRegisterServer function"
ms.assetid: ea2d3f99-fbe6-402f-89ec-18e0c8452023
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlModuleRegisterServer
Registers every object in the object map.  
  
 **Note** This function is obsolete in Visual C++ .NET 2002 and later but is available for backward compatibility with projects created with previous versions of Visual C++.  
  
## Syntax  
  
```  
  
      ATLAPI AtlModuleRegisterServer(  
   _ATL_MODULE* pM,  
   BOOL bUnRegTypeLib,  
   const CLSID* pCLSID   
);  
```  
  
#### Parameters  
 `pM`  
 Pointer to a `CComModule` class or derived class.  
  
 `bUnRegTypeLib`  
 TRUE if the type library is to be registered.  
  
 `pCLSID`  
 Points to the CLSID of the object to be registered. If NULL, all objects in the object map will be registered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This function walks the ATL object map and registers each object in the map. If `pCLSID` is not NULL, then only the object referred to by `pCLSID` is registered; otherwise, all objects are registered.  
  
 This function is obsolete. Instead, use its replacement, [AtlComModuleRegisterServer](../vs140/atlcommoduleregisterserver.md).  
  
 This helper function is used by [CComModule::RegisterServer](../vs140/ccommodule--registerserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [CComModule::RegisterServer](../vs140/ccommodule--registerserver.md)   
 [AtlComModuleRegisterServer](../vs140/atlcommoduleregisterserver.md)