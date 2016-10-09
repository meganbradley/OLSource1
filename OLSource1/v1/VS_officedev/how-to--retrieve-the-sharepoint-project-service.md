---
title: "How to: Retrieve the SharePoint Project Service"
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
  - "SharePoint project service"
ms.assetid: 3d8b7adf-2603-4247-9b61-6326a1dd0dec
caps.latest.revision: 15
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
# How to: Retrieve the SharePoint Project Service
  You can access the SharePoint project service in the following types of solutions:  
  
-   An extension of the SharePoint project system, such as a project extension, project item extension, or project item type definition. For more information about these types of extensions, see [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md).  
  
-   An extension of the **SharePoint Connections** node in **Server Explorer**. For more information about these types of extensions, see [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md).  
  
-   Another type of Visual Studio extension, such as an add-in or a VSPackage.  
  
## Retrieving the Service in Project System Extensions  
 In any extension of the SharePoint project system, you can access the project service by using the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectService*> property of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object.  
  
 You can also retrieve the project service by using the following procedures.  
  
#### To retrieve the service in a project extension  
  
1.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface, locate the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize*> method.  
  
2.  Use the *projectService* parameter to access the service.  
  
     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple project extension.  
  
     [!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#1](../VS_officedev/codesnippet/VisualBasic/how-to--retrieve-the-sharepoint-project-service_1.vb)]
[!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#1](../VS_officedev/codesnippet/CSharp/how-to--retrieve-the-sharepoint-project-service_1.cs)]  
  
     For more information about creating project extensions, see [How to: Create a SharePoint Project Extension](../VS_officedev/how-to--create-a-sharepoint-project-extension.md).  
  
#### To retrieve the service in a project item extension  
  
1.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> interface, locate the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize*> method.  
  
2.  Use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType.ProjectService*> property of the *projectItemType* parameter to retrieve the service.  
  
     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple extension of the **List Definition** project item.  
  
     [!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#2](../VS_officedev/codesnippet/VisualBasic/how-to--retrieve-the-sharepoint-project-service_2.vb)]
[!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#2](../VS_officedev/codesnippet/CSharp/how-to--retrieve-the-sharepoint-project-service_2.cs)]  
  
     For more information about creating project item extensions, see [How to: Create a SharePoint Project Item Extension](../VS_officedev/how-to--create-a-sharepoint-project-item-extension.md).  
  
#### To retrieve the service in a project item type definition  
  
1.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface, locate the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method.  
  
2.  Use the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.ProjectService*> property of the *typeDefinition* parameter to retrieve the service.  
  
     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window in a simple project item type definition.  
  
     [!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#3](../VS_officedev/codesnippet/VisualBasic/how-to--retrieve-the-sharepoint-project-service_3.vb)]
[!code[SPExtensibility.ProjectService.FromProjectSystemExtensions#3](../VS_officedev/codesnippet/CSharp/how-to--retrieve-the-sharepoint-project-service_3.cs)]  
  
     For more information about defining project item types, see [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md).  
  
## Retrieving the Service in Server Explorer Extensions  
 In an extension of the **SharePoint Connections** node in **Server Explorer**, you can access the project service by using the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode.ServiceProvider*> property of an \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode> object.  
  
#### To retrieve the service in a Server Explorer extension  
  
1.  Get an \<xref:System.IServiceProvider> object from the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode.ServiceProvider*> property of an \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode> object in your extension.  
  
2.  Use the \<xref:System.IServiceProvider.GetService*> method to request an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object.  
  
     The following code example demonstrates how to use the project service to write a message to the **Output** window and **Error List** window from a shortcut menu that the extension adds to list nodes in **Server Explorer**.  
  
     [!code[SPExtensibility.ProjectService.FromSPExplorerExtensions#1](../VS_officedev/codesnippet/VisualBasic/how-to--retrieve-the-sharepoint-project-service_4.vb)]
[!code[SPExtensibility.ProjectService.FromSPExplorerExtensions#1](../VS_officedev/codesnippet/CSharp/how-to--retrieve-the-sharepoint-project-service_4.cs)]  
  
     For more information about extending the **SharePoint Connections** node in **Server Explorer**, see [How to: Extend a SharePoint Node in Server Explorer](../VS_officedev/how-to--extend-a-sharepoint-node-in-server-explorer.md).  
  
## Retrieving the Service in Other Visual Studio Extensions  
 You can retrieve the project service in a VSPackage, or in any Visual Studio extension that has access to a \<xref:EnvDTE80.DTE2> object in the automation object model, such as an add-in or a project template wizard that implements the \<xref:Microsoft.VisualStudio.TemplateWizard.IWizard> interface.  
  
 In a VSPackage, you can request an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object by using one of the following methods:  
  
-   The \<xref:System.IServiceProvider.GetService*> method of a managed VSPackage that derives from the \<xref:Microsoft.VisualStudio.Shell.Package> class. For more information, see [How to: Get a Service](../Topic/How%20to:%20Get%20a%20Service.md).  
  
-   The static \<xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService*> method. For more information, see [How to: Use GetGlobalService](../Topic/How%20to:%20Use%20GetGlobalService.md).  
  
 In a Visual Studio extension that has access to a \<xref:EnvDTE80.DTE2> object, you can request an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object by using the \<xref:Microsoft.VisualStudio.Shell.ServiceProvider.GetService*> method of a \<xref:Microsoft.VisualStudio.Shell.ServiceProvider> object. For more information, see [How to: Get a Service from the DTE Object](../Topic/How%20to:%20Get%20a%20Service%20from%20the%20DTE%20Object.md).  
  
### Example  
 The following code example demonstrates how to retrieve the project service in a Visual Studio add-in. To use this code, run it from the `Connect` class in an add-in project. The `_applicationObject` object is automatically generated in add-in projects; this object is an instance of the \<xref:EnvDTE80.DTE2> interface.  
  
 [!code[SPExtensibility.ProjectService.FromDTE#1](../VS_officedev/codesnippet/CSharp/how-to--retrieve-the-sharepoint-project-service_5.cs)]
[!code[SPExtensibility.ProjectService.FromDTE#1](../VS_officedev/codesnippet/VisualBasic/how-to--retrieve-the-sharepoint-project-service_5.vb)]  
  
 This example requires:  
  
-   A Visual Studio add-in project. For more information, see [How to: Create an Add-In](../Topic/How%20to:%20Create%20an%20Add-In.md).  
  
-   References to the Microsoft.VisualStudio.OLE.Interop, Microsoft.VisualStudio.Shell and Microsoft.VisualStudio.SharePoint assemblies.  
  
## See Also  
 [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md)   
 [How to: Create an Add-In](../Topic/How%20to:%20Create%20an%20Add-In.md)   
 [How to: Get a Service](../Topic/How%20to:%20Get%20a%20Service.md)   
 [How to: Get a Service from the DTE Object](../Topic/How%20to:%20Get%20a%20Service%20from%20the%20DTE%20Object.md)   
 [How to: Use Wizards with Project Templates](../Topic/How%20to:%20Use%20Wizards%20with%20Project%20Templates.md)  
  
  