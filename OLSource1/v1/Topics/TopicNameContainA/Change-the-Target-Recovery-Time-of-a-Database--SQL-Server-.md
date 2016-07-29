---
title: "Change the Target Recovery Time of a Database (SQL Server)"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 2015-10-13
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e466419a-d8a4-48f7-8d97-13a903ad6b15
caps.latest.revision: 14
manager: jhubbard
---
# Change the Target Recovery Time of a Database (SQL Server)
This topic describes how to set the change the target recovery time of a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] database in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. By default, the target recovery time is 0, and the database uses *automatic checkpoints* (which are controlled by the **recovery interval** server option). Setting the target recovery time to greater than 0 causes the database to use the *indirect-checkpoints* and establishes an upper-bound on recovery time for this database.  
  
> [!NOTE]  
>  The upper-bound that is specified for a given database by its target recovery time setting could be exceeded if a long-running transaction causes excessive UNDO times.  
  
-   **Before you begin:**  [Limitations and Restrictions](#Restrictions), [Security](#Security)  
  
-   **To change the target recovery time, using:**  [SQL Server Management Studio](#SSMSProcedure) or [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a>  
  
> [!CAUTION]  
>  An online transactional workload on a database that is configured for indirect checkpoints could experience performance degradation. Indirect checkpoints make sure that the number of dirty pages are below a certain threshold so that the database recovery completes within the target recovery time. The recovery interval configuration option uses the number of transactions to determine the recovery time as opposed to indirect checkpoints which makes use of number of dirty pages. When indirect checkpoints are enabled on a database receiving a large number of DML operations, the background writer can start aggressively flushing dirty buffers to disk to ensure that the time required to perform recovery is within the target recovery time set of the database. This can cause additional I/O activity on certain systems which can contribute to a performance bottleneck if the disk subsystem is operating above or nearing the I/O threshold.  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires ALTER permission on the database.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 **To change the target recovery time**  
  
1.  In **Object Explorer**, connect to an instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], and expand that instance.  
  
2.  Right-click the database you want to change, and click the **Properties** command.  
  
3.  In the **Database Properties** dialog box, click the **Options** page.  
  
4.  In the **Recovery** panel, in the **Target Recovery Time (Seconds)** field, specify the number of seconds that you want as the upper-bound on the recovery time for this database.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 **To change the target recovery time**  
  
1.  Connect to the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] where the database resides.  
  
2.  Use the following [ALTER DATABASE](assetId:///f76fbd84-df59-4404-806b-8ecb4497c9cc)statement, as follows:  
  
     TARGET_RECOVERY_TIME **=***target_recovery_time* { SECONDS &#124; MINUTES }  
  
     *target_recovery_time*  
     When greater than 0 (the default), specifies the upper-bound on the recovery time for the specified database in the event of a crash.  
  
     SECONDS  
     Indicates that *target_recovery_time* is expressed as the number of seconds.  
  
     MINUTES  
     Indicates that *target_recovery_time* is expressed as the number of minutes.  
  
     The following example sets the target recovery time of the [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] database to `60` seconds.  
  
    ```  
    ALTER DATABASE AdventureWorks2012 SET TARGET_RECOVERY_TIME = 60 SECONDS;  
    ```  
  
## See Also  
 [Database Checkpoints (SQL Server)](../../Topics/TopicNameNotContainA/Database-Checkpoints--SQL-Server-.md)   
 [ALTER DATABASE SET Options (Transact-SQL)](assetId:///f76fbd84-df59-4404-806b-8ecb4497c9cc)