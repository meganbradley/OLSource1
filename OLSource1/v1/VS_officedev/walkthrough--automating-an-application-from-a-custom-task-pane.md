---
title: "Walkthrough: Automating an Application from a Custom Task Pane"
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
  - "task panes [Office development in Visual Studio], PowerPoint"
  - "PowerPoint [Office development in Visual Studio], custom task panes"
  - "automating Office applications"
  - "custom task panes [Office development in Visual Studio], automating applications"
  - "custom task panes [Office development in Visual Studio], PowerPoint"
  - "task panes [Office development in Visual Studio], automating applications"
ms.assetid: 77be5ab5-e330-4564-87ec-9cba564ba8f9
caps.latest.revision: 37
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
# Walkthrough: Automating an Application from a Custom Task Pane
  This walkthrough demonstrates how to create a custom task pane that automates PowerPoint. The custom task pane inserts dates into a slide when the user clicks a \<xref:System.Windows.Forms.MonthCalendar> control that is on the custom task pane.  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
 Although this walkthrough uses PowerPoint specifically, the concepts demonstrated by the walkthrough are applicable to any applications that are listed above.  
  
 This walkthrough illustrates the following tasks:  
  
-   Designing the user interface of the custom task pane.  
  
-   Automating PowerPoint from the custom task pane.  
  
-   Displaying the custom task pane in PowerPoint.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../VS_officedev/includes/vsto_vsprereq_md.md)]  
  
-   Microsoft PowerPoint 2010 or [!INCLUDE[PowerPoint_15_short](../VS_officedev/includes/powerpoint_15_short_md.md)].  
  
## Creating the Add-in Project  
 The first step is to create an VSTO Add-in project for PowerPoint.  
  
#### To create a new project  
  
1.  Create a PowerPoint VSTO Add-in project with the name **MyAddIn**, by using the PowerPoint Add-in project template. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
     [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **MyAddIn** project to **Solution Explorer**.  
  
## Designing the User Interface of the Custom Task Pane  
 There is no visual designer for custom task panes, but you can design a user control with the layout you want. Later in this walkthrough, you will add the user control to the custom task pane.  
  
#### To design the user interface of the custom task pane  
  
1.  On the **Project** menu, click **Add User Control**.  
  
2.  In the **Add New Item** dialog box, change the name of the user control to **MyUserControl**, and click **Add**.  
  
     The user control opens in the designer.  
  
3.  From the **Common Controls** tab of the **Toolbox**, drag a **MonthCalendar** control to the user control.  
  
     If the **MonthCalendar** control is larger than the design surface of the user control, resize the user control to fit the **MonthCalendar** control.  
  
## Automating PowerPoint from the Custom Task Pane  
 The purpose of the VSTO Add-in is to put a selected date on the first slide of the active presentation. Use the \<xref:System.Windows.Forms.MonthCalendar.DateChanged> event of the control to add the selected date whenever it changes.  
  
#### To automate PowerPoint from the custom task pane  
  
1.  In the designer, double-click the \<xref:System.Windows.Forms.MonthCalendar> control.  
  
     The **MyUserControl.cs** or **MyUserControl.vb** file opens, and an event handler for the \<xref:System.Windows.Forms.MonthCalendar.DateChanged> event is created.  
  
2.  Add the following code to the top of the file. This code creates aliases for the \<xref:Microsoft.Office.Core> and \<xref:Microsoft.Office.Interop.PowerPoint> namespaces.  
  
     [!code[Trin_TaskPaneMonthCalendar#1](../VS_officedev/codesnippet/CSharp/walkthrough--automating-an-application-from-a-custom-task-pane_1.cs)]
[!code[Trin_TaskPaneMonthCalendar#1](../VS_officedev/codesnippet/VisualBasic/walkthrough--automating-an-application-from-a-custom-task-pane_1.vb)]  
  
3.  Add the following code to the `MyUserControl` class. This code declares a \<xref:Microsoft.Office.Interop.PowerPoint.Shape> object as a member of `MyUserControl`. In the following step, you will use this \<xref:Microsoft.Office.Interop.PowerPoint.Shape> to add a text box to a slide in the active presentation.  
  
     [!code[Trin_TaskPaneMonthCalendar#2](../VS_officedev/codesnippet/CSharp/walkthrough--automating-an-application-from-a-custom-task-pane_2.cs)]
[!code[Trin_TaskPaneMonthCalendar#2](../VS_officedev/codesnippet/VisualBasic/walkthrough--automating-an-application-from-a-custom-task-pane_2.vb)]  
  
4.  Replace the `monthCalendar1_DateChanged` event handler with the following code. This code adds a text box to the first slide in the active presentation, and then adds the currently selected date to the text box. This code uses the `Globals.ThisAddIn` object to access the object model of PowerPoint.  
  
     [!code[Trin_TaskPaneMonthCalendar#3](../VS_officedev/codesnippet/CSharp/walkthrough--automating-an-application-from-a-custom-task-pane_3.cs)]
[!code[Trin_TaskPaneMonthCalendar#3](../VS_officedev/codesnippet/VisualBasic/walkthrough--automating-an-application-from-a-custom-task-pane_3.vb)]  
  
5.  In **Solution Explorer**, right-click the **MyAddIn** project and then click **Build**. Verify that the project builds without errors.  
  
## Displaying the Custom Task Pane  
 To display the custom task pane when the VSTO Add-in starts, add the user control to the task pane in the \<xref:Microsoft.Office.Tools.AddIn.Startup> event handler of the VSTO Add-in.  
  
#### To display the custom task pane  
  
1.  In **Solution Explorer**, expand **PowerPoint**.  
  
2.  Right-click **ThisAddIn.cs** or **ThisAddIn.vb** and click **View Code**.  
  
3.  Add the following code to the `ThisAddIn` class. This code declares instances of `MyUserControl` and \<xref:Microsoft.Office.Tools.CustomTaskPane> as members of the `ThisAddIn` class.  
  
     [!code[Trin_TaskPaneMonthCalendar#4](../VS_officedev/codesnippet/VisualBasic/walkthrough--automating-an-application-from-a-custom-task-pane_4.vb)]
[!code[Trin_TaskPaneMonthCalendar#4](../VS_officedev/codesnippet/CSharp/walkthrough--automating-an-application-from-a-custom-task-pane_4.cs)]  
  
4.  Replace the `ThisAddIn_Startup` event handler with the following code. This code creates a new \<xref:Microsoft.Office.Tools.CustomTaskPane> by adding the `MyUserControl` object to the `CustomTaskPanes` collection. The code also displays the task pane.  
  
     [!code[Trin_TaskPaneMonthCalendar#5](../VS_officedev/codesnippet/VisualBasic/walkthrough--automating-an-application-from-a-custom-task-pane_5.vb)]
[!code[Trin_TaskPaneMonthCalendar#5](../VS_officedev/codesnippet/CSharp/walkthrough--automating-an-application-from-a-custom-task-pane_5.cs)]  
  
## Testing the Add-In  
 When you run the project, PowerPoint opens and the VSTO Add-in displays the custom task pane. Click the \<xref:System.Windows.Forms.MonthCalendar> control to test the code.  
  
#### To test your VSTO Add-in  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the custom task pane is visible.  
  
3.  Click a date in the \<xref:System.Windows.Forms.MonthCalendar> control on the task pane.  
  
     The date is inserted into the first slide in the active presentation.  
  
## Next Steps  
 You can learn more about how to create custom task panes from these topics:  
  
-   Create a custom task pane in an VSTO Add-in for a different application. For more information about the applications that support custom task panes, see [Custom Task Panes](../VS_officedev/custom-task-panes.md).  
  
-   Create a Ribbon button that can be used to hide or display a custom task pane. For more information, see [Walkthrough: Synchronizing a Custom Task Pane with a Ribbon Button](../VS_officedev/walkthrough--synchronizing-a-custom-task-pane-with-a-ribbon-button.md).  
  
-   Create a custom task pane for every e-mail message that is opened in Outlook. For more information, see [Walkthrough: Displaying Custom Task Panes with E-Mail Messages in Outlook](../VS_officedev/walkthrough--displaying-custom-task-panes-with-e-mail-messages-in-outlook.md).  
  
## See Also  
 [Custom Task Panes](../VS_officedev/custom-task-panes.md)   
 [How to: Add a Custom Task Pane to an Application](../VS_officedev/how-to--add-a-custom-task-pane-to-an-application.md)   
 [Walkthrough: Synchronizing a Custom Task Pane with a Ribbon Button](../VS_officedev/walkthrough--synchronizing-a-custom-task-pane-with-a-ribbon-button.md)   
 [Walkthrough: Displaying Custom Task Panes with E-Mail Messages in Outlook](../VS_officedev/walkthrough--displaying-custom-task-panes-with-e-mail-messages-in-outlook.md)  
  
  