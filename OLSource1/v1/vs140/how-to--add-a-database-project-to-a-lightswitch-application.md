---
title: "How to: Add a Database Project to a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6a3698af-80d3-4e2a-9d4f-75763d59088e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Database Project to a LightSwitch Application
If you add a database project to your LightSwitch solution, you can write scripts that update the intrinsic database for your application when you build or deploy it. For example, you can populate a table with data when you deploy the application or change the schema of a database that you've already deployed.  
  
### To add a database project  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Solution** node, choose **Add**, and then choose **New Project**.  
  
2.  In the **Add New Project** dialog box, choose the **SQL Server** node.  
  
3.  In the project list, choose **SQL Server Database Project**.  
  
4.  In the **Name** text box, enter a name for the project, and then choose the **OK** button.  
  
### To associate a database project  
  
1.  In **Solution Explorer**, expand the LightSwitch **Application** node, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  On the **General Properties** tab, in the **SQL Database Project** list, choose the database project.  
  
    > [!NOTE]
    >  You might need to wait while LightSwitch creates the associations.  
  
## See Also  
 [Managing the Intrinsic Database](../vs140/managing-the-intrinsic-database-for-lightswitch.md)   
 [Walkthrough: Using a Database Project with LightSwitch](../vs140/walkthrough--managing-data-in-a--lightswitch-application.md)