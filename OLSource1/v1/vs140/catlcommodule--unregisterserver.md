---
title: "CAtlComModule::UnregisterServer"
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
  - CAtlComModule.UnregisterServer
  - UnregisterServer
  - ATL.CAtlComModule.UnregisterServer
  - CAtlComModule::UnregisterServer
  - ATL::CAtlComModule::UnregisterServer
dev_langs: 
  - C++
helpviewer_keywords: 
  - UnregisterServer method
ms.assetid: 37808de3-3f24-48e6-97c9-e26c3c9cda74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlComModule::UnregisterServer
Call this method to unregister each object in the object map.  
  
## Syntax  
  
```  
  
      HRESULT UnregisterServer(  
   BOOL bRegTypeLib = FALSE,  
   const CLSID* pCLSID = NULL   
);  
```  
  
#### Parameters  
 `bRegTypeLib`  
 TRUE if the type library is to be unregistered. The default value is FALSE.  
  
 `pCLSID`  
 Points to the CLSID of the object to be unregistered. If NULL (the default value), all objects in the object map will be unregistered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Calls the global function [AtlComModuleUnregisterServer](../vs140/atlcommoduleunregisterserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlComModule Class](../vs140/catlcommodule-class.md)   
 [CAtlComModule::RegisterServer](../vs140/catlcommodule--registerserver.md)