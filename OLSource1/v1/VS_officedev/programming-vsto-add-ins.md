---
title: "Programming VSTO Add-Ins"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectItem.Addin"
  - "VST.ProjectItem.AddinProject"
  - "thisAddIn"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "ICustomTaskPaneConsumer interface"
  - "add-ins [Office development in Visual Studio], programming"
  - "IRibbonExtensibility interface"
  - "UI customizing [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], application-level add-ins"
  - "programming [Office development in Visual Studio], application-level add-ins"
  - "ThisAddIn class"
  - "user interfaces [Office development in Visual Studio], customizing"
  - "writing code for Office solutions"
  - "host items [Office development in Visual Studio], AddIn"
  - "application development [Office development in Visual Studio], application-level add-ins"
  - "add-ins [Office development in Visual Studio], ThisAddIn class"
  - "application-level add-ins [Office development in Visual Studio], ThisAddIn class"
  - "FormRegionStartup interface"
  - "ThisAddIn_Startup"
  - "application-level add-ins [Office development in Visual Studio], programming"
  - "ThisAddIn_Shutdown"
ms.assetid: c534786d-2833-4afa-9e4c-4633f46b9eed
caps.latest.revision: 70
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
# Programming VSTO Add-Ins
  When you extend a Microsoft Office application by creating a VSTO Add-in, you write code directly against the `ThisAddIn` class in your project. You can use this class to perform tasks such as accessing the object model of the Microsoft Office host application, customizing the user interface (UI) of the application, and exposing objects in your VSTO Add-in to other Office solutions.  
  
 [!INCLUDE[appliesto_allapp](../VS_officedev/includes/appliesto_allapp_md.md)]  
  
 Some aspects of writing code in VSTO Add-in projects are different from other types of projects in Visual Studio. Many of these differences are caused by the way the Office object models are exposed to managed code. For more information, see [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md).  
  
 For general information about VSTO Add-ins and other types of solutions you can create by using the Office development tools in Visual Studio, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
## Using the ThisAddIn Class  
 You can start writing your VSTO Add-in code in the `ThisAddIn` class. Visual Studio automatically generates this class in the ThisAddIn.vb (in [!INCLUDE[vbprvb](../VS_officedev/includes/vbprvb_md.md)]) or ThisAddIn.cs (in C#) code file in your VSTO Add-in project. The [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] automatically instantiates this class for you when the Microsoft Office application loads your VSTO Add-in.  
  
 There are two default event handlers in the `ThisAddIn` class. To run code when the VSTO Add-in is loaded, add code to the `ThisAddIn_Startup` event handler. To run code just before the VSTO Add-in is unloaded, add code to the `ThisAddIn_Shutdown` event handler. For more information about these event handlers, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
> [!NOTE]  
>  In Outlook, by default the `ThisAddIn_Shutdown` event handler is not always called when the VSTO Add-in is unloaded. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
### Accessing the Object Model of the Host Application  
 To access the object model of the host application, use the `Application` field of the `ThisAddIn` class. This field returns an object that represents the current instance of the host application. The following table lists the type of the return value for the `Application` field in each VSTO Add-in project.  
  
|Host application|Return value type|  
|----------------------|-----------------------|  
|Microsoft Office Excel|\<xref:Microsoft.Office.Interop.Excel.Application>|  
|Microsoft Office InfoPath|\<xref:Microsoft.Office.Interop.InfoPath.Application>|  
|Microsoft Office Outlook|\<xref:Microsoft.Office.Interop.Outlook.Application>|  
|Microsoft Office PowerPoint|\<xref:Microsoft.Office.Interop.PowerPoint.Application>|  
|Microsoft Office Project|Microsoft.Office.Interop.MSProject.Application|  
|Microsoft Office Visio|Microsoft.Office.Interop.Visio.Application|  
|Microsoft Office Word|\<xref:Microsoft.Office.Interop.Word.Application>|  
  
 The following code example shows how to use the `Application` field to create a new workbook in an VSTO Add-in for Microsoft Office Excel. This example is intended to be run from the `ThisAddIn` class.  
  
```vb#  
Dim newWorkbook As Excel.Workbook = Me.Application.Workbooks.Add()  
```  
  
```c#  
Excel.Workbook newWorkbook = this.Application.Workbooks.Add(System.Type.Missing);  
```  
  
 To do the same thing from outside the `ThisAddIn` class, use the `Globals` object to access the `ThisAddIn` class. For more information about the `Globals` object, see [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md).  
  
```vb#  
Dim newWorkbook As Excel.Workbook = Globals.ThisAddIn.Application.Workbooks.Add()  
```  
  
```c#  
Excel.Workbook newWorkbook = Globals.ThisAddIn.Application.Workbooks.Add(System.Type.Missing);  
```  
  
 For more information about the object models of specific Microsoft Office applications, see the following topics:  
  
-   [Excel Object Model Overview](../VS_officedev/excel-object-model-overview.md)  
  
-   [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)  
  
-   [Outlook Object Model Overview](../VS_officedev/outlook-object-model-overview.md)  
  
-   [InfoPath Solutions](../VS_officedev/infopath-solutions.md)  
  
-   [PowerPoint Solutions](../VS_officedev/powerpoint-solutions.md)  
  
-   [Project Solutions](../VS_officedev/project-solutions.md)  
  
-   [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)  
  
###  <a name="AccessingDocuments"></a> Accessing a Document When the Office Application Starts  
 Not all [!INCLUDE[office14_long](../VS_officedev/includes/office14_long_md.md)] applications automatically open a document when you start them, and none of the [!INCLUDE[Office_15_short](../VS_officedev/includes/office_15_short_md.md)] applications open a document when you start them. Therefore, don’t add code in the `ThisAdd-In_Startup` event handler if the code requires a document to be open. Instead, add that code to an event that the Office application raises when a user creates or opens a document. That way, you can guarantee that a document is open before your code performs operations on it.  
  
 The following code example works with a document in Word only when the user creates a document or opens an existing document.  
  
 [!code[Trin_WordAddIn_Menus#3](../VS_officedev/codesnippet/CSharp/programming-vsto-add-ins_1.cs)]
[!code[Trin_WordAddIn_Menus#3](../VS_officedev/codesnippet/VisualBasic/programming-vsto-add-ins_1.vb)]  
  
### ThisAddIn Members to Use for Other Tasks  
 The following table describes other common tasks and shows which members of the `ThisAddIn` class you can use to perform the tasks.  
  
|Task|Member to use|  
|----------|-------------------|  
|Run code to initialize the VSTO Add-in when the VSTO Add-in is loaded.|Add code to the `ThisAddIn_Startup` method. This is the default event handler for the \<xref:Microsoft.Office.Tools.AddInBase.Startup> event. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).|  
|Run code to clean up resources used by the VSTO Add-in before the VSTO Add-in is unloaded.|Add code to the `ThisAddIn_Shutdown` method. This is the default event handler for the \<xref:Microsoft.Office.Tools.AddInBase.Shutdown> event. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md). **Note:**  In Outlook, by default the `ThisAddIn_Startup` event handler is not always called when the VSTO Add-in is unloaded. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).|  
|Display a custom task pane.|Use the `CustomTaskPanes` field. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md).|  
|Expose objects in your VSTO Add-in to other Microsoft Office solutions.|Override the \<xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService*> method. For more information, see [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md).|  
|Customize a feature in the Microsoft Office system by implementing an extensibility interface.|Override the \<xref:Microsoft.Office.Tools.AddInBase.RequestService*> method to return an instance of a class that implements the interface. For more information, see [Customizing UI Features By Using Extensibility Interfaces](../VS_officedev/customizing-ui-features-by-using-extensibility-interfaces.md). **Note:**  To customize the ribbon UI, you can also override the \<xref:Microsoft.Office.Tools.AddInBase.CreateRibbonExtensibilityObject*> method.|  
  
### Understanding the Design of the ThisAddIn Class  
 In projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)], \<xref:Microsoft.Office.Tools.AddIn> is an interface. The `ThisAddIn` class derives from the \<xref:Microsoft.Office.Tools.AddInBase> class. This base class redirects all calls to its members to an internal implementation of the \<xref:Microsoft.Office.Tools.AddIn> interface in the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)].  
  
 In VSTO Add-in projects for Outlook, the `ThisAddIn` class derives from the Microsoft.Office.Tools.Outlook.OutlookAddIn class in projects that target the .NET Framework 3.5, and from \<xref:Microsoft.Office.Tools.Outlook.OutlookAddInBase> in projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)]. These base classes provide some additional functionality to support form regions. For more information about form regions, see [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md).  
  
## Customizing the User Interface of Microsoft Office Applications  
 You can programmatically customize the UI of Microsoft Office applications by using a VSTO Add-in. For example, you can customize the ribbon, display a custom task pane, or create a custom form region in Outlook. For more information, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
 Visual Studio provides designers and classes that you can use to create custom task panes, ribbon customizations, and Outlook form regions. These designers and classes help to simplify the process of customizing these features. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md), [Ribbon Designer](../VS_officedev/ribbon-designer.md), and [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md).  
  
 If you want to customize one of these features in a way that is not supported by the classes and designers, you can also customize these features by implementing an *extensibility interface* in your VSTO Add-in. For more information, see [Customizing UI Features By Using Extensibility Interfaces](../VS_officedev/customizing-ui-features-by-using-extensibility-interfaces.md).  
  
 In addition, you can modify the UI of Word documents and Excel workbooks by generating host items that extend the behavior of documents and workbooks. This enables you to add managed controls to documents and worksheets. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## Calling Code in VSTO Add-ins from Other Solutions  
 You can expose objects in your VSTO Add-in to other solutions, including other Office solutions. This is useful if your VSTO Add-in provides a service that you want to enable other solutions to use. For example, if you have an VSTO Add-in for Microsoft Office Excel that performs calculations on financial data from a web service, other solutions can perform these calculations by calling into the Excel VSTO Add-in at run time.  
  
 For more information, see [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md).  
  
## See Also  
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Calling Code in VSTO Add-ins from Other Office Solutions](../VS_officedev/calling-code-in-vsto-add-ins-from-other-office-solutions.md)   
 [Walkthrough: Calling Code in a VSTO Add-in from VBA](../VS_officedev/walkthrough--calling-code-in-a-vsto-add-in-from-vba.md)   
 [Customizing UI Features By Using Extensibility Interfaces](../VS_officedev/customizing-ui-features-by-using-extensibility-interfaces.md)   
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)  
  
  