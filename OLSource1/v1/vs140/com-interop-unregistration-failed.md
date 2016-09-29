---
title: "COM Interop unregistration failed"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.cannot_unregister_com2"
ms.assetid: 1172b560-c4b0-4aff-9f74-cf9b29ff76d9
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Interop unregistration failed
A problem occurred when trying to unregister an old copy of the assembly.  
  
 If the **Register for COM Interop** property is set, the project system will attempt to first unregister an old copy of the COM object before registering the copy that was just built. This is done to keep the registry current.  
  
 See the **Build** property page in the Configuration Properties folder to access the **Register for COM Interop** property.  
  
 Some possible reasons for failure include:  
  
-   Inability to unregister the previous type library for the assembly. This could be a permissions problem in the registry.  
  
-   Inability to unregister the old assembly. This could be a permissions problem in the registry as well.  
  
 If the unregistration process fails, a leak of the GUID for CoCreatable objects may occur, as well as for any type library GUIDs. However, the overall build process will still succeed.  
  
## See Also  
 [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md)