---
title: "DECLARE_REGISTRY"
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
  - "DECLARE_REGISTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_REGISTRY macro"
ms.assetid: 89b8949b-5c27-4a9c-8a51-ad276bba3a54
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_REGISTRY
Enters the standard class registration into the system registry or removes it from the system registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Included for backward compatibility.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that is a version-specific program identifier.  
  
 *vpid*  
 [in] An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is a version-independent program identifier.  
  
 *nid*  
 [in] A **UINT** that is an index of the resource string in the registry to use as the description of the program.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> containing the program's threading model in the registry. Must be one of the following values: **THREADFLAGS_APARTMENT**, **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
## Remarks  
 The standard registration consists of the CLSID, program ID, version-independent program ID, description string, and thread model.  
  
 When you create an object or control using the ATL Add Class Wizard, the wizard automatically implements script-based registry support and adds the [DECLARE_REGISTRY_RESOURCEID](../vs140/declare_registry_resourceid.md) macro to your files. If you do not want script-based registry support, you need to replace this macro with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> only inserts the five basic keys described above into the registry. You must manually write code to insert other keys into the registry.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Registry Macros](../vs140/registry-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_REGISTRY_RESOURCE](../vs140/declare_registry_resource.md)