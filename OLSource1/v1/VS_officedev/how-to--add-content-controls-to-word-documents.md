---
title: "How to: Add Content Controls to Word Documents"
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
  - "restricted permissions [Office development in Visual Studio]"
  - "DropDownListContentControl, adding to documents"
  - "BuildingBlockGalleryContentControl, adding to documents"
  - "partial document protection [Office development in Visual Studio]"
  - "RichTextContentControl, adding to documents"
  - "Word [Office development in Visual Studio], partial document protection"
  - "content controls [Office development in Visual Studio], protecting"
  - "PictureContentControl, adding to documents"
  - "GroupContentControl, adding to documents"
  - "document protection [Office development in Visual Studio]"
  - "PlainTextContentControl, adding to documents"
  - "content controls [Office development in Visual Studio], adding"
  - "ComboBoxContentControl, adding to documents"
  - "DatePickerContentControl, adding to documents"
  - "Word [Office development in Visual Studio], restricted permissions"
ms.assetid: 68ddb24e-71c6-46f7-8e11-c9899d7814df
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
# How to: Add Content Controls to Word Documents
  In document-level Word projects, you can add content controls to the document in your project at design time or at run time. In Word VSTO Add-in projects, you can add content controls to any open document at run time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding content controls at design time](#designtime)  
  
-   [Adding content controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding content controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For information about content controls, see [Content Controls](../VS_officedev/content-controls.md).  
  
##  <a name="designtime"></a> Adding Content Controls at Design Time  
 There are several ways to add content controls to the document in a document-level project at design time:  
  
-   Add a content control from the **Word Controls** tab of the **Toolbox**.  
  
-   Add a content control to your document in the same manner you would add a native content control in Word.  
  
-   Drag a content control to your document from the **Data Sources** window. This is useful when you want to bind the control to data when the control is created. For more information, see [How to: Populate Documents with Data from Objects](../VS_officedev/how-to--populate-documents-with-data-from-objects.md) and [How to: Populate Documents with Data from a Database](../VS_officedev/how-to--populate-documents-with-data-from-a-database.md).  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
#### To add a content control to a document by using the Toolbox  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.  
  
2.  Open the **Toolbox** and click the **Word Controls** tab.  
  
3.  Add the control one of the following ways:  
  
    -   Double-click a content control in the **Toolbox**.  
  
         or  
  
    -   Click a content control in the **Toolbox** and then press the ENTER key.  
  
         or  
  
    -   Drag a content control from the **Toolbox** to the document. The content control is added at the current selection in the document, not at the location of the mouse pointer.  
  
> [!NOTE]  
>  You cannot add a \<xref:Microsoft.Office.Tools.Word.GroupContentControl> by using the **Toolbox**. You can only add a \<xref:Microsoft.Office.Tools.Word.GroupContentControl> in Word, or at run time.  
  
> [!NOTE]  
>  Visual Studio does not provide a check box content control in the Toolbox. To add a check box content control to the document, you must create a \<xref:Microsoft.Office.Tools.Word.ContentControl> object programmatically. For more information, see [Content Controls](../VS_officedev/content-controls.md).  
  
#### To add a content control to a document in Word  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.  
  
2.  On the Ribbon, click the **Developer** tab.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer Tab on the Ribbon](../VS_officedev/how-to--show-the-developer-tab-on-the-ribbon.md).  
  
3.  In the **Controls** group, click the icon for the content control that you want to add.  
  
##  <a name="runtimedoclevel"></a> Adding Content Controls at Run Time in a Document-Level Project  
 You can add content controls programmatically to your document at run time by using methods of the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of the `ThisDocument` class in your project. Each method has three overloads that you can use to add a content control in the following ways:  
  
-   Add a control at the current selection.  
  
-   Add a control at a specified range.  
  
-   Add a control that is based on a native content control in the document.  
  
 Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
> [!NOTE]  
>  To add a check box content control to a document in a Word 2010 project, you must create a \<xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content Controls](../VS_officedev/content-controls.md).  
  
#### To add a content control at the current selection  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a single parameter for the name of the new control.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to add a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisDocument_Startup` event handler.  
  
     [!code[Trin_ContentControlReference#700](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_1.cs)]
[!code[Trin_ContentControlReference#700](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_1.vb)]  
  
#### To add a content control at a specified range  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a \<xref:Microsoft.Office.Interop.Word.Range> parameter.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to add a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisDocument_Startup` event handler.  
  
     [!code[Trin_ContentControlReference#701](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_2.cs)]
[!code[Trin_ContentControlReference#701](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_2.vb)]  
  
#### To add a content control that is based on a native content control  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a Microsoft.Office.Interop.Word.ContentControl parameter.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to create a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `CreateRichTextControlsFromNativeControls` method from the `ThisDocument_Startup` event handler.  
  
     [!code[Trin_ContentControlReference#702](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_3.cs)]
[!code[Trin_ContentControlReference#702](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_3.vb)]  
  
##  <a name="runtimeaddin"></a> Adding Content Controls at Run Time in a VSTO Add-in Project  
 You can add content controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a \<xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of this host item. Each method has three overloads that you can use to add a content control in the following ways:  
  
-   Add a control at the current selection.  
  
-   Add a control at a specified range.  
  
-   Add a control that is based on a native content control in the document.  
  
 Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Persisting Dynamic Controls in Office Documents](../VS_officedev/persisting-dynamic-controls-in-office-documents.md).  
  
 For more information about generating host items in VSTO Add-in projects, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
> [!NOTE]  
>  To add a check box content control to a document, you must create a \<xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content Controls](../VS_officedev/content-controls.md).  
  
#### To add a content control at the current selection  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a single parameter for the name of the new control.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to add a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisAddIn_Startup` event handler.  
  
     [!code[Trin_WordAddInDynamicControls#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_4.vb)]
[!code[Trin_WordAddInDynamicControls#1](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_4.cs)]  
  
#### To add a content control at a specified range  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a \<xref:Microsoft.Office.Interop.Word.Range> parameter.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to add a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisAddIn_Startup` event handler.  
  
     [!code[Trin_WordAddInDynamicControls#2](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_5.vb)]
[!code[Trin_WordAddInDynamicControls#2](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_5.cs)]  
  
#### To add a content control that is based on a native content control  
  
1.  Use a \<xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*>), and that has a Microsoft.Office.Interop.Word.ContentControl parameter.  
  
     The following code example uses the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl*> method to create a new \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in a document, after the document is opened. To run this code, add the code to the `ThisAddIn` class in your project.  
  
     [!code[Trin_WordAddInDynamicControls#3](../VS_officedev/codesnippet/VisualBasic/how-to--add-content-controls-to-word-documents_6.vb)]
[!code[Trin_WordAddInDynamicControls#3](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_6.cs)]  
  
     For C#, you must also attach the `Application_DocumentOpen` event handler to the \<xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.  
  
     [!code[Trin_WordAddInDynamicControls#6](../VS_officedev/codesnippet/CSharp/how-to--add-content-controls-to-word-documents_7.cs)]  
  
## See Also  
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)  
  
  