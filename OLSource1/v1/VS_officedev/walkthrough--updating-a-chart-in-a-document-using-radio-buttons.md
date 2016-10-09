---
title: "Walkthrough: Updating a Chart in a Document Using Radio Buttons"
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
  - "documents [Office development in Visual Studio], updating using controls"
  - "controls [Office development in Visual Studio], updating documents"
ms.assetid: 56e6d1f2-65a4-41f0-aff5-f0cfd96d7185
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
# Walkthrough: Updating a Chart in a Document Using Radio Buttons
  This walkthrough demonstrates how to use radio buttons in a document-level customization for Microsoft Office Word to give users the option to select chart styles on the document.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding a chart to the document in a document-level project at design time.  
  
-   Grouping radio buttons by adding them to a user control.  
  
-   Changing the chart style when an option is selected.  
  
 To see the result as a completed sample, see the Word Controls Sample at [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md).  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)].  
  
## Creating the Project  
 The first step is to create a Word Document project.  
  
#### To create a new project  
  
1.  Create a Word Document project with the name **My Chart Options**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Word document in the designer and adds the **My Chart Options** project to **Solution Explorer**.  
  
## Adding a Chart to the Document  
  
#### To add a chart  
  
1.  In the Word document that is hosted in the Visual Studio designer, on the Ribbon, click the **Insert** tab.  
  
2.  In the **Text** group, click the **Insert Object** drop-down button, and click **Object**.  
  
     The **Object** dialog box opens.  
  
3.  In the **Object type** list on the **Create New** tab, select **Microsoft Graph Chart** and then click **OK**.  
  
     A chart is added to the document at the insertion point, and the **Datasheet** window appears with some default data.  
  
4.  Close the **Datasheet** window to accept the default values in the chart and click inside the document to move focus away from the chart.  
  
5.  Right-click the chart, and then click **Format Object**.  
  
6.  On the **Layout** tab of the **Format Object** dialog box, select **Square** and click **OK**.  
  
## Adding a User Control to the Project  
 Radio buttons on a document are not mutually exclusive by default. You can make them function correctly by adding them to a user control, and then writing code to control the selection.  
  
#### To add a user control  
  
1.  Select the **My Chart Options** project in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add New Item**.  
  
3.  In the **Add New Item** dialog box, click **User Control**, name the control **ChartOptions,** and click **Add**.  
  
#### To add Windows Form controls to the user control  
  
1.  If the user control is not visible in the designer, double-click **ChartOptions** in **Solution Explorer**.  
  
2.  From the **Common Controls** tab of the **Toolbox**, drag the first **Radio Button** control to the user control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**columnChart**|  
    |**Text**|**Column Chart**|  
  
3.  Add a second **Radio Button** to the user control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**barChart**|  
    |**Text**|**Bar Chart**|  
  
4.  Add a third **Radio Button** to the user control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**lineChart**|  
    |**Text**|**Line Chart**|  
  
5.  Add a fourth **Radio Button** to the user control, and change the following properties.  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**areaBlockChart**|  
    |**Text**|**Area Block Chart**|  
  
## Adding References  
 To access the chart from the user control on a document, you must have a reference to the Microsoft.Office.Interop.Graph assembly in your project.  
  
#### To add a reference to the Microsoft.Office.Interop.Graph assembly  
  
1.  On the **Project** menu, click **Add Reference**.  
  
     The **Add Reference** dialog box appears.  
  
2.  On the **.NET** tab, select **Microsoft.Office.Interop.Graph** and click **OK**. Select the 14.0.0.0 version of the assembly.  
  
## Changing the Chart Style when a Radio Button is Selected  
 To make the buttons work correctly, create a public event on the user control, add a property to set the selection type, and create a procedure for the `CheckedChanged` event of each of the radio buttons.  
  
#### To create an event and property on a user control  
  
1.  In **Solution Explorer**, right-click the user control, and then click **View Code**.  
  
2.  Add code to create a `SelectionChanged` event and the `Selection` property to the `ChartOptions` class.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#9](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_1.cs)]
[!code[Trin_VstcoreProgrammingControlsWord#9](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_1.vb)]  
  
#### To handle the CheckedChange event of the radio buttons  
  
1.  Set the chart type in the `CheckedChanged` event handler of the `areaBlockChart` radio button and then raise the event.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#10](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_2.cs)]
[!code[Trin_VstcoreProgrammingControlsWord#10](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_2.vb)]  
  
2.  Set the chart type in the `CheckedChanged` event handler of the `barChart` radio button.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#11](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_3.cs)]
[!code[Trin_VstcoreProgrammingControlsWord#11](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_3.vb)]  
  
3.  Set the chart type in the `CheckedChanged` event handler of the `columnChart` radio button.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#12](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_4.cs)]
[!code[Trin_VstcoreProgrammingControlsWord#12](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_4.vb)]  
  
4.  Set the chart type in the `CheckedChanged` event handler of the `lineChart` radio button.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#13](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_5.cs)]
[!code[Trin_VstcoreProgrammingControlsWord#13](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_5.vb)]  
  
5.  In C#, you must add event handlers for the radio buttons. You can add the code to the `ChartOptions` constructor, beneath the call to `InitializeComponent`. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreProgrammingControlsWord#14](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_6.cs)]  
  
## Adding the User Control to the Document  
 When you build the solution, the new user control is automatically added to the **Toolbox**. You can then drag the control from the **Toolbox** to your document.  
  
#### To add the user control your document  
  
1.  On the **Build** menu, click **Build Solution**.  
  
     The **ChartOptions** user control is added to the **Toolbox**.  
  
2.  In **Solution Explorer**, right-click **ThisDocument.vb** or **ThisDocument.cs**, and then click **View Designer**.  
  
3.  Drag the `ChartOptions` control from the **Toolbox** to the document.  
  
     In the **Properties** window, name the control that you just added to the document  `ChartOptions1`.  
  
## Changing the Chart Type  
 Create an event handler to change the chart type according to the option that is selected in the user control.  
  
#### To change the type of chart that is displayed in the document  
  
1.  Add the following event handler to the `ThisDocument` class.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#15](../VS_officedev/codesnippet/VisualBasic/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_7.vb)]
[!code[Trin_VstcoreProgrammingControlsWord#15](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_7.cs)]  
  
2.  In C#, you must add an event handler for the user control to the \<xref:Microsoft.Office.Tools.Word.Document.Startup> event.  
  
     [!code[Trin_VstcoreProgrammingControlsWord#16](../VS_officedev/codesnippet/CSharp/walkthrough--updating-a-chart-in-a-document-using-radio-buttons_8.cs)]  
  
## Testing the Application  
 You can now test your document to make sure that the chart style is updated correctly when you select a radio button.  
  
#### To test your document  
  
1.  Press F5 to run your project.  
  
2.  Select various radio buttons.  
  
3.  Confirm that the chart style changes to match the selection.  
  
## Next Steps  
 Here are some tasks that might come next:  
  
-   Using a button to populate a text box. For more information, see [Walkthrough: Displaying Text in a Text Box in a Document Using a Button](../VS_officedev/walkthrough--displaying-text-in-a-text-box-in-a-document-using-a-button.md).  
  
-   Change formatting by selecting a style from a combo box. For more information, see [Walkthrough: Changing Document Formatting Using CheckBox Controls](../VS_officedev/walkthrough--changing-document-formatting-using-checkbox-controls.md).  
  
## See Also  
 [Walkthroughs Using Word](../VS_officedev/walkthroughs-using-word.md)   
 [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md)   
 [Limitations of Windows Forms Controls on Office Documents](../VS_officedev/limitations-of-windows-forms-controls-on-office-documents.md)  
  
  