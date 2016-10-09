---
title: "Getting Started Programming VSTO Add-ins"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectItem.Outlook"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "application-level add-ins [Office development in Visual Studio], getting started"
  - "add-ins [Office development in Visual Studio], getting started"
ms.assetid: 9ac1e6ea-9511-4633-80f9-dc7641f22b63
caps.latest.revision: 60
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
# Getting Started Programming VSTO Add-ins
  You can use VSTO Add-ins to automate Microsoft Office applications, extend features of the application, and customize the user interface (UI) of the application. For information about how VSTO Add-ins compare to other types of Office solutions you can create by using Visual Studio, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
 [!INCLUDE[appliesto_allapp](../VS_officedev/includes/appliesto_allapp_md.md)]  
  
## Creating VSTO Add-in Projects  
 Create VSTO Add-in projects by using one of the VSTO Add-in project templates in the **New Project** dialog box. These templates include required assembly references and project files. Visual Studio provides VSTO Add-in project templates for most applications in Office.  
  
 For more information about how to create a VSTO Add-in project, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md).  
  
## Developing VSTO Add-in Projects  
 When you create an VSTO Add-in project, Visual Studio automatically creates a ThisAddIn.vb (in [!INCLUDE[vbprvb](../VS_officedev/includes/vbprvb_md.md)]) or ThisAddIn.cs (in C#) code file. This file contains the `ThisAddIn` class, which provides the foundation for your VSTO Add-in. You can use members of this class to run code when the VSTO Add-in is loaded or unloaded, to access the object model of the host application, and to extend features of the application. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
## Automating Applications by Using the Object Models  
 The object models of Microsoft Office applications expose many types that you can program against in a VSTO Add-in. You can use these types to automate the application. For example, you can programmatically create and send an e-mail message in Outlook, or you can open a document and add content in Word. For more information about how to access the object model of the host application in code, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
 For more information about the object models of specific Microsoft Office applications, see the following topics:  
  
-   [Excel Object Model Overview](../VS_officedev/excel-object-model-overview.md)  
  
-   [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)  
  
-   [Outlook Object Model Overview](../VS_officedev/outlook-object-model-overview.md)  
  
-   [InfoPath Solutions](../VS_officedev/infopath-solutions.md)  
  
-   [PowerPoint Solutions](../VS_officedev/powerpoint-solutions.md)  
  
-   [Project Solutions](../VS_officedev/project-solutions.md)  
  
-   [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)  
  
## Customizing the User Interface of Applications  
 There are several different ways to customize the UI of the host application by using an VSTO Add-in:  
  
-   For Excel and Word, you can add managed controls to documents. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
-   You can customize the Ribbon if the application supports it. For more information, see [Ribbon Overview](../VS_officedev/ribbon-overview.md).  
  
-   You can create a custom task pane if the application supports it. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md).  
  
-   For Outlook, you can create a custom form region. For more information, see [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md).  
  
-   For all Microsoft Office applications, you can display Windows Forms in your VSTO Add-in.  
  
 For more information about how to customize the UI of Microsoft Office applications, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
## Next Steps  
 To learn how to create VSTO Add-ins, see the following walkthroughs:  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Excel](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-excel.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-In for Outlook](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-outlook.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for PowerPoint](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-powerpoint.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Project](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-project.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Word](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-word.md)  
  
 These walkthroughs introduce you to the Office development tools in Visual Studio and the programming model for VSTO Add-ins.  
  
 For a list of topics that walk you through some of the common tasks in Office projects, see [Common Tasks in Office Programming](../VS_officedev/common-tasks-in-office-programming.md).  
  
## See Also  
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Getting Started &#40;Office Development in Visual Studio&#41;](../VS_officedev/getting-started--office-development-in-visual-studio-.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)  
  
  