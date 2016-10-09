---
title: "Extending the SharePoint Tools in Visual Studio"
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
  - "Visual Studio, extending tools"
  - "extensibility [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, extending tools"
ms.assetid: 084cf4bf-aaba-4277-8032-448f2cb2a124
caps.latest.revision: 39
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
# Extending the SharePoint Tools in Visual Studio
  The SharePoint tools in Visual Studio meet the requirements of many application development scenarios. However, you might discover cases where they do not provide functionality that you or other developers require. In these cases, you can extend the SharePoint tools to create the functionality that you need.  
  
## How to Extend the SharePoint Tools  
 You can extend the SharePoint project system and the **SharePoint Connections** node in the **Server Explorer** window.  
  
### Extending the SharePoint Project System  
 Visual Studio includes a set of project templates and item templates that you can use to create SharePoint solutions. For example, there are templates for event receivers, list definitions, workflows, and Web Parts. However, you can also define your own types of SharePoint project items for creating SharePoint components such as fields or custom actions. You can also create extensions for SharePoint project item types that are already installed in Visual Studio, and you can create extensions for SharePoint projects.  
  
 For more information, see [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md).  
  
### Extending the SharePoint Connections Node in Server Explorer  
 In Visual Studio, you can use the **SharePoint Connections** node in the**Server Explorer** window to view many of the components of one or more local SharePoint sites in a hierarchical tree view. You can also extend the **SharePoint Connections** node in the following ways:  
  
-   By adding your own nodes. This is useful if you want to display components of SharePoint sites that are not displayed by default.  
  
-   By extending existing nodes. For example, you can add a new child node to an existing node, or you can add a shortcut menu item to a node and perform tasks when a developer clicks the menu item.  
  
 For more information, see [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md).  
  
## Development Computer Requirements  
 To create extensions for the SharePoint tools, your development computer must meet the same requirements for creating SharePoint solutions in Visual Studio. For more information, see [Requirements for Developing SharePoint Solutions](../VS_officedev/requirements-for-developing-sharepoint-solutions.md).  
  
 We also recommend that you install the [!INCLUDE[vssdk_current_long](../VS_officedev/includes/vssdk_current_long_md.md)]. The SDK includes project templates and tools that you can use to extend Visual Studio. In particular, the SDK includes a project template you can use to easily create a Visual Studio Extension (VSIX) package. VSIX packages are the preferred way to deploy Visual Studio extensions in Visual Studio. All SharePoint tools extensions must be deployed by using VSIX packages. All of the walkthroughs in this documentation assume that you have the [!INCLUDE[vssdk_current_long](../VS_officedev/includes/vssdk_current_long_md.md)] installed.  
  
 To download the SDK, see [http://go.microsoft.com/fwlink/?LinkId=164562](http://go.microsoft.com/fwlink/?LinkId=164562). For more information about Visual Studio extensions, see [Developing Visual Studio Extensions](../Topic/Developing%20Visual%20Studio%20Extensions.md).  
  
## See Also  
 [Overview of the Programming Model of SharePoint Tools Extensions](../VS_officedev/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)   
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)   
 [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md)   
 [Programming Concepts and Features for SharePoint Tools Extensions](../VS_officedev/programming-concepts-and-features-for-sharepoint-tools-extensions.md)   
 [Reference &#40;SharePoint Tools Extensibility&#41;](../VS_officedev/reference--sharepoint-tools-extensibility-.md)   
 [Debugging Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/debugging-extensions-for-the-sharepoint-tools-in-visual-studio.md)   
 [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md)  
  
  