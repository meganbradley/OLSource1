---
title: "Walkthrough: Inserting Text into a Document from an Actions Pane"
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
  - "smart documents [Office development in Visual Studio], creating in Word"
  - "smart documents [Office development in Visual Studio], adding controls"
  - "actions panes [Office development in Visual Studio], creating in Word"
  - "actions panes [Office development in Visual Studio], adding controls"
ms.assetid: fd14c896-5737-4a20-94f7-6064b67112c5
caps.latest.revision: 70
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
# Walkthrough: Inserting Text into a Document from an Actions Pane
  This walkthrough demonstrates how to create an actions pane in a Microsoft Office Word document. The actions pane contains two controls that collect input and then send the text to the document.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Designing an interface by using Windows Forms controls on an actions pane control.  
  
-   Displaying the actions pane when the application opens.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)].  
  
## Creating the Project  
 The first step is to create a Word Document project.  
  
#### To create a new project  
  
1.  Create a Word Document project with the name **My Basic Actions Pane**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Word document in the designer and adds the **My Basic Actions Pane** project to **Solution Explorer**.  
  
## Adding Text and Bookmarks to the Document  
 The actions pane will send text to bookmarks in the document. To design the document, type some text to create a basic form.  
  
#### To add text to your document  
  
1.  Type the following text into your Word document:  
  
     **March 21, 2008**  
  
     **Name**  
  
     **Address**  
  
     **This is an example of a basic actions pane in Word.**  
  
 You can add a \<xref:Microsoft.Office.Tools.Word.Bookmark> control to your document by dragging it from the **Toolbox** in Visual Studio or by using the **Bookmark** dialog box in Word.  
  
#### To add a Bookmark control to your document  
  
1.  From the **Word Controls** tab of the **Toolbox**, drag a \<xref:Microsoft.Office.Tools.Word.Bookmark> control to your document.  
  
     The **Add Bookmark Control** dialog box appears.  
  
2.  Select the word **Name**, without selecting the paragraph mark, and click **OK**.  
  
    > [!NOTE]  
    >  The paragraph mark should be outside of the bookmark. If paragraph marks are not visible in the document, click the **Tools** menu, point to **Microsoft Office Word Tools** and then click **Options**. Click the **View** tab, and select the **Paragraph marks** check box in the **Formatting marks** section of the **Options** dialog box.  
  
3.  In the **Properties** window, change the **Name** property of **Bookmark1** to **showName**.  
  
4.  Select the word **Address**, without selecting the paragraph mark.  
  
5.  On the **Insert** tab of the Ribbon, in the **Links** group, click **Bookmark**.  
  
6.  In the **Bookmark** dialog box, type **showAddress** in the **Bookmark Name** box and click **Add**.  
  
## Adding Controls to the Actions Pane  
 To design the actions pane interface, add an actions pane control to the project and then add Windows Forms controls to the actions pane control.  
  
#### To add an actions pane control  
  
1.  Select the **My Basic Actions Pane** project in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add New Item**.  
  
3.  In the **Add New Item** dialog box, click **Actions Pane Control**, name the control **InsertTextControl,** and click **Add**.  
  
#### To add Windows Form controls to the actions pane control  
  
1.  If the actions pane control is not visible in the designer, double-click **InsertTextControl**.  
  
2.  From the **Common Controls** tab of the **Toolbox**, drag a **Label** control to the actions pane control.  
  
3.  Change the **Text** property of the Label control to **Name**.  
  
4.  Add a **Textbox** control to the actions pane control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**getName**|  
    |**Size**|**130, 20**|  
  
5.  Add a second **Label** control to the actions pane control, and change the **Text** property to **Address**.  
  
6.  Add a second **Textbox** control to the actions pane control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**getAddress**|  
    |**Accepts Return**|**True**|  
    |**Multiline**|**True**|  
    |**Size**|**130, 40**|  
  
7.  Add a **Button** control to the actions pane control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**addText**|  
    |**Text**|**Insert**|  
  
## Adding Code to Insert Text into the Document  
 In the actions pane, write code that inserts the text from the text boxes into the appropriate \<xref:Microsoft.Office.Tools.Word.Bookmark> controls in the document. You can use the `Globals` class to access controls on the document from the controls on the actions pane. For more information, see [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md).  
  
#### To insert text from the actions pane in a bookmark in the document  
  
1.  Add the following code to the \<xref:System.Windows.Forms.Control.Click> event handler of the **addText** button.  
  
     [!code[Trin_VstcoreActionsPaneWord#8](../VS_officedev/codesnippet/CSharp/walkthrough--inserting-text-into-a-document-from-an-actions-pane_1.cs)]
[!code[Trin_VstcoreActionsPaneWord#8](../VS_officedev/codesnippet/VisualBasic/walkthrough--inserting-text-into-a-document-from-an-actions-pane_1.vb)]  
  
2.  In C#, you must add an event handler for the button click. You can place this code in the `InsertTextControl` constructor after the call to `IntializeComponent`. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreActionsPaneWord#9](../VS_officedev/codesnippet/CSharp/walkthrough--inserting-text-into-a-document-from-an-actions-pane_2.cs)]  
  
## Adding Code to Show the Actions Pane  
 To show the actions pane, add the control you created to the control collection.  
  
#### To show the actions pane  
  
1.  Create a new instance of the actions pane control in the `ThisDocument` class.  
  
     [!code[Trin_VstcoreActionsPaneWord#10](../VS_officedev/codesnippet/CSharp/walkthrough--inserting-text-into-a-document-from-an-actions-pane_3.cs)]
[!code[Trin_VstcoreActionsPaneWord#10](../VS_officedev/codesnippet/VisualBasic/walkthrough--inserting-text-into-a-document-from-an-actions-pane_3.vb)]  
  
2.  Add the following code to the \<xref:Microsoft.Office.Tools.Word.Document.Startup> event handler of `ThisDocument`.  
  
     [!code[Trin_VstcoreActionsPaneWord#11](../VS_officedev/codesnippet/CSharp/walkthrough--inserting-text-into-a-document-from-an-actions-pane_4.cs)]
[!code[Trin_VstcoreActionsPaneWord#11](../VS_officedev/codesnippet/VisualBasic/walkthrough--inserting-text-into-a-document-from-an-actions-pane_4.vb)]  
  
## Testing the Application  
 Test your document to verify that the actions pane opens when the document is opened and that text typed into the text boxes is inserted into the bookmarks when the button is clicked.  
  
#### To test your document  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the actions pane is visible.  
  
3.  Type your name and address into the text boxes on the actions pane and click **Insert**.  
  
## Next Steps  
 Here are some tasks that might come next:  
  
-   Creating an actions pane in Excel. For more information, see [How to: Add an Actions Pane to Excel Workbooks](assetId:///62abfce6-e44f-419d-85d8-26bf59f33872).  
  
-   Binding data to controls on an actions pane. For more information, see [Walkthrough: Binding Data to Controls on a Word Actions Pane](../VS_officedev/walkthrough--binding-data-to-controls-on-a-word-actions-pane.md).  
  
## See Also  
 [Actions Pane Overview](../VS_officedev/actions-pane-overview.md)   
 [How to: Add an Actions Pane to Word Documents or Excel Workbooks](../VS_officedev/how-to--add-an-actions-pane-to-word-documents-or-excel-workbooks.md)   
 [How to: Add an Actions Pane to Excel Workbooks](assetId:///62abfce6-e44f-419d-85d8-26bf59f33872)   
 [How to: Manage Control Layout on Actions Panes](../VS_officedev/how-to--manage-control-layout-on-actions-panes.md)   
 [Bookmark Control](../VS_officedev/bookmark-control.md)  
  
  