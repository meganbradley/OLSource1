---
title: "Embedded and Shared Data Connections or Data Sources (Report Builder and SSRS)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f417782c-b85a-4c4d-8a40-839176daba56
caps.latest.revision: 29
manager: mblythe
robots: noindex,nofollow
---
# Embedded and Shared Data Connections or Data Sources (Report Builder and SSRS)
Reports use data connections to retrieve data for a report when a query runs or when the report is processed. You choose from a list of built-in data connection types to connect to a relational database, a multidimensional database, a Web service, or some other source of data. The following terms are used when describing data connections.  
  
-   **Data connection.** Also known as a *data source*. A data connection includes a name and connection properties that are dependent on the connection type. By design, a data connection does not include credentials. A data connection does not specify which data to retrieve from the external data source. To do that, you specify a query when you create a dataset.  
  
-   **Data source definition.** A file that contains the XML representation of a report data source. When a report is published, its data sources are saved on the report server or SharePoint site as data source definitions, independently from the report definition. For example, a report server administrator might update the connection string or credentials. On a native report server, the file type is .rds. On a SharePoint site, the file type is .rsds.  
  
-   **Connection string.** A connection string is a string version of the connection properties that are needed to connect to a data source. Connection properties differ based on data connection type. For examples, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md).  
  
-   **Shared data source.** A data source that is available on a report server or SharePoint site to be used by multiple reports.  
  
-   **Embedded data source.** Also known as a *report-specific data source*. A data source that is defined in a report and used only by that report.  
  
-   **Credentials.** Credentials are the authentication information that must be provided to allow you access to external data.  
  
 The difference between the embedded and shared data sources is in how they are created, stored, and managed.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Shared Data Sources  
 Shared data sources are useful when you have data sources that you use often. It is recommended that you use shared data sources as much as possible. They make reports and report access easier to manage, and help to keep reports and the data sources they access more secure. If you need a shared data source, ask your system administrator to create one for you.  
  
 In Report Builder, you cannot create a shared data source. You can browse to and select a shared data source from the report server. For more information, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings-in-Report-Builder.md).  
  
 In Report Designer, you cannot browse to a shared data source on the report server. You can create shared data sources as part of a project in Solution Explorer and choose whether to deploy them to a report server. You might choose to use them locally only because of differences in credentials required from your computer or from the report server. For more information, see [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md).  
  
 The following icon indicates a shared data source item in the report server folder hierarchy: ![Shared data source icon](../../Topics/TopicNameContainA/media/hlp_16datasource.png "hlp_16datasource")  
  
## Embedded Data Sources  
 An embedded data source is a data connection that is saved in the report definition. Embedded data source connection information can be used only by the report in which it is embedded. To define and manage embedded data sources, use the **Data Source Properties** dialog box.  
  
##  <a name="Comparing"></a> Comparing Embedded and Shared Data Sources  
 The following table summarizes the differences between embedded and shared data sources:  
  
|Description|Embedded<br /><br /> Data Source|Shared<br /><br /> Data Source|  
|-----------------|------------------------------|----------------------------|  
|Data connection is embedded in the report definition.|![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")||  
|Pointer to the data connection on the report server is embedded in the report definition.||![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")|  
|Managed on the report server|![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")|![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")|  
|Required for shared datasets||![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")|  
|Required for components||![Available](../../Topics/TopicNameNotContainA/media/greencheck.gif "greencheck")|  
  
## Data Source Credentials  
 Credentials are used to create an embedded data source, to run a query, or to retrieve data during report processing. The owner of the data source determines the type of credentials that you must use to access the data. Credentials are managed independently from the data connection on a report server, a SharePoint site, or on a local computer in a report authoring environment. Depending on the type of data source, credentials can be saved to avoid prompting or set to prompt each user. The credentials that you need might differ depending on whether you are connecting to the data source from your computer or from the report server. For more information, see [Specify Credentials in Report Builder](../../Topics/TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md) and [Data Connections, Data Sources, and Connection Strings (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Connections--Data-Sources--and-Connection-Strings--Report-Builder-and-SSRS-.md).  
  
## See Also  
 [Report Datasets (SSRS)](../../Topics/TopicNameNotContainA/Report-Datasets--SSRS-.md)   
 [Report Authoring Concepts (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-Authoring-Concepts--Report-Builder-and-SSRS-.md)   
 [Data Sources Supported by Reporting Services (SSRS)](../../Topics/TopicNameNotContainA/Data-Sources-Supported-by-Reporting-Services--SSRS-.md)   
 [Add and Verify a Data Connection (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-and-Verify-a-Data-Connection--Report-Builder-and-SSRS-.md)   
 [Embedded and Shared Datasets (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Embedded-and-Shared-Datasets--Report-Builder-and-SSRS-.md)