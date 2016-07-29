---
title: "Create a Publication from an Oracle Database"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b3812746-14b0-4b22-809e-b4a95e1c8083
caps.latest.revision: 39
manager: jhubbard
---
# Create a Publication from an Oracle Database
This topic describes how to create a publication from an Oracle database in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)].  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Prerequisites](#Prerequisites)  
  
-   **To create a publication from an Oracle database, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Prerequisites"></a> Prerequisites  
  
-   Before creating a publication, you must install Oracle software on the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Distributor, and you must configure the Oracle database. For more information, see [Configure an Oracle Publisher](../../Topics/TopicNameNotContainA/Configure-an-Oracle-Publisher.md).  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 Create a snapshot or transactional publication from an Oracle Database with the New Publication Wizard.  
  
 The first time you create a publication from an Oracle database, you must identify the Oracle Publisher at the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Distributor (you do not need to do this for subsequent publications from the same database.). Identifying the Oracle Publisher can be accomplished from the New Publication Wizard or the **Distributor Properties - <Distributor\>** dialog box; this topic shows the **Distributor Properties - <Distributor\>** dialog box.  
  
#### To identify the Oracle Publisher at the SQL Server Distributor  
  
1.  In [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], connect to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance that the Oracle Publisher will use as a Distributor, and then expand the server node.  
  
2.  Right-click the **Replication** folder, and then click **Distributor Properties**.  
  
3.  On the **Publishers** page of the **Distributor Properties - <Distributor\>** dialog box, click **Add**, and then click **Add Oracle Publisher**.  
  
4.  In the **Connect to Server** dialog box, click the **Options** button.  
  
5.  On the **Login** tab:  
  
    1.  Enter the Oracle database instance name or select **Browse for more** in the **Server instance** combo box.  
  
    2.  Select **Oracle Standard Authentication** (recommended) or **Windows Authentication**.  
  
         If you select **Windows Authentication**: the Oracle server must be configured to allow connections using Windows credentials (for more information, see the Oracle documentation); and you must be currently logged in with the same [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows account you specified for the replication administrative user schema.  
  
    3.  If you select **Oracle Standard Authentication**, enter the login and password of the replication administrative user schema you created on the Oracle Publisher during configuration.  
  
6.  On the **Connection Properties** tab, select a Publisher type of **Gateway** or **Complete**.  
  
     The **Complete** option is designed to provide snapshot and transactional publications with the complete set of supported features for Oracle publishing. The **Gateway** option provides specific design optimizations to improve performance for cases where replication serves as a gateway between systems. The **Gateway** option cannot be used if you plan to publish the same table in multiple transactional publications. A table can appear in at most one transactional publication and any number of snapshot publications if you select **Gateway**.  
  
7.  Click **Connect**, which creates a connection to the Oracle Publisher and configures it for replication. The **Connect to Server** dialog box closes and you are returned to the **Distributor Properties - <Distributor\>** dialog box.  
  
    > [!NOTE]  
    >  If there are any problems with the network configuration, you will receive an error at this point. If you experience problems connecting to the Oracle database, see the section "The SQL Server Distributor cannot connect to the Oracle database instance" in [Troubleshooting Oracle Publishers](../../Topics/TopicNameNotContainA/Troubleshooting-Oracle-Publishers.md).  
  
8.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
#### To create a publication from an Oracle database  
  
1.  Connect to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance that the Oracle Publisher will use as a Distributor, and then expand the server node.  
  
2.  Expand the **Replication** folder.  
  
3.  Right-click the **Local Publications** folder, and then click **New Oracle Publication**.  
  
4.  On the **Oracle Publisher** page of the New Publication Wizard, select the Oracle Publisher. If the Oracle Publisher is not displayed, click **Add Oracle Publisher**, which takes you through the steps from the previous procedure.  
  
5.  On the **Publication Type** page, select **Snapshot publication** or **Transactional publication**.  
  
6.  On the **Articles** page, select the database objects you want to publish.  
  
     Optionally, filter out table columns by expanding a table and then clearing the checkbox for one or more columns. Click **Article Properties** to view and modify article properties and to specify alternative data type mappings if necessary. For more information about data type mappings, see [Specify Data Type Mappings for an Oracle Publisher](../../Topics/TopicNameNotContainA/Specify-Data-Type-Mappings-for-an-Oracle-Publisher.md).  
  
7.  On the **Filter Table Rows** page, optionally apply filters to publish a subset of data from one or more tables.  
  
8.  On the **Snapshot Agent** page, clear **Create a snapshot immediately** only if you have created all objects and added all required data in the subscription database.  
  
9. On the **Agent Security** page, specify credentials for the Snapshot Agent (for all publications) and the Log Reader Agent (for transactional publications). The agents run and make connections to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Distributor using the context of the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows account you specify. The agents make connections to the Oracle database using the context of the account you specified as the replication administrative user schema. For more information, see [Configure an Oracle Publisher](../../Topics/TopicNameNotContainA/Configure-an-Oracle-Publisher.md).  
  
     For more information about the permissions required by each agent, see [Replication Agent Security Model](../../Topics/TopicNameNotContainA/Replication-Agent-Security-Model.md) and [Replication Security Best Practices](../../Topics/TopicNameNotContainA/Replication-Security-Best-Practices.md).  
  
10. On the **Wizard Actions** page, optionally script the publication. For more information, see [Scripting Replication](../../Topics/TopicNameNotContainA/Scripting-Replication.md).  
  
11. On the **Complete the Wizard** page, specify a name for the publication.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 After the Oracle database has been configured as a Publisher, you can create a transactional or snapshot publication the same way that you would from a [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Publisher, by using system stored procedures.  
  
#### To create an Oracle Publication  
  
1.  Configure the Oracle database as a Publisher. For more information, see [Configure an Oracle Publisher](../../Topics/TopicNameNotContainA/Configure-an-Oracle-Publisher.md).  
  
2.  If a remote Distributor does not exist, configure the remote Distributor. For more information, see [Configure Publishing and Distribution](../../Topics/TopicNameNotContainA/Configure-Publishing-and-Distribution.md).  
  
3.  At the remote Distributor that the Oracle Publisher will use, execute [sp_adddistpublisher](assetId:///04e15011-a902-4074-b38c-3ec2fc73b838). Specify the Transparent Network Substrate (TNS) name of the Oracle database instance for **@publisher** and a value of **ORACLE** or **ORACLE GATEWAY** for **@publisher_type**. `Specify` the security mode used when connecting from the Oracle Publisher to the remote [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Distributor as one of the following:  
  
    -   To use Oracle Standard Authentication, the default, specify a value of **0** for **@security_mode**, the login of the replication administrative user schema you created on the Oracle Publisher during configuration for **@login**, and the password for **@password**.  
  
        > [!IMPORTANT]  
        >  When possible, prompt users to enter security credentials at runtime. If you store credentials in a script file, you must secure the file to prevent unauthorized access.  
  
    -   To use Windows Authentication, specify a value of **1** for **@security_mode**.  
  
        > [!NOTE]  
        >  To use Windows Authentication, the Oracle server must be configured to allow connections using Windows credentials (for more information, see the Oracle documentation); and you must be currently logged in with the same Microsoft Windows account you specified for the replication administrative user schema..  
  
4.  Create a Log Reader Agent job for the publication database.  
  
    -   If you are unsure whether a Log Reader Agent job exists for a published database, execute [sp_helplogreader_agent](assetId:///ff837209-e2b3-481a-a48f-8530bfe53d97) at the Distributor used by the Oracle Publisher on the distribution database. Specify the name of the Oracle Publisher for **@publisher**. If the result set is empty, then a Log Reader Agent job must be created.  
  
    -   If a Log Reader Agent job already exists for the publication database, proceed to step 5.  
  
    -   At the Distributor used by the Oracle Publisher on the distribution database, execute [sp_addlogreader_agent](assetId:///d83096b9-96ee-4789-bde0-940d4765b9ed). Specify the Windows credentials under which the agent runs for **@job_login** and **@job_password**.  
  
        > [!NOTE]  
        >  The **@job_login** parameter must match the login supplied in step 3. Do not supply publisher security information. The Log Reader agent connects to the Publisher using the security information provided in step 3.  
  
5.  At the Distributor on the distribution database, execute [sp_addpublication](assetId:///c7167ed1-2b7e-4824-b82b-65f4667c4407) to create the publication. For more information, see [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md).  
  
6.  At the Distributor on the distribution database, execute [sp_addpublication_snapshot](assetId:///192b6214-df6e-44a3-bdd4-9d933a981619). Specify the publication name used in step 4 for **@publication** and the Windows credentials under which the Snapshot Agent runs for **@job_name** and **@password**. To use Oracle Standard Authentication when connecting to the Publisher, you must also specify a value of **0** for **@publisher_security_mode** and the Oracle login information for **@publisher_login** and **@publisher_password**. This creates a Snapshot Agent job for the publication.  
  
## See Also  
 [Configure an Oracle Publisher](../../Topics/TopicNameNotContainA/Configure-an-Oracle-Publisher.md)   
 [Publish Data and Database Objects](../../Topics/TopicNameNotContainA/Publish-Data-and-Database-Objects.md)   
 [Configure the Transaction Set Job for an Oracle Publisher (Replication Transact-SQL Programming)](../../Topics/TopicNameNotContainA/Configure-the-Transaction-Set-Job-for-an-Oracle-Publisher--Replication-Transact-SQL-Programming-.md)   
 [Oracle Publishing Overview](../../Topics/TopicNameNotContainA/Oracle-Publishing-Overview.md)   
 [Script to Grant Oracle Permissions](../../Topics/TopicNameNotContainA/Script-to-Grant-Oracle-Permissions.md)