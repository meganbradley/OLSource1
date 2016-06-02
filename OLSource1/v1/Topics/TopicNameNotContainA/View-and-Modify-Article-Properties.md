---
title: View and Modify Article Properties
ms.custom: na
ms.devlang: 
  - TSQL
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e71831fa-3d39-4e4a-9706-4d3a497082cc
---
# View and Modify Article Properties
  This topic describes how to view and modify article properties in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], [!INCLUDE[tsql](../../Token\Other/tsql_md.md)], or Replication Management Objects \(RMO\).  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
-   **To view and modify article properties, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
     [Replication Management Objects \(RMO\)](#RMOProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   Some properties cannot be modified after a publication has been created, and others cannot be modified if there are subscriptions to the publication. Properties that cannot be modified are displayed as read\-only.  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   After a publication is created, some property changes require a new snapshot. If a publication has subscriptions, some changes also require all subscriptions to be reinitialized. For more information, see [Change Publication and Article Properties](../../Topics\TopicNameNotContainA/Change-Publication-and-Article-Properties.md) and [Add Articles to and Drop Articles from Existing Publications](../../Topics\TopicNameNotContainA/Add-Articles-to-and-Drop-Articles-from-Existing-Publications.md).  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
 View and modify article properties in the **Publication Properties \- \<Publication\>** dialog box, which is available in [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] and Replication Monitor. For information about starting Replication Monitor, see [Start the Replication Monitor](../../Topics\TopicNameNotContainA/Start-the-Replication-Monitor.md).  
  
-   The **General** page includes the publication name and description, the database name, the type of publication, and the subscription expiration settings.  
  
-   The **Articles** page corresponds to the **Articles** page in the New Publication Wizard. Use this page to add and delete articles, and to change properties and column filtering for articles.  
  
-   The **Filter Rows** page corresponds to the **Filter Table Rows** page in the New Publication Wizard. Use this page to add, edit, and delete static row filters for all types of publications, and to add, edit, and delete parameterized row filters and join filters for merge publications.  
  
-   The **Snapshot** page allows you to specify the format and location of the snapshot, whether the snapshot should be compressed, and scripts to run before and after the snapshot is applied.  
  
-   The **FTP Snapshot** page \(for snapshot and transactional publications, and merge publications for Publishers running versions prior to SQL Server 2005\) allows you to specify whether Subscribers can download snapshot files through File Transfer Protocol \(FTP\).  
  
-   The **FTP Snapshot and Internet** page \(for merge publications from Publishers running SQL Server 2005 or later\) allows you to specify whether Subscribers can download snapshot files through FTP, and whether Subscribers can synchronize subscriptions through HTTPS.  
  
-   The **Subscription Options** page allows you to set a number of options that apply to all subscriptions. The options differ depending on the type of publication.  
  
-   The **Publication Access List** page allows you to specify which logins and groups can access a publication.  
  
-   The **Agent Security** page allows you to access settings for the accounts under which the following agents run and make connections to the computers in a replication topology: the Snapshot Agent for all publications; the Log Reader Agent for all transactional publications; and the Queue Reader Agent for transactional publications that allow queued updating subscriptions.  
  
-   The **Data Partitions** page \(for merge publications from Publishers running SQL Server 2005 or later\) allows you to specify whether Subscribers to publications with parameterized filters can request a snapshot if one is not available. It also allows you to generate snapshots for one or more partitions, either once or on a recurring schedule.  
  
#### To view and modify article properties  
  
1.  On the **Articles** Page of the **Publication Properties \- \<Publication\>** dialog box, select an article, and then click **Article Properties**.  
  
2.  Select which articles property changes should apply to:  
  
    -   Click **Set Properties of Highlighted \<ObjectType\> Article** to launch the **Article Properties \- \<ObjectName\>** dialog box; property changes made in this dialog box are applied only to the object that is highlighted in the object pane on the **Articles** page.  
  
    -   Click **Set Properties of All \<ObjectType\> Articles**, to launch the **Properties for All \<ObjectType\> Articles** dialog box; property changes made in this dialog box are applied to all objects of that type in the object pane on the **Articles** page, including ones not yet selected for publication.  
  
        > [!NOTE]  
        >  Property changes made in the **Properties for All \<ObjectType\> Articles** dialog box override any made previously in the **Article Properties \- \<ObjectName\>** dialog box. If, for example, you want to set a number of defaults for all articles of an object type, but also want to set some properties for individual objects, set the defaults for all articles first. Then set the properties for the individual objects.  
  
3.  Modify any properties if necessary, and then click **OK**.  
  
4.  Click **OK** on the **Publication Properties \- \<Publication\>** dialog box.  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
 Articles can be modified and their properties returned programmatically using replication stored procedures. The stored procedures that you use depend on the type of publication to which the article belongs.  
  
#### To view the properties of an article belonging to a snapshot or transactional publication  
  
1.  Execute [sp\_helparticle](../Topic/sp_helparticle%20\(Transact-SQL\).md), specifying the name of the publication for the **@publication** parameter and the name of the article for the **@article** parameter. If you do not specify **@article**, information will be returned for all articles in the publication.  
  
2.  Execute [sp\_helparticlecolumns](../Topic/sp_helparticlecolumns%20\(Transact-SQL\).md) for table articles to list all columns available in the base table.  
  
#### To modify the properties of an article belonging to a snapshot or transactional publication  
  
1.  Execute [sp\_changearticle](../Topic/sp_changearticle%20\(Transact-SQL\).md), specifying the article property being changed in the **@property** parameter and the new value of this property in the **@value** parameter.  
  
    > [!NOTE]  
    >  If the change requires the generation of a new snapshot, you must also specify a value of **1** for **@force\_invalidate\_snapshot**, and if the change requires that Subscribers be reinitialized, you must also specify a value of **1** for **@force\_reinit\_subscription**. For more information on the properties that, when changed, require a new snapshot or reinitialization, see [Change Publication and Article Properties](../../Topics\TopicNameNotContainA/Change-Publication-and-Article-Properties.md).  
  
#### To view the properties of an article belonging to a merge publication  
  
1.  Execute [sp\_helpmergearticle](../Topic/sp_helpmergearticle%20\(Transact-SQL\).md), specifying the name of the publication for the **@publication** parameter and the name of the article for the **@article** parameter. If you do not specify these parameters, information will be returned for all articles in a publication or at the publisher.  
  
2.  Execute [sp\_helpmergearticlecolumn](../Topic/sp_helpmergearticlecolumn%20\(Transact-SQL\).md) for table articles to list all columns available in the base table.  
  
#### To modify the properties of an article belonging to a merge publication  
  
1.  Execute [sp\_changemergearticle](../Topic/sp_changemergearticle%20\(Transact-SQL\).md), specifying the article property being changed in the **@property** parameter and the new value of this property in the **@value** parameter.  
  
    > [!NOTE]  
    >  If the change requires the generation of a new snapshot, you must also specify a value of **1** for **@force\_invalidate\_snapshot**, and if the change requires that Subscribers be reinitialized, you must also specify a value of **1** for **@force\_reinit\_subscription**. For more information on the properties that, when changed, require a new snapshot or reinitialization, see [Change Publication and Article Properties](../../Topics\TopicNameNotContainA/Change-Publication-and-Article-Properties.md).  
  
###  <a name="TsqlExample"></a> Example \(Transact\-SQL\)  
 This transactional replication example returns the properties of the published article.  
  
 [!CODE [HowTo#sp_helptranarticle](../CodeSnippet/SQL15/replication/howto#sp_helptranarticle)]  
  
 This transactional replication example changes the schema options for the published article.  
  
 [!CODE [HowTo#sp_changetranarticle](../CodeSnippet/SQL15/replication/howto#sp_changetranarticle)]  
  
 This merge replication example returns the properties of the published article.  
  
 [!CODE [HowTo#sp_helpmergearticle](../CodeSnippet/SQL15/replication/howto#sp_helpmergearticle)]  
  
 This merge replication example changes the conflict detection settings for a published article.  
  
 [!CODE [HowTo#sp_changemergearticle](../CodeSnippet/SQL15/replication/howto#sp_changemergearticle)]  
  
##  <a name="RMOProcedure"></a> Using Replication Management Objects \(RMO\)  
 You can modify articles and access their properties programmatically by using Replication Management Objects \(RMO\). The RMO classes you use to view or modify article properties depend on the type of publication to which the article belongs.  
  
#### To view or modify properties of an article that belongs to a snapshot or transactional publication  
  
1.  Create a connection to the Publisher by using the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) class.  
  
2.  Create an instance of the [TransArticle](assetId:///T:Microsoft.SqlServer.Replication.TransArticle) class.  
  
3.  Set the [Name](assetId:///P:Microsoft.SqlServer.Replication.Article.Name), [PublicationName](assetId:///P:Microsoft.SqlServer.Replication.Article.PublicationName), and [DatabaseName](assetId:///P:Microsoft.SqlServer.Replication.Article.DatabaseName) properties.  
  
4.  Set the connection from step 1 for the [ConnectionContext](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.ConnectionContext) property.  
  
5.  Call the [LoadProperties](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.LoadProperties) method to get the properties of the object. If this method returns **false**, either the article properties in step 3 were defined incorrectly or the article does not exist.  
  
6.  \(Optional\) To change properties, set a new value for one of the [TransArticle](assetId:///T:Microsoft.SqlServer.Replication.TransArticle) properties that can be set.  
  
7.  \(Optional\) If you specified a value of **true** for [CachePropertyChanges](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.CachePropertyChanges), call the [CommitPropertyChanges](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.CommitPropertyChanges) method to commit changes on the server. If you specified a value of **false** for [CachePropertyChanges](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.CachePropertyChanges) \(the default\), changes are sent to the server immediately.  
  
#### To view or modify properties of an article that belongs to a merge publication  
  
1.  Create a connection to the Publisher by using the [ServerConnection](assetId:///T:Microsoft.SqlServer.Management.Common.ServerConnection) class.  
  
2.  Create an instance of the [MergeArticle](assetId:///T:Microsoft.SqlServer.Replication.MergeArticle) class.  
  
3.  Set the [Name](assetId:///P:Microsoft.SqlServer.Replication.Article.Name), [PublicationName](assetId:///P:Microsoft.SqlServer.Replication.Article.PublicationName), and [DatabaseName](assetId:///P:Microsoft.SqlServer.Replication.Article.DatabaseName) properties.  
  
4.  Set the connection from step 1 for the [ConnectionContext](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.ConnectionContext) property.  
  
5.  Call the [LoadProperties](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.LoadProperties) method to get the properties of the object. If this method returns **false**, either the article properties in step 3 were defined incorrectly or the article does not exist.  
  
6.  \(Optional\) To change properties, set a new value for one of the [MergeArticle](assetId:///T:Microsoft.SqlServer.Replication.MergeArticle) properties that can be set.  
  
7.  \(Optional\) If you specified a value of **true** for [CachePropertyChanges](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.CachePropertyChanges), call the [CommitPropertyChanges](assetId:///M:Microsoft.SqlServer.Replication.ReplicationObject.CommitPropertyChanges) method to commit changes on the server. If you specified a value of **false** for [CachePropertyChanges](assetId:///P:Microsoft.SqlServer.Replication.ReplicationObject.CachePropertyChanges) \(the default\), changes are sent to the server immediately.  
  
###  <a name="PShellExample"></a> Example \(RMO\)  
 This example changes a merge article to specify the business logic handler used by the article.  
  
 [!CODE [HowTo#rmo_ChangeMergeArticle_BLH](../CodeSnippet/SQL15/replication/howto#rmo_changemergearticle_blh)]  
  
 [!CODE [HowTo#rmo_vb_ChangeMergeArticle_BLH](../CodeSnippet/SQL15/replication/howto#rmo_vb_changemergearticle_blh)]  
  
## See Also  
 [Implement a Business Logic Handler for a Merge Article](../../Topics\TopicNameContainA/Implement-a-Business-Logic-Handler-for-a-Merge-Article.md)   
 [Publish Data and Database Objects](../../Topics\TopicNameNotContainA/Publish-Data-and-Database-Objects.md)   
 [Change Publication and Article Properties](../../Topics\TopicNameNotContainA/Change-Publication-and-Article-Properties.md)   
 [Replication System Stored Procedures Concepts](../Topic/Replication%20System%20Stored%20Procedures%20Concepts.md)   
 [Advanced Merge Replication Conflict Detection and Resolution](../../Topics\TopicNameNotContainA/Advanced-Merge-Replication-Conflict-Detection-and-Resolution.md)  
  
  