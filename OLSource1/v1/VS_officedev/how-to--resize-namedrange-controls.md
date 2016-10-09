---
title: "How to: Resize NamedRange Controls"
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
  - "NamedRange control, resizing"
  - "ranges, resizing in Excel"
ms.assetid: 7d6f0b2f-be46-49b7-9f38-b4c8849683f7
caps.latest.revision: 48
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
# How to: Resize NamedRange Controls
  You can set the size of a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control when you add it to a Microsoft Office Excel document; however, you might want to resize it at a later time.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You can resize a named range at design time or at run time in document-level projects. You can also resize named ranges at run time in application-level VSTO Add-ins.  
  
 This topic describes the following tasks:  
  
-   [Resizing NamedRange controls at design time](#designtime)  
  
-   [Resizing NamedRange controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Resizing NamedRange controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
##  <a name="designtime"></a> Resizing NamedRange Controls at Design Time  
 You can resize a named range by redefining its size in the **Define Name** dialog box.  
  
#### To resize a named range by using the Define Name dialog box  
  
1.  Right-click a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control.  
  
2.  Click **Manage Named Ranges** on the shortcut menu.  
  
     The **Define Name** dialog box appears.  
  
3.  Select the named range you want to resize.  
  
4.  Clear the **Refers to** box.  
  
5.  Select the cells you want to use to define the size of the named range.  
  
6.  Click **OK**.  
  
##  <a name="runtimedoclevel"></a> Resizing NamedRange Controls at Run Time in a Document-Level Project  
 You can resize a named range programmatically by using the \<xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo*> property.  
  
> [!NOTE]  
>  In the **Properties** window, the \<xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo*> property is marked as read-only.  
  
#### To resize a named range programmatically  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.  
  
     [!code[Trin_VstcoreHostControlsExcel#4](../VS_officedev/codesnippet/CSharp/how-to--resize-namedrange-controls_1.cs)]
[!code[Trin_VstcoreHostControlsExcel#4](../VS_officedev/codesnippet/VisualBasic/how-to--resize-namedrange-controls_1.vb)]  
  
2.  Resize the named range to include cell **B1**.  
  
     [!code[Trin_VstcoreHostControlsExcel#5](../VS_officedev/codesnippet/CSharp/how-to--resize-namedrange-controls_2.cs)]
[!code[Trin_VstcoreHostControlsExcel#5](../VS_officedev/codesnippet/VisualBasic/how-to--resize-namedrange-controls_2.vb)]  
  
##  <a name="runtimeaddin"></a> Resizing NamedRange Controls at Run Time in an VSTO Add-in project  
 You can resize a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control on any open worksheet at run time. For more information about how to add a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet by using an VSTO Add-in, see [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md).  
  
#### To resize a named range programmatically  
  
1.  Create a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.  
  
     [!code[Trin_Excel_Dynamic_Controls#10](../VS_officedev/codesnippet/CSharp/how-to--resize-namedrange-controls_3.cs)]
[!code[Trin_Excel_Dynamic_Controls#10](../VS_officedev/codesnippet/VisualBasic/how-to--resize-namedrange-controls_3.vb)]  
  
2.  Resize the named range to include cell **B1**.  
  
     [!code[Trin_Excel_Dynamic_Controls#11](../VS_officedev/codesnippet/CSharp/how-to--resize-namedrange-controls_4.cs)]
[!code[Trin_Excel_Dynamic_Controls#11](../VS_officedev/codesnippet/VisualBasic/how-to--resize-namedrange-controls_4.vb)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [NamedRange Control](../VS_officedev/namedrange-control.md)   
 [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md)   
 [How to: Resize Bookmark Controls](../VS_officedev/how-to--resize-bookmark-controls.md)   
 [How to: Resize ListObject Controls](../VS_officedev/how-to--resize-listobject-controls.md)  
  
  