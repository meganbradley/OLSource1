---
title: "API Reference (SharePoint Tools Extensibility)"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, reference for project and tools extensibility"
ms.assetid: 3a42dacd-0213-4c25-aeba-9b6935ab70db
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
# API Reference (SharePoint Tools Extensibility)
  This section contains API reference documentation for extending the SharePoint tools in Visual Studio.  
  
## In This Section  
 \<xref:Microsoft.VisualStudio.SharePoint>  
 Contains types that you use to extend the SharePoint project system. For example, you can extend the built-in SharePoint projects and project items, or you can create your own project items.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Commands>  
 Contains types that you can use to create custom *SharePoint commands*. A SharePoint command is a method that calls into the SharePoint server object model from a SharePoint tools extension.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Deployment>  
 Contains types that you use to extend the deployment process for SharePoint projects.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Explorer>  
 Contains types that you use to extend SharePoint nodes in **Server Explorer** or to define your own types of nodes.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Explorer.Extensions>  
 Contains types that you can use to get information about built-in **Server Explorer** nodes that represent individual components on a SharePoint site, such as a node that represents a list, field, or content type.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Features>  
 Contains types that you use to access the definition of a feature in a SharePoint project.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Packages>  
 Contains types that you use to access the package definition in a SharePoint project.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Remote.Authentication>  
 Contains types that you use to authenticate and communicate with apps for SharePoint that are deployed to remote SharePoint sites.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Remote.Commands>  
 Contains types that you use to create SharePoint remote commands, which are used with apps for SharePoint that are deployed to remote SharePoint sites.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Tasks>  
 Contains types that Visual Studio uses as build tasks for packaging and debugging SharePoint projects, apps for Office, and apps for SharePoint. This API supports the Office and SharePoint infrastructure and isn't intended to be used directly from your code.  
  
 \<xref:Microsoft.VisualStudio.SharePoint.Validation>  
 Contains types that you use to customize the feature and package validation behavior for a SharePoint project.  
  
## See Also  
 [Reference &#40;SharePoint Tools Extensibility&#41;](../VS_officedev/reference--sharepoint-tools-extensibility-.md)   
 [Overview of the Programming Model of SharePoint Tools Extensions](../VS_officedev/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)   
 [Extending the SharePoint Project System](../VS_officedev/extending-the-sharepoint-project-system.md)   
 [Extending the SharePoint Connections Node in Server Explorer](../VS_officedev/extending-the-sharepoint-connections-node-in-server-explorer.md)   
 [Extending SharePoint Packaging and Deployment](../VS_officedev/extending-sharepoint-packaging-and-deployment.md)   
 [Calling into the SharePoint Object Models](../VS_officedev/calling-into-the-sharepoint-object-models.md)  
  
  