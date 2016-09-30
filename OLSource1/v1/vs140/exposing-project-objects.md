---
title: "Exposing Project Objects"
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
  - "project objects, exposing"
  - "extensibility, project objects"
ms.assetid: 5bb24967-434a-4ef4-87a0-2f3250c9e22d
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Exposing Project Objects
Custom project types can provide automation objects in order to allow access to the project using automation interfaces. Every project type is expected to provide the standard \<xref:EnvDTE.Project*> automation object that is accessed from \<xref:EnvDTE.Solution*>, which contains a collection of all projects that are open in the IDE. Each item in the project is expected to be exposed by a \<xref:EnvDTE.ProjectItem*> object accessed with \<xref:Project.ProjectItems*>. In addition to these standard automation objects, projects can choose to offer project-specific automation objects.  
  
 You can create custom root-level automation objects that you can access late-bound from the root DTE object using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For example, Visual C++ creates C++ project-specific project collection called “VCProjects” that you can access using DTE.VCProjects or DTE.GetObject("VCProjects"). You can also create a Project.Object, which is unique for the project type, a Project.CodeModel, which can be queried for its most-derived object, a ProjectItem, which exposes ProjectItem.Object and a ProjectItem.FileCodeModel.  
  
 It is a common convention for projects to expose a custom, project-specific project collection. For example, [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] creates a C++ specific project collection that you can then access using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You can also create a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which is unique for the project type, a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which can be queried for its most-derived object, a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which exposes <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### To contribute a VSPackage-specific object for a project  
  
1.  Add the appropriate keys to the .pkgdef file of your VSPackage.  
  
     For example, here are the .pkgdef settings for the C++ language project:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Implement the code in the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*> method, as in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     In the code, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the name of your project collection. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method creates an object that implements the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface and returns an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pointer to the calling object, as shown in the following code example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     You should choose a unique name for your automation object. Name conflicts are unpredictable, and collisions cause a conflicting object name to be arbitrarily thrown out if multiple project types use the same name. You should include your corporate name or some unique aspect of its product name in the name of the automation object.  
  
     The custom <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> collection object is a convenience entry point for the remaining part of your project automation model. Your project object is also accessible from the \<xref:EnvDTE.Solution*> project collection. After you have created the appropriate code and registry entries that provide consumers with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> collection objects, your implementation must provide remaining standard objects for the project model. For more information, see [Project Modeling](../vs140/project-modeling.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*>