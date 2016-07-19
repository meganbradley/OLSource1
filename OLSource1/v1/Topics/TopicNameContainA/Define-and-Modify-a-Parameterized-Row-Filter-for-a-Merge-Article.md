---
title: Define and Modify a Parameterized Row Filter for a Merge Article
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: de0482a2-3cc8-4030-8a4a-14364549ac9f
manager: jhubbard
---
# Define and Modify a Parameterized Row Filter for a Merge Article
This topic describes how to define and modify a parameterized row filter in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)].  
  
 When creating table articles, you can use parameterized row filters. These filters use a [WHERE](assetId:///a8430421-7bce-4fab-a2d2-56c00a3c6fa4) clause to select the appropriate data to be published. Rather than specifying a literal value in the clause (as you do with a static row filter), you specify one or both of the following system functions: [SUSER_SNAME](assetId:///11ec7d86-d429-4004-a436-da25df9f8761) and [HOST_NAME](assetId:///4b8b0705-c083-4b07-b954-c83ee73b2ebb). For more information, see [Parameterized Row Filters](../../Topics/TopicNameNotContainA/Parameterized-Row-Filters.md).  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
-   **To define and modify a parameterized row filter, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   If you add, modify, or delete a parameterized row filter after subscriptions to the publication have been initialized, you must generate a new snapshot and reinitialize all subscriptions after making the change. For more information about requirements for property changes, see [Change Publication and Article Properties](../../Topics/TopicNameNotContainA/Change-Publication-and-Article-Properties.md).  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   For performance reasons, we recommend that you not apply functions to column names in parameterized row filter clauses, such as `LEFT([MyColumn]) = SUSER_SNAME()`. If you use HOST_NAME in a filter clause and override the HOST_NAME value, it might be necessary to convert data types using CONVERT. For more information about best practices for this case, see the section "Overriding the HOST_NAME() Value" in the topic [Parameterized Row Filters](../../Topics/TopicNameNotContainA/Parameterized-Row-Filters.md).  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 Define, modify, and delete parameterized row filters on the **Filter Table Rows** page of the New Publication Wizard or the **Filter Rows** page of the **Publication Properties - <Publication\>** dialog box. For more information about using the wizard and accessing the dialog box, see [Create a Publication](../../Topics/TopicNameContainA/Create-a-Publication.md) and [View and Modify Publication Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Publication-Properties.md).  
  
#### To define a parameterized row filter  
  
1.  On the **Filter Table Rows** page of the New Publication Wizard or the **Filter Rows** page of the **Publication Properties - <Publication\>**, click **Add**, and then click **Add Filter**.  
  
2.  In the **Add Filter** dialog box, select a table to filter from the drop-down list box.  
  
3.  Create a filter statement in the **Filter statement** text box. You can type directly in the text area, and you can also drag and drop columns from the **Columns** list box.  
  
    -   The **Filter statement** text area includes the default text, which is in the form of:  
  
        ```  
        SELECT <published_columns> FROM [tableowner].[tablename] WHERE  
        ```  
  
    -   The default text cannot be changed; type the filter clause after the WHERE keyword using standard SQL syntax. A parameterized filter includes a call to the system function **HOST_NAME()** and/or **SUSER_SNAME()**, or a user-defined function that references one or both of these functions. The following is an example of a complete filter clause for a parameterized row filter:  
  
        ```  
        SELECT <published_columns> FROM [HumanResources].[Employee] WHERE LoginID = SUSER_SNAME()  
        ```  
  
         The WHERE clause should use two-part naming; three-part naming and four-part naming are not supported.  
  
4.  Select the option that matches how data will be shared among Subscribers:  
  
    -   **A row from this table will go to multiple subscriptions**  
  
    -   **A row from this table will go to only one subscription**  
  
     If you select **A row from this table will go to only one subscription**, merge replication can optimize performance by storing and processing less metadata. However, you must ensure that the data is partitioned in such a way that a row cannot be replicated to more than one Subscriber. For more information, see the section "Setting 'partition options'" in the topic [Parameterized Row Filters](../../Topics/TopicNameNotContainA/Parameterized-Row-Filters.md).  
  
5.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
6.  If you are in the **Publication Properties - <Publication\>** dialog box, click **OK** to save and close the dialog box.  
  
#### To modify a parameterized row filter  
  
1.  On the **Filter Table Rows** page of the New Publication Wizard or the **Filter Rows** page of the **Publication Properties - <Publication\>**, select a filter in the **Filtered Tables** pane, and then click **Edit**.  
  
2.  In the **Edit Filter** dialog box, modify the filter.  
  
3.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
#### To delete a parameterized row filter  
  
1.  On the **Filter Table Rows** page of the New Publication Wizard or the **Filter Rows** page of the **Publication Properties - <Publication\>**, select a filter in the **Filtered Tables** pane, and then click **Delete**.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
 Parameterized row filters can be created and modified programmatically using replication stored procedures.  
  
#### To define a parameterized row filter for an article in a merge publication  
  
1.  At the Publisher on the publication database, execute [Changing Publication and Article Properties](assetId:///0df654ea-24e2-4c61-a75a-ecaa7a140a6c). Specify **@publication**, a name for the article for **@article**, the table being published for **@source_object**, the WHERE clause that defines the parameterized filter for **@subset_filterclause** (not including `WHERE`), and one of the following values for **@partition_options**, which describes the type of partitioning that will result from the parameterized row filter:  
  
    -   **0** - Filtering for the article either is static or does not yield a unique subset of data for each partition (an "overlapping" partition).  
  
    -   **1** - Resulting partitions are overlapping, and updates made at the Subscriber cannot change the partition to which a row belongs.  
  
    -   **2** - Filtering for the article yields nonoverlapping partitions, but multiple Subscribers can receive the same partition.  
  
    -   **3** - Filtering for the article yields nonoverlapping partitions that are unique for each subscription.  
  
#### To change a parameterized row filter for an article in a merge publication  
  
1.  At the Publisher on the publication database, execute [sp_changemergearticle](assetId:///0dc3da5c-4af6-45be-b5f0-074da182def2). Specify **@publication**, **@article**, a value of **subset_filterclause** for **@property**, the expression that defines the parameterized filter for **@value** (not including `WHERE`), and a value of **1** for both **@force_invalidate_snapshot** and **@force_reinit_subscription**.  
  
2.  If this change results in different partitioning behavior, then execute [sp_changemergearticle](assetId:///0dc3da5c-4af6-45be-b5f0-074da182def2) again. Specify **@publication**, **@article**, a value of **partition_options** for **@property**, and the most appropriate partitioning option for **@value**, which can be one of the following:  
  
    -   **0** - Filtering for the article either is static or does not yield a unique subset of data for each partition (an "overlapping" partition).  
  
    -   **1** - Resulting partitions are overlapping, and updates made at the Subscriber cannot change the partition to which a row belongs.  
  
    -   **2** - Filtering for the article yields nonoverlapping partitions, but multiple Subscribers can receive the same partition.  
  
    -   **3** - Filtering for the article yields nonoverlapping partitions that are unique for each subscription.  
  
###  <a name="TsqlExample"></a> Example (Transact-SQL)  
 This example defines a group of articles in a merge publication where the articles are filtered with a series of join filters against the `Employee` table that is itself filtered using a parameterized row filter on the **LoginID** column. During synchronization, the value returned by the [HOST_NAME](assetId:///4b8b0705-c083-4b07-b954-c83ee73b2ebb) function is overridden. For more information, see Overriding the HOST_NAME() Value in the topic [Parameterized Row Filters](../../Topics/TopicNameNotContainA/Parameterized-Row-Filters.md).  
  
 [!CODE [HowTo#sp_MergeDynamicPub1](../CodeSnippet/SQL15/replication/howto#sp_mergedynamicpub1)]  
  
## See Also  
 [Define and Modify a Join Filter Between Merge Articles](../../Topics/TopicNameContainA/Define-and-Modify-a-Join-Filter-Between-Merge-Articles.md)   
 [Change Publication and Article Properties](../../Topics/TopicNameNotContainA/Change-Publication-and-Article-Properties.md)   
 [Join Filters](../../Topics/TopicNameNotContainA/Join-Filters.md)   
 [Parameterized Row Filters](../../Topics/TopicNameNotContainA/Parameterized-Row-Filters.md)