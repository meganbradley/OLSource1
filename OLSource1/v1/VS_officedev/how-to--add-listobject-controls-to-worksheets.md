---
title: "How to: Add ListObject Controls to Worksheets"
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
  - "ListObject control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
ms.assetid: 40788ecb-937f-4d2a-90ba-9c938e495b74
caps.latest.revision: 44
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
# How to: Add ListObject Controls to Worksheets
  You can add \<xref:Microsoft.Office.Tools.Excel.ListObject> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You can also add \<xref:Microsoft.Office.Tools.Excel.ListObject> controls at run time in VSTO Add-in projects.  
  
 This topic describes the following tasks:  
  
-   [Adding ListObject controls at design time](#designtime)  
  
-   [Adding ListObject controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding ListObject controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about \<xref:Microsoft.Office.Tools.Excel.ListObject> controls, see [ListObject Control](../VS_officedev/listobject-control.md).  
  
##  <a name="designtime"></a> Adding ListObject Controls at Design Time  
 There are several ways to add \<xref:Microsoft.Office.Tools.Excel.ListObject> controls to a worksheet in a document-level project at design time: From within Excel, from the Visual Studio **Toolbox**, and from the **Data Sources** window.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
#### To use the Ribbon in Excel  
  
1.  On the **Insert** tab, in the **Tables** group, click **Table**.  
  
2.  Select the cell or cells you want to include in the list and click **OK**.  
  
#### To use the Toolbox  
  
1.  From the **Excel Controls** tab of the **Toolbox**, drag a \<xref:Microsoft.Office.Tools.Excel.ListObject> to the worksheet.  
  
     The **Add ListObject Control** dialog box appears.  
  
2.  Select the cell or cells you want to include in the list and click **OK**.  
  
     If you do not want to keep the default name, you can change the name in the **Properties** window.  
  
#### To use the Data Sources window  
  
1.  Open the **Data Sources** window and create a data source for your project. For more information, see [How to: Connect to Data in a Database](../Topic/How%20to:%20Connect%20to%20Data%20in%20a%20Database.md).  
  
2.  Drag a table from the **Data Sources** window to your worksheet.  
  
     A data-bound \<xref:Microsoft.Office.Tools.Excel.ListObject> control is added to the worksheet. For more information, see [Data Binding and Windows Forms](../Topic/Data%20Binding%20and%20Windows%20Forms.md).  
  
##  <a name="runtimedoclevel"></a> Adding ListObject Controls at Run Time in a Document-Level Project  
 You can add the \<xref:Microsoft.Office.Tools.Excel.ListObject> control dynamically at run time. This enables you to create the host controls in response to events. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a ListObject control to a worksheet programmatically  
  
1.  In the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add a \<xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.  
  
     [!code[Trin_VstcoreHostControlsExcel#2](../VS_officedev/codesnippet/CSharp/how-to--add-listobject-controls-to-worksheets_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#2](../VS_officedev/codesnippet/VisualBasic/how-to--add-listobject-controls-to-worksheets_1.vb)]  
  
##  <a name="runtimeaddin"></a> Adding ListObject Controls at Run Time in an VSTO Add-in project  
 You can add a \<xref:Microsoft.Office.Tools.Excel.ListObject> control programmatically to any open worksheet in an VSTO Add-in project. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is saved and then closed. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a ListObject control to a worksheet programmatically  
  
1.  The following code generates a worksheet host item that is based on the open worksheet, and then adds a \<xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.  
  
     [!code[Trin_Excel_Dynamic_Controls#8](../VS_officedev/codesnippet/CSharp/how-to--add-listobject-controls-to-worksheets_2.cs)]
[!code[Trin_Excel_Dynamic_Controls#8](../VS_officedev/codesnippet/VisualBasic/how-to--add-listobject-controls-to-worksheets_2.vb)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [ListObject Control](../VS_officedev/listobject-control.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [How to: Resize ListObject Controls](../VS_officedev/how-to--resize-listobject-controls.md)   
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  