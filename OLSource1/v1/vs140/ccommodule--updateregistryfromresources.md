---
title: "CComModule::UpdateRegistryFromResourceS"
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
  - "UpdateRegistryFromResourceS"
  - "CComModule.UpdateRegistryFromResourceS"
  - "CComModule::UpdateRegistryFromResourceS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateRegistryFromResourceS method"
ms.assetid: 5e0ec2cf-182d-4798-95b1-4eb85462468b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::UpdateRegistryFromResourceS
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A resource name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A resource ID.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Indicates whether the resource script should be registered.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. To use additional replaceable parameters, see the Remarks for details. Otherwise, use the **NULL** default value.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Similar to [UpdateRegistryFromResourceD](../vs140/ccommodule--updateregistryfromresourced.md) except <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> creates a static link to the ATL Registry Component (Registrar).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will be invoked automatically when your object map is processed, provided you add <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to your stdafx.h.  
  
> [!NOTE]
>  To substitute replacement values at run time, do not specify the [DECLARE_REGISTRY_RESOURCE](../vs140/declare_registry_resource.md) or [DECLARE_REGISTRY_RESOURCEID](../vs140/declare_registry_resourceid.md) macro. Instead, create an array of **_ATL_REGMAP_ENTRIES** structures, where each entry contains a variable placeholder paired with a value to replace the placeholder at run time. Then call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, passing the array for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. This adds all the replacement values in the **_ATL_REGMAP_ENTRIES** structures to the Registrar's replacement map.  
  
 For more information about replaceable parameters and scripting, see the article [The ATL Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)