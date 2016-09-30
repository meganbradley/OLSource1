---
title: "AtlSetPerUserRegistration"
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
  - "ATL::AtlSetPerUserRegistration"
  - "ATL.AtlSetPerUserRegistration"
  - "AtlSetPerUserRegistration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlSetPerUserRegistration function"
ms.assetid: 71aaa19f-02c0-4f88-afde-47470fe2247a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlSetPerUserRegistration
Sets whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
ATLINLINE ATLAPI AtlSetPerUserRegistration(  
   bool bEnable  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` indicates that the registry information is directed to the **HKCU** node; `FALSE` indicates that the application writes registry information to the default node. The default node is **HKEY_CLASSES_ROOT** (**HKCR**).  
  
## Return Value  
 `S_OK` if the method is successful, otherwise the `HRESULT` error code if an error occurs.  
  
## Remarks  
 Registry redirection is not enabled by default. If you enable this option, registry access is redirected to **HKEY_CURRENT_USER\Software\Classes**.  
  
 The redirection is not global. Only the MFC and ATL frameworks are affected by this registry redirection.  
  
## Requirements  
 `Header:` atlbase.h  
  
## See Also  
 [Registry and TypeLib Global Functions](../vs140/registry-and-typelib-global-functions.md)   
 [AtlGetPerUserRegistration](../vs140/atlgetperuserregistration.md)