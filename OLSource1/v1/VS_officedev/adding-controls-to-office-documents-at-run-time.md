---
title: "Adding Controls to Office Documents at Run Time"
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
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "host controls [Office development in Visual Studio], adding"
  - "Windows Forms controls [Office development in Visual Studio], adding"
  - "Office documents [Office development in Visual Studio, host controls"
  - "user controls [Office development in Visual Studio], adding at run time"
  - "documents [Office development in Visual Studio], Windows Forms controls"
  - "document-level customizations [Office development in Visual Studio], host controls"
  - "documents [Office development in Visual Studio], host controls"
  - "document-level customizations [Office development in Visual Studio], Windows Forms controls"
  - "controls [Office development in Visual Studio], adding at run time"
  - "helper methods [Office development in Visual Studio]"
ms.assetid: 4f43b3eb-f0ec-44e2-9885-6ede327c6913
caps.latest.revision: 102
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
# Adding Controls to Office Documents at Run Time
  You can add controls to a Microsoft Office Word document and Microsoft Office Excel workbook at run time. You can also remove them at run time. Controls that you add or remove at run time are called *dynamic controls*.  
  
 [!INCLUDE[appliesto_controls](../VS_officedev/includes/appliesto_controls_md.md)]  
  
 This topic describes the following:  
  
-   [Managing controls at run time by using the control collections](#ControlsCollection).  
  
-   [Adding host controls to documents](#HostControls).  
  
-   [Adding Windows Forms controls to documents](#WindowsForms).  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Add Controls to a Document Surface at Runtime?](http://go.microsoft.com/fwlink/?LinkId=132782).  
  
##  <a name="ControlsCollection"></a> Managing Controls at Run Time by Using the Control Collections  
 To add, get, or remove controls at run time, use helper methods of \<xref:Microsoft.Office.Tools.Excel.ControlCollection> and \<xref:Microsoft.Office.Tools.Word.ControlCollection> objects.  
  
 The way that you access these objects depends on the type of project you are developing:  
  
-   In a document-level project for Excel, use the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Controls*> property of the `Sheet1`, `Sheet2`, and `Sheet3` classes. For more information about these classes, see [Worksheet Host Item](../VS_officedev/worksheet-host-item.md).  
  
-   In a document-level project for Word, use the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of the `ThisDocument` class. For more information about this class, see [Document Host Item](../VS_officedev/document-host-item.md).  
  
-   In an VSTO Add-in project for Excel or Word, use the Controls property of a \<xref:Microsoft.Office.Tools.Excel.Worksheet> or \<xref:Microsoft.Office.Tools.Word.Document> that you generate at run time. For more information about generating these objects at run time, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### Adding Controls  
 The \<xref:Microsoft.Office.Tools.Excel.ControlCollection> and \<xref:Microsoft.Office.Tools.Word.ControlCollection> types include helper methods that you can use to add host controls and common Windows Forms controls to documents and worksheets. Each method name has the format `Add`*control class*, where *control class* is the class name of the control that you want to add. For example, to add a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control to your document, use the \<xref:Microsoft.Office.Tools.Excel.ControlCollection.AddNamedRange*> method.  
  
 The following code example adds a \<xref:Microsoft.Office.Tools.Excel.NamedRange> to `Sheet1` in a document-level project for Excel.  
  
 [!code[Trin_ExcelWorkbookDynamicControls#3](../VS_officedev/codesnippet/VisualBasic/adding-controls-to-office-documents-at-run-time_1.vb)]
[!code[Trin_ExcelWorkbookDynamicControls#3](../VS_officedev/codesnippet/CSharp/adding-controls-to-office-documents-at-run-time_1.cs)]  
  
### Accessing and Deleting Controls  
 You can use the Controls property of a \<xref:Microsoft.Office.Tools.Excel.Worksheet> or \<xref:Microsoft.Office.Tools.Word.Document> to iterate through all the controls in your document, including the controls you added at design time. Controls that you add at design time are also called *static controls*.  
  
 You can remove dynamic controls by calling the Delete method of the control, or by calling the Remove method of each Controls collection. The following code example uses the \<xref:Microsoft.Office.Tools.Excel.ControlCollection.Remove*> method to remove a \<xref:Microsoft.Office.Tools.Excel.NamedRange> from `Sheet1` in a document-level project for Excel.  
  
 [!code[Trin_ExcelWorkbookDynamicControls#4](../VS_officedev/codesnippet/VisualBasic/adding-controls-to-office-documents-at-run-time_2.vb)]
[!code[Trin_ExcelWorkbookDynamicControls#4](../VS_officedev/codesnippet/CSharp/adding-controls-to-office-documents-at-run-time_2.cs)]  
  
 You cannot remove static controls at run time. If you try to use the Delete or Remove method to remove a static control, a \<xref:Microsoft.Office.Tools.CannotRemoveControlException> will be thrown.  
  
> [!NOTE]  
>  Do not programmatically remove controls in the `Shutdown` event handler of the document. The UI elements of the document are no longer available when the `Shutdown` event is raised. If you want to remove controls before the document closes, add your code to the event handler for another event, such as \<xref:Microsoft.Office.Tools.Word.Document.BeforeClose> or \<xref:Microsoft.Office.Tools.Word.Document.BeforeSave> for Word, or \<xref:Microsoft.Office.Tools.Excel.Workbook.BeforeClose>, or \<xref:Microsoft.Office.Tools.Excel.Workbook.BeforeSave> for Excel.  
  
##  <a name="HostControls"></a> Adding Host Controls to Documents  
 When you programmatically add host controls to documents, you must provide a name that uniquely identifies the control, and you must specify where to add the control on the document. For specific instructions, see the following topics:  
  
-   [How to: Add ListObject Controls to Worksheets](../VS_officedev/how-to--add-listobject-controls-to-worksheets.md)  
  
-   [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md)  
  
-   [How to: Add Chart Controls to Worksheets](../VS_officedev/how-to--add-chart-controls-to-worksheets.md)  
  
-   [How to: Add Content Controls to Word Documents](../VS_officedev/how-to--add-content-controls-to-word-documents.md)  
  
-   [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md)  
  
 For more information about host controls, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
 When a document is saved and then closed, all dynamically created host controls are disconnected from their events and they lose their data binding functionality. You can add code to your solution to re-create the host controls when the document is reopened. For more information, see [Persisting Dynamic Controls in Office Documents](../VS_officedev/persisting-dynamic-controls-in-office-documents.md).  
  
> [!NOTE]  
>  Helper methods are not provided for the following host controls, because these controls cannot be added programmatically to documents: \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange>, \<xref:Microsoft.Office.Tools.Word.XMLNode>, and \<xref:Microsoft.Office.Tools.Word.XMLNodes>.  
  
##  <a name="WindowsForms"></a> Adding Windows Forms Controls to Documents  
 When you programmatically add a Windows Forms control to a document, you must provide the location of the control and a name that uniquely identifies the control. The [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] provides helper methods for each control. These methods are overloaded so that you can pass either a range or specific coordinates for the location of the control.  
  
 When a document is saved and then closed, all dynamically created Windows Forms controls are removed from the document. You can add code to your solution to re-create the controls when the document is reopened. If you create dynamic Windows Forms controls by using an VSTO Add-in, the ActiveX wrappers for the controls are left in the document. For more information, see [Persisting Dynamic Controls in Office Documents](../VS_officedev/persisting-dynamic-controls-in-office-documents.md).  
  
> [!NOTE]  
>  Windows Forms controls cannot be programmatically added to protected documents. If you programmatically unprotect a Word document or Excel worksheet to add a control, you must write additional code to remove the control's ActiveX wrapper when the document is closed. The control's ActiveX wrapper is not automatically deleted from protected documents.  
  
### Adding Custom Controls  
 If you want to add a \<xref:System.Windows.Forms.Control> that is not supported by the available helper methods, such as a custom user control, use the following methods:  
  
-   For Excel, use one of the \<xref:Microsoft.Office.Tools.Excel.ControlCollection.AddControl*> methods of a \<xref:Microsoft.Office.Tools.Excel.ControlCollection> object.  
  
-   For Word, use one of the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddControl*> methods of a \<xref:Microsoft.Office.Tools.Word.ControlCollection> object.  
  
 To add the control, pass the \<xref:System.Windows.Forms.Control>, a location for the control, and a name that uniquely identifies the control to the AddControl method. The AddControl method returns an object that defines how the control interacts with the worksheet or document. The AddControl method returns a \<xref:Microsoft.Office.Tools.Excel.ControlSite> (for Excel) or a \<xref:Microsoft.Office.Tools.Word.ControlSite> object (for Word).  
  
 The following code example demonstrates how to use the \<xref:Microsoft.Office.Tools.Excel.ControlCollection.AddControl*> method to dynamically add a custom user control to a worksheet in a document-level Excel project. In this example, the user control is named `UserControl1`, and the \<xref:Microsoft.Office.Interop.Excel.Range> is named `range1`. To use this example, run it from a `Sheet`*n* class in the project.  
  
 [!code[Trin_VstcoreProgrammingControlsExcel#2](../VS_officedev/codesnippet/VisualBasic/adding-controls-to-office-documents-at-run-time_3.vb)]
[!code[Trin_VstcoreProgrammingControlsExcel#2](../VS_officedev/codesnippet/CSharp/adding-controls-to-office-documents-at-run-time_3.cs)]  
  
### Using Members of Custom Controls  
 After using one of the AddControl methods to add a control to a worksheet or document, you now have two different control objects:  
  
-   The \<xref:System.Windows.Forms.Control> that represents the custom control.  
  
-   The ControlSite, OLEObject, or OLEControl object that represents the control after it was added to the worksheet or document.  
  
 Many properties and methods are shared between these controls. It is important that you access these members through the appropriate control:  
  
-   To access members that belong only to the custom control, use the \<xref:System.Windows.Forms.Control>.  
  
-   To access members that are shared by the controls, use the ControlSite, OLEObject, or OLEControl object.  
  
 If you access a shared member from the \<xref:System.Windows.Forms.Control>, it might fail without warning or notification, or it can produce invalid results. Always use methods or properties of the ControlSite, OLEObject, or OLEControl object unless the method or property needed is not available; only then should you reference the \<xref:System.Windows.Forms.Control>.  
  
 For example, both the \<xref:Microsoft.Office.Tools.Excel.ControlSite> class and the \<xref:System.Windows.Forms.Control> class have a Top property. To get or set the distance between the top of the control and the top of the document, use the \<xref:Microsoft.Office.Tools.Excel.ControlSite.Top*> property of the \<xref:Microsoft.Office.Tools.Excel.ControlSite>, not the \<xref:System.Windows.Forms.Control.Top*> property of the \<xref:System.Windows.Forms.Control>.  
  
 [!code[Trin_VstcoreProgrammingControlsExcel#3](../VS_officedev/codesnippet/VisualBasic/adding-controls-to-office-documents-at-run-time_4.vb)]
[!code[Trin_VstcoreProgrammingControlsExcel#3](../VS_officedev/codesnippet/CSharp/adding-controls-to-office-documents-at-run-time_4.cs)]  
  
## See Also  
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Persisting Dynamic Controls in Office Documents](../VS_officedev/persisting-dynamic-controls-in-office-documents.md)   
 [How to: Add ListObject Controls to Worksheets](../VS_officedev/how-to--add-listobject-controls-to-worksheets.md)   
 [How to: Add NamedRange Controls to Worksheets](../VS_officedev/how-to--add-namedrange-controls-to-worksheets.md)   
 [How to: Add Chart Controls to Worksheets](../VS_officedev/how-to--add-chart-controls-to-worksheets.md)   
 [How to: Add Content Controls to Word Documents](../VS_officedev/how-to--add-content-controls-to-word-documents.md)   
 [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md)   
 [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md)   
 [How to: Add Windows Forms Controls to Office Documents](../VS_officedev/how-to--add-windows-forms-controls-to-office-documents.md)  
  
  