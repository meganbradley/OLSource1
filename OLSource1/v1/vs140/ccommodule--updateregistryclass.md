---
title: "CComModule::UpdateRegistryClass"
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
  - "UpdateRegistryClass"
  - "CComModule.UpdateRegistryClass"
  - "CComModule::UpdateRegistryClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateRegistryClass method"
ms.assetid: 46001300-844f-4f74-8a4d-f13fdfec8a88
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::UpdateRegistryClass
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The CLSID of the object to be registered or unregistered.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The ProgID associated with the object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The version-independent ProgID associated with the object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The identifier of the string resource for the object's description.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A string containing the object's description.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the threading model to enter in the registry. Possible values are **THREADFLAGS_APARTMENT**, **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Indicates whether the object should be registered.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **TRUE**, this method enters the object's standard class registration in the system registry.  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **FALSE**, it removes the object's registration.  
  
 Depending on the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls either [RegisterClassHelper](../vs140/ccommodule--registerclasshelper.md) or [UnregisterClassHelper](../vs140/ccommodule--unregisterclasshelper.md).  
  
 By specifying the [DECLARE_REGISTRY](../vs140/declare_registry.md) macro, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will be invoked automatically when your object map is processed.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)