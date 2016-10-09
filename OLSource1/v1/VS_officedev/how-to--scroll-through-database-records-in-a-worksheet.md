---
title: "How to: Scroll Through Database Records in a Worksheet"
ms.custom: na
ms.date: "09/17/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "databases [Office development in Visual Studio], scrolling records"
  - "records [Office development in Visual Studio], scrolling"
  - "data [Office development in Visual Studio], scrolling database records"
  - "worksheets [Office development in Visual Studio], scrolling records"
ms.assetid: aea4c86c-9d6d-47dd-8977-066e21945dab
caps.latest.revision: 33
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
# How to: Scroll Through Database Records in a Worksheet
  The following procedure shows how to use the designer to display a single field from a database table in a Microsoft Office Excel worksheet, with controls that enable the end user to scroll through all the records.  
  
 You can use the designer only in document-level projects. However, you can also add controls and bind them to data programmatically at run time. For more information, see [Walkthrough: Simple Data Binding in VSTO add-in Project](../VS_officedev/walkthrough--simple-data-binding-in-vsto-add-in-project.md).  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
### To scroll through database records in a worksheet  
  
1.  Open an Excel application project in Visual Studio.  
  
2.  Open the **Data Sources** window and create a data source from the database. For more information, see [How to: Connect to Data in a Database](../Topic/How%20to:%20Connect%20to%20Data%20in%20a%20Database.md).  
  
3.  Expand the table that contains the data that you want to show, and select the specific column.  
  
4.  Open the list of controls and select **NamedRange**.  
  
5.  Drag the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control onto the cell where you want the data to appear.  
  
6.  From the **Windows Forms** tab of the **Toolbox**, add a \<xref:System.Windows.Forms.BindingNavigator> control to your worksheet, and set up the controls you want to use. For more information, see [BindingNavigator Control Overview &#40;Windows Forms&#41;](../Topic/BindingNavigator%20Control%20Overview%20(Windows%20Forms).md).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)  
  
  