---
title: "Extending Properties"
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
  - "Properties window, providing support"
ms.assetid: 68e2cbd4-861c-453f-8c9f-4ab6afc80e67
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending Properties
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Properties** window is a universal property browser for COM and COM+ components and supports all [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] products. The **Properties** window works with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> type information and COM+ metadata to list the design-time properties for the currently selected object in any other window in the integrated development environment (IDE).  
  
 The **Properties** window, which can be opened by pressing F4 on the keyboard, or selecting **Properties Window** on the **View** menu, is used to view and edit configuration-independent, design-time properties and events of selected objects. Configuration-dependent properties, associated with solutions and projects, are displayed on [Property Pages](../vs140/property-pages.md). For more information, see [NIB:Project Properties](assetId:///fb126574-24ad-4c96-9b2b-6e1f3879ba50), [Managing Configuration Options](../vs140/managing-configuration-options.md), and [NIB:Item Management in Projects](assetId:///762e606b-7f44-4b66-97a1-e30a703654a0).  
  
 ![Properties Window Overview](../vs140/media/vspropertieswindow.png "vsPropertiesWindow")  
Properties window  
  
 This section provides detailed information that relates to the individual areas of the **Properties** window and the interfaces that you must implement and call to populate the window.  
  
## In This Section  
 [Properties Window Overview](../vs140/properties-window-overview.md)  
 Explains the purpose of the **Properties** window relative to the tool window and the document window.  
  
 [Template Policy and the Properties Window](../vs140/template-policy-and-the-properties-window.md)  
 Discusses how a project is contained in an enterprise template project, and how that enterprise template project can enforce policy.  
  
 [Properties Window Fields and Interfaces](../vs140/properties-window-fields-and-interfaces.md)  
 Explains the basis for selection that determines what information is displayed in the **Properties** window.  
  
 [Properties Window Object List](../vs140/properties-window-object-list.md)  
 Describes the purpose of the **Properties** window object list, describing how, when a different object from this list triggers a call, the environment is informed that a new object has been selected.  
  
 [Properties Window Buttons](../vs140/properties-window-buttons.md)  
 Explains the purpose of the four default buttons displayed on the **Properties** window toolbar.  
  
 [Properties Display Grid](../vs140/properties-display-grid.md)  
 Explains where the property names and property values fields are found in the grid.  
  
 [How to: Announce Selection Tracking to the Environment](../vs140/announcing-property-window-selection-tracking.md)  
 Describes selection tracking for the **Properties** window.  
  
 [Hiding Properties That Have Child Properties](../vs140/hiding-properties-that-have-child-properties.md)  
 Explains how to hide properties that have child properties by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing*> interface.  
  
 [How to: Provide Your Own Properties Window](../vs140/providing-a-custom-properties-window.md)  
 Details the steps for providing your own property browser.  
  
 [Getting Field Descriptions from the Properties Window](../vs140/getting-field-descriptions-from-the-properties-window.md)  
 Explains where to find the description area that displays information related to the selected property field.  
  
 [How to: Update Property Values in the Properties Window](../vs140/updating-property-values-in-the-properties-window.md)  
 Provides step-by-step instructions that show the two ways to keep the **Properties** window synchronized with property value changes.  
  
## Related Sections  
 [Project Types](../vs140/project-types.md)  
 Discusses projects as the building blocks of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE.  
  
 [Compiling and Building](../vs140/compiling-and-building-in-visual-studio.md)  
 Describes how you can use the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Platform for continuously testing and debugging applications as you build them.  
  
 [HTML Document Properties, Properties Window](assetId:///46e3d164-a1a7-42f9-87b0-344e10a37b62)  
 Provides instructions for editing an HTML document directly from the Properties window, and provides a table detailing the fields in an HTML document in the Properties window.  
  
 [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5)  
 Describes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface, which was first designed to support automation, providing a late-bound mechanism to access and retrieve information about the methods and properties of an object.  
  
 [NIB: Introduction to Dynamic Properties (Visual Studio)](assetId:///f5102027-1431-4195-ae40-9b991de46d3a)  
 Provides an overview of dynamic properties that let you configure your application so that property values are stored in an external configuration file instead of the application's compiled code.  
  
 [NIB:Projects as Containers](assetId:///87d40f63-f487-4767-8963-64beec27ba1b)  
 Describes the role of the project as a container in a solution to logically manage, build, and debug the items that make up your application.  
  
 [NIB:Project Properties](assetId:///fb126574-24ad-4c96-9b2b-6e1f3879ba50)  
 Describes how the project manages settings that let you control properties that apply to the whole project and also properties that are limited to certain build configurations of the project.  
  
 [Solutions and Projects](../vs140/solutions-and-projects-in-visual-studio.md)  
 Explains how [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] efficiently manages the items such as references, data connections, folders, and files that are required by your development effort through solutions and projects.  
  
 [User Interfaces](../vs140/extending-other-parts-of-visual-studio.md)  
 Explains how to use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] services to create UI elements that match the rest of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].