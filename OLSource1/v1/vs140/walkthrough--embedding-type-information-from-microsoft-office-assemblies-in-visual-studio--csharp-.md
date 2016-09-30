---
title: "Walkthrough: Embedding Type Information from Microsoft Office Assemblies in Visual Studio (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 3320e866-01f1-4b7f-8932-049a7b2d2a9b
caps.latest.revision: 7
---
# Walkthrough: Embedding Type Information from Microsoft Office Assemblies in Visual Studio (C#)
If you embed type information in an application that references COM objects, you can eliminate the need for a primary interop assembly (PIA). Additionally, the embedded type information enables you to achieve version independence for your application. That is, your program can be written to use types from multiple versions of a COM library without requiring a specific PIA for each version. This is a common scenario for applications that use objects from Microsoft Office libraries. Embedding type information enables the same build of a program to work with different versions of Microsoft Office on different computers without the need to redeploy either the program or the PIA for each version of Microsoft Office.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 This walkthrough requires the following:  
  
-   A computer on which Visual Studio and Microsoft Excel are installed.  
  
-   A second computer on which the .NET Framework 4 or higher and a different version of Excel are installed.  
  
##  \<a name="BKMK_createapp">\</a> To create an application that works with multiple versions of Microsoft Office  
  
1.  Start Visual Studio on a computer on which Excel is installed.  
  
2.  On the **File** menu, choose **New**, **Project**.  
  
3.  In the **New Project** dialog box, in the **Project Types** pane, make sure that **Windows** is selected. Select **Console Application** in the **Templates** pane. In the **Name** box, enter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and then choose the **OK** button. The new project is created.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **References** folder and then choose **Add Reference**.  
  
5.  On the **.NET** tab, choose the most recent version of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For example, **Microsoft.Office.Interop.Excel 14.0.0.0**. Choose the **OK** button.  
  
6.  In the list of references for the **CreateExcelWorkbook** project, select the reference for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that you added in the previous step. In the **Properties** window, make sure that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  The application created in this walkthrough runs with different versions of Microsoft Office because of the embedded interop type information. If the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> property is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you must include a PIA for each version of Microsoft Office that the application will run with.  
  
7.  Open the **Program.cs** file. Replace the code in the file with the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
8.  Save the project.  
  
9. Press CTRL+F5 to build and run the project. Verify that an Excel workbook has been created at the location specified in the example code: C:\SampleFolder\SampleWorkbook.xls.  
  
##  \<a name="BKMK_publishapp">\</a> To publish the application to a computer on which a different version of Microsoft Office is installed  
  
1.  Open the project created by this walkthrough in Visual Studio.  
  
2.  On the **Build** menu, choose **Publish CreateExcelWorkbook**. Follow the steps of the Publish Wizard to create an installable version of the application. For more information, see [Publish Wizard (Office Development in Visual Studio)](assetId:///793314b6-b6a6-4509-8f1c-dd9466cf5190).  
  
3.  Install the application on a computer on which the .NET Framework 4 or higher and a different version of Excel are installed.  
  
4.  When the installation is finished, run the installed program.  
  
5.  Verify that an Excel workbook has been created at the location specified in the sample code: C:\SampleFolder\SampleWorkbook.xls.  
  
## See Also  
 [Walkthrough: Embedding Types from Managed Assemblies in Visual Studio (C#)](../vs140/walkthrough--embedding-types-from-managed-assemblies-in-visual-studio--csharp-.md)   
 [/link (C# Compiler Options)](../vs140/-link--csharp-compiler-options-.md)