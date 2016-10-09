---
title: "Walkthrough: Displaying Text in a Text Box in a Document Using a Button"
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
  - "text boxes, displaying text in documents"
ms.assetid: 04c54ed7-9f00-4068-aaec-1f3200110116
caps.latest.revision: 60
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
# Walkthrough: Displaying Text in a Text Box in a Document Using a Button
  This walkthrough demonstrates how to use buttons and text boxes in a document-level customization for Microsoft Office Word.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding controls to the Word document in a document-level project at design time.  
  
-   Populating a text box when a button is clicked.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   Microsoft Word  
  
## Creating the Project  
 The first step is to create a Word Document project.  
  
#### To create a new project  
  
1.  Create a Word Document project with the name **My Word Button**. In the wizard, select **Create a new document**.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Word document in the designer and adds the **My Word Button** project to **Solution Explorer**.  
  
## Adding Controls to the Word Document  
 The user interface controls consist of a button and a text box on the Word document.  
  
#### To add a button and a text box  
  
1.  Verify that the document is open in the Visual Studio designer.  
  
2.  From the **Common Controls** tab of the **Toolbox**, drag a \<xref:Microsoft.Office.Tools.Word.Controls.TextBox> control to the document.  
  
    > [!NOTE]  
    >  In Word, controls are dropped in-line with text by default. You can modify the way controls and shape objects are inserted by changing the default on the **Edit** tab of the **Options** dialog box in Word.  
  
3.  On the **View** menu, click **Properties Window**.  
  
4.  Find **TextBox1** in the **Properties** window drop-down box and change the **Name** property of the text box to **displayText**.  
  
5.  Drag a **Button** control to the document and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**insertText**|  
    |**Text**|**Insert Text**|  
  
 Now you can write the code that will run when the button is clicked.  
  
## Populating the Text Box When the Button Is Clicked  
 Every time the user clicks the button, **Hello World!** is added to the text box.  
  
#### To write to the text box when the button is clicked  
  
1.  In **Solution Explorer**, right-click **ThisDocument**, and then click **View Code** on the shortcut menu.  
  
2.  Add the following code to the \<xref:System.Windows.Forms.Control.Click> event handler of the button.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#7](../VS_officedev/codesnippet/VisualBasic/walkthrough--displaying-text-in-a-text-box-in-a-document-using-a-button_1.vb)]
[!code[Trin_VstcoreProgrammingControlsWord#7](../VS_officedev/codesnippet/CSharp/walkthrough--displaying-text-in-a-text-box-in-a-document-using-a-button_1.cs)]  
  
3.  In C#, you must add an event handler for the button to the \<xref:Microsoft.Office.Tools.Word.Document.Startup> event. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreProgrammingControlsWord#8](../VS_officedev/codesnippet/CSharp/walkthrough--displaying-text-in-a-text-box-in-a-document-using-a-button_2.cs)]  
  
## Testing the Application  
 You can now test your document to make sure that the message **Hello World!** appears in the text box when you click the button.  
  
#### To test your document  
  
1.  Press F5 to run your project.  
  
2.  Click the button.  
  
3.  Confirm that **Hello World!** appears in the text box.  
  
## Next Steps  
 This walkthrough shows the basics of using buttons and text boxes on Word documents. Here are some tasks that might come next:  
  
-   Using a combo box to change formatting. For more information, see [Walkthrough: Changing Document Formatting Using CheckBox Controls](../VS_officedev/walkthrough--changing-document-formatting-using-checkbox-controls.md).  
  
-   Using radio buttons to select chart styles. For more information, see [Walkthrough: Updating a Chart in a Document Using Radio Buttons](../VS_officedev/walkthrough--updating-a-chart-in-a-document-using-radio-buttons.md).  
  
## See Also  
 [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md)   
 [Walkthroughs Using Word](../VS_officedev/walkthroughs-using-word.md)   
 [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md)   
 [How to: Add Windows Forms Controls to Office Documents](../VS_officedev/how-to--add-windows-forms-controls-to-office-documents.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  