---
title: "How to: Add a Custom SharePoint Node to Server Explorer"
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
  - "SharePoint development in Visual Studio, extending SharePoint Connections node in Server Explorer"
  - "SharePoint Connections [SharePoint development in Visual Studio], creating a new node type"
ms.assetid: b992a192-f926-45e6-9416-85ddfe1061d0
caps.latest.revision: 36
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
# How to: Add a Custom SharePoint Node to Server Explorer
  You can add custom nodes under the **SharePoint Connections** node in **Server Explorer**. This is useful when you want to display additional SharePoint components that are not displayed in **Server Explorer** by default. For more information, see [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md).  
  
 To add a custom node, first create a class that defines the new node. Then create an extension that adds the node as a child of an existing node.  
  
### To define the new node  
  
1.  Create a class library project.  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint  
  
    -   Microsoft.VisualStudio.SharePoint.Explorer.Extensions  
  
    -   System.ComponentModel.Composition  
  
    -   System.Drawing  
  
3.  Create a class that implements the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> interface.  
  
4.  Add the following attributes to the class:  
  
    -   \<xref:System.ComponentModel.Composition.ExportAttribute>. This attribute enables Visual Studio to discover and load your \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> implementation. Pass the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> type to the attribute constructor.  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeTypeAttribute>. In a node definition, this attribute specifies the string identifier for the new node. We recommend that you use the format *company name*.*node name* to make sure that all nodes have a unique identifier.  
  
5.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider.InitializeType*> method, use members of the *typeDefinition* parameter to configure the behavior of the new node. This parameter is an \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeDefinition> object that provides access to the events defined in the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents> interface.  
  
     The following code example demonstrates how to define a new node. This example assumes that your project contains an icon named CustomChildNodeIcon as an embedded resource.  
  
     [!code[SPExtensibility.ProjectSystemExtension.General#6](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-custom-sharepoint-node-to-server-explorer_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#6](../VS_officedev/codesnippet/CSharp/how-to--add-a-custom-sharepoint-node-to-server-explorer_1.cs)]  
  
### To add the new node as a child of an existing node  
  
1.  In the same project as your node definition, create a class that implements the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> interface.  
  
2.  Add the \<xref:System.ComponentModel.Composition.ExportAttribute> attribute to the class. This attribute enables Visual Studio to discover and load your \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> implementation. Pass the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> type to the attribute constructor.  
  
3.  Add the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeTypeAttribute> attribute to the class. In a node extension, this attribute specifies the string identifier for the type of node that you want to extend.  
  
     To specify built-in node types provided by Visual Studio, pass one of the following enumeration values to the attribute constructor:  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeTypes>: Use these values to specify site connection nodes (the nodes that display site URLs), site nodes, or all other parent nodes in **Server Explorer**.  
  
    -   \<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions.ExtensionNodeTypes>: Use these values to specify one of the built-in nodes that represent an individual component on a SharePoint site, such as a node that represents a list, field, or content type.  
  
4.  In your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension.Initialize*> method, handle the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents.NodeChildrenRequested> event of the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeType> parameter.  
  
5.  In the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeEvents.NodeChildrenRequested> event handler, add the new node to the child nodes collection of the \<xref:Microsoft.VisualStudio.SharePoint.Explorer.ExplorerNodeEventArgs.Node*> object that is exposed by the event arguments parameter.  
  
     The following code example demonstrates how to add the new node as a child of the SharePoint site node in **Server Explorer**.  
  
     [!code[SPExtensibility.ProjectSystemExtension.General#7](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-custom-sharepoint-node-to-server-explorer_2.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#7](../VS_officedev/codesnippet/CSharp/how-to--add-a-custom-sharepoint-node-to-server-explorer_2.cs)]  
  
## Complete Example  
 The following code example provides the complete code to define a simple node and add it as a child of the SharePoint site node in **Server Explorer**.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#5](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-custom-sharepoint-node-to-server-explorer_3.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#5](../VS_officedev/codesnippet/CSharp/how-to--add-a-custom-sharepoint-node-to-server-explorer_3.cs)]  
  
## Compiling the Code  
 This example assumes that your project contains an icon named CustomChildNodeIcon as an embedded resource. This example also requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   System.ComponentModel.Composition  
  
-   System.Drawing  
  
## Deploying the Extension  
 To deploy the **Server Explorer** extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md)   
 [How to: Extend a SharePoint Node in Server Explorer](../VS_officedev/how-to--extend-a-sharepoint-node-in-server-explorer.md)   
 [Walkthrough: Extending Server Explorer to Display Web Parts](../VS_officedev/walkthrough--extending-server-explorer-to-display-web-parts.md)  
  
  