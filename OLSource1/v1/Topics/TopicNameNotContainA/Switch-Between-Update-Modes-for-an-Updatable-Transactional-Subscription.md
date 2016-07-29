---
title: "Switch Between Update Modes for an Updatable Transactional Subscription"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ab5ebab1-7ee4-41f4-999b-b4f0c420c921
caps.latest.revision: 38
manager: jhubbard
---
# Switch Between Update Modes for an Updatable Transactional Subscription
This topic describes how to switch between update modes for an updatable transaction subscription in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. Specify the mode for updatable subscriptions using the New Subscription Wizard. For information about setting the mode when using this wizard, see [View and Modify Pull Subscription Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Pull-Subscription-Properties.md).  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
-   **To switch between update modes for an updatable transactional subscription, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   You can fail over from immediate to queued updating at any time. After you do, however, you cannot return to immediate updating until the Subscriber and Publisher are connected and the Queue Reader Agent has applied all pending messages in the queue to the Publisher.  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   When an updating subscription to a transactional publication supports failover from one updating mode to another, you can programmatically switch update modes to handle situations when connectivity changes for a short period of time. The update mode can be set programmatically and on demand using replication stored procedures. For more information, see [Updatable Subscriptions for Transactional Replication](../../Topics/TopicNameNotContainA/Updatable-Subscriptions-for-Transactional-Replication.md).  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
> [!NOTE]  
>  To change the update mode after the subscription is created, the **update_mode** property must be set to **failover** (which allows a switch from immediate updating to queued updating) or **queued failover** (which allows a switch from queued updating to immediate updating) when the subscription is created. These properties are set automatically in the New Subscription Wizard.  
  
#### To set the updating mode for a push subscription  
  
1.  Connect to the Subscriber in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], and then expand the server node.  
  
2.  Expand the **Replication** folder, and then expand the **Local Subscriptions** folder.  
  
3.  Right-click the subscription for which you want to set the update mode, and then click **Set Update Method**.  
  
4.  In the **Set Update Method - <Subscriber\>: <SubscriptionDatabase\>** dialog box, select **Immediate updating** or **Queued updating**.  
  
5.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
#### To set the updating mode for a pull subscription  
  
1.  In the **Subscription Properties - <Publisher\>: <PublicationDatabase\>** dialog box, select a value of **Immediately replicate changes** or **Queue changes** for the **Subscriber update method** option.  
  
2.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
 For more information about accessing the **Subscription Properties - <Publisher\>: <PublicationDatabase\>** dialog box, see [View and Modify Pull Subscription Properties](../../Topics/TopicNameNotContainA/View-and-Modify-Pull-Subscription-Properties.md).  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To switch between update modes  
  
1.  Verify that the subscription supports failover by executing [sp_helppullsubscription](assetId:///a0d9c3f1-1fe9-497c-8e2f-5b74f47a7346) for a pull subscription or [sp_helpsubscription](assetId:///ff96bcbf-e2b9-4da8-8515-d80d4ce86c16) for a push subscription. If the value of **update mode** in the result set is **3** or **4**, failover is supported.  
  
2.  At the Subscriber on the subscription database, execute [sp_setreplfailovermode](assetId:///ca98a4c3-bea4-4130-88d7-79e0fd1e85f6). Specify **@publisher**, **@publisher_db**, **@publication**, and one of the following values for **@failover_mode**:  
  
    -   **queued** - fail over to queued updating when connectivity has been temporarily lost.  
  
    -   **immediate** - fail over to immediate updating when connectivity has been restored.  
  
## See Also  
 [Updatable Subscriptions for Transactional Replication](../../Topics/TopicNameNotContainA/Updatable-Subscriptions-for-Transactional-Replication.md)