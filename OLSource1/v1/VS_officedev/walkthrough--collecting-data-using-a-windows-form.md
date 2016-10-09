---
title: "Walkthrough: Collecting Data Using a Windows Form"
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
  - "data [Office development in Visual Studio], Windows Forms"
  - "Windows Forms [Office development in Visual Studio], collecting data"
  - "forms [Office development in Visual Studio], walkthroughs"
  - "worksheets [Office development in Visual Studio], collecting data"
ms.assetid: 40e87f7f-cfbb-4761-bf1b-d042f45f4f09
caps.latest.revision: 54
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
# Walkthrough: Collecting Data Using a Windows Form
  This walkthrough demonstrates how to open a Windows Form from a document-level customization for Microsoft Office Excel, collect information from the user, and write that information into a worksheet cell.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 Although this walkthrough uses a document-level project for Excel specifically, the concepts demonstrated by the walkthrough are applicable to other Office projects.  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Excel_15_short](../VS_officedev/includes/excel_15_short_md.md)] or [!INCLUDE[Excel_14_short](../VS_officedev/includes/excel_14_short_md.md)].  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Creating a New Project  
 The first step is to create an Excel Workbook project.  
  
#### To create a new project  
  
1.  Create an Excel Workbook project with the name **WinFormInput**, and select **Create a new document** in the wizard. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the new Excel workbook in the designer and adds the **WinFormInput** project to **Solution Explorer**.  
  
## Adding a NamedRange Control to the Worksheet  
  
#### To add a named range to Sheet1  
  
1.  Select cell **A1** on `Sheet1`.  
  
2.  In the **Name** box, type **formInput**.  
  
     The **Name** box is located to the left of the formula bar, just above column **A** of the worksheet.  
  
3.  Press ENTER.  
  
     A \<xref:Microsoft.Office.Tools.Excel.NamedRange> control is added to cell **A1**. There is no visible indication on the worksheet, but **formInput** appears in the **Name** box (just above the worksheet on the left side) and in the **Properties** window when cell **A1** is selected.  
  
## Adding a Windows Form to the Project  
 Create a Windows Form to prompt the user for information.  
  
#### To add a Windows Form  
  
1.  Select the project **WinFormInput** in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add Windows Form**.  
  
3.  Name the form **GetInputString.vb** or **GetInputString.cs**, and then click **Add**.  
  
     The new form opens in the designer.  
  
4.  Add a \<xref:System.Windows.Forms.TextBox> and a \<xref:System.Windows.Forms.Button> to the form.  
  
5.  Select the button, find the property **Text** in the **Properties** window, and change the text to **OK**.  
  
 Next, add code to `ThisWorkbook.vb` or `ThisWorkbook.cs` to collect the user's information.  
  
## Displaying the Windows Form and Collecting Information  
 Create an instance of the `GetInputString` Windows Form and display it, and then write the user's information into a cell in the worksheet.  
  
#### To display the form and collect information  
  
1.  Right-click **ThisWorkbook.vb** or **ThisWorkbook.cs** in **Solution Explorer**, and then click **View Code**.  
  
2.  In the \<xref:Microsoft.Office.Tools.Excel.Workbook.Open> event handler of `ThisWorkbook`, add the following code to declare a variable for the form `GetInputString` and then show the form.  
  
    > [!NOTE]  
    >  In C#, you must add an event handler as shown in the \<xref:Microsoft.Office.Tools.Excel.Workbook.Startup> event below. For information about creating event handlers, see [How to: Create Event Handlers in Office Projects](../VS_officedev/how-to--create-event-handlers-in-office-projects.md).  
  
     [!code[Trin_VstcoreProgrammingCollectingData#1](../VS_officedev/codesnippet/CSharp/walkthrough--collecting-data-using-a-windows-form_1.cs)]
[!code[Trin_VstcoreProgrammingCollectingData#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--collecting-data-using-a-windows-form_1.vb)]  
  
3.  Create a method called `WriteStringToCell` that writes text to a named range. This method is called from the form, and the user's input is passed to the \<xref:Microsoft.Office.Tools.Excel.NamedRange> control, `formInput`, on cell **A1**.  
  
     [!code[Trin_VstcoreProgrammingCollectingData#2](../VS_officedev/codesnippet/CSharp/walkthrough--collecting-data-using-a-windows-form_2.cs)]
[!code[Trin_VstcoreProgrammingCollectingData#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--collecting-data-using-a-windows-form_2.vb)]  
  
 Next, add code to the form to handle the button's click event.  
  
## Sending Information to the Worksheet  
  
#### To send information to the worksheet  
  
1.  Right-click **GetInputString** in **Solution Explorer**, and then click **View Designer**.  
  
2.  Double-click the button to open the code file with the button's \<xref:System.Windows.Forms.Control.Click> event handler added.  
  
3.  Add code to the event handler to take the input from the text box, send it to the function `WriteStringToCell`, and then close the form.  
  
     [!code[Trin_VstcoreProgrammingCollectingData#3](../VS_officedev/codesnippet/CSharp/walkthrough--collecting-data-using-a-windows-form_3.cs)]
[!code[Trin_VstcoreProgrammingCollectingData#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--collecting-data-using-a-windows-form_3.vb)]  
  
## Testing  
 You can now run the project. The Windows Form appears, and your input appears in the worksheet.  
  
#### To test your workbook  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the Windows Form appears.  
  
3.  Type **Hello World** in the text box, and then click **OK**.  
  
4.  Confirm that **Hello World** appears in cell **A1** of the worksheet.  
  
## Next Steps  
 This walkthrough shows the basics of showing a Windows Form and passing data to a worksheet. Other tasks you may want to perform include:  
  
-   Use Windows Forms controls on an Excel workbook or a Word document. For more information, see [Windows Forms Controls on Office Documents Overview](../VS_officedev/windows-forms-controls-on-office-documents-overview.md).  
  
-   Modify the user interface of a Microsoft Office application from a document-level customization or an VSTO Add-in. For more information, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
## See Also  
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)   
 [Walkthroughs Using Word](../VS_officedev/walkthroughs-using-word.md)   
 [Walkthroughs Using Excel](../VS_officedev/walkthroughs-using-excel.md)  
  
  