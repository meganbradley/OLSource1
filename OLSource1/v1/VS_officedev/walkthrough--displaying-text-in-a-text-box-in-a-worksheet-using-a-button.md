---
title: "Walkthrough: Displaying Text in a Text Box in a Worksheet Using a Button"
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
  - "text [Office development in Visual Studio], displaying worksheets"
  - "worksheets, displaying text"
  - "text boxes, displaying text in worksheets"
  - "text [Office development in Visual Studio], text boxes"
ms.assetid: 59b73159-aab7-4f61-9ace-1723c18d78d6
caps.latest.revision: 56
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
# Walkthrough: Displaying Text in a Text Box in a Worksheet Using a Button
  This walkthrough shows the basics of using buttons and text boxes on Microsoft Office Excel worksheets, and how to create Excel projects using Office development tools in Visual Studio. To see the result as a completed sample, see the Excel Controls Sample at [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md).  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
 During this walkthrough, you will learn how to:  
  
-   Add controls to a worksheet.  
  
-   Populate a text box when a button is clicked.  
  
-   Test your project.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Excel_15_short](../VS_officedev/includes/excel_15_short_md.md)] or [!INCLUDE[Excel_14_short](../VS_officedev/includes/excel_14_short_md.md)].  
  
## Creating the Project  
 In this step, you will create an Excel Workbook project using Visual Studio.  
  
#### To create a new project  
  
1.  Create an Excel Workbook project with the name **My Excel Button**. Make sure that **Create a new document** is selected. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Excel workbook in the designer and adds the **My Excel Button** project to **Solution Explorer**.  
  
## Adding Controls to the Worksheet  
 For this walkthrough, you will need a button and a text box on the first worksheet.  
  
#### To add a button and a text box  
  
1.  Verify that the **My Excel Button.xlsx** workbook is open in the Visual Studio designer, with `Sheet1` displayed.  
  
2.  From the **Common Controls** tab of the Toolbox, drag a \<xref:Microsoft.Office.Tools.Excel.Controls.TextBox> to `Sheet1`.  
  
3.  From the **View** menu, select **Properties Window**.  
  
4.  Be sure that **TextBox1** is visible in the **Properties** window drop-down box and change the **Name** property of the text box to **displayText**.  
  
5.  Drag a **Button** control onto `Sheet1` and change the following properties:  
  
    |Property|Value|  
    |--------------|-----------|  
    |**Name**|**insertText**|  
    |**Text**|**Insert Text**|  
  
 Now write the code to run when the button is clicked.  
  
## Populating the Text Box when the Button is Clicked  
 Each time the user clicks the button, **Hello World!** is appended to the text box.  
  
#### To write to the text box when the button is clicked  
  
1.  In **Solution Explorer**, right-click **Sheet1**, and then click **View Code** on the shortcut menu.  
  
2.  Add the following code to the \<xref:System.Windows.Forms.Control.Click> event handler of the button:  
  
     [!code[Trin_VstcoreProgrammingControlsExcel#11](../VS_officedev/codesnippet/VisualBasic/walkthrough--displaying-text-in-a-text-box-in-a-worksheet-using-a-button_1.vb)]
[!code[Trin_VstcoreProgrammingControlsExcel#11](../VS_officedev/codesnippet/CSharp/walkthrough--displaying-text-in-a-text-box-in-a-worksheet-using-a-button_1.cs)]  
  
3.  In C#, you must add an event handler to the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event as shown below. For information on creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreProgrammingControlsExcel#12](../VS_officedev/codesnippet/CSharp/walkthrough--displaying-text-in-a-text-box-in-a-worksheet-using-a-button_2.cs)]  
  
## Testing the Application  
 You can now test your workbook to make sure that the message **Hello World!** appears in the text box when you click the button.  
  
#### To test your workbook  
  
1.  Press F5 to run your project.  
  
2.  Click the button.  
  
3.  Confirm that **Hello World!** appears in the text box.  
  
## Next Steps  
 This walkthrough shows the basics of using buttons and text boxes on Excel worksheets. Here are some tasks that might come next:  
  
-   Deploying the project. For more information, see [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md).  
  
-   Using check boxes to change formatting. For more information, see [Walkthrough: Changing Worksheet Formatting Using CheckBox Controls](../VS_officedev/walkthrough--changing-worksheet-formatting-using-checkbox-controls.md).  
  
## See Also  
 [How to: Add Windows Forms Controls to Office Documents](../VS_officedev/how-to--add-windows-forms-controls-to-office-documents.md)   
 [Walkthroughs Using Excel](../VS_officedev/walkthroughs-using-excel.md)   
 [Limitations of Windows Forms Controls on Office Documents](../VS_officedev/limitations-of-windows-forms-controls-on-office-documents.md)  
  
  