---
title: Histogram Target
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2ea39141-7eb0-4c74-abf8-114c2c106a19
---
# Histogram Target
  The histogram target groups occurrences of a specific event type based on event data. The groupings of events are counted based on a specified event column or action. You can use the histogram target to troubleshoot performance issues. By identifying which events are occurring most frequently, you can find "hotspots" that indicate a potential cause of a performance problem.  
  
 The following table describes the options that can be used to configure the histogram target.  
  
|Option|Allowed values|Description|  
|------------|--------------------|-----------------|  
|slots|Any integer value. This value is optional.|A user\-specified value indicating the maximum number of groupings to retain. When this value is reached, new events that do not belong to the existing groups are ignored.<br /><br /> Note that to improve performance, the slot number is rounded up to the next power of 2.|  
|filtering\_event\_name|Any event present in the Extended Events session. This value is optional.|A user\-specified value that is used to identify a class of events. Only instances of the specified event are bucketed. All other events are ignored.<br /><br /> If you specify this value, you must use the format: *package\_name*.*event\_name*, for example `'sqlserver.checkpoint_end'`. You can identify the package name by using the following query:<br /><br /> `SELECT p.name, se.event_name FROM sys.dm_xe_session_events se JOIN sys.dm_xe_packages p ON se_event_package_guid = p.guid ORDER BY p.name, se.event_name`<br /><br /> If you do not specify the filtering\_event\_name value, source\_type must be set to 1 \(the default\).|  
|source\_type|The type of object that the bucket is based on. This value is optional and if not specified has a default value of 1.|Can have one of the following values:<br /><br /> 0 for an event<br /><br /> 1 for an action|  
|source|Event column or action name.|The event column or action name that is used as the data source.<br /><br /> When you specify an event column for source, you must specify a column from the event that is used for the filtering\_event\_name value. You can identify the potential columns by using the following query:<br /><br /> `SELECT name FROM sys.dm_xe_object_columns WHERE object_name = '<eventname>' AND column_type != 'readonly'`<br /><br /> When you specify an event column for source, you do not have to include the package name in the source value.<br /><br /> When you specify an action name for source, you must use one of the actions that is configured for collection in the event session for which this target is being used. To find potential values for the action name, you can query the action\_name column of the sys.dm\_xe\_sesssion\_event\_actions view.<br /><br /> If you are using an action name as the data source, you must specify the source value by using the format: *package\_name*.*action\_name*.|  
  
 The following example illustrates at a high level how the histogram target collects data. In this example, you want to use the histogram target to count how many waits of each wait type occurred. To do this, you would specify the following options when you define the histogram target:  
  
-   filtering\_event\_name \= 'wait\_info'  
  
-   source \= 'wait\_type'  
  
-   source\_type \= 0 \(because wait\_type is an event column\)  
  
 In the example scenario, the following data is recorded for the wait\_type source.  
  
|Filtering event name|Source column value|  
|--------------------------|-------------------------|  
|wait\_info|file\_io|  
|wait\_info|file\_io|  
|wait\_info|network|  
|wait\_info|network|  
|wait\_info|sleep|  
  
 The wait type values would be categorized into three slots, with the following values and slot counts:  
  
|Value|Slot count|  
|-----------|----------------|  
|file\_io|2|  
|network|2|  
|sleep|1|  
  
 The histogram target only retains event data for the specified source. In some cases the event data may be too large to retain completely, in which case the data is truncated. When event data is truncated, the number of bytes is recorded and displayed as XML output.  
  
## Adding the Target to a Session  
 To add the histogram target to an Extended Events session, you must include either of the following statements when you create or alter an event session, depending on the desired target type:  
  
```  
ADD TARGET package0.histogram  
```  
  
 You can use the SET statement to set the various options. The following example shows the addition of the histogram target, where data for the sqlserver.checkpoint\_end event is collected.  
  
```  
ADD TARGET package0.histogram  
(SET slots = 32, filtering_event_name = 'sqlserver.checkpoint_end', source_type = 0, source = 'database_id')  
```  
  
 For more information, see [Find the Objects That Have the Most Locks Taken on Them](../../Topics\TopicNameNotContainA/Find-the-Objects-That-Have-the-Most-Locks-Taken-on-Them.md), and [Monitor System Activity Using Extended Events](../../Topics\TopicNameNotContainA/Monitor-System-Activity-Using-Extended-Events.md).  
  
## Reviewing the Target Output  
 The histogram target serializes data to a calling program or procedure in XML format. The target output does not conform to any schema.  
  
 To review the output from the histogram target, you can use the following query, replacing *session\_name* with the name of the event session.  
  
```  
SELECT name, target_name, CAST(xet.target_data AS xml)  
FROM sys.dm_xe_session_targets AS xet  
JOIN sys.dm_xe_sessions AS xe  
   ON (xe.address = xet.event_session_address)  
WHERE xe.name = 'session_name'  
```  
  
 The following example illustrates histogram target output format.  
  
```  
<Slots truncated = "0" buckets=[count]>  
    <Slot count=[count] trunc=[truncated bytes]>  
        <value>  
        </value>  
    </Slot>  
</Slots>  
```  
  
## See Also  
 [SQL Server Extended Events Targets](../../Topics\TopicNameNotContainA/SQL-Server-Extended-Events-Targets.md)   
 [sys.dm_xe_session_targets &#40;Transact-SQL&#41;](../Topic/sys.dm_xe_session_targets%20\(Transact-SQL\).md)   
 [CREATE EVENT SESSION &#40;Transact-SQL&#41;](../Topic/CREATE%20EVENT%20SESSION%20\(Transact-SQL\).md)   
 [ALTER EVENT SESSION &#40;Transact-SQL&#41;](../Topic/ALTER%20EVENT%20SESSION%20\(Transact-SQL\).md)  
  
  