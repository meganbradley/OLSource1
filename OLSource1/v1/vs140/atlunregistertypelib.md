---
title: "AtlUnRegisterTypeLib"
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
  - "ATL.AtlUnRegisterTypeLib"
  - "AtlUnRegisterTypeLib"
  - "ATL::AtlUnRegisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlUnRegisterTypeLib function"
ms.assetid: 962b0fc8-e423-4341-a0f4-22c93760926a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlUnRegisterTypeLib
This function is called to unregister a type library.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlUnRegisterTypeLib(  
HINSTANCE hInstTypeLib,  
LPCOLESTR lpszIndex   
);  
```  
  
#### Parameters  
 `hInstTypeLib`  
 The handle to the module instance.  
  
 `lpszIndex`  
 String in the format "\\\N", where N is the integer index of the type library resource. Can be NULL if no index is required.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This helper function is utilized by [CAtlComModule::UnRegisterTypeLib](../vs140/catlcommodule--unregistertypelib.md) and [AtlComModuleUnregisterServer](../vs140/atlcommoduleunregisterserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [AtlRegisterTypeLib](../vs140/atlregistertypelib.md)   
 [AtlLoadTypeLib](../vs140/atlloadtypelib.md)