---
title: "AtlGetPerUserRegistration"
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
  - "AtlGetPerUserRegistration"
  - "ATL.AtlGetPerUserRegistration"
  - "ATL::AtlGetPerUserRegistration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetPerUserRegistration function"
ms.assetid: e34db830-828b-4903-ae57-cfc426dd8e5f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetPerUserRegistration
Use this function to determine whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> indicates that the registry information is directed to the **HKCU** node; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> indicates that the application writes registry information to the default node. The default node is **HKEY_CLASSES_ROOT** (**HKCR**).  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method is successful, otherwise the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> error code if an error occurs.  
  
## Remarks  
 Registry redirection is not enabled by default. If you enable this option, registry access is redirected to **HKEY_CURRENT_USER\Software\Classes**.  
  
 The redirection is not global. Only the MFC and ATL frameworks are affected by this registry redirection.  
  
## Requirements  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> atlbase.h  
  
## See Also  
 [Registry and TypeLib Global Functions](../vs140/registry-and-typelib-global-functions.md)   
 [AtlSetPerUserRegistration](../vs140/atlsetperuserregistration.md)