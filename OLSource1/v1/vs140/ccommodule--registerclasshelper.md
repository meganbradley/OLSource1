---
title: "CComModule::RegisterClassHelper"
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
  - "RegisterClassHelper"
  - "CComModule.RegisterClassHelper"
  - "CComModule::RegisterClassHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterClassHelper method"
ms.assetid: 2ca9827e-5e86-4e8c-9cf3-00d6cc06f5c5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::RegisterClassHelper
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The CLSID of the object to be registered.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The ProgID associated with the object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The version-independent ProgID associated with the object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The identifier of a string resource for the object's description.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Specifies the threading model to enter in the registry. Possible values are **THREADFLAGS_APARTMENT**, **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Enters an object's standard class registration in the system registry.  
  
 The [UpdateRegistryClass](../vs140/ccommodule--updateregistryclass.md) method calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::UnregisterClassHelper](../vs140/ccommodule--unregisterclasshelper.md)