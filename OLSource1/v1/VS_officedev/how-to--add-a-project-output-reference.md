---
title: "How to: Add a Project Output Reference"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "project output references [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, project output references"
  - "SharePoint development in Visual Studio, advanced packaging tools"
ms.assetid: 9d6bc25e-bf0d-4483-a691-2ad7a796fa80
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
# How to: Add a Project Output Reference
  To deploy non-SharePoint project assemblies (or .xap files in Silverlight projects) to SharePoint, add them as a project output reference.  
  
 This process creates a solution build dependency between the two projects. Projects associated with project output references are built before the SharePoint project is built and deployed.  
  
### To add a Project Output Reference  
  
1.  Load a solution that contains at least one SharePoint project and one non-SharePoint project.  
  
2.  In **Solution Explorer**, choose an item in the SharePoint project node.  
  
3.  In the **Properties** window, choose the **Project Output References** property, and then choose the ellipsis (![ASP.NET Mobile Designer ellipse](../VS_officedev/media/mwellipsis.gif "mwEllipsis")) button next to it.  
  
4.  In the **Project Output References** dialog box, choose the **Add** button.  
  
5.  In the properties pane, choose the arrow next to the **Deployment Type** property, and then choose an appropriate value for the non-SharePoint item you are referencing, such as **ElementFile**.  
  
6.  Choose the arrow next to **Project Name**, choose the name of the non-SharePoint project item, and then choose the **OK** button.  
  
## See Also  
 [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md)   
 [How to: Mark Controls as Safe Controls](../VS_officedev/how-to--mark-controls-as-safe-controls.md)   
 [Packaging and Deploying SharePoint Solutions](../VS_officedev/packaging-and-deploying-sharepoint-solutions.md)  
  
  