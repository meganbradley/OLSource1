---
title: "How to: Prevent Outlook from Displaying a Form Region"
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
  - "form regions [Office development in Visual Studio], canceling display"
  - "canceling form region display"
ms.assetid: 82a25def-776a-476a-a72d-d0a48a827d3c
caps.latest.revision: 24
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
# How to: Prevent Outlook from Displaying a Form Region
  There might be situations in which you do not want Microsoft Office Outlook to display a form region for a particular item. For example, if a contact item does not contain a business address, you can prevent a form region that shows the location of the business in a map from appearing.  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
### To prevent Outlook from displaying a form region  
  
1.  Open the code file for the form region you want to modify.  
  
2.  Expand the **Form Region Factory** code region.  
  
3.  Add code to the `FormRegionInitializing` event handler that sets the \<xref:System.ComponentModel.CancelEventArgs.Cancel*> property of the \<xref:Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs> class to **true**.  
  
 In this example, if the contact item does not contain an address, the \<xref:System.ComponentModel.CancelEventArgs.Cancel*> property is set to **true**, and the form region does not appear.  
  
## Example  
 [!code[Trin_Outlook_FR_Separate#1](../VS_officedev/codesnippet/CSharp/how-to--prevent-outlook-from-displaying-a-form-region_1.cs)]
[!code[Trin_Outlook_FR_Separate#1](../VS_officedev/codesnippet/VisualBasic/how-to--prevent-outlook-from-displaying-a-form-region_1.vb)]  
  
## See Also  
 [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)   
 [Walkthrough: Designing an Outlook Form Region](../VS_officedev/walkthrough--designing-an-outlook-form-region.md)   
 [How to: Add a Form Region to an Outlook Add-in Project](../VS_officedev/how-to--add-a-form-region-to-an-outlook-add-in-project.md)   
 [Walkthrough: Designing an Outlook Form Region](../VS_officedev/walkthrough--designing-an-outlook-form-region.md)   
 [Walkthrough: Importing a Form Region That Is Designed in Outlook](../VS_officedev/walkthrough--importing-a-form-region-that-is-designed-in-outlook.md)  
  
  