---
title: "Accessing a Form Region at Run Time"
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
  - "Inspectors [Office development in Visual Studio]"
  - "Explorers [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], accessing at run time"
ms.assetid: 58eaa9e0-acba-4a13-a6dd-b7e37a38156e
caps.latest.revision: 23
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
# Accessing a Form Region at Run Time
  
  
|Applies to|  
|----------------|  
|The information in this topic applies only to the following project types and versions of Microsoft Office. For more information, see [Features Available by Office Application and Project Type](../VS_officedev/features-available-by-office-application-and-project-type.md).<br /><br /> **Project type**<br /><br /> -   VSTO Add-in projects<br /><br /> **Microsoft Office version**<br /><br /> -   [!INCLUDE[Outlook_14_short](../VS_officedev/includes/outlook_14_short_md.md)]|  
  
 Use the `Globals` class to access form regions from anywhere within your Outlook project. For more information about the `Globals` class, see [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md).  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
## Accessing Form Regions That Appear in a Specific Outlook Inspector Window  
 To access all form regions that appear in a specific Outlook Inspector, call the `FormRegions` property of the `Globals` class and pass in an \<xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.  
  
 The following example gets the collection of form regions that appear in the Inspector that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#2](../VS_officedev/codesnippet/VisualBasic/accessing-a-form-region-at-run-time_1.vb)]
[!code[Trin_Outlook_FR_Access#2](../VS_officedev/codesnippet/CSharp/accessing-a-form-region-at-run-time_1.cs)]  
  
## Accessing Form Regions That Appear in a Specific Outlook Explorer Window  
 To access all form regions that appear in a specific Outlook Explorer, call the `FormRegions` property of the `Globals` class and pass in an \<xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.  
  
 The following example gets the collection of form regions that appear in the Explorer that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#3](../VS_officedev/codesnippet/VisualBasic/accessing-a-form-region-at-run-time_2.vb)]
[!code[Trin_Outlook_FR_Access#3](../VS_officedev/codesnippet/CSharp/accessing-a-form-region-at-run-time_2.cs)]  
  
## Accessing All Form Regions  
 To access all form regions that appear in all Explorers and all Inspectors, call the `FormRegions` property of the `Globals` class.  
  
 The following example gets the collection of form regions that appear in all Explorers and all Inspectors. This example then accesses a form region named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code[Trin_Outlook_FR_Access#1](../VS_officedev/codesnippet/VisualBasic/accessing-a-form-region-at-run-time_3.vb)]
[!code[Trin_Outlook_FR_Access#1](../VS_officedev/codesnippet/CSharp/accessing-a-form-region-at-run-time_3.cs)]  
  
## Accessing Controls on a Form Region  
 To access controls on a form region by using the `Globals` class, you must make the controls accessible to code outside of the form region code file.  
  
### Form Regions Designed in the Form Region Designer  
 For C#, change the modifier of each control that you want to access. To do this, select each control in the form region designer and change the **Modifiers** property to **Internal** or **public** in the **Properties** window. For example, if you change the **Modifier** property of `textBox1` to **Internal**, you can access `textBox1` by typing `Globals.FormRegions.FormRegion1.textBox1`.  
  
 For Visual Basic, you do not need to change the modifier.  
  
### Imported Form Regions  
 When you import a form region that was designed in Outlook, the access modifier of each control on the form region becomes private. Because you cannot use the form region designer to modify an imported form region, there is no way to change the modifier of a control in the **Properties** window.  
  
 To enable access to a control from outside the form region code file, create a property in the form region code file to return that control.  
  
 For more information about how to create properties in C#, see [How to: Declare and Use Read Write Properties &#40;C&#35; Programming Guide&#41;](../Topic/How%20to:%20Declare%20and%20Use%20Read%20Write%20Properties%20(C%23%20Programming%20Guide).md).  
  
 For more information about how to create properties in Visual Basic, see [NOT IN BUILD: How to: Add Fields and Properties to a Class](assetId:///ae53f61b-3abc-413e-8931-703c5f5e8fc2).  
  
## See Also  
 [Guidelines for Creating Outlook Form Regions](../VS_officedev/guidelines-for-creating-outlook-form-regions.md)   
 [Walkthrough: Designing an Outlook Form Region](../VS_officedev/walkthrough--designing-an-outlook-form-region.md)   
 [How to: Add a Form Region to an Outlook Add-in Project](../VS_officedev/how-to--add-a-form-region-to-an-outlook-add-in-project.md)   
 [Custom Actions in Outlook Form Regions](../VS_officedev/custom-actions-in-outlook-form-regions.md)   
 [Associating a Form Region with an Outlook Message Class](../VS_officedev/associating-a-form-region-with-an-outlook-message-class.md)   
 [Walkthrough: Importing a Form Region That Is Designed in Outlook](../VS_officedev/walkthrough--importing-a-form-region-that-is-designed-in-outlook.md)   
 [How to: Prevent Outlook from Displaying a Form Region](../VS_officedev/how-to--prevent-outlook-from-displaying-a-form-region.md)   
 [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)   
 [Accessing the Ribbon at Run Time](../VS_officedev/accessing-the-ribbon-at-run-time.md)  
  
  