---
title: "How to: Create, Open, Save, or Delete a LightSwitch Project"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - projects [Visual Studio LightSwitch]
  - projects [Visual Studio LightSwitch], deleting
  - projects [Visual Studio LightSwitch], creating
  - projects [Visual Studio LightSwitch], adding
ms.assetid: e2b10a16-5cc0-4a13-ac04-3cf1691a4398
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create, Open, Save, or Delete a LightSwitch Project
In Visual Studio LightSwitch, projects are the containers for applications. You can create a project, open an existing project, save changes to a project, or delete a project that you no longer need.  
  
### To create a project  
  
1.  On the menu bar, choose **File**, **New Project.**  
  
     The **New Project** dialog box opens.  
  
2.  In the left-hand pane, choose **Installed Templates**, expand the **Visual Basic** or **Visual C#** node, and then choose the **LightSwitch** node.  
  
3.  In the center pane, choose a project template.  
  
     The right-hand pane displays a description of each project template as you choose it.  
  
4.  In the **Name** text box, enter a name for the new project.  
  
5.  In the **Location** text box, enter the location where the project will be saved.  
  
6.  In the **Solution** list, choose **Create New Solution** to replace the currently open solution, or choose **Add to Solution** to add the new project to the open solution.  
  
7.  If you're using a source code control product to store your code, select the **Add to source control** check box.  
  
8.  Choose the **OK** button to create the project.  
  
### To open an existing project  
  
1.  On the menu bar, choose **File**, **Open Project**.  
  
2.  In the **Open Project** dialog box, browse to the location of the project that you want to open.  
  
3.  Choose the **Close Solution** option button to replace the currently open solution, or choose the **Add to Solution** option button to add the new project to the open solution.  
  
4.  Choose the **Open** button to open the project.  
  
### To save a project  
  
-   On the menu bar, choose **File**, **Save All**.  
  
     The project files are saved to the location that you specified when you created the project.  
  
### To delete a project  
  
-   You can delete a project permanently but not by using LightSwitch. Before you delete a project, save any files that you want to use again in another application. Use **File Explorer** to delete the directory that contains the project files.  
  
### To add a client project to an existing solution  
  
1.  In **Solution Explorer**, choose the project node.  
  
2.  On the menu bar, choose **Project**, **Add Client**.  
  
     The **Add Client** dialog box appears.  
  
3.  In the **Select the type of client to add** list, choose **HTML Client** or **Desktop Client**.  
  
    > [!NOTE]
    >  A project can contain only one HTML client and one desktop client. If the project has been enabled for SharePoint, it can contain only a single client.  
  
4.  In the **Name** text box, enter a name for the client, and then choose the **OK** button.  
  
5.  When you add an HTML client, the project must be upgraded to a new solution model. If you're prompted to upgrade, choose the **OK** button.  
  
     A migration report appears in a browser window when the upgrade is complete.  
  
## See Also  
 [Projects: The Container for Your Application](../vs140/projects--the-container-for-your-lightswitch-application.md)   
 [How to: Manage Project Settings](../vs140/how-to--manage-application-settings-in-lightswitch.md)