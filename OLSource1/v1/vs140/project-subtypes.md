---
title: "Project Subtypes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - projects [Visual Studio SDK], subtypes
  - project subtypes [Visual Studio SDK]
ms.assetid: d235b47b-cf11-4d47-a63f-e33d9d16105d
caps.latest.revision: 24
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Project Subtypes
Project subtypes let you customize or flavor the behavior of the project systems of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Customizations include saving additional data in the project file, adding or filtering items in the **Add New Item** dialog box, controlling how assemblies are debugged and deployed, and extending the project **Property Pages** dialog box. VSPackages implement project subtypes using COM aggregation.  
  
> [!NOTE]
>  The Visual C++ project system does not support project subtypes. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] itself uses project subtypes to implement SQL Server and Smart Device projects.  
  
## In This Section  
 [Project Subtypes Design](../vs140/project-subtypes-design.md)  
 Describes the concept of project subtypes.  
  
 [Initialization Sequence of Project Subtypes](../vs140/initialization-sequence-of-project-subtypes.md)  
 Describes the programmatic project subtype initialization sequence by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment.  
  
 [Properties and Methods Extended by Project Subtypes](../vs140/properties-and-methods-extended-by-project-subtypes.md)  
 Provides detailed descriptions of the features and methods most frequently extended by using project subtypes.  
  
 [Persisting Data in the Project File](../vs140/persisting-data-in-the-msbuild-project-file.md)  
 Describes how to persist data in a project file and how to use <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment?qualifyHint=False> to maintain the data in the project file across the project subtype aggregation levels.  
  
 [Project Property UI](../vs140/project-property-user-interface.md)  
 Describes how project subtypes can modify the project **Property Pages** dialog box.  
  
 [Extending the Automation Object Model](../vs140/extending-the-object-model-of-the-base-project.md)  
 Provides information about how project subtypes can use Automation Extenders to extend the automation object model.  
  
 [Contributing to the Add New Item Dialog](../vs140/contributing-to-the-add-new-item-dialog-box.md)  
 Describes how to add items to the **Add New Item** dialog box.  
  
 [How to: Save Data in Project Files](../vs140/saving-data-in-project-files.md)  
 Explains how a project subtype can save and retrieve subtype-specific data in the project file by using the Managed Package Framework (MPF).  
  
 [How to: Handle Specialized Deployment](../vs140/handling-specialized-deployment.md)  
 Explains how project subtypes can supply specialized deployment behavior by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg?qualifyHint=False> interface.  
  
 [How to: Add and Remove Property Pages](../vs140/adding-and-removing-property-pages.md)  
 Describes adding and removing property pages in Project Designer.  
  
## Related Sections  
 [Adding a Project Type](../vs140/project-types.md)  
 Provides links to topics detailing [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] projects.