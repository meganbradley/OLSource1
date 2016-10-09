---
title: "How to: Programmatically Apply Styles to Ranges in Workbooks"
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
  - "ranges, styles"
  - "styles, workbook ranges"
  - "workbooks, styles"
ms.assetid: c7e781ed-f366-45bb-aeb6-69c10d19d842
caps.latest.revision: 51
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
# How to: Programmatically Apply Styles to Ranges in Workbooks
  You can apply named styles to regions in workbooks. Excel supplies a number of predefined styles.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 The **Format Cells** dialog box displays all the options you can use to format cells, and each of these options is available from your code. To display this dialog box in Excel, click **Cells** on the **Format** menu.  
  
### To apply a style to a named range in a document-level customization  
  
1.  Create a new style and set its attributes.  
  
     [!code[Trin_VstcoreExcelAutomation#53](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#53](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_1.vb)]  
  
2.  Create a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control, assign text to it, and then apply the new style. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#54](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_2.cs)]
[!code[Trin_VstcoreExcelAutomation#54](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_2.vb)]  
  
### To clear a style from a named range in a document-level customization  
  
1.  Apply the Normal style to the range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code[Trin_VstcoreExcelAutomation#55](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_3.cs)]
[!code[Trin_VstcoreExcelAutomation#55](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_3.vb)]  
  
### To apply a style to a named range in a VSTO Add-in  
  
1.  Create a new style and set its attributes.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#28](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_4.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#28](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_4.vb)]  
  
2.  Create a \<xref:Microsoft.Office.Interop.Excel.Range>, assign text to it, and then apply the new style.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#29](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_5.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#29](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_5.vb)]  
  
### To clear a style from a named range in an VSTO Add-in  
  
1.  Apply the Normal style to the range.  
  
     [!code[Trin_VstcoreExcelAutomation#56](../VS_officedev/codesnippet/CSharp/how-to--programmatically-apply-styles-to-ranges-in-workbooks_6.cs)]
[!code[Trin_VstcoreExcelAutomation#56](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-apply-styles-to-ranges-in-workbooks_6.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  