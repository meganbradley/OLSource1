---
title: "Developing Office Solutions"
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
  - "Office development in Visual Studio, about developing solutions"
  - "solutions [Office development in Visual Studio], developing"
  - "Office solutions [Office development in Visual Studio], developing"
ms.assetid: 7361cfe0-dee4-48d7-a066-232f87f093ca
caps.latest.revision: 34
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
# Developing Office Solutions
  After you design a project by using the Office developer tools in Visual Studio and set up the project files, you can begin to concentrate on implementing the code and custom user interface (UI).  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Office Solutions Programming Model  
 The Office object model exposes a variety of objects that you can program against. Whenever you program Office solutions by using managed code, you write code that uses types in the Office primary interop assemblies. In solutions you create by using the Office project templates in Visual Studio, you also write code directly against generated classes in your project. For more information, see [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md).  
  
## Programming Different Types of Office Solutions  
 The type of solution that you are creating determines which features you can use in your project. For example, you can add Windows Forms controls and extended Office controls (named *host controls*) to document-level customizations by dragging items from the **Toolbox** in Visual Studio at design time. However, if you are developing a VSTO Add-in, you can only add these sorts of controls to documents at run time, by writing code.  
  
 For more information about features that are specific to different types of solutions, see the following topics:  
  
-   [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
-   [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md).  
  
-   [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
 For background information to help you plan your Office solutions and procedures to help you create projects, see [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)|Describes different aspects of writing code in Office solutions.|  
|[Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)|Provides an overview of the programming model of VSTO Add-ins and related programming tasks.|  
|[Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)|Provides an overview of the programming model of document-level customizations and related programming tasks.|  
|[Office UI Customization](../VS_officedev/office-ui-customization.md)|Describes the different ways that you can customize the UI of Office applications by using VSTO Add-ins and document-level customizations.|  
|[Data in Office Solutions](../VS_officedev/data-in-office-solutions.md)|Describes the different ways that you can work with data in Office solutions, such as binding data to controls and caching data in document-level customizations.|  
|[Troubleshooting Office Solutions](../VS_officedev/troubleshooting-office-solutions.md)|Provides tips for solving common problems that you might encounter when creating Office solutions.|  
|[Threading Support in Office](../VS_officedev/threading-support-in-office.md)|Provides an overview of working with multiple threads in Office solutions.|  
|[Accessibility in Office Projects](../VS_officedev/accessibility-in-office-projects.md)|Describes the accessibility features that are available in Office solutions.|  
  
## See Also  
 [How to: Create and Modify Custom Document Properties](../VS_officedev/how-to--create-and-modify-custom-document-properties.md)   
 [How to: Read from and Write to Document Properties](../VS_officedev/how-to--read-from-and-write-to-document-properties.md)   
 [How to: Target the Office Multilingual User Interface](../VS_officedev/how-to--target-the-office-multilingual-user-interface.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Excel](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-excel.md)   
 [Walkthrough: Creating Your First Document-Level Customization for Excel](../VS_officedev/walkthrough--creating-your-first-document-level-customization-for-excel.md)   
 [Walkthrough: Creating Your First VSTO Add-In for Outlook](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-outlook.md)   
 [Walkthrough: Creating Your First VSTO Add-in for PowerPoint](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-powerpoint.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Project](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-project.md)   
 [Walkthrough: Creating Your First VSTO Add-in for Word](../VS_officedev/walkthrough--creating-your-first-vsto-add-in-for-word.md)   
 [Walkthrough: Creating Your First Document-Level Customization For Word](../VS_officedev/walkthrough--creating-your-first-document-level-customization-for-word.md)  
  
  