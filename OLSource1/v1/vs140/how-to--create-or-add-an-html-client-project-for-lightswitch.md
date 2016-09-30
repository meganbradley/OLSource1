---
title: "How to: Create or Add an HTML Client Project for LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2c04c6d9-961a-4d18-850e-e22b576439a2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create or Add an HTML Client Project for LightSwitch
You can use an HTML client project to add cross-browser, mobile web client capabilities to your Visual Studio LightSwitch application. HTML clients are based on HTML5 and JavaScript and optimized for touch-first displays on mobile devices, such as tablet computers that are running a variety of operating systems.  
  
 You can add an **HTML Client** project to an existing LightSwitch desktop or web application, or you can create a solution that contains only an **HTML Client** project. In either case, a single **Server** project contains the data layer for your application. Each solution can contain one **HTML Client** project and one **Desktop Client** project.  
  
> [!NOTE]
>  LightSwitch apps for SharePoint can have only a single client project, either **HTML Client** or **Desktop Client**.  
  
### To create an HTML client solution  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog box, choose either the **LightSwitch HTML Application (VB)** or **LightSwitch HTML Application (C#)** template.  
  
    > [!NOTE]
    >  JavaScript is the programming language for the **HTML Client** project. Depending on your choice, either Visual Basic or C# is the programming language for the **Server** project.  
  
3.  Name the project, and then choose the **OK** button.  
  
     The solution is added to **Solution Explorer** with **Server** and **Client** projects.  
  
### To add an HTML client project to an existing solution  
  
1.  In **Solution Explorer**, choose the **Solution** node.  
  
2.  On the menu bar, choose **Project**, **Add Client**.  
  
3.  In the **Add Client** dialog box, choose **HTML Client**.  
  
4.  Name the project, and then choose the **OK** button.  
  
     A client project is added to **Solution Explorer** and set as the **Startup** project.  
  
## See Also  
 [HTML Client Applications in LightSwitch](../vs140/html-client-screens-for-lightswitch-apps.md)   
 [How to: Create, Open, Save, or Delete a Project](../vs140/how-to--create--open--save--or-delete-a-lightswitch-project.md)