---
title: "Grant permissions on data mining structures and models (Analysis Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a0008004-e2b7-47db-acad-5fe7e12b130f
caps.latest.revision: 38
manager: mblythe
---
# Grant permissions on data mining structures and models (Analysis Services)
By default, only an Analysis Services server administrator has permissions to view data mining structures or mining models in the database. Follow the instructions below to grant permissions to non-administrator users.  
  
## Set permissions to access a mining structure  
  
1.  In SSMS, connect to Analysis Services. See [Connect from client applications (Analysis Services)](../../Topics/TopicNameNotContainA/Connect-from-client-applications--Analysis-Services-.md) if you need help with the steps.  
  
2.  Open the **Databases** folder, and select a database in Object Explorer.  
  
3.  Right-click **Roles** and choose **New Role**.  
  
4.  In the General page, enter a name, and optionally, a description. The page also contains several database permissions, such as Full Control, Process Database, and Read Definition. None of these permissions are needed for data mining access. See [Grant database permissions (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-database-permissions--Analysis-Services-.md) for more information about database permissions.  
  
5.  In the **Mining Structure** pane, select **Read** or **Read/Write**  for each data mining structure.  
  
6.  In the **Membership** pane, enter the Windows user and group accounts that connect to Analysis Services using this role.  
  
7.  Click **OK** to finish creating the role.  
  
## Set permissions to access a mining model  
 For a data mining model, a role can have either **Read** or **Read/Write** permissions, as well as **Drillthrough** and **Read Definition** permissions that allow viewing and browsing the underlying data.  
  
 **Note** If you enable drillthrough on both the mining structure and the mining model, any user who is a member of a role that has drillthrough permissions on the mining model and the mining structure can also view columns in the mining structure, even if those columns are not included in the mining model. Therefore, to protect sensitive information, you should set up the data source view to mask personal information, and allow drillthrough access on the mining structure only when necessary.  
  
 To grant read or read/write permissions to a database role, a user must be a member of the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] server role or a member of an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database role that has Full Control (Administrator) permissions.  
  
1.  In [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], connect to the instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)], expand **Roles** for the appropriate database in Object Explorer, and then click a database role (or create a new database role).  
  
2.  In the **Mining Structure** pane, locate the mining model in the **Mining Models** list, and then select **Read**, **Read/Write**, **Drill Through**, or **Browse** for that mining model.  
  
3.  In the **Membership** pane, enter the Windows user and group accounts that connect to Analysis Services using this role.  
  
4.  Click **OK** to finish creating the role.  
  
 To use a data source in a drillthrough query that uses the Data Mining Extensions (DMX) **OPENQUERY** clause, the database role also needs read/write permission on the appropriate data source object. For more information, see [Grant permissions on a data source object (Analysis Services)](../../Topics/TopicNameContainA/Grant-permissions-on-a-data-source-object--Analysis-Services-.md) and [OPENQUERY (DMX)](assetId:///fe57f3a3-a8e6-402c-995e-bd2fe28a7a7c).  
  
> [!NOTE]  
>  By default, the submission of DMX queries by using **OPENROWSET** is disabled.  
  
## See Also  
 [Grant server admin rights to an  Analysis Services instance](../../Topics/TopicNameNotContainA/Grant-server-admin-rights-to-an--Analysis-Services-instance.md)   
 [Grant cube or model permissions (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-cube-or-model-permissions--Analysis-Services-.md)   
 [Grant custom access to dimension data (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-custom-access-to-dimension-data--Analysis-Services-.md)   
 [Grant custom access to cell data (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-custom-access-to-cell-data--Analysis-Services-.md)