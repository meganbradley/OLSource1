---
title: "Saving Data in Extensions of the SharePoint Project System"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "SharePoint project items, saving string data"
  - "project items [SharePoint development in Visual Studio], saving string data"
  - "projects [SharePoint development in Visual Studio], saving string data"
  - "SharePoint projects, saving string data"
ms.assetid: 903b9da7-2eea-404c-9a7a-7bc15cb90d6c
caps.latest.revision: 13
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Saving Data in Extensions of the SharePoint Project System
  When you extend the SharePoint project system, you can save string data that persists after a SharePoint project is closed. The data is typically associated with a particular project item or with the project itself.  
  
 If you have data that does not need to persist, you can add the data to any object in the SharePoint tools object model that implements the \<xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject> interface. For more information, see [Associating Custom Data with SharePoint Tools Extensions](../VS_officedev/associating-custom-data-with-sharepoint-tools-extensions.md).  
  
## Saving Data That is Associated with a Project Item  
 When you have data that is associated with a particular SharePoint project item, such as the value of a property that you add to a project item, you can save the data to the .spdata file for the project item. To do this, use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object. Data that you add to this property is saved in the **ExtensionData** element in the .spdata file for the project item. For more information, see [ExtensionData Element](../VS_officedev/extensiondata-element.md).  
  
 The following code example demonstrates how to use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property to save the value of a string property that is defined in a custom SharePoint project item type. To see this example in the context of a larger example, see [How to: Add a Property to a Custom SharePoint Project Item Type](../VS_officedev/how-to--add-a-property-to-a-custom-sharepoint-project-item-type.md).  
  
 [!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../VS_officedev/codesnippet/VisualBasic/saving-data-in-extensions-of-the-sharepoint-project-system_1.vb)]
[!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../VS_officedev/codesnippet/CSharp/saving-data-in-extensions-of-the-sharepoint-project-system_1.cs)]  
  
## Saving Data That is Associated with a Project  
 When you have project-level data, such as the value of a property that you add to SharePoint projects, you can save the data to the project file (the .csproj file or .vbproj file) or the project user option file (the .csproj.user file or .vbproj.user file). The file you choose to save the data in depends on how you want the data to be used:  
  
-   If you want the data to be available to all developers who open the SharePoint project, save the data to the project file. This file is always checked in to source control databases, so the data in this file is available to other developers who check out the project.  
  
-   If you want the data to be available only to the current developer who has the SharePoint project open in Visual Studio, save the data to the project user option file. This file is not typically checked in to source control databases, so the data in this file is not available to other developers who check out the project.  
  
### Saving Data to the Project File  
 To save data to the project file, convert an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object to an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage> object, and then use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetPropertyValue*> method. The following code example demonstrates how to use this method to save the value of a project property to the project file. To see this example in the context of a larger sample, see [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md).  
  
 [!code[SpExt_SPCustomPrjProperty#3](../VS_officedev/codesnippet/VisualBasic/saving-data-in-extensions-of-the-sharepoint-project-system_2.vb)]
[!code[SpExt_SPCustomPrjProperty#3](../VS_officedev/codesnippet/CSharp/saving-data-in-extensions-of-the-sharepoint-project-system_2.cs)]  
  
 For more information about converting \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> objects to other types in the Visual Studio automation object model or integration object model, see [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../VS_officedev/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).  
  
### Saving Data to the Project User Option File  
 To save data to the project user option file, use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectUserFileData*> property of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. The following code example demonstrates how to use this property to save the value of a project property to the project user option file. To see this example in the context of a larger sample, see [How to: Add a Property to SharePoint Projects](../VS_officedev/how-to--add-a-property-to-sharepoint-projects.md).  
  
 [!code[SpExt_SPCustomPrjProperty#2](../VS_officedev/codesnippet/VisualBasic/saving-data-in-extensions-of-the-sharepoint-project-system_3.vb)]
[!code[SpExt_SPCustomPrjProperty#2](../VS_officedev/codesnippet/CSharp/saving-data-in-extensions-of-the-sharepoint-project-system_3.cs)]  
  
## See Also  
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)   
 [Associating Custom Data with SharePoint Tools Extensions](../VS_officedev/associating-custom-data-with-sharepoint-tools-extensions.md)   
 [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../VS_officedev/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)  
  
  