---
title: "How to: Add Bookmark Controls to Word Documents"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.Bookmark.Dialog"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Bookmark control, adding to documents"
  - "Create Bookmark Control dialog box"
  - "controls [Office development in Visual Studio], adding to documents"
ms.assetid: 2940704e-31f5-4486-854e-76298a9e2ee4
caps.latest.revision: 52
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
# How to: Add Bookmark Controls to Word Documents
  In document-level projects, you can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in your project at design time or at run time. In VSTO Add-in projects, you can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding Bookmark controls at design time](#designtime)  
  
-   [Adding Bookmark controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding Bookmark controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about \<xref:Microsoft.Office.Tools.Word.Bookmark> controls, see [Bookmark Control](../VS_officedev/bookmark-control.md).  
  
##  <a name="designtime"></a> Adding Bookmark Controls at Design Time  
 There are several ways to add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in a document-level project at design time:  
  
-   From the Visual Studio **Toolbox**.  
  
     You can drag the \<xref:Microsoft.Office.Tools.Word.Bookmark> control from the **Toolbox** to your document. You might want to choose this way if you are already using the **Toolbox** to add Windows Forms controls to your document.  
  
-   From within Word.  
  
     You can add the \<xref:Microsoft.Office.Tools.Word.Bookmark> control to your document in the same manner you would add the native bookmark. The advantage of adding it this way is that you can name your control at the time you create it.  
  
-   From the **Data Sources** window.  
  
     You can drag the \<xref:Microsoft.Office.Tools.Word.Bookmark> control to your document from the **Data Sources** window. This is useful when you want to bind the control to data at the same time. You can add the host control in the same way you would add a Windows Form control from the **Data Sources** window. For more information, see [Data Binding and Windows Forms](../Topic/Data%20Binding%20and%20Windows%20Forms.md).  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
#### To add a Bookmark control to a document from the Toolbox  
  
1.  Open the **Toolbox** and click the **Word Controls** tab.  
  
2.  Drag a \<xref:Microsoft.Office.Tools.Word.Bookmark> control to the document.  
  
     The **Add Bookmark** dialog box appears.  
  
3.  Select the text or other items you want to include in the bookmark.  
  
4.  Click **OK**.  
  
     If you do not want to keep the default bookmark name, you can change the name in the **Properties** window.  
  
#### To add a Bookmark control to a document in Word  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] designer, put the cursor where you want to add the bookmark, or select the text that you want the bookmark to enclose.  
  
2.  On the **Insert** tab of the Ribbon, in the **Links** group, click the **Bookmark** button.  
  
3.  In the **Bookmark** dialog box, type the name of the new bookmark, and click **Add**.  
  
##  <a name="runtimedoclevel"></a> Adding Bookmark Controls at Run Time in a Document-Level Project  
 You can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to your document at run time by using methods of the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of the `ThisDocument` class in your project. There are two method overloads that you can use to add a \<xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:  
  
-   Add a \<xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.  
  
-   Add a \<xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a \<xref:Microsoft.Office.Interop.Word.Bookmark>).  
  
 Dynamically created \<xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native \<xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a \<xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a Bookmark control to a document programmatically  
  
1.  In the `ThisDocument_Startup` event handler in your project, insert the following code to add the \<xref:Microsoft.Office.Tools.Word.Bookmark> control to the first paragraph in the document.  
  
     [!code[Trin_VstcoreHostControlsWord#1](../VS_officedev/codesnippet/CSharp/how-to--add-bookmark-controls-to-word-documents_1.cs)]
[!code[Trin_VstcoreHostControlsWord#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-bookmark-controls-to-word-documents_1.vb)]  
  
    > [!NOTE]  
    >  If you want create a \<xref:Microsoft.Office.Tools.Word.Bookmark> control from an existing \<xref:Microsoft.Office.Interop.Word.Bookmark>, use the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark*> method and pass in the existing \<xref:Microsoft.Office.Interop.Word.Bookmark>.  
  
##  <a name="runtimeaddin"></a> Adding Bookmark Controls at Run Time in an VSTO Add-in project  
 You can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a \<xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the \<xref:Microsoft.Office.Tools.Word.Document.Controls*> property of this host item. There are two method overloads that you can use to add a \<xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:  
  
-   Add a \<xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.  
  
-   Add a \<xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a \<xref:Microsoft.Office.Interop.Word.Bookmark>).  
  
 Dynamically created \<xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native \<xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a \<xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Persisting Dynamic Controls in Office Documents](../VS_officedev/persisting-dynamic-controls-in-office-documents.md).  
  
 For more information about generating host items in VSTO Add-in projects, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a Bookmark control at a specified range  
  
1.  Use the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark*> method, and pass in the \<xref:Microsoft.Office.Interop.Word.Range> where you want to add the \<xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     The following code example adds a new \<xref:Microsoft.Office.Tools.Word.Bookmark> to the beginning of the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.  
  
     [!code[Trin_WordAddInDynamicControls#4](../VS_officedev/codesnippet/VisualBasic/how-to--add-bookmark-controls-to-word-documents_2.vb)]
[!code[Trin_WordAddInDynamicControls#4](../VS_officedev/codesnippet/CSharp/how-to--add-bookmark-controls-to-word-documents_2.cs)]  
  
#### To add a Bookmark control that is based on a native Bookmark control  
  
1.  Use the \<xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark*> method, and pass in the existing \<xref:Microsoft.Office.Interop.Word.Bookmark> that you want to use as the basis for the new \<xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     The following code example creates a new \<xref:Microsoft.Office.Tools.Word.Bookmark> that is based on the first \<xref:Microsoft.Office.Interop.Word.Bookmark> in the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.  
  
     [!code[Trin_WordAddInDynamicControls#5](../VS_officedev/codesnippet/VisualBasic/how-to--add-bookmark-controls-to-word-documents_3.vb)]
[!code[Trin_WordAddInDynamicControls#5](../VS_officedev/codesnippet/CSharp/how-to--add-bookmark-controls-to-word-documents_3.cs)]  
  
## See Also  
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)   
 [How to: Resize Bookmark Controls](../VS_officedev/how-to--resize-bookmark-controls.md)  
  
  