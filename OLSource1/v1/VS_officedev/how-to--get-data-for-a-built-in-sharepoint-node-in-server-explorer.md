---
title: "How to: Get Data for a Built-In SharePoint Node in Server Explorer"
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
  - "SharePoint Connections [SharePoint development in Visual Studio], extending a node"
  - "SharePoint development in Visual Studio, extending SharePoint Connections node in Server Explorer"
ms.assetid: 86d04e0a-c114-427e-9945-da5fa339fda4
caps.latest.revision: 7
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
# How to: Get Data for a Built-In SharePoint Node in Server Explorer
  For each built-in SharePoint node in **Server Explorer**, you can get data for the underlying SharePoint component that the node represents. For more information, see [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md).  
  
## Example  
 The following code example demonstrates how to get data for the underlying SharePoint list that a list node represents in **Server Explorer**. By default, list nodes have a **View in Browser** context menu item that you can click to open the lists in a Web browser. This example extends list nodes by adding a **View in Visual Studio** context menu item that opens the lists directly in Visual Studio. The code accesses the list data for the node to get the URL of the list to open in Visual Studio.  
  
 [!code[SPExtensibility.ProjectSystemExtension.General#10](../VS_officedev/codesnippet/VisualBasic/how-to--get-data-for-a-built-in-sharepoint-node-in-server-explorer_1.vb)]
[!code[SPExtensibility.ProjectSystemExtension.General#10](../VS_officedev/codesnippet/CSharp/how-to--get-data-for-a-built-in-sharepoint-node-in-server-explorer_1.cs)]  
  
 This example uses the SharePoint project service to obtain the \<xref:EnvDTE.DTE> object that is used to open lists in Visual Studio. For more information about the SharePoint project service, see [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md).  
  
 For more information about the basic tasks to create an extension for a SharePoint node, see [How to: Extend a SharePoint Node in Server Explorer](../VS_officedev/how-to--extend-a-sharepoint-node-in-server-explorer.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   EnvDTE  
  
-   Microsoft.VisualStudio.SharePoint  
  
-   Microsoft.VisualStudio.SharePoint.Explorer.Extensions  
  
-   System.ComponentModel.Composition  
  
## Deploying the Extension  
 To deploy the **Server Explorer** extension, create a [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md)   
 [How to: Extend a SharePoint Node in Server Explorer](../VS_officedev/how-to--extend-a-sharepoint-node-in-server-explorer.md)   
 [Using the SharePoint Project Service](../VS_officedev/using-the-sharepoint-project-service.md)   
 [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md)  
  
  