---
title: "Walkthrough: Creating Your First Document-Level Customization For Word"
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
  - "Office development in Visual Studio, creating your first project"
  - "Word [Office development in Visual Studio], creating your first project"
  - "document-level customizations [Office development in Visual Studio], creating your first project"
ms.assetid: ec9f5173-0923-4aee-985a-e760e80eaae3
caps.latest.revision: 45
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
# Walkthrough: Creating Your First Document-Level Customization For Word
  This introductory walkthrough shows you how to create a document-level customization for Microsoft Office Word. The features that you create in this kind of solution are available only when a specific document is open. You cannot use a document-level customization to make application-wide changes, for example, displaying a new Ribbon tab when any document is open.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating a Word document project.  
  
-   Adding text to the document that is hosted in the Visual Studio designer.  
  
-   Writing code that uses the object model of Word to add text to the customized document when it is opened.  
  
-   Building and running the project to test it.  
  
-   Cleaning up the project to remove unnecessary build files and security settings from your development computer.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   Microsoft Word  
  
## Creating the Project  
  
#### To create a new Word document project in Visual Studio  
  
1.  Start [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **Project**.  
  
3.  In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.  
  
4.  Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.  
  
5.  In the list of project templates, select a Word VSTO document project .  
  
6.  In the **Name** box, type **FirstDocumentCustomization**.  
  
7.  Click **OK**.  
  
     The **Visual Studio Tools for Office Project Wizard** opens.  
  
8.  Select **Create a new document**, and click **OK**.  
  
     [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] creates the **FirstDocumentCustomization** project, and adds the **FirstDocumentCustomization** document and ThisDocument code file to the project. The **FirstDocumentCustomization** document is opened automatically in the designer.  
  
## Closing and Reopening the Document in the Designer  
 If you deliberately or accidentally close the document in the designer while you are developing your project, you can reopen it.  
  
#### To close and reopen the document in the designer  
  
1.  Close the document by clicking the **Close** button (X) for the designer window.  
  
2.  In **Solution Explorer**, right-click the **ThisDocument** code file, and click **View Designer**.  
  
     \- or -  
  
     In **Solution Explorer**, double-click the **ThisDocument** code file.  
  
## Adding Text to the Document in the Designer  
 You can design the user interface (UI) of your customization by modifying the document that is open in the designer. For example, you can add text, tables, or Word controls. For more information about how to use the designer, see [Office Projects in the Visual Studio Environment](../VS_officedev/office-projects-in-the-visual-studio-environment.md).  
  
#### To add text to your document by using the designer  
  
1.  In the document that is open in the designer, type the following text.  
  
     **This text was added by using the designer.**  
  
## Adding Text to the Document Programmatically  
 Next, add code to the ThisDocument code file. The new code uses the object model of Word to add a second paragraph of text to the document. By default, the ThisDocument code file contains the following generated code:  
  
-   A partial definition of the `ThisDocument` class, which represents the programming model of the document and provides access to the object model of Word. For more information, see [Document Host Item](../VS_officedev/document-host-item.md) and [Word Object Model Overview](../VS_officedev/word-object-model-overview.md). The remainder of the `ThisDocument` class is defined in a hidden code file that you should not modify.  
  
-   The `ThisDocument_Startup` and `ThisDocument_Shutdown` event handlers. These event handlers are called when the document is opened and closed. Use these event handlers to initialize your customization when the document is opened, and to clean up resources used by your customization when the document is closed. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
#### To add a second paragraph of text to the document by using code  
  
1.  In **Solution Explorer**, right-click **ThisDocument**, and then click **View Code**.  
  
     The code file opens in Visual Studio.  
  
2.  Replace the `ThisDocument_Startup` event handler with the following code. When the document is opened, this code adds a second paragraph of text to the document.  
  
     [!code[Trin_WordDocumentTutorial#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-your-first-document-level-customization-for-word_1.vb)]
[!code[Trin_WordDocumentTutorial#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-your-first-document-level-customization-for-word_1.cs)]  
  
    > [!NOTE]  
    >  This code uses the index value 1 to access the first paragraph in the \<xref:Microsoft.Office.Tools.Word.Document.Paragraphs*> property. Although Visual Basic and Visual C# use 0-based arrays, the lower array bounds of most collections in the Word object model is 1. For more information, see [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md).  
  
## Testing the Project  
  
#### To test your document  
  
1.  Press **F5** to build and run your project.  
  
     When you build the project, the code is compiled into an assembly that is associated with the document. Visual Studio puts a copy of the document and the assembly in the build output folder for the project, and it configures the security settings on the development computer to enable the customization to run. For more information, see [Building Office Solutions](../VS_officedev/building-office-solutions.md).  
  
2.  In the document, verify that you see the following text.  
  
     **This text was added by using the designer.**  
  
     **This text was added by using code.**  
  
3.  Close the document.  
  
## Cleaning up the Project  
 When you finish developing a project, you should remove the files in the build output folder and the security settings created by the build process.  
  
#### To clean up the completed project on your development computer  
  
1.  In Visual Studio, on the **Build** menu, click **Clean Solution**.  
  
## Next Steps  
 Now that you have created a basic document-level customization for Word, you can learn more about how to develop customizations from these topics:  
  
-   General programming tasks that you can perform in document-level customizations: [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md).  
  
-   Programming tasks that are specific to document-level customizations for Word: [Word Solutions](../VS_officedev/word-solutions.md).  
  
-   Using the object model of Word: [Word Object Model Overview](../VS_officedev/word-object-model-overview.md).  
  
-   Customizing the UI of Word, for example, by adding a custom tab to the Ribbon or creating your own actions pane: [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
-   Using extended Word objects provided by Office solutions in Visual Studio to perform tasks that are not possible by using the Word object model (for example, hosting managed controls on documents and binding Word controls to data by using the Windows Forms data binding model): [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md).  
  
-   Building and debugging document-level customizations for Word: [Building Office Solutions](../VS_officedev/building-office-solutions.md).  
  
-   Deploying document-level customizations for Word: [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md).  
  
## See Also  
 [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md)   
 [Word Solutions](../VS_officedev/word-solutions.md)   
 [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)   
 [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)   
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Building Office Solutions](../VS_officedev/building-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md)  
  
  