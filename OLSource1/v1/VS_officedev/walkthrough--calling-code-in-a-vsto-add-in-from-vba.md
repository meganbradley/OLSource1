---
title: "Walkthrough: Calling Code in a VSTO Add-in from VBA"
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
  - "VBA [Office development in Visual Studio], calling code in application-level add-ins"
  - "application-level add-ins [Office development in Visual Studio], calling code from other solutions"
  - "Video How tos, Office development in Visual Studio"
  - "calling add-in code"
  - "add-ins [Office development in Visual Studio], calling code from other solutions"
  - "interoperability [Office development in Visual Studio]"
  - "calling code from VBA"
ms.assetid: 9c04d1df-0d93-473c-85fd-02dc2e956c9e
caps.latest.revision: 48
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
# Walkthrough: Calling Code in a VSTO Add-in from VBA
  This walkthrough demonstrates how to expose an object in a VSTO Add-in to other Microsoft Office solutions, including Visual Basic for Applications (VBA) and COM VSTO Add-ins.  
  
 [!INCLUDE[appliesto_allapp](../VS_officedev/includes/appliesto_allapp_md.md)]  
  
 Although this walkthrough uses Excel specifically, the concepts demonstrated by the walkthrough are applicable to any VSTO Add-in project template provided by Visual Studio.  
  
 This walkthrough illustrates the following tasks:  
  
-   Defining a class that can be exposed to other Office solutions.  
  
-   Exposing the class to other Office solutions.  
  
-   Calling a method of the class from VBA code.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   Microsoft Excel  
  
## Creating the VSTO Add-in Project  
 The first step is to create a VSTO Add-in project for Excel.  
  
#### To create a new project  
  
1.  Create an Excel VSTO Add-in project with the name **ExcelImportData**, using the Excel VSTO Add-in project template. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **ExcelImportData** project to **Solution Explorer**.  
  
## Defining a Class That You Can Expose to Other Office Solutions  
 The purpose of this walkthrough is to call into the `ImportData` method of a class named `AddInUtilities` in your VSTO Add-in from VBA code. This method writes a string into cell A1 of the active worksheet.  
  
 To expose the `AddInUtilities` class to other Office solutions, you must make the class public and visible to COM. You must also expose the [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5) interface in the class. The code in the following procedure demonstrates one way to meet these requirements. For more information, see [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md).  
  
#### To define a class that you can expose to other Office solutions  
  
1.  On the **Project** menu, click **Add Class**.  
  
2.  In the **Add New Item** dialog box, change the name of the new class to **AddInUtilities**, and click **Add**.  
  
     The **AddInUtilities.cs** or **AddInUtilities.vb** file opens in the Code Editor.  
  
3.  Add the following statements to the top of the file.  
  
     [!code[Trin_AddInInteropWalkthrough#2](../VS_officedev/codesnippet/CSharp/walkthrough--calling-code-in-a-vsto-add-in-from-vba_1.cs)]
[!code[Trin_AddInInteropWalkthrough#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--calling-code-in-a-vsto-add-in-from-vba_1.vb)]  
  
4.  Replace the `AddInUtilities` class with the following code.  
  
     [!code[Trin_AddInInteropWalkthrough#3](../VS_officedev/codesnippet/CSharp/walkthrough--calling-code-in-a-vsto-add-in-from-vba_2.cs)]
[!code[Trin_AddInInteropWalkthrough#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--calling-code-in-a-vsto-add-in-from-vba_2.vb)]  
  
     This code makes the `AddInUtilities` class visible to COM, and it adds the `ImportData` method to the class. To expose the [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5) interface, the `AddInUtilities` class also has the \<xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute, and it implements an interface that is visible to COM.  
  
## Exposing the Class to Other Office Solutions  
 To expose the `AddInUtilities` class to other Office solutions, override the \<xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService*> method in the `ThisAddIn` class. In your override, return an instance of the `AddInUtilities` class.  
  
#### To expose the AddInUtilities class to other Office Solutions  
  
1.  In **Solution Explorer**, expand **Excel**.  
  
2.  Right-click **ThisAddIn.cs** or **ThisAddIn.vb**, and then click **View Code**.  
  
3.  Add the following code to the `ThisAddIn` class.  
  
     [!code[Trin_AddInInteropWalkthrough#1](../VS_officedev/codesnippet/CSharp/walkthrough--calling-code-in-a-vsto-add-in-from-vba_3.cs)]
[!code[Trin_AddInInteropWalkthrough#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--calling-code-in-a-vsto-add-in-from-vba_3.vb)]  
  
4.  On the **Build** menu, click **Build Solution**.  
  
     Verify that the solution builds without errors.  
  
## Testing the VSTO Add-in  
 You can call into the `AddInUtilities` class from several different types of Office solutions. In this walkthrough, you will use VBA code in an Excel workbook. For more information about the other types of Office solutions you can also use, see [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md).  
  
#### To test your VSTO Add-in  
  
1.  Press F5 to run your project.  
  
2.  In Excel, save the active workbook as an Excel Macro-Enabled Workbook (*.xlsm). Save it in a convenient location, such as the desktop.  
  
3.  On the Ribbon, click the **Developer** tab.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer Tab on the Ribbon](../VS_officedev/how-to--show-the-developer-tab-on-the-ribbon.md).  
  
4.  In the **Code** group, click **Visual Basic**.  
  
     The Visual Basic Editor opens.  
  
5.  In the **Project** window, double-click **ThisWorkbook**.  
  
     The code file for the `ThisWorkbook` object opens.  
  
6.  Add the following VBA code to the code file. This code first gets a COMAddIn object that represents the **ExcelImportData** VSTO Add-in. Then, the code uses the Object property of the COMAddIn object to call the `ImportData` method.  
  
    ```  
    Sub CallVSTOMethod()  
        Dim addIn As COMAddIn  
        Dim automationObject As Object  
        Set addIn = Application.COMAddIns("ExcelImportData")  
        Set automationObject = addIn.Object  
        automationObject.ImportData  
    End Sub  
    ```  
  
7.  Press F5.  
  
8.  Verify that a new **Imported Data** sheet has been added to the workbook. Also verify that cell A1 contains the string **This is my data**.  
  
9. Exit Excel.  
  
## Next Steps  
 You can learn more about programming VSTO Add-ins from these topics:  
  
-   Use the `ThisAddIn` class to automate the host application and perform other tasks in VSTO Add-in projects. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
-   Create a custom task pane in a VSTO Add-in. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md) and [How to: Add a Custom Task Pane to an Application](../VS_officedev/how-to--add-a-custom-task-pane-to-an-application.md).  
  
-   Customize the Ribbon in a VSTO Add-in. For more information, see [Ribbon Overview](../VS_officedev/ribbon-overview.md) and [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md).  
  
## See Also  
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md)   
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [Customizing UI Features By Using Extensibility Interfaces](../VS_officedev/customizing-ui-features-by-using-extensibility-interfaces.md)  
  
  