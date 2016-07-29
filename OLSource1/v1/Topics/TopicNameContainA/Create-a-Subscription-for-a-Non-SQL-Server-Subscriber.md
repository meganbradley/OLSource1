---
title: "Create a Subscription for a Non-SQL Server Subscriber"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5020ee68-b988-4d57-8066-67d183e61237
caps.latest.revision: 28
manager: jhubbard
---
# Create a Subscription for a Non-SQL Server Subscriber
This topic describes how to create a subscription for a non-SQL Server Subscriber in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. Transactional and snapshot replication support publishing data to non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers. For information about supported Subscriber platforms, see [Non-SQL Server Subscribers](../../Topics/TopicNameNotContainA/Non-SQL-Server-Subscribers.md).  
  
 **In This Topic**  
  
-   **To create a subscription for a non-SQL Server Subscriber, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 To create a subscription for a non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscriber:  
  
1.  Install and configure the appropriate client software and OLE DB provider(s) on the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Distributor. For more information, see [Oracle Subscribers](../../Topics/TopicNameNotContainA/Oracle-Subscribers.md) and [IBM DB2 Subscribers](../../Topics/TopicNameNotContainA/IBM-DB2-Subscribers.md).  
  
2.  Create a publication using the New Publication Wizard. For more information about creating publications, see [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md) and [Create a Publication from an Oracle Database](../../Topics/TopicNameContainA/Create-a-Publication-from-an-Oracle-Database.md). Specify the following options in the New Publication Wizard:  
  
    -   On the **Publication Type** page, select **Snapshot publication** or **Transactional publication**.  
  
    -   On the **Snapshot Agent** page, clear **Create a snapshot immediately**.  
  
         You create the snapshot after the publication is enabled for non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers to ensure that the Snapshot Agent generates a snapshot and initialization scripts that are suitable for non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers.  
  
3.  Enable the publication for non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers using the **Publication Properties - <PublicationName\>** dialog box. See [Publication Properties, Subscription Options](../../Topics/TopicNameNotContainA/Publication-Properties--Subscription-Options.md) for more information about this step.  
  
4.  Create a subscription using the New Subscription Wizard. This topic provides more information about this step.  
  
5.  (Optional) Change the **pre_creation_cmd** article property to retain tables at the Subscriber. This topic provides more information about this step.  
  
6.  Generate a snapshot for the publication. This topic provides more information about this step.  
  
7.  Synchronize the subscription. For more information, see [Synchronize a Push Subscription](../../Topics/TopicNameContainA/Synchronize-a-Push-Subscription.md).  
  
#### To enable a publication for non-SQL Server Subscribers  
  
1.  Connect to the Publisher in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], and then expand the server node.  
  
2.  Expand the **Replication** folder, and then expand the **Local Publications** folder.  
  
3.  Right-click the publication, and then click **Properties**.  
  
4.  On the **Subscription Options** page, select a value of **True** for the option **Allow non-SQL Server Subscribers**. Selecting this option changes a number of properties so that the publication is compatible with non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers.  
  
    > [!NOTE]  
    >  Selecting **True** sets the value of the **pre_creation_cmd** article property to 'drop'. This setting specifies that replication should drop a table at the Subscriber if it matches the name of the table in the article. If you have existing tables at the Subscriber that you want to keep, use the [sp_changearticle](assetId:///24c33ca5-f03a-4417-a267-131ca5ba6bb5) stored procedure for each article; specify a value 'none' for **pre_creation_cmd**: `sp_changearticle @publication= 'MyPublication', @article= 'MyArticle', @property='pre_creation_cmd', @value='none'`.  
  
5.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)] You will be prompted to create a new snapshot for the publication. If you do not want to create one at this time, use the steps described in the next "how to" procedure at a later time.  
  
#### To create a subscription for a non-SQL Server Subscriber  
  
1.  Expand the **Replication** folder, and then expand the **Local Publications** folder.  
  
2.  Right-click the appropriate publication, and then click **New Subscriptions**.  
  
3.  On the **Distribution Agent Location** page, ensure **Run all agents at the Distributor** is selected. Non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers do not support running agents at the Subscriber.  
  
4.  On the **Subscribers** page, click **Add Subscriber** and then click **Add Non-SQL Server Subscriber**.  
  
5.  In the **Add Non-SQL Server Subscriber** dialog box, select the type of Subscriber.  
  
6.  Enter a value in **Data source name**:  
  
    -   For Oracle, this is the transparent network substrate (TNS) name you configured.  
  
    -   For IBM, this can be any name. It is typical to specify the network address of the Subscriber.  
  
     The data source name entered in this step and the credentials specified in step 9 are not validated by this wizard. They are not used by replication until the Distribution Agent runs for the subscription. Ensure that all values have been tested by connecting to the Subscriber using a client tool (such as **sqlplus** for Oracle). For more information, see [Oracle Subscribers](../../Topics/TopicNameNotContainA/Oracle-Subscribers.md) and [IBM DB2 Subscribers](../../Topics/TopicNameNotContainA/IBM-DB2-Subscribers.md).  
  
7.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)] On the **Subscribers** page of the wizard, the Subscriber is now displayed in the **Subscriber** column with a read-only **(default destination)** in the **Subscription Database** column:  
  
    -   For Oracle, a server has at most one database, so it is not necessary to specify the database.  
  
    -   For IBM DB2, the database is specified in the **Initial Catalog** property of the DB2 connection string, which can be entered in the **Additional connection options** field described later in this process.  
  
8.  On the **Distribution Agent Security** page, click the properties button (**…**) next to the Subscriber to access the **Distribution Agent Security** dialog box.  
  
9. In the **Distribution Agent Security** dialog box:  
  
    -   In the **Process account**, **Password**, and **Confirm password** fields, enter the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows account and password under which the Distribution Agent should run and make local connections to the Distributor.  
  
         The account requires these minimum permissions: member of the **db_owner** fixed database role in the distribution database; member of the publication access list (PAL); read permissions on the snapshot share; and read permission on the install directory of the OLE DB provider. For more information about the PAL, see [Secure the Publisher](../../Topics/TopicNameNotContainA/Secure-the-Publisher.md).  
  
    -   Under **Connect to the Subscriber**, in the **Login**, **Password**, and **Confirm password** fields, enter the login and password that should be used to connect to the Subscriber. This login should already be configured and should have sufficient permissions to create objects in the subscription database.  
  
    -   In the **Additional connection options** field, specify any connection options for the Subscriber in the form of a connection string (Oracle does not require additional options). Each option should be separated by a semi-colon. The following is an example of a DB2 connection string (line breaks are for readability):  
  
        ```  
        Provider=DB2OLEDB;Initial Catalog=MY_SUBSCRIBER_DB;Network Transport Library=TCP;Host CCSID=1252;  
        PC Code Page=1252;Network Address=MY_SUBSCRIBER;Network Port=50000;Package Collection=MY_PKGCOL;  
        Default Schema=MY_SCHEMA;Process Binary as Character=False;Units of Work=RUW;DBMS Platform=DB2/NT;  
        Persist Security Info=False;Connection Pooling=True;  
        ```  
  
         Most of the options in the string are specific to the DB2 server you are configuring, but the **Process Binary as Character** option should always be set to **False**. A value is required for the **Initial Catalog** option to identify the subscription database.  
  
10. On the **Synchronization Schedule** page, select a schedule for the Distribution Agent from the **Agent Schedule** menu (the schedule is typically **Run continuously**).  
  
11. On the **Initialize Subscriptions** page, specify whether the subscription should be initialized and, if so, when it should be initialized:  
  
    -   Clear **Initialize** only if you have created all objects and added all required data in the subscription database.  
  
    -   Select **Immediately** from the drop-down list in the **Initialize When** column to have the Distribution Agent transfer snapshot files to the Subscriber after this wizard is completed. Select **At first synchronization** to have the agent transfer the files the next time it is scheduled to run.  
  
12. On the **Wizard Actions** page, optionally script the subscription. For more information, see [Scripting Replication](../../Topics/TopicNameNotContainA/Scripting-Replication.md).  
  
#### To retain tables at the Subscriber  
  
-   By default, enabling a publication for non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers sets the value of the **pre_creation_cmd** article property to 'drop'. This setting specifies that replication should drop a table at the Subscriber if it matches the name of the table in the article. If you have existing tables at the Subscriber that you want to keep, use the [sp_changearticle](assetId:///24c33ca5-f03a-4417-a267-131ca5ba6bb5) stored procedure for each article; specify a value 'none' for **pre_creation_cmd**. `sp_changearticle @publication= 'MyPublication', @article= 'MyArticle', @property='pre_creation_cmd', @value='none'`.  
  
#### To generate a snapshot for the publication  
  
1.  Expand the **Replication** folder, and then expand the **Local Publications** folder.  
  
2.  Right-click the publication, and then click **View Snapshot Agent Status**.  
  
3.  In the **View Snapshot Agent Status - <Publication\>** dialog box, click **Start**.  
  
 When the Snapshot Agent finishes generating the snapshot, a message is displayed, such as "[100%] A snapshot of 17 article(s) was generated."  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 You can create push subscriptions to non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers programmatically using replication stored procedures.  
  
> [!IMPORTANT]  
>  When possible, prompt users to enter security credentials at runtime. If you must store credentials in a script file, you must secure the file to prevent unauthorized access.  
  
#### To create a push subscription for a transactional or snapshot publication to a non-SQL Server Subscriber  
  
1.  Install the most recent OLE DB provider for the non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscriber at both the Publisher and Distributor. For the replication requirements for an OLE DB provider, see [Non-SQL Server Subscribers](../../Topics/TopicNameNotContainA/Non-SQL-Server-Subscribers.md), [Oracle Subscribers](../../Topics/TopicNameNotContainA/Oracle-Subscribers.md), [IBM DB2 Subscribers](../../Topics/TopicNameNotContainA/IBM-DB2-Subscribers.md).  
  
2.  At the Publisher on the publication database, verify that the publication supports non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers by executing [sp_helppublication (Transact-SQL)](assetId:///e801c3f0-dcbd-4b4a-b254-949a05f63518).  
  
    -   If the value of **enabled_for_het_sub** is 1, non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Subscribers are supported.  
  
    -   If the value of **enabled_for_het_sub** is 0, execute [sp_changepublication (Transact-SQL)](assetId:///c36e5865-25d5-42b7-b045-dc5036225081), specifying **enabled_for_het_sub** for **@property** and **true** for **@value**.  
  
        > [!NOTE]  
        >  Before changing **enabled_for_het_sub** to **true**, you must drop any existing subscriptions to the publication. You cannot set **enabled_for_het_sub** to **true** when the publication also supports updating subscriptions. Changing **enabled_for_het_sub** will affect other publication properties. For more information, see [Non-SQL Server Subscribers](../../Topics/TopicNameNotContainA/Non-SQL-Server-Subscribers.md).  
  
3.  At the Publisher on the publication database, execute [sp_addsubscription (Transact-SQL)](assetId:///61ddf287-1fa0-4c1a-8657-ced50cebf0e0). Specify **@publication**, **@subscriber**, a value of **(default destination)** for **@destination_db**, a value of **push** for **@subscription_type**, and a value of 3 for **@subscriber_type** (specifies an OLE DB provider).  
  
4.  At the Publisher on the publication database, execute [sp_addpushsubscription_agent (Transact-SQL)](assetId:///1fdd2052-50d8-4318-8aa7-fc635d5cad18). Specify the following:  
  
    -   The **@subscriber**and **@publication** parameters.  
  
    -   A value of **(default destination)** for **@subscriber_db**,  
  
    -   The properties of the non-[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] data source for **@subscriber_provider**, **@subscriber_datasrc**, **@subscriber_location**, **@subscriber_provider_string**, and **@subscriber_catalog**.  
  
    -   The [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows credentials under which the Distribution Agent at the Distributor runs for **@job_login** and **@job_password**.  
  
        > [!NOTE]  
        >  Connections made using Windows Integrated Authentication always use the Windows credentials specified by **@job_login** and **@job_password**. The Distribution Agent always makes the local connection to the Distributor using Windows Integrated Authentication. By default, the agent will connect to the Subscriber using Windows Integrated Authentication.  
  
    -   A value of **0** for **@subscriber_security_mode** and the OLE DB provider login information for **@subscriber_login** and **@subscriber_password**.  
  
    -   A schedule for the Distribution Agent job for this subscription. For more information, see [Specify Synchronization Schedules](../../Topics/TopicNameNotContainA/Specify-Synchronization-Schedules.md).  
  
    > [!IMPORTANT]  
    >  When creating a push subscription at a Publisher with a remote Distributor, the values supplied for all parameters, including *job_login* and *job_password*, are sent to the Distributor as plain text. You should encrypt the connection between the Publisher and its remote Distributor before executing this stored procedure. For more information, see [Enable Encrypted Connections to the Database Engine (SQL Server Configuration Manager)](../../Topics/TopicNameNotContainA/Enable-Encrypted-Connections-to-the-Database-Engine--SQL-Server-Configuration-Manager-.md).  
  
## See Also  
 [IBM DB2 Subscribers](../../Topics/TopicNameNotContainA/IBM-DB2-Subscribers.md)   
 [Oracle Subscribers](../../Topics/TopicNameNotContainA/Oracle-Subscribers.md)   
 [Other Non-SQL Server Subscribers](../../Topics/TopicNameNotContainA/Other-Non-SQL-Server-Subscribers.md)   
 [Programming Replication Using System Stored Procedures](assetId:///816d2bda-ed72-43ec-aa4d-7ee3dc25fd8a)   
 [Replication Security Best Practices](../../Topics/TopicNameNotContainA/Replication-Security-Best-Practices.md)