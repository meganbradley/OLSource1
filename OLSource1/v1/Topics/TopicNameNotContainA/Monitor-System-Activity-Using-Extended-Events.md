---
title: Monitor System Activity Using Extended Events
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d83ad88f-818c-49fe-a9a9-299f704fca53
manager: jhubbard
---
# Monitor System Activity Using Extended Events
This procedure illustrates how Extended Events can be used with Event Tracing for Windows (ETW) to monitor system activity. The procedure also shows how the CREATE EVENT SESSION, ALTER EVENT SESSION, and DROP EVENT SESSION statements are used.  
  
 Accomplishing these tasks involves using Query Editor in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] to carry out the following procedure. The procedure also requires using the command prompt to run ETW commands.  
  
### To monitor system activity using Extended Events  
  
1.  In Query Editor, issue the following statements to create an event session and add two events. These events, checkpoint_begin and checkpoint_end, fire at the beginning and end of a database checkpoint.  
  
    ```  
    CREATE EVENT SESSION test0  
    ON SERVER  
    ADD EVENT sqlserver.checkpoint_begin,  
    ADD EVENT sqlserver.checkpoint_end  
    WITH (MAX_DISPATCH_LATENCY = 1 SECONDS)  
    go  
    ```  
  
2.  Add the bucketing target with 32 buckets to count the number of checkpoints based on the database ID.  
  
    ```  
    ALTER EVENT SESSION test0  
    ON SERVER  
    ADD TARGET package0.histogram  
    (  
          SET slots = 32, filtering_event_name = 'sqlserver.checkpoint_end', source_type = 0, source = 'database_id'  
    )  
    go  
    ```  
  
3.  Issue the following statements to add the ETW target. This will enable you to see the begin and end events, which is used to determine how long the checkpoint takes.  
  
    ```  
    ALTER EVENT SESSION test0  
    ON SERVER  
    ADD TARGET package0.etw_classic_sync_target  
    go  
    ```  
  
4.  Issue the following statements to start the session and begin event collection.  
  
    ```  
    ALTER EVENT SESSION test0  
    ON SERVER  
    STATE = start  
    go  
    ```  
  
5.  Issue the following statements to cause three events to fire.  
  
    ```  
    USE tempdb  
          checkpoint  
    go  
    USE master  
          checkpoint  
          checkpoint  
    go  
    ```  
  
6.  Issue the following statements to view the event counts.  
  
    ```  
    SELECT CAST(xest.target_data AS xml) Bucketizer_Target_Data_in_XML  
    FROM sys.dm_xe_session_targets xest  
    JOIN sys.dm_xe_sessions xes ON xes.address = xest.event_session_address  
    JOIN sys.server_event_sessions ses ON xes.name = ses.name  
    WHERE xest.target_name = 'histogram' AND xes.name = 'test0'  
    go  
    ```  
  
7.  At the command prompt, issue the following commands to view the ETW data.  
  
    > [!NOTE]  
    >  To get help for the **tracerpt** command, at the command prompt, enter `tracerpt /?`.  
  
    ```  
    logman query -ets --- List the ETW sessions. This is optional.  
    logman update XE_DEFAULT_ETW_SESSION -fd -ets --- Flush the ETW log.  
    tracerpt %temp%\xeetw.etl -o xeetw.txt --- Dump the events so they can be seen.  
    ```  
  
8.  Issue the following statements to stop the event session and remove it from the server.  
  
    ```  
    ALTER EVENT SESSION test0  
    ON SERVER  
    STATE = STOP  
    go  
  
    DROP EVENT SESSION test0  
    ON SERVER  
    go  
    ```  
  
## See Also  
 [CREATE EVENT SESSION (Transact-SQL)](assetId:///67683027-2b0f-47aa-b223-604731af8b4d)   
 [ALTER EVENT SESSION (Transact-SQL)](assetId:///da006ac9-f914-4995-a2fb-25b5d971cd90)   
 [DROP EVENT SESSION (Transact-SQL)](assetId:///92eabe4b-24e2-43b1-978c-31a199964b90)   
 [SQL Server Extended Events Catalog Views (Transact-SQL)](assetId:///a8c2fb81-9644-4943-9391-fa62b37056de)   
 [SQL Server Extended Events Dynamic Management Views](assetId:///6d337c2f-71e9-4e0c-8877-9780baa7699d)   
 [SQL Server Extended Events Targets](../../Topics/TopicNameNotContainA/SQL-Server-Extended-Events-Targets.md)