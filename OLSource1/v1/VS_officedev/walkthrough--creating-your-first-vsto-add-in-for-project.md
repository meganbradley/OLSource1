---
title: "Walkthrough: Creating Your First VSTO Add-in for Project"
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
  - "Project [Office development in Visual Studio], creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
ms.assetid: da2b727e-6db8-4853-bf00-7afe0ef13213
caps.latest.revision: 28
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
# Walkthrough: Creating Your First VSTO Add-in for Project
  This walkthrough shows you how to create an VSTO Add-in for Microsoft Office Project. The features that you create in this kind of solution are available to the application itself, regardless of which projects are open. For more information, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
 [!INCLUDE[appliesto_projallapp](../VS_officedev/includes/appliesto_projallapp_md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating a Project VSTO Add-in project.  
  
-   Writing code that uses the object model of Project to add a task to a new project.  
  
-   Building and running the project to test it.  
  
-   Cleaning up the completed project so that the VSTO Add-in no longer runs automatically on your development computer.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   [!INCLUDE[Project_15_short](../VS_officedev/includes/project_15_short_md.md)] or [!INCLUDE[Project_14_short](../VS_officedev/includes/project_14_short_md.md)].  
  
## Creating the Project  
  
#### To create a new project in Visual Studio  
  
1.  Start [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **Project**.  
  
3.  In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.  
  
4.  Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.  
  
5.  In the list of project templates, select **Project 2010 Add-in** or **Project 2013 Add-in**.  
  
6.  In the **Name** box, type **FirstProjectAddIn**.  
  
7.  Click **OK**.  
  
     [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] creates the **FirstProjectAddIn** project and opens the **ThisAddIn** code file in the editor.  
  
## Writing Code that Adds a New Task to a Project  
 Next, add code to the ThisAddIn code file. The new code uses the object model of Project to add a new task to a project. By default, the ThisAddIn code file contains the following generated code:  
  
-   A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of Project. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.  
  
-   The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when Project loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your VSTO Add-in when it is unloaded. For more information, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
#### To add a task to a new project  
  
1.  In the ThisAddIn code file, add the following code to the `ThisAddIn` class. This code defines an event handler for the NewProject event of the Microsoft.Office.Interop.MSProject.Application class.  
  
     When the user creates a new project, this event handler adds a task to the project.  
  
     [!code[Trin_ProjectAddInTutorial#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--creating-your-first-vsto-add-in-for-project_1.vb)]
[!code[Trin_ProjectAddInTutorial#1](../VS_officedev/codesnippet/CSharp/walkthrough--creating-your-first-vsto-add-in-for-project_1.cs)]  
  
 To modify the project, this code example use the following objects:  
  
-   The `Application` field of the `ThisAddIn` class. The `Application` field returns an Microsoft.Office.Interop.MSProject.Application object, which represents the current instance of Project.  
  
-   The `pj` parameter of the event handler for the NewProject event. The `pj` parameter is a Microsoft.Office.Interop.MSProject.Project object, which represents the project. For more information, see [Project Solutions](../VS_officedev/project-solutions.md).  
  
1.  If you are using C#, add the following code to the `ThisAddIn_Startup` event handler. This code connects the `Application_Newproject` event handler with the NewProject event.  
  
     [!code[Trin_ProjectAddInTutorial#2](../VS_officedev/codesnippet/CSharp/walkthrough--creating-your-first-vsto-add-in-for-project_2.cs)]  
  
-  
  
## Testing the Project  
 When you build and run the project, verify that the new task appears in the resulting new project.  
  
#### To test the project  
  
1.  Press **F5** to build and run your project. Microsoft Project starts and automatically opens a new blank project.  
  
     When you build the project, the code is compiled into an assembly that is included in the build output folder for the project. Visual Studio also creates a set of registry entries that enable Project to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Office Solution Build Process Overview](assetId:///a9d12e4f-c9ea-4a62-a841-c42b91f831ee).  
  
2.  Verify that a new task is added to the blank project.  
  
3.  Verify that the following text appears in the **Task Name** field of the task.  
  
     **This text was added by using code.**  
  
4.  Close Microsoft Project.  
  
## Cleaning up the Project  
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will run every time you open Microsoft Project on the development computer.  
  
#### To clean up your project  
  
1.  In Visual Studio, on the **Build** menu, click **Clean Solution**.  
  
## Next Steps  
 Now that you have created a basic VSTO Add-in for Project, you can learn more about how to develop VSTO Add-ins from these topics:  
  
-   General programming tasks that you can perform in VSTO Add-ins for Project: [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md).  
  
-   Using the object model of Project: [Project Solutions](../VS_officedev/project-solutions.md).  
  
-   Building and debugging VSTO Add-ins for Project: [Building Office Solutions](../VS_officedev/building-office-solutions.md).  
  
-   Deploying VSTO Add-ins for Project: [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md).  
  
## See Also  
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Project Solutions](../VS_officedev/project-solutions.md)   
 [Building Office Solutions](../VS_officedev/building-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md)  
  
  