---
title: "How to: Add a Property to a Custom SharePoint Project Item Type"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint development in Visual Studio, defining new project item types"
ms.assetid: 47e940f6-1779-4530-aea6-c43a370c544f
caps.latest.revision: 16
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
# How to: Add a Property to a Custom SharePoint Project Item Type
  When you define a custom SharePoint project item type, you can add a property to the project item. The property appears in the **Properties** window when the project item is selected in **Solution Explorer**.  
  
 The following steps assume that you have already defined your own SharePoint project item type. For more information, see [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md).  
  
### To add a property to a definition of a project item type  
  
1.  Define a class with a public property that represents the property you are adding to the custom project item type. If you want to add multiple properties to a custom project item type, you can define all the properties in the same class or in different classes.  
  
2.  In the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method of your \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation, handle the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event of the *projectItemTypeDefinition* parameter.  
  
3.  In the event handler for the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event, add an instance of your custom properties class to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemPropertiesRequestedEventArgs.PropertySources*> collection of the event arguments parameter.  
  
## Example  
 The following code example demonstrates how to add a property named **Example Property** to a custom project item type.  
  
 [!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#11](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-property-to-a-custom-sharepoint-project-item-type_1.vb)]
[!code[SPExtensibility.ProjectItemExtension.MenuAndProperty#11](../VS_officedev/codesnippet/CSharp/how-to--add-a-property-to-a-custom-sharepoint-project-item-type_1.cs)]  
  
### Understanding the Code  
 To ensure that the same instance of the `CustomProperties` class is used each time the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event occurs, the code example saves the properties object to the \<xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations*> property of the project item the first time this event occurs. The code retrieves this object whenever this event occurs again. For more information about using the \<xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations*> property to save data with project items, see [Associating Custom Data with SharePoint Tools Extensions](../VS_officedev/associating-custom-data-with-sharepoint-tools-extensions.md).  
  
 To persist changes to the property value, the **set** accessor for `ExampleProperty` saves the new value to the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object that the property is associated with. For more information about using the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property to persist data with project items, see [Saving Data in Extensions of the SharePoint Project System](../VS_officedev/saving-data-in-extensions-of-the-sharepoint-project-system.md).  
  
### Specifying the Behavior of Custom Properties  
 You can define how a custom property appears and behaves in the **Properties** window by applying attributes from the \<xref:System.ComponentModel> namespace to the property definition. The following attributes are useful in many scenarios:  
  
-   \<xref:System.ComponentModel.DisplayNameAttribute>: Specifies the name of the property that appears in the **Properties** window.  
  
-   \<xref:System.ComponentModel.DescriptionAttribute>: Specifies the description string that appears in the bottom of the **Properties** window when the property is selected.  
  
-   \<xref:System.ComponentModel.DefaultValueAttribute>: Specifies the default value of the property.  
  
-   \<xref:System.ComponentModel.TypeConverterAttribute>: Specifies a custom conversion between the string that is displayed in the **Properties** window and a non-string property value.  
  
-   \<xref:System.ComponentModel.EditorAttribute>: Specifies a custom editor to use to modify the property.  
  
## Compiling the Code  
 These code examples require a class library project with references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
## Deploying the Project Item  
 To enable other developers to use your project item, create a project template or a project item template. For more information, see [Creating Item Templates and Project Templates for SharePoint Project Items](../VS_officedev/creating-item-templates-and-project-templates-for-sharepoint-project-items.md).  
  
 To deploy the project item, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly, the template, and any other files that you want to distribute with the project item. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md)   
 [How to: Add a Shortcut Menu Item to a Custom SharePoint Project Item Type](../VS_officedev/how-to--add-a-shortcut-menu-item-to-a-custom-sharepoint-project-item-type.md)   
 [Defining Custom SharePoint Project Item Types](../VS_officedev/defining-custom-sharepoint-project-item-types.md)  
  
  