---
title: "Walkthrough: Creating Your First VSTO Add-in for PowerPoint"
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
  - "application-level add-ins [Office development in Visual Studio], creating your first project"
  - "Office development in Visual Studio, creating your first project"
  - "PowerPoint [Office development in Visual Studio], creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
ms.assetid: 52d1543a-c9cb-4ee1-aa5b-90759fce9d3a
caps.latest.revision: 34
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
# Walkthrough: Creating Your First VSTO Add-in for PowerPoint
  This walkthrough shows you how to create an VSTO Add-in for Microsoft Office PowerPoint. The features that you create in this kind of solution are available to the application itself, regardless of which presentations are open. For more information, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
 [!INCLUDE[appliesto_pptallapp](../VS_officedev/includes/appliesto_pptallapp_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating a PowerPoint VSTO Add-in project for PowerPoint.  
  
-   Writing code that uses the object model of PowerPoint to add a text box to each new slide.  
  
-   Building and running the project to test it.  
  
-   Cleaning up the project so that the VSTO Add-in no longer runs automatically on your development computer.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   PowerPoint  
  
## Creating the Project  
  
#### To create a new project  
  
1.  Start [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **Project**.  
  
3.  In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.  
  
4.  Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.  
  
5.  In the list of project templates, select a PowerPoint VSTO Add-in project.  
  
6.  In the **Name** box, type **FirstPowerPointAddIn**.  
  
7.  Click **OK**.  
  
     [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] creates the **FirstPowerPointAddIn** project and opens the **ThisAddIn** code file in the editor.  
  
## Writing Code that Adds Text to Each New Slide  
 Next, add code to the ThisAddIn code file. The new code uses the object model of PowerPoint to add a text box to each new slide. By default, the ThisAddIn code file contains the following generated code:  
  
-   A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of PowerPoint. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.  
  
-   The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when PowerPoint loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your VSTO Add-in when it is unloaded. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
#### To add a text box to each new slide  
  
1.  In the ThisAddIn code file, add the following code to the `ThisAddIn` class. This code defines an event handler for the \<xref:Microsoft.Office.Interop.PowerPoint.EApplication_Event.PresentationNewSlide> event of the \<xref:Microsoft.Office.Interop.PowerPoint.Application> object.  
  
     When the user adds a new slide to the active presentation, this event handler adds a text box to the top of the new slide, and it adds some text to the text box.  
  
     [!code[Trin_PowerPointAddInTutorial#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-your-first-vsto-add-in-for-powerpoint_1.vb)]
[!code[Trin_PowerPointAddInTutorial#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-your-first-vsto-add-in-for-powerpoint_1.cs)]  
  
2.  If you are using C#, add the following code to the `ThisAddIn_Startup` event handler. This code is required to connect the `Application_PresentationNewSlide` event handler with the \<xref:Microsoft.Office.Interop.PowerPoint.EApplication_Event.PresentationNewSlide> event.  
  
     [!code[Trin_PowerPointAddInTutorial#2](../VS_officedev/codesnippet/CSharp/walkthrough--creating-your-first-vsto-add-in-for-powerpoint_2.cs)]  
  
 To modify each new slide, the previous code examples use the following objects:  
  
-   The `Application` field of the `ThisAddIn` class. The `Application` field returns an \<xref:Microsoft.Office.Interop.PowerPoint.Application> object, which represents the current instance of PowerPoint.  
  
-   The `Sld` parameter of the event handler for the \<xref:Microsoft.Office.Interop.PowerPoint.EApplication_Event.PresentationNewSlide> event. The `Sld` parameter is a \<xref:Microsoft.Office.Interop.PowerPoint.Slide> object, which represents the new slide. For more information, see [PowerPoint Solutions](../VS_officedev/powerpoint-solutions.md).  
  
## Testing the Project  
 When you build and run the project, verify that the text box appears in new slides that you add to a presentation.  
  
#### To test the project  
  
1.  Press **F5** to build and run your project.  
  
     When you build the project, the code is compiled into an assembly that is put in the build output folder for the project. Visual Studio also creates a set of registry entries that enable PowerPoint to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Building Office Solutions](../VS_officedev/building-office-solutions.md).  
  
2.  In PowerPoint, add a new slide to the active presentation.  
  
3.  Verify that the following text is added to a new text box at the top of the slide.  
  
     **This text was added by using code.**  
  
4.  Close PowerPoint.  
  
## Cleaning up the Project  
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will run every time you open PowerPoint on the development computer.  
  
#### To clean up your project  
  
1.  In Visual Studio, on the **Build** menu, click **Clean Solution**.  
  
## Next Steps  
 Now that you have created a basic VSTO Add-in for PowerPoint, you can learn more about how to develop VSTO Add-ins from these topics:  
  
-   General programming tasks that you can perform in VSTO Add-ins for PowerPoint. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
-   Using the object model of PowerPoint. For more information, see [PowerPoint Solutions](../VS_officedev/powerpoint-solutions.md).  
  
-   Customizing the UI of PowerPoint, for example, by adding a custom tab to the Ribbon or creating your own custom task pane. For more information, see [Office UI Customization](../VS_officedev/office-ui-customization.md).  
  
-   Building and debugging VSTO Add-ins for PowerPoint. For more information, see [Building Office Solutions](../VS_officedev/building-office-solutions.md).  
  
-   Deploying VSTO Add-ins for PowerPoint. For more information, see [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md).  
  
## See Also  
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [PowerPoint Solutions](../VS_officedev/powerpoint-solutions.md)   
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Building Office Solutions](../VS_officedev/building-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md)  
  
  