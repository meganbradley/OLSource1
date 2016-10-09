---
title: "Walkthrough: Creating Shortcut Menus for Bookmarks"
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
  - "context menus, Word"
  - "Bookmark control, events"
  - "shortcut menus, Word"
  - "menus, creating in Office applications"
ms.assetid: 86dbf3ff-ba75-42f9-8df6-abfc19b3cf6b
caps.latest.revision: 57
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
# Walkthrough: Creating Shortcut Menus for Bookmarks
  This walkthrough demonstrates how to create shortcut menus for \<xref:Microsoft.Office.Tools.Word.Bookmark> controls in a document-level customization for Word. When a user right-clicks the text in a bookmark, a shortcut menu appears and gives the user options for formatting the text.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   [Creating the Project](#BKMK_CreateProject).  
  
-   [Adding Text and Bookmarks to the Document](#BKMK_addtextandbookmarks).  
  
-   [Adding Commands to a Shortcut Menu](#BKMK_AddCmndsShortMenu).  
  
-   [Format the Text in the Bookmark](#BKMK_formattextbkmk).  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)]  
  
##  <a name="BKMK_CreateProject"></a> Creating the Project  
 The first step is to create a Word document project in Visual Studio.  
  
#### To create a new project  
  
-   Create a Word document project that has the name **My Bookmark Shortcut Menu**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Word document in the designer and adds the **My Bookmark Shortcut Menu** project to **Solution Explorer**.  
  
##  <a name="BKMK_addtextandbookmarks"></a> Adding Text and Bookmarks to the Document  
 Add some text to your document and then add two overlapping bookmarks.  
  
#### To add text to your document  
  
-   In the document that appears in the designer of your project, type the following text.  
  
     **This is an example of creating a shortcut menu when you right-click the text in a bookmark.**  
  
#### To add a Bookmark control to your document  
  
1.  In the **Toolbox**, from the **Word Controls** tab, drag a \<xref:Microsoft.Office.Tools.Word.Bookmark> control to your document.  
  
     The **Add Bookmark Control** dialog box appears.  
  
2.  Select the words “creating a shortcut menu when you right-click the text”, and then click **OK**.  
  
     `bookmark1` is added to the document.  
  
3.  Add another \<xref:Microsoft.Office.Tools.Word.Bookmark> control to the words “right-click the text in a bookmark”.  
  
     `bookmark2` is added to the document.  
  
    > [!NOTE]  
    >  The words “right-click the text” are in both `bookmark1` and `bookmark2`.  
  
 When you add a bookmark to a document at design time, a \<xref:Microsoft.Office.Tools.Word.Bookmark> control is created. You can program against several events of the bookmark. You can write code in the \<xref:Microsoft.Office.Tools.Word.Bookmark.BeforeRightClick> event of the bookmark so that when the user right-clicks the text in the bookmark, a shortcut menu appears.  
  
##  <a name="BKMK_AddCmndsShortMenu"></a> Adding Commands to a Shortcut Menu  
 Add buttons to the shortcut menu that appears when you right-click the document.  
  
#### To add commands to a shortcut menu  
  
1.  Add a **Ribbon XML** item to the project. For more information, see [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md).  
  
2.  In **Solution Explorer**, select **ThisDocument.cs** or **ThisDocument.vb**.  
  
3.  On the menu bar, choose **View**, **Code**.  
  
     The **ThisDocument** class file opens in the Code Editor.  
  
4.  Add the following code to the **ThisDocument** class. This code overrides the CreateRibbonExtensibilityObject method and returns the Ribbon XML class to the Office application.  
  
     [!code[Trin_Word_Document_Menus#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_1.cs)]
[!code[Trin_Word_Document_Menus#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-shortcut-menus-for-bookmarks_1.vb)]  
  
5.  In **Solution Explorer**, select the Ribbon XML file. By default, the Ribbon XML file is named Ribbon1.xml.  
  
6.  On the menu bar, choose **View**, **Code**.  
  
     The Ribbon xml file opens in the Code Editor.  
  
7.  In the Code Editor, replace the contents of the Ribbon XML file with the following code.  
  
    ```  
    <?xml version="1.0" encoding="UTF-8"?>  
    <customUI xmlns="http://schemas.microsoft.com/office/2009/07/customui" onLoad="Ribbon_Load">  
      <contextMenus>  
        <contextMenu idMso="ContextMenuText">  
          <button id="BoldButton" label="Bold" onAction="ButtonClick"          
               getVisible="GetVisible" />  
          <button id="ItalicButton" label="Italic" onAction="ButtonClick"   
              getVisible="GetVisible"/>  
        </contextMenu>  
      </contextMenus>  
    </customUI>  
    ```  
  
     This code adds two buttons to the shortcut menu that appears when you right-click the document.  
  
8.  In **Solution Explorer**, right-click `ThisDocument`, and then click **View Code**.  
  
9. Declare the following variables and a bookmark variable at the class level.  
  
     [!code[Trin_Word_Document_Menus#2](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_2.cs)]
[!code[Trin_Word_Document_Menus#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-shortcut-menus-for-bookmarks_2.vb)]  
  
10. In **Solution Explorer**, select the Ribbon code file. By default, the Ribbon code file is named **Ribbon1.cs** or **Ribbon1.vb**.  
  
11. On the menu bar, choose **View**, **Code**.  
  
     The Ribbon code file opens in the Code Editor.  
  
12. In the Ribbon code file, add the following method. This is a callback method for the two buttons that you have added to the shortcut menu of the document. This method determines whether these buttons appear in the shortcut menu. The bold and italic buttons appear only if you right-click text within the bookmark.  
  
     [!code[Trin_Word_Document_Menus#5](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_3.cs)]
[!code[Trin_Word_Document_Menus#5](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-shortcut-menus-for-bookmarks_3.vb)]  
  
##  <a name="BKMK_formattextbkmk"></a> Format the Text in the Bookmark  
  
#### To format the text in the bookmark  
  
1.  In the Ribbon code file, add a `ButtonClick` event handler to apply formatting to the bookmark.  
  
     [!code[Trin_Word_Document_Menus#6](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_4.cs)]
[!code[Trin_Word_Document_Menus#6](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-shortcut-menus-for-bookmarks_4.vb)]  
  
2.  **Solution Explorer**, select **ThisDocument.cs** or **ThisDocument.vb**.  
  
3.  On the menu bar, choose **View**, **Code**.  
  
     The **ThisDocument** class file opens in the Code Editor.  
  
4.  Add the following code to the **ThisDocument** class.  
  
     [!code[Trin_Word_Document_Menus#3](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_5.cs)]
[!code[Trin_Word_Document_Menus#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-shortcut-menus-for-bookmarks_5.vb)]  
  
    > [!NOTE]  
    >  You must write code to handle the case where bookmarks overlap. If you do not, by default, the code will be called for all bookmarks in the selection.  
  
5.  In C#, you must add event handlers for the bookmark controls to the \<xref:Microsoft.Office.Tools.Word.Document.Startup> event. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_Word_Document_Menus#4](../VS_officedev/codesnippet/CSharp/walkthrough--creating-shortcut-menus-for-bookmarks_6.cs)]  
  
## Testing the Application  
 Test your document to verify that the bold and italic menu items appear in the shortcut menu when you right-click text in a bookmark and that the text is properly formatted.  
  
#### To test your document  
  
1.  Press F5 to run your project.  
  
2.  Right-click in the first bookmark, and then click **Bold**.  
  
3.  Verify that all of the text in `bookmark1` is formatted as bold.  
  
4.  Right-click the text where the bookmarks overlap, and then click **Italic**.  
  
5.  Verify that all of the text in `bookmark2` is italic, and only the part of the text in `bookmark1` that overlaps `bookmark2` is italic.  
  
## Next Steps  
 Here are some tasks that might come next:  
  
-   Write code to respond to events of host controls in Excel. For more information, see [Walkthrough: Programming Against Events of a NamedRange Control](../VS_officedev/walkthrough--programming-against-events-of-a-namedrange-control.md).  
  
-   Use a check box to change formatting in a bookmark. For more information, see [Walkthrough: Changing Document Formatting Using CheckBox Controls](../VS_officedev/walkthrough--changing-document-formatting-using-checkbox-controls.md).  
  
## See Also  
 [Walkthroughs Using Word](../VS_officedev/walkthroughs-using-word.md)   
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Bookmark Control](../VS_officedev/bookmark-control.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  