---
title: Update Statistics Task (Maintenance Plan)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 22902fd0-eb39-4f18-af94-3fcb69d2a3a4
---
# Update Statistics Task (Maintenance Plan)
  Use the **Update Statistics Task** dialog to update [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] information about the data in the tables and indexes. This task resamples the distribution statistics of each index created on user tables in the database. The distribution statistics are used by [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to optimize navigation through tables during the processing of [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statements. To build the distribution statistics automatically, [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] periodically samples the data in the corresponding table for each index. This size of the sample is based on the number of rows in the table and the frequency of data modification. Use this option to perform an additional sampling using the specified percentage of data in the tables. [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] uses this information to create better query plans.  
  
 This task executes the UPDATE STATISTICS statement.  
  
## Options  
 **Connection**  
 Select the server connection to use when performing this task.  
  
 **New**  
 Create a new server connection to use when performing this task. The **New Connection** dialog box is described below.  
  
 **Databases**  
 Specify the databases affected by this task.  
  
-   **All databases**  
  
     Generate a maintenance plan that runs maintenance tasks against all [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] databases, except tempdb.  
  
-   **All system databases**  
  
     Generate a maintenance plan that runs maintenance tasks against each of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] system databases except tempdb. No maintenance tasks are run against user\-created databases.  
  
-   **All user databases**  
  
     Generate a maintenance plan that runs maintenance tasks against all user\-created databases. No maintenance tasks are run against the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] system databases.  
  
-   **These specific databases**  
  
     Generate a maintenance plan that runs maintenance tasks against only those databases that are selected. At least one database in the list must be selected if this option is chosen.  
  
 **Note** Maintenance plans only run against databases set to compatibility level 80 or higher. Databases set to compatibility level 70 or lower are not displayed.  
  
 **Object**  
 Limit the **Selection** grid to display tables, views, or both.  
  
 **Selection**  
 Specify the tables or indexes affected by this task. Not available when **Tables and Views** is selected in the Object box.  
  
 **All existing statistics**  
 Update statistics for both columns and indexes.  
  
 **Column statistics only**  
 Only update column statistics.  
  
 **Index statistics only**  
 Only update index statistics.  
  
 **Scan type**  
 Type of scan used to gather updated statistics.  
  
 **Full scan**  
 Read all rows in the table or view to gather the statistics.  
  
 **Sample by**  
 Specify the percentage of the table or indexed view, or the number of rows to sample when collecting statistics for larger tables or views.  
  
 **View T\-SQL**  
 View the [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statements performed against the server for this task, based on the selected options.  
  
> [!NOTE]  
>  When the number of objects affected is large, this display can take a considerable amount of time.  
  
## New Connection Dialog Box  
 **Connection name**  
 Enter a name for the new connection.  
  
 **Select or enter a server name**  
 Select a server to connect to when performing this task.  
  
 **Refresh**  
 Refresh the list of available servers.  
  
 **Enter information to log on to the server**  
 Specify how to authenticate against the server.  
  
 **Use Windows integrated security**  
 Connect to an instance of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] with [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Windows Authentication.  
  
 **Use a specific user name and password**  
 Connect to an instance of the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] using [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Authentication. This option is not available.  
  
 **User name**  
 Provide a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] login to use when authenticating. This option is not available.  
  
 **Password**  
 Provide a password to use when authenticating. This option is not available.  
  
## See Also  
 [UPDATE STATISTICS &#40;Transact-SQL&#41;](../Topic/UPDATE%20STATISTICS%20\(Transact-SQL\).md)  
  
  