---
title: "CAtlModule::UpdateRegistryFromResourceDHelper"
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
  - ATL::CAtlModule::UpdateRegistryFromResourceDHelper
  - CAtlModule.UpdateRegistryFromResourceDHelper
  - ATL.CAtlModule.UpdateRegistryFromResourceDHelper
  - CAtlModule::UpdateRegistryFromResourceDHelper
  - UpdateRegistryFromResourceDHelper
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateRegistryFromResourceDHelper method
ms.assetid: ebaefc9f-a88d-428e-8882-f1f712a14d4e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlModule::UpdateRegistryFromResourceDHelper
This method is called by `UpdateRegistryFromResourceD` to perform the registry update.  
  
## Syntax  
  
```  
  
      inline HRESULT WINAPI UpdateRegistryFromResourceDHelper(  
   LPCOLESTR lpszRes,  
   BOOL bRegister,  
   struct _ATL_REGMAP_ENTRY* pMapEntries = NULL   
) throw( );  
```  
  
#### Parameters  
 `lpszRes`  
 A resource name.  
  
 `bRegister`  
 Indicates whether the object should be registered.  
  
 `pMapEntries`  
 A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses %MODULE%. To use additional replaceable parameters, see [CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md). Otherwise, use the **NULL** default value.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method provides the implementation of [CAtlModule::UpdateRegistryFromResourceD](../vs140/catlmodule--updateregistryfromresourced.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)