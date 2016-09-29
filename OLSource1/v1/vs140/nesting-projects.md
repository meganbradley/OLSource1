---
title: "Nesting Projects"
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
  - "project nesting"
  - "nested projects"
  - "projects [Visual Studio SDK], child projects"
  - "projects [Visual Studio SDK], nesting"
ms.assetid: 12cce037-9840-4761-845e-5abd5fb317b0
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Nesting Projects
Enterprise application developers who use your VS Package can conveniently group similar types of projects together in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] by using *project nesting*. For example, the Enterprise Template project uses nested projects to group projects into categories. Business facade projects, Web UI projects, and so on are grouped together in one category.  
  
 In this scenario, there is no limit to the number of projects the developer can nest under each parent project, although the developer can programmatically provide limits. This type of grouping can also be made recursive, in which case the projects of the same type as a child project can be nested under the child to become a subproject of the child, which is a subproject of the parent.  
  
 Project nesting is not an intrinsic part of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. You have to write the code to enable nesting and subproject nesting within child projects. The parent project is a special VSPackage, or project type, created and registered with its own GUID that includes the code that is required to implement project nesting.  
  
 You can find an example of nested projects in the C# Example.Nested Project sample.  
  
## Nested projects example  
 ![Nested Projects Solution](../vs140/media/vsnestedprojects.gif "vsNestedProjects")  
Nested projects example  
  
## See Also  
 [How to: Implement Nested Projects](../vs140/how-to--implement-nested-projects.md)   
 [Conditions for Unloading and Reloading Nested Project Items](../vs140/considerations-for-unloading-and-reloading-nested-projects.md)   
 [Wizard Support for Nested Projects](../vs140/wizard-support-for-nested-projects.md)   
 [Registering Project and Item Templates](../vs140/registering-project-and-item-templates.md)   
 [Implementing Command Handling for Nested Projects](../vs140/implementing-command-handling-for-nested-projects.md)   
 [Filtering the AddItem Dialog Box for Nested Projects](../vs140/filtering-the-additem-dialog-box-for-nested-projects.md)   
 [Checklist: Creating New Project Types](../vs140/checklist--creating-new-project-types.md)   
 [Context Parameters](../vs140/context-parameters.md)   
 [Wizard (.Vsz) File](../vs140/wizard--.vsz--file.md)