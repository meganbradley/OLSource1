---
title: "Managing the Intrinsic Database for LightSwitch"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eb27f407-5385-498e-965c-daed2f995398
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Managing the Intrinsic Database for LightSwitch
If your LightSwitch application includes a database project in [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)], you can write scripts to manage the intrinsic database whenever you build or deploy that application. For example, you can populate a table with data or add an index for a non-unique field. When you design a LightSwitch application, you can perform some tasks, such as creating tables and editing data, by using the data designer, but other tasks can only be accomplished by adding SQL Server database project and writing a script. For more information about database-management tasks, see [SQL Server Data Tools (SSDT)](http://msdn.microsoft.com/library/hh272686.aspx).  
  
 You create scripts by using the Transact-SQL language, which is the standard for SQL Server development. See [Transact-SQL Reference](http://msdn.microsoft.com/library/bb510741\(v=sql.105\).aspx).  
  
## Database Projects and LightSwitch  
 When you add a database project to your LightSwitch solution, the contents of that project are incorporated into the intrinsic database that LightSwitch deploys when you build or deploy your application. But you must first associate the database project with the application by opening the Application Designer and then setting the SQL Server Database property. See [How to: Add a Database Project](../vs140/how-to--add-a-database-project-to-a-lightswitch-application.md).  
  
 You can add multiple database projects to a solution, but you can associate only one project at a time with the LightSwitch application. For example, you can write a different build script in a different database project for each environment to which you expect to deploy the application. You could then associate the appropriate project with the solution before each build.  
  
### Post-deployment Scripts  
 If you create a post-deployment script, you can populate data, change a schema, or add an index after you deploy your application. See [Walkthrough: Using a Database Project with LightSwitch](../vs140/walkthrough--managing-data-in-a--lightswitch-application.md).  
  
 Because the script runs every time that you deploy the application, you must ensure that the script doesn't change the database in ways that you don't intend. For example, you can populate a table with data by using an INSERT statement, but you'll probably end up with multiple copies of the same data. Instead, you should avoid duplication by using a MERGE statement. See [Inserting, Updating, and Deleting Data by Using MERGE](http://msdn.microsoft.com/library/bb522522%28v=sql.105%29.aspx).  
  
### Build Scripts  
 A build script changes the intrinsic database while you deploy your application, instead of after you deploy it. Each build script is parsed and compared against the database schema to avoid potential errors, such as attempting to duplicate an index.  
  
## See Also  
 [How to: Add a Database Project](../vs140/how-to--add-a-database-project-to-a-lightswitch-application.md)   
 [Walkthrough: Using a Database Project with LightSwitch](../vs140/walkthrough--managing-data-in-a--lightswitch-application.md)   
 [Intrinsic Database Management with Database Projects](http://blogs.msdn.com/b/lightswitch/archive/2013/07/03/intrinsic-database-management-with-database-projects-chris-rummel.aspx)