---
title: "How to: Add a Custom Task Pane to an Application"
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
  - "task panes [Office development in Visual Studio], adding to application"
  - "custom task panes [Office development in Visual Studio], adding to application"
ms.assetid: 67b4ed5b-d77e-4630-b851-34bb25bdc9b3
caps.latest.revision: 28
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
# How to: Add a Custom Task Pane to an Application
  You can add a custom task pane to the applications listed above by using VSTO Add-in. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md).  
  
 [!INCLUDE[appliesto_olkallapp](../VS_officedev/includes/appliesto_olkallapp_md.md)]  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Adding a Custom Task Pane to an Application  
  
#### To add a custom task pane to an application  
  
1.  Open or create a VSTO Add-in project for one of the applications listed above. For more information, see [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md).  
  
2.  On the **Project** menu, click **Add User Control**.  
  
3.  In the **Add New Item** dialog box, change the name of the new user control to **MyUserControl**, and then click **Add**.  
  
     The user control opens in the designer.  
  
4.  Add one or more Windows Forms controls from the **Toolbox** to the user control.  
  
5.  Open the **ThisAddIn.cs** or **ThisAddIn.vb** code file.  
  
6.  Add the following code to the `ThisAddIn` class. This code declares instances of `MyUserControl` and \<xref:Microsoft.Office.Tools.CustomTaskPane> as members of the `ThisAddIn` class.  
  
     [!code[Trin_TaskPaneBasic#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-custom-task-pane-to-an-application_1.vb)]
[!code[Trin_TaskPaneBasic#1](../VS_officedev/codesnippet/CSharp/how-to--add-a-custom-task-pane-to-an-application_1.cs)]  
  
7.  Add the following code to the `ThisAddIn_Startup` event handler. This code creates a new \<xref:Microsoft.Office.Tools.CustomTaskPane> by adding the `MyUserControl` object to the `CustomTaskPanes` collection. The code also displays the task pane.  
  
     [!code[Trin_TaskPaneBasic#2](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-custom-task-pane-to-an-application_2.vb)]
[!code[Trin_TaskPaneBasic#2](../VS_officedev/codesnippet/CSharp/how-to--add-a-custom-task-pane-to-an-application_2.cs)]  
  
    > [!NOTE]  
    >  This code associates your custom task pane with the active window in the application. For some applications, you might want to modify this code to ensure that the task pane appears with other documents or items in the application. For more information, see [Custom Task Panes](../VS_officedev/custom-task-panes.md).  
  
## See Also  
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Custom Task Panes](../VS_officedev/custom-task-panes.md)   
 [Walkthrough: Automating an Application from a Custom Task Pane](../VS_officedev/walkthrough--automating-an-application-from-a-custom-task-pane.md)  
  
  