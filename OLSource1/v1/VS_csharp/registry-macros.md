---
title: "Registry Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registry, ATL macros"
ms.assetid: 3ee041da-c63b-42a4-89cf-2a4b2a6f81ae
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Registry Macros
These macros define useful type library and registry facilities.  
  
|||  
|-|-|  
|[_ATL_STATIC_REGISTRY](../VS_csharp/_atl_static_registry.md)|Indicates that you want the registration code for your object to be in the object to avoid a dependency on ATL.DLL.|  
|[DECLARE_LIBID](../VS_csharp/declare_libid.md)|Provides a way for ATL to obtain the *libid* of the type library.|  
|[DECLARE_NO_REGISTRY](../VS_csharp/declare_no_registry.md)|Avoids default ATL registration.|  
|[DECLARE_REGISTRY](../VS_csharp/declare_registry.md)|Enters or removes the main object's entry in the system registry.|  
|[DECLARE_REGISTRY_APPID_RESOURCEID](../VS_csharp/declare_registry_appid_resourceid.md)|Specifies the information required to automatically register the *appid*.|  
|[DECLARE_REGISTRY_RESOURCE](../VS_csharp/declare_registry_resource.md)|Finds the named resource and runs the registry script within it.|  
|[DECLARE_REGISTRY_RESOURCEID](../VS_csharp/declare_registry_resourceid.md)|Finds the resource identified by an ID number and runs the registry script within it.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)