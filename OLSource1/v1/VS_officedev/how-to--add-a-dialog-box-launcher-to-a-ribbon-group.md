---
title: "How to: Add a Dialog Box Launcher to a Ribbon Group"
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
  - "dialog box launcher [Office development in Visual Studio]"
  - "Ribbon [Office development in Visual Studio], dialog box launcher"
ms.assetid: 5972664f-4e37-4dc6-90d0-69cedd057e60
caps.latest.revision: 19
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
# How to: Add a Dialog Box Launcher to a Ribbon Group
  You can add a dialog box launcher to any group on a Ribbon. A dialog box launcher is a small icon that appears in a group. Users click this icon to open related dialog boxes or task panes that provide more options that relate to the group.  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
### To add a dialog box launcher to a Ribbon group  
  
1.  Select the Ribbon code file (.vb or .cs file) in **Solution Explorer**.  
  
2.  On the **View** menu, click **Designer**.  
  
3.  In the Ribbon Designer, right-click any group, and then click **Add DialogBoxLauncher**.  
  
     Add code to the \<xref:Microsoft.Office.Tools.Ribbon.RibbonGroup.DialogLauncherClick> event of the group to open a custom or built-in dialog box.  
  
## See Also  
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Accessing the Ribbon at Run Time](../VS_officedev/accessing-the-ribbon-at-run-time.md)   
 [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Ribbon Object Model Overview](../VS_officedev/ribbon-object-model-overview.md)   
 [Ribbon XML](../VS_officedev/ribbon-xml.md)   
 [How to: Export a Ribbon from the Ribbon Designer to Ribbon XML](../VS_officedev/how-to--export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md)   
 [How to: Change the Position of a Tab on the Ribbon](../VS_officedev/how-to--change-the-position-of-a-tab-on-the-ribbon.md)   
 [How to: Customize a Built-in Tab](../VS_officedev/how-to--customize-a-built-in-tab.md)   
 [How to: Add Controls to the Backstage View](../VS_officedev/how-to--add-controls-to-the-backstage-view.md)   
 [Customizing a Ribbon for Outlook](../VS_officedev/customizing-a-ribbon-for-outlook.md)   
 [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md)   
 [How to: Show Add-in User Interface Errors](../VS_officedev/how-to--show-add-in-user-interface-errors.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Updating the Controls on a Ribbon at Run Time](../VS_officedev/walkthrough--updating-the-controls-on-a-ribbon-at-run-time.md)   
 [Walkthrough: Creating a Custom Tab by Using Ribbon XML](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-ribbon-xml.md)  
  
  