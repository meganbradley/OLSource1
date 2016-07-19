---
title: Retrieve and Understand the Change Data
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: af366697-6942-42bb-aea5-18fdef018965
manager: jhubbard
---
# Retrieve and Understand the Change Data
In the data flow of an [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package that performs an incremental load of change data, the first task is to run the query that retrieves the change data. You execute this query inside a source component in a Data Flow task. You can then use downstream transformations and destinations to apply the change data to your destination.  
  
> [!NOTE]  
>  The creation of a query that contains a table-valued function is the third step in the process of creating a package that performs an incremental load of change data. For more information about this query, see, [Create the Function to Retrieve the Change Data](../../Topics/TopicNameNotContainA/Create-the-Function-to-Retrieve-the-Change-Data.md). For a description of the overall process for creating a package that performs an incremental load of change data, see [Change Data Capture (SSIS)](../../Topics/TopicNameNotContainA/Change-Data-Capture--SSIS-.md).  
  
## Adding the Data Flow Task  
 In the data flow of the package, you retrieve the change data, separate the rows based on the type of change that occurred, and then apply the changes to the destination.  
  
#### To add a Data Flow task to the package  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], on the **Control Flow** tab, add a Data Flow task.  
  
2.  Connect the preceding task that prepared the query string to the Data Flow task.  
  
## Configuring the Source Component to Query for Changes  
 The source component uses the query string that was prepared and stored in a variable to calls the table-valued function that retrieves the changed data.  
  
> [!NOTE]  
>  For more information about the query string that was prepared and stored in a variable, see [Prepare to Query for the Change Data](../../Topics/TopicNameNotContainA/Prepare-to-Query-for-the-Change-Data.md). For more information about the table-valued function that retrieves the change data, see [Create the Function to Retrieve the Change Data](../../Topics/TopicNameNotContainA/Create-the-Function-to-Retrieve-the-Change-Data.md).  
  
#### To configure an OLE DB source to retrieve the change data  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], on the **Data Flow** tab, add an OLE DB source.  
  
2.  In the **OLE DB Source Editor**, on the **Connection Manager** page, select the following options:  
  
    1.  Configure a valid connection to the source database.  
  
    2.  For **Data access mode**, select **SQL command from variable**.  
  
    3.  For **Variable name**, select **User::SqlDataQuery**.  
  
3.  In the **OLE DB Source Editor**, on the **Columns** page, make sure that all the columns that you want are mapped to output columns.  
  
## Next Step  
 After you have configured an OLE DB source to retrieve the change data, the next step is to start designing the data flow in the package.  
  
 **Next topic:** [Process Inserts, Updates, and Deletes](../../Topics/TopicNameNotContainA/Process-Inserts--Updates--and-Deletes.md)