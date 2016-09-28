---
title: "COM Interop Wrapper Error"
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
  - "vs.tasklisterror.cannotcopyassembly"
  - "Vs.refruntlbimp"
helpviewer_keywords: 
  - "COM Interop Wrapper dialog box"
ms.assetid: 9a9d6374-ee26-4dbc-9e34-e1d90f6254b4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Interop Wrapper Error
This message box is displayed when the project system could not create a COM interop wrapper for a particular component.  COM interop wrappers are required by the common language runtime (CLR) to manage and communicate with COM components.  For more information, see [COM Interoperability in Visual Basic and Visual C#](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md).  
  
 Common causes for the failure include:  
  
-   The type library for the component is not properly registered.  
  
-   A component on which the component being wrapped is dependent could not be found on your machine.  
  
 In both of these cases, you need to ensure that the COM component is properly installed and registered on your machine and retry the operation.  
  
> [!TIP]
>  You can also search the [MSDN Web site](http://go.microsoft.com/fwlink/?LinkId=3355) for a COM interop wrapper that has been published for your specific COM component.  
  
> [!NOTE]
>  COM interop wrappers are sometimes referred to as "primary interop assemblies." These terms are synonymous  
  
## See Also  
 [Component Model Namespaces in Visual Studio](assetId:///705d0add-0707-44ba-a6de-637381d9c937)   
 [Component Authoring](assetId:///4a5a5e49-0378-4a31-83bc-24da0f1a727d)   
 [COM Interop](../vs140/com-interop--visual-basic-.md)   
 [Common Language Runtime](assetId:///059a624e-f7db-4134-ba9f-08b676050482)   
 [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md)