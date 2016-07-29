---
title: "Dataset Properties Dialog Box, Query"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1fa34a4b-7de0-4e92-99fa-bc28a206773f
caps.latest.revision: 38
manager: mblythe
robots: noindex,nofollow
---
# Dataset Properties Dialog Box, Query
Select **Query** on the **Dataset Properties** dialog box to choose a data source and create a query.  
  
 The **Dataset Properties** dialog box includes the following:  
  
-   [Dataset Properties Dialog Box, Parameters](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Parameters.md)  
  
-   [Dataset Properties Dialog Box, Fields](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Fields.md)  
  
-   [Dataset Properties Dialog Box, Options](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Options.md)  
  
-   [Dataset Properties Dialog Box, Filters](../../Topics/TopicNameNotContainA/Dataset-Properties-Dialog-Box--Filters.md)  
  
## Options  
 **Name**  
 Type a name for the dataset. The name cannot be the same as a name for any data region or group in the report.  
  
 **Data Source**  
 Select the data source on which to base the dataset. To create a new data source, click **New**.  
  
 **Query type**  
 Select the type of command or query to use for the dataset. Select **Text** to run a query to retrieve data from the database. Select **Table** to use the **TableDirect** feature of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] to select all the fields within a table. Select **Stored Procedure** to run a stored procedure by name. **Text** is selected by default and is used for most queries. To edit the selected data source query, click **Query Designer**.  
  
> [!NOTE]  
>  Not all query types are supported by all data sources. For example, **Table** is supported only by data source types **OLE DB** and **ODBC**.  
  
 **Query**  
 This option appears when you choose the **Text** command type option. Type a query or import a pre-existing query by clicking **Import**. Click the **Expression** (*fx*) button to edit the expression.  
  
> [!NOTE]  
>  If you used a query designer to build a query, the text of the query appears in this box.  
  
 **Table name**  
 Enter the name of the table that you want to use as a dataset. This option appears when you select **Table**.  
  
 **Select or enter stored procedure name**  
 Type or choose the name of the stored procedure that you want to use. Click the **Expression** (*fx*) button to edit the expression. This option appears when you choose the Stored Procedure command type option.  
  
 **Time out (in seconds)**  
 Type the number of seconds until the query times out. The default is 30 seconds. The value for **Time out** must be empty or greater than zero. If it is empty, the query does not time out.  
  
## See Also  
 [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md)   
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)   
 [Query Designers (Report Builder)](../../Topics/TopicNameNotContainA/Query-Designers--Report-Builder-.md)   
 [Reporting Services Query Designers](../../Topics/TopicNameNotContainA/Reporting-Services-Query-Designers.md)