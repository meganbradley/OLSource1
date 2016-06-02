---
title: Modify Statistics
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-statistics
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b06299ca-ed52-411a-b245-45eac4628c99
---
# Modify Statistics
  You can modify existing statistics in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Token\Other/tsql_md.md)].  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Security](#Security)  
  
-   **To modify statistics, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 Requires that:  
  
-   The user has ALTER permission on the table or view.  
  
-   The user be the table or indexed view owner, or a member of one of the following roles: **sysadmin** fixed server role, **db\_owner** fixed database role, or the **db\_ddladmin** fixed database role.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To modify statistics  
  
1.  In **Object Explorer**, click the plus sign to expand the database in which you want to modify a statistic.  
  
2.  Click the plus sign to expand the **Tables** folder.  
  
3.  Click the plus sign to expand the table in which you want to modify a statistic.  
  
4.  Click the plus sign to expand the **Statistics** folder.  
  
5.  Right\-click the statistics object that you wish to modify and select **Properties**.  
  
6.  In the **Statistics Properties \-** *statistics\_name* dialog box, on the **General** page, click **Add**, **Remove**, **Move Up**, or **Move Down**, or any combination, to alter the properties of the statistics. Remember that a column’s location within the **Statistics Columns** grid can substantially impact the usefulness of the statistics.  
  
7.  Click **OK**.  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
 **To modify statistics**  
  
 This task cannot be performed using Transact\-SQL statements. To modify statistics using Transact\-SQL, you must first delete the existing statistic and then re\-create it with new attributes.  
  
 For more information, see [DROP STATISTICS &#40;Transact-SQL&#41;](../Topic/DROP%20STATISTICS%20\(Transact-SQL\).md) and [CREATE STATISTICS &#40;Transact-SQL&#41;](../Topic/CREATE%20STATISTICS%20\(Transact-SQL\).md).  
  
  