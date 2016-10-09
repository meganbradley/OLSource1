---
title: "How to: Validate Data When a New Row is Added to a ListObject Control"
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
  - "controls [Office development in Visual Studio], validating data"
  - "ListObject control, new row"
  - "ListObject control, validating data"
ms.assetid: 107bce92-e5ef-40be-8c05-cd6861d39d75
caps.latest.revision: 43
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
# How to: Validate Data When a New Row is Added to a ListObject Control
  Users can add new rows to a \<xref:Microsoft.Office.Tools.Excel.ListObject> control that is bound to data. You can validate the user's data before committing the changes to the data source.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Data Validation  
 Whenever a row is added to a \<xref:Microsoft.Office.Tools.Excel.ListObject> that is bound to data, the \<xref:Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataBoundRow> event is raised. You can handle this event to perform your data validation. For example, if your application requires that only employees between the ages of 18 and 65 can be added to the data source, you can verify that the age entered falls within that range before the row is added.  
  
> [!NOTE]  
>  You should always check user input on the server in addition to the client. For more information, see [Secure Client Applications](../Topic/Secure%20Client%20Applications.md).  
  
#### To validate data when a new row is added to data-bound ListObject  
  
1.  Create variables for the ID and \<xref:System.Data.DataTable> at the class level.  
  
     [!code[Trin_VstcoreHostControlsExcel#8](../VS_officedev/codesnippet/CSharp/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#8](../VS_officedev/codesnippet/VisualBasic/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_1.vb)]  
  
2.  Create a new \<xref:System.Data.DataTable> and add sample columns and data in the `Startup` event handler of the `Sheet1` class (in a document-level project) or `ThisAddIn` class (in an VSTO Add-in project).  
  
     [!code[Trin_VstcoreHostControlsExcel#9](../VS_officedev/codesnippet/CSharp/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_2.cs)]
[!code[Trin_VstcoreHostControlsExcel#9](../VS_officedev/codesnippet/VisualBasic/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_2.vb)]  
  
3.  Add code to the `list1_BeforeAddDataBoundRow` event handler to check whether the age entered falls within the acceptable range.  
  
     [!code[Trin_VstcoreHostControlsExcel#10](../VS_officedev/codesnippet/CSharp/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_3.cs)]
[!code[Trin_VstcoreHostControlsExcel#10](../VS_officedev/codesnippet/VisualBasic/how-to--validate-data-when-a-new-row-is-added-to-a-listobject-control_3.vb)]  
  
## Compiling the Code  
 This code example assumes that you have an existing \<xref:Microsoft.Office.Tools.Excel.ListObject> named `list1` on the worksheet in which this code appears.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [ListObject Control](../VS_officedev/listobject-control.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [How to: Map ListObject Columns to Data](../VS_officedev/how-to--map-listobject-columns-to-data.md)  
  
  