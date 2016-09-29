---
title: "Automation for Configuration and SelectedItem Objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "automation [Visual Studio SDK], SelectedItem object"
  - "automation [Visual Studio SDK], builds"
ms.assetid: 120377f1-51aa-4445-b2f7-06ab7fc2b47f
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Automation for Configuration and SelectedItem Objects
You can automate the build and selected item processes in [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
## Automation for Builds  
 Build or configuration has an automation model that is provided when you implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider*>. For more information, see [Understanding Build Configurations](../VS_csharp/understanding-build-configurations.md).  
  
 If you create a VSPackage and want to control configuration options, you must use the automation model.  
  
## Automation for SelectedItem  
 You do not have to provide an implementation for the `SelectedItem` object because Visual Studio contains a standard implementation. However, you can implement the `SelectedItem` object if you prefer. You must implement an object that contains the `SelectedItem` interface and return a response to a call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage*> method with VSITEMID set to <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_ExtSelectedItem*>.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage*>   
 [Contributing to the Automation Model](../VS_csharp/contributing-to-the-automation-model.md)   
 [Understanding Build Configurations](../VS_csharp/understanding-build-configurations.md)