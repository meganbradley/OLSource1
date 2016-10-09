---
title: "How to: Add NamedRange Controls to Worksheets"
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
  - "ranges, adding to worksheets"
  - "NamedRange control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
ms.assetid: da7ec48f-92cb-4fa3-b3e2-447c238d17a8
caps.latest.revision: 54
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
# How to: Add NamedRange Controls to Worksheets
  You can add \<xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You can also add \<xref:Microsoft.Office.Tools.Excel.NamedRange> controls at run time in VSTO Add-in projects.  
  
 This topic describes the following tasks:  
  
-   [Adding NamedRange controls at design time](#designtime)  
  
-   [Adding NamedRange controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding NamedRange controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about \<xref:Microsoft.Office.Tools.Excel.NamedRange> controls, see [NamedRange Control](../VS_officedev/namedrange-control.md).  
  
##  <a name="designtime"></a> Adding NamedRange Controls at Design Time  
 There are several ways to add \<xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a worksheet in a document-level project at design time: from within Excel, from the Visual Studio **Toolbox**, and from the **Data Sources** window.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
#### To add a NamedRange control to a worksheet using the Name Box in Excel  
  
1.  Select the cell or cells you want to include in the named range.  
  
2.  In the **Name Box**, type a name for the range and press ENTER.  
  
     The **Name Box** is located beside the formula bar, just above column **A** of the worksheet.  
  
#### To add a NamedRange control to a worksheet using the Toolbox  
  
1.  Open the **Toolbox** and click the **Excel Controls** tab.  
  
2.  Click \<xref:Microsoft.Office.Tools.Excel.NamedRange> and drag it to a worksheet.  
  
     The **Add Named Range** dialog box appears.  
  
3.  Select the cell or cells you want to include in the named range.  
  
4.  Click **OK**.  
  
     If you do not want the default name that is given to the control, you can change the name in the **Properties** window.  
  
#### To add a NamedRange control to a worksheet using the Data Sources window  
  
1.  Open the **Data Sources** window and create a data source for your project. For more information, see [How to: Connect to Data in a Database](../Topic/How%20to:%20Connect%20to%20Data%20in%20a%20Database.md).  
  
2.  Drag a single field from the **Data Sources** window to your worksheet.  
  
     A data-bound \<xref:Microsoft.Office.Tools.Excel.NamedRange> control is added to the worksheet. For more information, see [Data Binding and Windows Forms](../Topic/Data%20Binding%20and%20Windows%20Forms.md).  
  
##  <a name="runtimedoclevel"></a> Adding NamedRange Controls at Run Time in a Document-Level Project  
 You can add a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control programmatically to your worksheet at run time. This enables you to create the host controls in response to events. Dynamically created named ranges are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a NamedRange control to a worksheet programmatically  
  
1.  In the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **A1** and set its \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property to `Hello world!`  
  
     [!code[Trin_VstcoreHostControlsExcel#3](../VS_officedev/codesnippet/CSharp/how-to--add-namedrange-controls-to-worksheets_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#3](../VS_officedev/codesnippet/VisualBasic/how-to--add-namedrange-controls-to-worksheets_1.vb)]  
  
##  <a name="runtimeaddin"></a> Adding NamedRange Controls at Run Time in an VSTO Add-in project  
 You can add a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control programmatically to any open worksheet in an VSTO Add-in project. Dynamically created named ranges are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a NamedRange control to a worksheet programmatically  
  
1.  The following code generates a worksheet host item that is based on the open worksheet, and then adds a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **A1** and sets its \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property to `Hello world`.  
  
     [!code[Trin_Excel_Dynamic_Controls#7](../VS_officedev/codesnippet/CSharp/how-to--add-namedrange-controls-to-worksheets_2.cs)]
[!code[Trin_Excel_Dynamic_Controls#7](../VS_officedev/codesnippet/VisualBasic/how-to--add-namedrange-controls-to-worksheets_2.vb)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [How to: Resize NamedRange Controls](../VS_officedev/how-to--resize-namedrange-controls.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  