---
title: "Contributing to the Automation Model"
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
  - "automation [Visual Studio SDK]"
ms.assetid: 44de482d-93c8-41a4-843c-cefda995a03e
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Contributing to the Automation Model
Visual Studio provides a set of automation interfaces for customizing the environment. The automation model is the object model that enables end users to create Visual Studio add-ins and extensions.  
  
 In addition, it is appropriate for you, as a VSPackage developer, to contribute to the automation model; by doing this, you enable end users of your VSPackage to create add-ins and generally provide a consistent user model experience when they use your VSPackage in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 To make the end-user experience consistent, you can follow a set of guidelines as you design your VSPackage so that the automation model for your VSPackage follows the ideas in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## In This Section  
 [Automation Model Overview](../vs140/automation-model-overview.md)  
 Defines the automation model as a related groups of objects that control major facets of the common environment. This set of objects is pictured in a diagram of the automation model.  
  
 [Providing Automation for VSPackages](../vs140/providing-automation-for-vspackages.md)  
 Discusses the two main ways to provide automation for your VSPackage.  
  
 [Exposing Project Objects](../vs140/exposing-project-objects.md)  
 Provides step-by-step instructions for creating VSPackage-specific objects.  
  
 [Project Modeling](../vs140/project-modeling.md)  
 Explains the standard project objects that are required to create automation for your new project type and illustrates the path that project automation follows. This topic also provides listings of declarations and implementation for classes.  
  
 [Exposing Events](../vs140/exposing-events-in-the-visual-studio-sdk.md)  
 Provides step-by-step instructions for creating events for your automation model.  
  
 [Automation Support for Options Pages](../vs140/automation-support-for-options-pages.md)  
 Describes how to return an automation object for supporting properties of a VSPackage's custom **Options** dialog box on the **Tool** menu by extending the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object.  
  
 [Providing Automation for Code](../vs140/providing-automation-for-code.md)  
 Explains that creating an automation model for your code is not required. However, a link is provided in this topic that provides insightful information into code models.  
  
 [How to: Provide Automation for Windows](../vs140/how-to--provide-automation-for-windows.md)  
 Explains that providing automation is a good idea whenever you want to make automation objects available on a window, and the environment does not already provide a ready-made automation object. Discusses automation for tool windows and document windows.  
  
 [Using the Automation Model](../vs140/using-the-automation-model.md)  
 Provides two code examples that show how an automation consumer obtains the initial project automation objects.  
  
 [Automation for Configuration and Selected Item Objects](../vs140/automation-for-configuration-and-selecteditem-objects.md)  
 Provides information about automation for Configuration Options and automation for Selected Items.  
  
## Reference  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*>  
 Provides a code sample that shows how a VSPackage participates in the DTE automation object model. Lists parameters, return values, and selected remarks.  
  
## Related Sections