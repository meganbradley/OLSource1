---
title: "How to: Hide Controls on Worksheets when Printing"
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
  - "printing [Office development in Visual Studio], worksheets"
  - "controls [Office development in Visual Studio], hiding while printing"
  - "printing [Office development in Visual Studio], hiding controls"
  - "worksheets, hiding controls when printing"
ms.assetid: a637fe9a-9de1-4162-8ff6-fe28ccd62389
caps.latest.revision: 28
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
# How to: Hide Controls on Worksheets when Printing
  When you print a Microsoft Office Excel document that contains Windows Forms controls, the controls are visible on the printed worksheet. You can hide the controls when printing a worksheet.  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
> [!NOTE]  
>  If you hide controls that display data, such as a \<xref:Microsoft.Office.Tools.Excel.Controls.TextBox>, the data in the control will not be visible on the printed worksheet.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To hide controls when a worksheet is printed  
  
1.  Create or open an Excel project in Visual Studio and verify that **Sheet1** is visible in the designer. For information about creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  From the **Common Controls** tab of the **Toolbox**, drag a \<xref:Microsoft.Office.Tools.Excel.Controls.Button> control to a cell on `Sheet1`.  
  
3.  In the **Properties** window, set the \<xref:Microsoft.Office.Tools.Excel.Controls.Button.PrintObject*> property to **False**.  
  
## See Also  
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md)   
 [How to: Add Windows Forms Controls to Office Documents](../VS_officedev/how-to--add-windows-forms-controls-to-office-documents.md)   
 [How to: Resize Controls Within Worksheet Cells](../VS_officedev/how-to--resize-controls-within-worksheet-cells.md)  
  
  