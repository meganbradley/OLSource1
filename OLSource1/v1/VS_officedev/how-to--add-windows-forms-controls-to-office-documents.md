---
title: "How to: Add Windows Forms Controls to Office Documents"
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
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "Windows Forms controls [Office development in Visual Studio], adding"
  - "controls [Office development in Visual Studio], Windows Forms controls"
  - "documents [Office development in Visual Studio], Windows Forms controls"
ms.assetid: 4d188ad2-8e17-4eb0-8422-2ff56c683e3d
caps.latest.revision: 54
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
# How to: Add Windows Forms Controls to Office Documents
  You can add Windows Forms controls to Microsoft Office Excel and Microsoft Office Word documents at design time in document-level projects. At run time, you can add controls in document-level customizations and in VSTO Add-ins. For example, you can add a \<xref:Microsoft.Office.Tools.Excel.Controls.ComboBox> control to your worksheet so that users can select from a list of options.  
  
 [!INCLUDE[appliesto_controls](../VS_officedev/includes/appliesto_controls_md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding controls at design time](#designtime)  
  
-   [Adding controls at run time in document-level projects](#runtimedoclevel)  
  
-   [Adding controls at run time in VSTO Add-ins](#runtimeaddin)  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Add Controls to a Document Surface at Runtime?](http://go.microsoft.com/fwlink/?LinkId=132782).  
  
##  <a name="designtime"></a> Adding Controls at Design Time  
 There are several ways to add Windows Forms controls to the document in a document-level project at design time.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
#### To drag a Windows Forms control to the document  
  
1.  Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  In the **Common Controls** tab of the **Toolbox**, click the control you want to add, and drag it to the document.  
  
    > [!NOTE]  
    >  When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
#### To draw a Windows Forms control on the document  
  
1.  Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  In the **Common Controls** tab of the **Toolbox**, click the control you want to add.  
  
3.  On the document, click where you want the upper-left corner of the control to be located, and drag to where you want the lower-right corner of the control to be located.  
  
     The control is added to the document with the specified location and size.  
  
    > [!NOTE]  
    >  When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")**  in the **Formula Bar**. This text is necessary and should not be deleted.  
  
#### To add a Windows Forms control to the document by single-clicking the control  
  
1.  Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  In the **Common Controls** tab of the **Toolbox**, click the control you want to add  
  
3.  One the document, click where you want the control to be added.  
  
     The control is added to the document with the default size.  
  
    > [!NOTE]  
    >  When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
#### To add a Windows Forms control to the document by double-clicking the control  
  
1.  Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  In the **Common Controls** tab of the **Toolbox**, double-click the control you want to add.  
  
     The control is added to the document at the center of the document or active pane.  
  
    > [!NOTE]  
    >  When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
#### To add a Windows Forms control to the document by pressing the ENTER key  
  
1.  Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  In the **Common Controls** tab of the **Toolbox**, click the control you want to add, and press the ENTER key.  
  
     The control is added to the document at the center of the document or active pane.  
  
    > [!NOTE]  
    >  When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
##  <a name="runtimedoclevel"></a> Adding Controls at Run Time in Document-Level Projects  
 You can programmatically add Windows Forms controls to a document at run time. In Word, use methods of the \<xref:Microsoft.Office.Tools.Word.DocumentBase.Controls*> property of the `ThisDocument` class. In Excel, use methods of the \<xref:Microsoft.Office.Tools.Excel.WorksheetBase.Controls*> property of a `Sheet`*n* class. Each method has several overloads that enable you to specify the location of the control in different ways.  
  
 When you add a Windows Forms control to a document at run time, the control is not persisted in the document when the document is closed. You can recreate the control the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a Windows Forms control at run time  
  
1.  Use a method that has the name Add\<*control class*> (where *control class* is the class name of the Windows Forms control that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlExtensions.AddButton*>).  
  
     The following code example demonstrates how to add a \<xref:Microsoft.Office.Tools.Excel.Controls.Button> to cell **C5** of `Sheet1` in a document-level project for Excel.  
  
     [!code[Trin_VstcoreProgrammingControlsExcel#4](../VS_officedev/codesnippet/VisualBasic/how-to--add-windows-forms-controls-to-office-documents_1.vb)]
[!code[Trin_VstcoreProgrammingControlsExcel#4](../VS_officedev/codesnippet/CSharp/how-to--add-windows-forms-controls-to-office-documents_1.cs)]  
  
##  <a name="runtimeaddin"></a> Adding Controls at Run Time in VSTO Add-ins  
 You can add Windows Forms controls programmatically to any open document at run time. First, generate a host item that is based on an open document or worksheet. Then, in Word, use methods of the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of the new host item. In Excel, use methods of the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Controls*> property of the new host item. Each method has several overloads that enable you to specify the location of the control in different ways.  
  
 When you add a Windows Forms control to a document at run time, the control is not persisted in the document when the document is closed. You can recreate the control the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
 For more information about generating host items in VSTO Add-in projects, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a Windows Forms control at run time  
  
1.  Use a method that has the name Add\<*control class*> (where *control class* is the class name of the Windows Forms control that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlExtensions.AddButton*>).  
  
    > [!NOTE]  
    >  In VSTO Add-in projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, you must add a reference to the Microsoft.Office.Tools.Excel.v4.0.Utilities.dll or Microsoft.Office.Tools.Word.v4.0.Utilities.dll assembly before you can access the Add\<*control class*> methods.  
  
     The following code example demonstrates how to add a \<xref:Microsoft.Office.Tools.Word.Controls.Button> to the first paragraph of the active document by using a Word VSTO Add-in.  
  
     [!code[Trin_WordAddInDynamicControls#7](../VS_officedev/codesnippet/VisualBasic/how-to--add-windows-forms-controls-to-office-documents_2.vb)]
[!code[Trin_WordAddInDynamicControls#7](../VS_officedev/codesnippet/CSharp/how-to--add-windows-forms-controls-to-office-documents_2.cs)]  
  
## See Also  
 [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [How to: Resize Controls Within Worksheet Cells](../VS_officedev/how-to--resize-controls-within-worksheet-cells.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  