---
title: "How to: Resize ListObject Controls"
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
  - "controls [Office development in Visual Studio], resizing"
  - "ListObject control, resizing"
ms.assetid: a4c7dceb-7b55-447e-9b88-c3596a2fc361
caps.latest.revision: 50
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
# How to: Resize ListObject Controls
  You set the size of a \<xref:Microsoft.Office.Tools.Excel.ListObject> control when you add it to a Microsoft Office Excel workbook; however, you might want to resize it at a later time. For example, you might want to change a two-column list to three columns.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You can resize \<xref:Microsoft.Office.Tools.Excel.ListObject> controls at design time or at run time in document-level projects. You can resize \<xref:Microsoft.Office.Tools.Excel.ListObject> controls at run time in an VSTO Add-in project.  
  
 This topic describes the following tasks:  
  
-   [Resizing ListObject controls at design time](#designtime)  
  
-   [Resizing ListObject controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Resizing ListObject controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about \<xref:Microsoft.Office.Tools.Excel.ListObject> controls, see [ListObject Control](../VS_officedev/listobject-control.md).  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Add Columns to a Data-Bound List Object at RunTime?](http://go.microsoft.com/fwlink/?LinkID=130318).  
  
##  <a name="designtime"></a> Resizing a ListObject Control at Design Time  
 To resize a list, you can click and drag one of the sizing handles, or you can redefine its size in the **Resize List** dialog box.  
  
#### To resize a list by using the Resize List dialog box  
  
  
1.  Click anywhere in the  \<xref:Microsoft.Office.Tools.Excel.ListObject> table. The **Table Tools, Design** tab in the ribbon appears.  
  
2.  In the Properties section, click on **Resize Table**.  

    ![VSTO_ResizeTable](../VS_officedev/media/vsto_resizetable.png)
  
3.  Select the new data range for your table.  
  
4.  Click **OK**.  
  
##  <a name="runtimedoclevel"></a> Resizing a ListObject Control at Run Time in a Document-Level Project  
 You can resize a \<xref:Microsoft.Office.Tools.Excel.ListObject> control at run time by using the \<xref:Microsoft.Office.Tools.Excel.ListObject.Resize*> method. You cannot use this method to move the \<xref:Microsoft.Office.Tools.Excel.ListObject> control to a new location on the worksheet. The headers must remain in the same row, and the resized \<xref:Microsoft.Office.Tools.Excel.ListObject> control must overlap the original list object. The resized \<xref:Microsoft.Office.Tools.Excel.ListObject> control must contain a header row, and at least one row of data.  
  
#### To resize a list object programmatically  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.ListObject> control that spans cell **A1** through **B3** on `Sheet1`.  
  
     [!code[Trin_VstcoreHostControlsExcel#6](../VS_officedev/codesnippet/CSharp/how-to--resize-listobject-controls_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#6](../VS_officedev/codesnippet/VisualBasic/how-to--resize-listobject-controls_1.vb)]  
  
2.  Resize the list to include cells **A1** through **C5**.  
  
     [!code[Trin_VstcoreHostControlsExcel#7](../VS_officedev/codesnippet/CSharp/how-to--resize-listobject-controls_2.cs)]
[!code[Trin_VstcoreHostControlsExcel#7](../VS_officedev/codesnippet/VisualBasic/how-to--resize-listobject-controls_2.vb)]  
  
##  <a name="runtimeaddin"></a> Resizing a ListObject at Run Time in an VSTO Add-in project  
 You can resize a \<xref:Microsoft.Office.Tools.Excel.ListObject> control on any open worksheet at run time. For more information about how to add a \<xref:Microsoft.Office.Tools.Excel.ListObject> control to a worksheet by using an VSTO Add-in, see [How to: Add ListObject Controls to Worksheets](../VS_officedev/how-to--add-listobject-controls-to-worksheets.md).  
  
#### To resize a list object programmatically  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.ListObject> control that spans cell **A1** through **B3** on `Sheet1`.  
  
     [!code[Trin_Excel_Dynamic_Controls#12](../VS_officedev/codesnippet/CSharp/how-to--resize-listobject-controls_3.cs)]
[!code[Trin_Excel_Dynamic_Controls#12](../VS_officedev/codesnippet/VisualBasic/how-to--resize-listobject-controls_3.vb)]  
  
2.  Resize the list to include cells **A1** through **C5**.  
  
     [!code[Trin_Excel_Dynamic_Controls#13](../VS_officedev/codesnippet/CSharp/how-to--resize-listobject-controls_4.cs)]
[!code[Trin_Excel_Dynamic_Controls#13](../VS_officedev/codesnippet/VisualBasic/how-to--resize-listobject-controls_4.vb)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [ListObject Control](../VS_officedev/listobject-control.md)   
 [How to: Add ListObject Controls to Worksheets](../VS_officedev/how-to--add-listobject-controls-to-worksheets.md)   
 [How to: Resize Bookmark Controls](../VS_officedev/how-to--resize-bookmark-controls.md)   
 [How to: Resize NamedRange Controls](../VS_officedev/how-to--resize-namedrange-controls.md)  
  
  