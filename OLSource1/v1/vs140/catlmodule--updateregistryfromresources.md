---
title: "CAtlModule::UpdateRegistryFromResourceS"
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
  - "CAtlModule.UpdateRegistryFromResourceS"
  - "UpdateRegistryFromResourceS"
  - "CAtlModule::UpdateRegistryFromResourceS"
  - "ATL.CAtlModule.UpdateRegistryFromResourceS"
  - "ATL::CAtlModule::UpdateRegistryFromResourceS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateRegistryFromResourceS method"
ms.assetid: e814cc18-7c1b-4fcd-a851-9f6bef108dca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModule::UpdateRegistryFromResourceS
Runs the script contained in a specified resource to register or unregister an object. This method statically links to the ATL Registry Component.  
  
## Syntax  
  
```  
  
      HRESULT WINAPI UpdateRegistryFromResourceS(  
   UINT nResID,  
   BOOL bRegister,  
   struct _ATL_REGMAP_ENTRY* pMapEntries = NULL   
) throw( );  
HRESULT WINAPI UpdateRegistryFromResourceS(  
   LPCTSTR lpszRes,  
   BOOL bRegister,  
   struct _ATL_REGMAP_ENTRY* pMapEntries = NULL   
) throw( );  
```  
  
#### Parameters  
 `nResID`  
 A resource ID.  
  
 `lpszRes`  
 A resource name.  
  
 `bRegister`  
 Indicates whether the resource script should be registered.  
  
 `pMapEntries`  
 A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses %MODULE%. To use additional replaceable parameters, see [CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md). Otherwise, use the **NULL** default value.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Similar to [CAtlModule::UpdateRegistryFromResourceD](../vs140/catlmodule--updateregistryfromresourced.md) except `CAtlModule::UpdateRegistryFromResourceS` creates a static link to the ATL Registry Component (Registrar).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)   
 [Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md)