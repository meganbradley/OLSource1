---
title: "Walkthrough: Binding to Data from a Service in a VSTO add-in Project"
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
  - "databases [Office development in Visual Studio], scrolling records"
  - "records [Office development in Visual Studio], scrolling"
  - "data [Office development in Visual Studio], scrolling database records"
ms.assetid: 9b008be4-06a3-4ffc-9f02-79dd6cfe00ab
caps.latest.revision: 38
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
# Walkthrough: Binding to Data from a Service in a VSTO add-in Project
  You can bind data to host controls in VSTO Add-in projects. This walkthrough demonstrates how to add controls to a Microsoft Office Word document, bind the controls to data retrieved from the MSDN Content Service, and respond to events at run time.  
  
 **Applies to:** The information in this topic applies to application-level projects for Word 2010. For more information, see [Features Available by Office Application and Project Type](../VS_officedev/features-available-by-office-application-and-project-type.md).  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding a \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> control to a document at run time.  
  
-   Binding the \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> control to data from a Web service.  
  
-   Responding to the \<xref:Microsoft.Office.Tools.Word.ContentControlBase.Entering> event of a \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> control.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)].  
  
## Creating a New Project  
 The first step is to create a Word VSTO Add-in project.  
  
#### To create a new project  
  
1.  Create a Word VSTO Add-in project with the name **MTPS Content Service**, using either Visual Basic or C#.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     Visual Studio opens the `ThisAddIn.vb` or `ThisAddIn.cs` file and adds the project to **Solution Explorer**.  
  
## Adding a Web Service  
 For this walkthrough, use a Web service called the MTPS Content Service. This Web service returns information from a specified MSDN article in the form of an XML string or plain text. A later step shows how to display the returned information in a content control.  
  
#### To add the MTPS Content Service to the project  
  
1.  On the **Data** menu, click **Add New Data Source**.  
  
2.  In the **Data Source Configuration Wizard**, click **Service**, and then click **Next**.  
  
3.  In the **Address** field, type the following URL:  
  
     **http://services.msdn.microsoft.com/ContentServices/ContentService.asmx**  
  
4.  Click **Go**.  
  
5.  In the **Namespace** field, type **ContentService**, and click **OK**.  
  
6.  In the **Add Reference Wizard** dialog box, click **Finish**.  
  
## Adding a Content Control and Binding to Data at Run Time  
 In VSTO Add-in projects, you add and bind controls at run time. For this walkthrough, configure the content control to retrieve data from the Web service when a user clicks inside the control.  
  
#### To add a content control and bind to data  
  
1.  In the `ThisAddIn` class, declare the variables for the MTPS Content Service, the content control, and the data binding.  
  
     [!code[Trin_WordAddIn_BindingDataToContentControl#2](../VS_officedev/codesnippet/CSharp/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_1.cs)]
[!code[Trin_WordAddIn_BindingDataToContentControl#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_1.vb)]  
  
2.  Add the following method to the `ThisAddIn` class. This method creates a content control at the beginning of the active document.  
  
     [!code[Trin_WordAddIn_BindingDataToContentControl#4](../VS_officedev/codesnippet/CSharp/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_2.cs)]
[!code[Trin_WordAddIn_BindingDataToContentControl#4](../VS_officedev/codesnippet/VisualBasic/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_2.vb)]  
  
3.  Add the following method to the `ThisAddIn` class. This method initializes the objects needed to create and send a request to the Web service.  
  
     [!code[Trin_WordAddIn_BindingDataToContentControl#6](../VS_officedev/codesnippet/CSharp/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_3.cs)]
[!code[Trin_WordAddIn_BindingDataToContentControl#6](../VS_officedev/codesnippet/VisualBasic/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_3.vb)]  
  
4.  Create an event handler to retrieve the MSDN Library document about content controls when a user clicks inside of the content control and bind the data to the content control.  
  
     [!code[Trin_WordAddIn_BindingDataToContentControl#5](../VS_officedev/codesnippet/CSharp/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_4.cs)]
[!code[Trin_WordAddIn_BindingDataToContentControl#5](../VS_officedev/codesnippet/VisualBasic/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_4.vb)]  
  
5.  Call the `AddRichTextControlAtRange` and `InitializeServiceObjects` methods from the `ThisAddIn_Startup` method. For C# programmers, add an event handler.  
  
     [!code[Trin_WordAddIn_BindingDataToContentControl#3](../VS_officedev/codesnippet/CSharp/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_5.cs)]
[!code[Trin_WordAddIn_BindingDataToContentControl#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--binding-to-data-from-a-service-in-a-vsto-add-in-project_5.vb)]  
  
## Testing the Add-In  
 When you open Word, the \<xref:Microsoft.Office.Tools.Word.RichTextContentControl> control appears. The text in the control changes when you click inside it.  
  
#### To test the VSTO Add-in  
  
1.  Press **F5**.  
  
2.  Click inside of the content control.  
  
     Information is downloaded from the MTPS Content Service and displayed inside the content control.  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)  
  
  