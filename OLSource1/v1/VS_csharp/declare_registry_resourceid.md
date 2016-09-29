---
title: "DECLARE_REGISTRY_RESOURCEID"
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
  - "DECLARE_REGISTRY_RESOURCEID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_REGISTRY_RESOURCEID macro"
ms.assetid: 65bf3576-5396-416e-ba48-e14b3236c49b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_REGISTRY_RESOURCEID
Same as [DECLARE_REGISTRY_RESOURCE](../VS_csharp/declare_registry_resource.md) except that it uses a wizard-generated **UINT** to identify the resource, rather than a string name.  
  
## Syntax  
  
```  
  
      DECLARE_REGISTRY_RESOURCEID(   
   x    
)  
```  
  
#### Parameters  
 *x*  
 [in] Wizard-generated identifier of your resource.  
  
## Remarks  
 When you create an object or control using the ATL Project Wizard, the wizard will automatically implement script-based registry support and add the `DECLARE_REGISTRY_RESOURCEID` macro to your files.  
  
 You can statically link with the ATL Registry Component (Registrar) for optimized registry access. To statically link to the Registrar code, add the following line to your stdafx.h file:  
  
 [!code[NVC_ATL_COM#56](../VS_csharp/codesnippet/CPP/declare_registry_resourceid_1.h)]  
  
 If you want ATL to substitute replacement values at run time, do not specify the `DECLARE_REGISTRY_RESOURCE` or `DECLARE_REGISTRY_RESOURCEID` macro. Instead, create an array of **_ATL_REGMAP_ENTRIES** structures, where each entry contains a variable placeholder paired with a value to replace the placeholder at run time. Then call [CAtlModule::UpdateRegistryFromResourceD](../Topic/CAtlModule::UpdateRegistryFromResourceD.md) or [CAtlModule::UpdateRegistryFromResourceS](../Topic/CAtlModule::UpdateRegistryFromResourceS.md), passing the array. This adds all of the replacement values in the **_ATL_REGMAP_ENTRIES** structures to the Registrar's replacement map.  
  
 For more information about replaceable parameters and scripting, see the article [The ATL Registry Component (Registrar)](../VS_csharp/atl-registry-component--registrar-.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Registry Macros](../VS_csharp/registry-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [DECLARE_REGISTRY](../VS_csharp/declare_registry.md)   
 [DECLARE_REGISTRY_RESOURCE](../VS_csharp/declare_registry_resource.md)