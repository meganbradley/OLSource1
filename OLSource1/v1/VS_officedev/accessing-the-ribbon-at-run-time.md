---
title: "Accessing the Ribbon at Run Time"
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
  - "Globals class, Ribbon"
  - "Ribbon [Office development in Visual Studio], accessing"
  - "RibbonManager class"
ms.assetid: 8a7c7c6d-1a18-4d6b-98ee-e483d41f0cd8
caps.latest.revision: 23
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
# Accessing the Ribbon at Run Time
  You can write code to show, hide, and modify the Ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.  
  
 You can access the Ribbon by using the `Globals` class. For Outlook projects, you can access the Ribbons that appear in a specific Outlook Inspector or Outlook Explorer window.  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
## Accessing the Ribbon by Using the Globals Class  
 You can use the `Globals` class to access the Ribbon in a document-level project or VSTO Add-in project from anywhere in the project.  
  
 For more information about the `Globals` class, see [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md).  
  
 The following example uses the `Globals` class to access a custom Ribbon named `Ribbon1` and set the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#4](../VS_officedev/codesnippet/VisualBasic/accessing-the-ribbon-at-run-time_1.vb)]
[!code[Trin_Outlook_FR_Access#4](../VS_officedev/codesnippet/CSharp/accessing-the-ribbon-at-run-time_1.cs)]  
  
## Accessing a Collection of Ribbons That Appear in a Specific Outlook Inspector Window  
 You can access a collection of Ribbons that appear in Outlook *Inspectors*. An Inspector is a window that opens in Outlook when users perform certain tasks, such as creating e-mail messages. To access the Ribbon of an Inspector window, call the `Ribbons` property of the `Globals` class and pass in an \<xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.  
  
 The following example gets the Ribbon collection of the Inspector that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#5](../VS_officedev/codesnippet/VisualBasic/accessing-the-ribbon-at-run-time_2.vb)]
[!code[Trin_Outlook_FR_Access#5](../VS_officedev/codesnippet/CSharp/accessing-the-ribbon-at-run-time_2.cs)]  
  
## Accessing a Collection of Ribbons That Appear for a Specific Outlook Explorer  
 You can access a collection of Ribbons that appear in an Outlook *Explorer*. An Explorer is the main application user interface (UI) for an instance of Outlook. To access the Ribbon of an Explorer window, call the `Ribbons` property of the `Globals` class and pass in an \<xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.  
  
 The following example gets the Ribbon collection of the Explorer that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#6](../VS_officedev/codesnippet/VisualBasic/accessing-the-ribbon-at-run-time_3.vb)]
[!code[Trin_Outlook_FR_Access#6](../VS_officedev/codesnippet/CSharp/accessing-the-ribbon-at-run-time_3.cs)]  
  
## See Also  
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Ribbon XML](../VS_officedev/ribbon-xml.md)   
 [Ribbon Object Model Overview](../VS_officedev/ribbon-object-model-overview.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Updating the Controls on a Ribbon at Run Time](../VS_officedev/walkthrough--updating-the-controls-on-a-ribbon-at-run-time.md)   
 [Customizing a Ribbon for Outlook](../VS_officedev/customizing-a-ribbon-for-outlook.md)   
 [Accessing a Form Region at Run Time](../VS_officedev/accessing-a-form-region-at-run-time.md)  
  
  