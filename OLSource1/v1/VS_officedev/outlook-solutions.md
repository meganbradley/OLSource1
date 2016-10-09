---
title: "Outlook Solutions"
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
  - "solutions [Office development in Visual Studio], Outlook"
  - "Office projects [Office development in Visual Studio], Outlook"
  - "Office solutions [Office development in Visual Studio], Outlook"
  - "templates [Office development in Visual Studio], Outlook"
  - "projects [Office development in Visual Studio], Outlook"
  - "Outlook [Office development in Visual Studio]"
  - "e-mail [Office development in Visual Studio], Outlook solutions"
ms.assetid: 2ae3cd9c-bf31-4efa-8b18-b6b1c34a8d93
caps.latest.revision: 27
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Outlook Solutions
  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office Outlook. You can use VSTO Add-ins to automate Outlook, extend Outlook features, or customize the Outlook user interface (UI). For more information about VSTO Add-ins, see [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md).  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Creating an Outlook VSTO Add-in Project  
 Create Outlook projects by using the **Outlook Add-in** project template in the **New Project** dialog box. This template includes required assembly references and project files.  
  
 For more information about how to create a VSTO Add-in project, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md).  
  
## Outlook VSTO Add-in Programming Model  
 When you create an Outlook VSTO Add-in project, Visual Studio generates a class, called `ThisAddIn`, which is the foundation of your solution. This class provides a starting point for writing your code, and it also exposes the object model of Outlook to your VSTO Add-in.  
  
 For more information about the `ThisAddIn` class and other features you can use in a VSTO Add-in, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
## Automating Outlook by Using the Outlook Object Model  
 The Outlook object model exposes many types that you can use to automate Outlook. These types enable you to write code to accomplish common tasks:  
  
-   Programmatically create and send e-mail messages.  
  
-   Send new meeting requests.  
  
-   Search for items in Outlook folders.  
  
 For more information, see [Outlook Object Model Overview](../VS_officedev/outlook-object-model-overview.md).  
  
## Customizing the User Interface of an Outlook Application  
  
|Task|For more information|  
|----------|--------------------------|  
|Add custom tabs to the Ribbon of an Outlook Inspector.|[Ribbon Overview](../VS_officedev/ribbon-overview.md)|  
|Add custom groups to a built-in tab in an Outlook Inspector.|[How to: Customize a Built-in Tab](../VS_officedev/how-to--customize-a-built-in-tab.md)|  
|Add a custom task pane that appears in an Outlook Inspector|[Custom Task Panes](../VS_officedev/custom-task-panes.md).|  
|Add a form region that extends or replaces existing Outlook forms.|[Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)|  
  
 For more information about customizing the UI of Outlook and other Microsoft Office applications, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Outlook Object Model Overview](../VS_officedev/outlook-object-model-overview.md)|Provides an overview of the objects that are provided by the Outlook object model.|  
|[Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)|Explains the tools provided by Visual Studio that make it easier for you to design, develop, and debug form regions.|  
|[Walkthrough: Creating Your First VSTO Add-In for Outlook](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-outlook.md)|Shows you how to create a VSTO Add-in for Microsoft Office Outlook.|  
|[Outlook 2010 in Office Development](http://go.microsoft.com/fwlink/?LinkId=199013)|The area of the MSDN Library where you can find articles and reference documentation about developing Outlook solutions (not specific to Office development using Visual Studio).|  
  
  