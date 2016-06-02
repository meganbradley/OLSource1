---
title: Subscription, Synchronization History (Merge Subscription, SQL Server 2005 and Later)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 85f666f6-14ee-4f19-b385-e5cc508aabe4
---
# Subscription, Synchronization History (Merge Subscription, SQL Server 2005 and Later)
  The **Synchronization History** tab displays detailed information on the Merge Agent, including status, article statistics, history, informational messages, and any error messages.  
  
## Options  
 Select which Merge Agent sessions to view from the **View** menu, and then select a specific session in the grid labeled **Sessions of the Merge Agent**. Detailed information on this session is displayed in the grid labeled **Articles processed in the selected session**.  
  
 **View**  
 Select which Merge Agent sessions to view.  
  
 **Status**  
 The status of the Merge Agent at the end of the session. The following list shows the possible status values:  
  
-   Error  
  
-   Completed  
  
-   Retrying  
  
-   Running  
  
 **Start Time**  
 The start time of the session.  
  
 **End Time**  
 The end time of the session. If the agent has not stopped, this field is empty.  
  
 **Duration**  
 The amount of time the Merge Agent has run in a session. The time represents elapsed time if the agent is currently running and total time if the agent has run previously.  
  
 **Uploaded Commands**  
 The number of rows uploaded during the Merge Agent session.  
  
 **Downloaded Commands**  
 The number of rows downloaded during the Merge Agent session.  
  
 **Error Message**  
 If a session ended in an error, this field displays the last error message logged by the Merge Agent. If a session did not end in an error, this field is blank.  
  
 **Article**  
 The name of each article in the publication, and the following processing phases for the entire publication:  
  
-   **Initialization**. This refers to starting the Merge Agent; this is not synonymous with initializing a subscription, which involves applying a snapshot.  
  
-   **Schema changes and bulk inserts**.  
  
-   **Upload changes to Publisher**.  
  
-   **Download changes to Subscriber**.  
  
 The phases are included so that the grid can display the amount of time and percentage of total time that each phase accounts for in the selected session.  
  
 **% of total**  
 The percentage of total processing time that each phase accounts for in the selected session.  
  
 **Duration**  
 The amount of time spent in each processing phase. The time represents elapsed time if the Merge Agent is currently running for the session and total time if the Merge Agent has run previously.  
  
 **Inserts**  
 The number of rows inserted in this phase of the selected session.  
  
 **Updates**  
 The number of rows updated in this phase of the selected session.  
  
 **Deletes**  
 The number of rows deleted in this phase of the selected session.  
  
 **Conflicts**  
 The number of conflicts in the selected session.  
  
 **Schema Changes**  
 The number of schema changes in the selected session. Schema changes can result from: schema changes being replicated from the publication database; adding or dropping articles; and changes to article or publication properties.  
  
 **Last message of the selected session**  
 This text area displays the last message in the selected session. If an error has occurred, it displays detailed error information and the command that was attempted at the time of the error. It also includes links to additional content related to the error.  
  
## See Also  
 [Start the Replication Monitor](../../Topics\TopicNameNotContainA/Start-the-Replication-Monitor.md)   
 [View Information and Perform Tasks for the Agents Associated With a Subscription &#40;Replication Monitor&#41;](../Topic/View%20Information%20and%20Perform%20Tasks%20for%20the%20Agents%20Associated%20With%20a%20Subscription%20\(Replication%20Monitor\).md)   
 [Monitoring Replication](../../Topics\TopicNameNotContainA/Monitoring-Replication.md)   
 [Replication Agents Overview](../../Topics\TopicNameNotContainA/Replication-Agents-Overview.md)  
  
  