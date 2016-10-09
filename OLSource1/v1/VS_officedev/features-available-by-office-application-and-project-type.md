---
title: "Features Available by Office Application and Project Type"
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
  - "application-level add-ins [Office development in Visual Studio]"
  - "Office development in Visual Studio, features"
  - "Ribbon [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], features available"
  - "document-level customizations [Office development in Visual Studio]"
  - "Office projects [Office development in Visual Studio], features available"
  - "add-ins [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], features available"
ms.assetid: 3e9aa4d3-affb-4f76-bc67-49fe5f26a6a1
caps.latest.revision: 53
ms.author: "normesta"
manager: "ghogen"
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
# Features Available by Office Application and Project Type
  Visual Studio has several types of project templates that support different business scenarios for Microsoft Office applications, including the following types:  
  
-   Document-level customizations.  
  
-   VSTO Add-ins.  
  
 Not all applications can use every project type. For example, document-level projects are available only for Microsoft Office Word and Microsoft Office Excel. Similarly, some features are available only for certain types of projects or applications. For example, the actions pane is available only in document-level projects, and Ribbon extensions are available only for some applications. For more information about the different project types, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
> [!NOTE]  
>  Office project templates are available only in some editions of [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)]. For more information, see [Configuring a Computer to Develop Office Solutions](../VS_officedev/configuring-a-computer-to-develop-office-solutions.md).  
  
## Project Types Available for Different Microsoft Office Applications  
 The following table shows the applications that you can use with each project type.  
  
|Project types|Microsoft Office application|  
|-------------------|----------------------------------|  
|Document-level customizations|Excel<br /><br /> Word|  
|VSTO Add-ins|Excel<br /><br /> InfoPath (InfoPath 2013 and InfoPath 2010 only)<br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Visio<br /><br /> Word<br /><br /> Excel|  
  
## Features Available in Different Project Types  
 The following table shows which project types provide each feature.  
  
|Feature|Project types that provide the feature|Further reading|  
|-------------|--------------------------------------------|---------------------|  
|Actions pane.|Document-level projects.|[Actions Pane Overview](../VS_officedev/actions-pane-overview.md)|  
|ClickOnce deployment.|VS and document-level projects.|[Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)|  
|Custom task panes.|VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Word|[Custom Task Panes](../VS_officedev/custom-task-panes.md)|  
|Custom XML parts.|Document-level projects.<br /><br /> Application level projects for the following applications:<br /><br /> -   Excel<br />-   PowerPoint<br />-   Word|[Custom XML Parts Overview](../VS_officedev/custom-xml-parts-overview.md)|  
|Data cache.|Document-level projects.|[Cached Data in Document-Level Customizations](../VS_officedev/cached-data-in-document-level-customizations.md)|  
|Expose an object in an VSTO Add-in to other Microsoft Office solutions.|VSTO Add-in projects.|[Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md)|  
|The following host controls:<br /><br /> -   Chart<br />-   ListObject<br />-   NamedRange<br />-   Content controls<br />-   Bookmark|Document-level projects.<br /><br /> VSTO Add-in projects for Word and Excel.|[Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)|  
|The following host controls:<br /><br /> -   XMLMappedRange<br />-   XMLNode<br />-   XMLNodes|Document-level projects.|[Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)|  
|Multi-project deployment.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Deploying Multiple Office Solutions in a Single ClickOnce Installer](assetId:///051223c0-4082-4799-b78b-a4763a9def55)|  
|Outlook form regions.|VSTO Add-in projects for Outlook.|[Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)|  
|Post-deployment actions.|Document-level projects.<br /><br /> VSTO Add-in projects.|[Walkthrough: Copying a Document to the End User Computer after a ClickOnce Installation](assetId:///100090f7-bc63-4152-b3e1-19b48bc27466)|  
|Ribbon customizations.|Document-level projects.<br /><br /> VSTO Add-in projects for the following applications:<br /><br /> -   Excel<br />-   InfoPath (InfoPath 2013 and InfoPath 2010 only)<br />-   Outlook<br />-   PowerPoint<br />-   Project<br />-   Visio<br />-   Word|[Ribbon Overview](../VS_officedev/ribbon-overview.md)|  
|Visual document designer.|Document-level projects.|[Office Projects in the Visual Studio Environment](../VS_officedev/office-projects-in-the-visual-studio-environment.md)|  
  
## See Also  
 [Getting Started &#40;Office Development in Visual Studio&#41;](../VS_officedev/getting-started--office-development-in-visual-studio-.md)   
 [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md)   
 [Actions Pane Overview](../VS_officedev/actions-pane-overview.md)   
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Cached Data in Document-Level Customizations](../VS_officedev/cached-data-in-document-level-customizations.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)  
  
  