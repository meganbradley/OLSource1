---
title: "Registry and TypeLib Global Functions"
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
  - "RegistryDataExchange function, global functions"
ms.assetid: d58b8a4e-975c-4417-8b34-d3c847f679b3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Registry and TypeLib Global Functions
These functions provide support for loading and registering a type library.  
  
> [!IMPORTANT]
>  The functions listed in the following tables cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
|||  
|-|-|  
|[AtlRegisterTypeLib](../VS_csharp/atlregistertypelib.md)|This function is called to register a type library.|  
|[AtlUnRegisterTypeLib](../VS_csharp/atlunregistertypelib.md)|This function is called to unregister a type library|  
|[AtlLoadTypeLib](../VS_csharp/atlloadtypelib.md)|This function is called to load a type library.|  
|[AtlUpdateRegistryFromResourceD](../VS_csharp/atlupdateregistryfromresourced.md)|This function is called to update the registry from the supplied resource.|  
|[RegistryDataExchange](../VS_csharp/registrydataexchange.md)|This function is called to read from, or write to, the system registry. Called by the [Registry Data Exchange Macros](../VS_csharp/registry-data-exchange-macros.md).|  
  
 These functions control which node in the registry the program uses to store information.  
  
|||  
|-|-|  
|[AtlGetPerUserRegistration](../VS_csharp/atlgetperuserregistration.md)|Retrieves whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
|[AtlSetPerUserRegistration](../VS_csharp/atlsetperuserregistration.md)|Sets whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.|  
  
## See Also  
 [Functions](../VS_csharp/atl-functions.md)