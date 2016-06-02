---
title: Implement Event Notifications
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 29ac8f68-a28a-4a77-b67b-a8663001308c
---
# Implement Event Notifications
  To implement an event notification, you must first create a target service to receive event notifications, and then create the event notification.  
  
> [!IMPORTANT]  
>  [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] dialog security should be configured for event notifications that send messages to a service broker on a remote server. Dialog security must be configured manually according to the full security model.  
  
## Creating the Target Service  
 You do not have to create a [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)]\-initiating service because [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] includes the following specific message type and contract for event notifications:  
  
```  
http://schemas.microsoft.com/SQL/Notifications/PostEventNotification  
```  
  
 The target service that receives event notifications must honor this preexisting contract.  
  
 **To create a target service**:  
  
1.  Create a queue to receive messages.  
  
    > [!NOTE]  
    >  The queue receives the following message type: `http://schemas.microsoft.com/SQL/Notifications/QueryNotification`.  
  
2.  Create a service on the queue that references the event notifications contract.  
  
3.  Create a route on the service to define the address to which [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] sends messages for the service. For event notifications that target a service in the same database, specify `ADDRESS = 'LOCAL'`.  
  
    > [!NOTE]  
    >  [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] routing determines the service that receives the notification messages. If the event notification targets a service on a remote server, both the source server and the target server must have routes defined on them to make sure that two\-way communication occurs.  
  
 The following example creates a queue, a service on the queue, and a route on the service to handle messages from the event notification contract.  
  
```  
CREATE QUEUE NotifyQueue ;  
GO  
CREATE SERVICE NotifyService  
ON QUEUE NotifyQueue  
(  
[http://schemas.microsoft.com/SQL/Notifications/PostEventNotification]  
);  
GO  
CREATE ROUTE NotifyRoute  
WITH SERVICE_NAME = 'NotifyService',  
ADDRESS = 'LOCAL';  
GO  
```  
  
## Creating the Event Notification  
 Event notifications are created by using the [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] CREATE EVENT NOTIFICATION statement, and are dropped by using the DROP EVENT NOTIFICATION STATEMENT. To modify an event notification, you must drop and re\-create the event notification.  
  
 The following example creates the event notification `CreateDatabaseNotification`. This notification sends a message about any `CREATE_DATABASE` event that occurs on the server to the `NotifyService` service that was previously created.  
  
```  
CREATE EVENT NOTIFICATION CreateDatabaseNotification  
ON SERVER  
FOR CREATE_DATABASE  
TO SERVICE 'NotifyService', '8140a771-3c4b-4479-8ac0-81008ab17984' ;  
```  
  
> [!CAUTION]  
>  Event notifications recognize CREATE\_SCHEMA events and the \<schema\_element\> definitions of CREATE SCHEMA statements as separate events. For example, an event notification is created on both the CREATE\_SCHEMA and CREATE\_TABLE events, and you run the following batch.  
>   
>  `CREATE SCHEMA s`  
>   
>  `CREATE TABLE t1 (col1 int)`  
>   
>  In this case, the event notification is raised two times: Onne time when the CREATE\_SCHEMA event occurs, and again when the CREATE\_TABLE event occurs. We recommend that you either avoid creating event notifications on both the CREATE\_SCHEMA events and the \<schema\_element\> texts of any corresponding CREATE SCHEMA definitions, or build logic into your application to avoid capturing unwanted event data.  
  
 **To create an event notification**  
  
-   [CREATE EVENT NOTIFICATION &#40;Transact-SQL&#41;](../Topic/CREATE%20EVENT%20NOTIFICATION%20\(Transact-SQL\).md)  
  
 **To drop an event notification**  
  
-   [DROP EVENT NOTIFICATION &#40;Transact-SQL&#41;](../Topic/DROP%20EVENT%20NOTIFICATION%20\(Transact-SQL\).md)  
  
## See Also  
 [Get Information About Event Notifications](../../Topics\TopicNameNotContainA/Get-Information-About-Event-Notifications.md)   
 [EVENTDATA &#40;Transact-SQL&#41;](../Topic/EVENTDATA%20\(Transact-SQL\).md)  
  
  