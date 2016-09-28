---
title: "Adding Project and Project Item Templates"
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
  - "projects [Visual Studio SDK], adding"
  - "project items [Visual Studio], adding"
ms.assetid: 8c59217f-56e5-4540-a73b-cd10de189373
caps.latest.revision: 21
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding Project and Project Item Templates
When you create your own project types, you must provide support for adding new projects and project items by using the standard [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) dialog boxes. The following topics discuss different techniques for adding projects and project items.  
  
## In This Section  
 [Project Context](../vs140/project-context.md)  
 Explains that the project provides most of the context information for what transpires in the environment.  
  
 [Project Priority](../vs140/project-priority.md)  
 Explains that a project item is usually a member of one project to help avoid ambiguity about which project is used to open the item.  
  
 [Miscellaneous Files Project](../vs140/miscellaneous-files-project.md)  
 Provides information about the two types of editors that can be used to open files in a project and the role the project plays in determining which editor to use when a project item is opened.  
  
 [Registering Project and Item Templates](../vs140/registering-project-and-item-templates.md)  
 Explains what occurs when a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project is created.  
  
 [Adding Items to the Add New Item Dialog Boxes](../vs140/adding-items-to-the-add-new-item-dialog-boxes.md)  
 Explains the process for adding items to the **Add New Item** dialog box.  
  
 [Adding Directories to the New Project Dialog Box](../vs140/adding-directories-to-the-new-project-dialog-box.md)  
 Provides an example of registering a new directory that contains custom templates made available by a VSPackage.  
  
 [Adding Directories to the Add New Item Dialog Box](../vs140/adding-directories-to-the-add-new-item-dialog-box.md)  
 Provides an example of registering a new set of directories for the **Add New Item** dialog box.  
  
 [IDE-Defined Commands for Extending Project Systems](../vs140/ide-defined-commands-for-extending-project-systems.md)  
 Lists different types of command items used for extending project systems.  
  
 [CATIDs for Objects Ordinarily Used to Extend Projects](../vs140/catids-for-objects-that-are-typically-used-to-extend-projects.md)  
 Lists CATIDs for objects that are used to extend [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)], and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project systems.  
  
## Related Sections  
 [How to: Open Project-Specific Editors](../vs140/how-to--open-project-specific-editors.md)  
 Provides step-by-step instructions for opening an item intrinsically bound to a specific editor for a project.  
  
 [How to: Open Standard Editors](../vs140/how-to--open-standard-editors.md)  
 Provides step-by-step instructions for opening a standard editor.  
  
 [Project Subtypes](../vs140/project-subtypes.md)  
 Provides links to project subtype conceptual topics. Project subtypes extend existing [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] projects.  
  
 [Project Types](../vs140/project-types.md)  
 Provides links to additional topics that offer information about how to design new project types.