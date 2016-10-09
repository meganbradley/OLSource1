---
title: "Using Windows Forms Controls on Excel Worksheets"
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
  - "Windows Forms controls [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], Windows Forms controls"
  - "controls [Office development in Visual Studio], Window Forms controls"
ms.assetid: bbda7461-0d69-4b56-8ba3-418d63ba49db
caps.latest.revision: 17
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
# Using Windows Forms Controls on Excel Worksheets
  You can add Windows Forms controls to your Microsoft Office Excel workbooks in the same manner that you add controls to Windows Forms. For general information about working with controls on documents, see [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md).  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Control Considerations for Excel  
 There are a few considerations that are specific to Excel.  
  
### Matching Control Size to Cell Size  
 You can set the control to be resized automatically when the size of the parent cell is changed. For more information, see [How to: Resize Controls Within Worksheet Cells](../VS_officedev/how-to--resize-controls-within-worksheet-cells.md).  
  
### Adding Components That Are Shared by All Worksheets  
 You can add components that you want to share among all worksheets, such as a \<xref:System.Data.DataSet>, to the Workbook Designer instead of to the worksheets. The component will appear on the component tray.  
  
### Formula for Embedding Controls  
 When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
## See Also  
 [How to: Resize Controls Within Worksheet Cells](../VS_officedev/how-to--resize-controls-within-worksheet-cells.md)   
 [How to: Hide Controls on Worksheets when Printing](../VS_officedev/how-to--hide-controls-on-worksheets-when-printing.md)   
 [Walkthrough: Changing Worksheet Formatting Using CheckBox Controls](../VS_officedev/walkthrough--changing-worksheet-formatting-using-checkbox-controls.md)   
 [Walkthrough: Displaying Text in a Text Box in a Worksheet Using a Button](../VS_officedev/walkthrough--displaying-text-in-a-text-box-in-a-worksheet-using-a-button.md)   
 [Walkthrough: Updating a Chart in a Worksheet Using Radio Buttons](../VS_officedev/walkthrough--updating-a-chart-in-a-worksheet-using-radio-buttons.md)  
  
  