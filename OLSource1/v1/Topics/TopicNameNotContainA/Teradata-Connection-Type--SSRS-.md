---
title: Teradata Connection Type (SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b02779c2-a6b9-453c-815f-adad53353952
---
# Teradata Connection Type (SSRS)
  To include data from a Teradata relational database in your report, you must have a dataset that is based on a report data source of type Teradata. This built\-in data source type is based on the .NET Managed Provider for Teradata data processing extension.  
  
 Use the information in this topic to build a data source. For step\-by\-step instructions, see [Add and Verify a Data Connection &#40;Report Builder and SSRS&#41;](../Topic/Add%20and%20Verify%20a%20Data%20Connection%20\(Report%20Builder%20and%20SSRS\).md).  
  
##  <a name="Connection"></a> Connection String  
 Contact your database administrator for connection information and for the credentials to use to connect to the data source. The following connection string example specifies a Teradata database on the server specified with an IP address:  
  
```  
data source=<IP Address>  
```  
  
 For more connection string examples, see [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics\TopicNameNotContainA/Data-Connections,-Data-Sources,-and-Connection-Strings-in-Report-Builder.md).  
  
##  <a name="Credentials"></a> Credentials  
 Credentials are required to run queries, to preview the report locally, and to preview the report from the report server.  
  
 After you publish your report, you may need to change the credentials for the data source so that when the report runs on the report server, the permissions to retrieve the data are valid.  
  
 For more information, see [Data Connections, Data Sources, and Connection Strings &#40;Report Builder and SSRS&#41;](../Topic/Data%20Connections,%20Data%20Sources,%20and%20Connection%20Strings%20\(Report%20Builder%20and%20SSRS\).md) or [Specify Credentials in Report Builder](../../Topics\TopicNameNotContainA/Specify-Credentials-in-Report-Builder.md).  
  
 ![Arrow icon used with Back to Top link](../../Images\Image\ImageNotContaina/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Remarks"></a> Remarks  
 Before you can connect a Teradata data source, the system administrator must have installed the version of the .NET Data Provider for Teradata that supports retrieving data from the Teradata database. This data provider must be installed on the same computer as Report Builder and also on the report server.  
  
 Not all report delivery modes are supported by this data provider. Delivering reports through data\-driven subscriptions is not supported for this data processing extension. For more information, see [Use an External Data Source for Subscriber Data &#40;Data-Driven Subscription&#41;](../Topic/Use%20an%20External%20Data%20Source%20for%20Subscriber%20Data%20\(Data-Driven%20Subscription\).md) in the [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).  
  
 ![Arrow icon used with Back to Top link](../../Images\Image\ImageNotContaina/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Models"></a> Report Models  
 To create a dataset from a report model that is based on a Teradata data source, the model must be designed in Model Designer in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)] and published on a report server.  
  
 ![Arrow icon used with Back to Top link](../../Images\Image\ImageNotContaina/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
##  <a name="Related"></a> Related Sections  
 These sections of the documentation provide in\-depth conceptual information about report data, as well as procedural information about how to define, customize, and use parts of a report that are related to data.  
  
 [Report Datasets &#40;SSRS&#41;](../Topic/Report%20Datasets%20\(SSRS\).md)  
 Provides an overview of accessing data for your report.  
  
 [Data Connections, Data Sources, and Connection Strings in Report Builder](../../Topics\TopicNameNotContainA/Data-Connections,-Data-Sources,-and-Connection-Strings-in-Report-Builder.md)  
 Provides information about data connections and data sources.  
  
 [Report Embedded Datasets and Shared Datasets &#40;Report Builder and SSRS&#41;](../Topic/Report%20Embedded%20Datasets%20and%20Shared%20Datasets%20\(Report%20Builder%20and%20SSRS\).md)  
 Provides information about embedded and shared datasets.  
  
 [Dataset Fields Collection &#40;Report Builder and SSRS&#41;](../Topic/Dataset%20Fields%20Collection%20\(Report%20Builder%20and%20SSRS\).md)  
 Provides information about the field collection that is generated by the dataset query.  
  
 [Data Sources Supported by Reporting Services &#40;SSRS&#41;](../Topic/Data%20Sources%20Supported%20by%20Reporting%20Services%20\(SSRS\).md) in the [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] documentation in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [Books Online](http://go.microsoft.com/fwlink/?linkid=121312).  
 Provides in\-depth information about platform and version support for each data extension.  
  
 [Using SQL Server 2008 Reporting Services with the .NET Framework Data Provider for Teradata](http://go.microsoft.com/fwlink/?LinkID=130848)  
 Provides detailed information about working with this data extension.  
  
 ![Arrow icon used with Back to Top link](../../Images\Image\ImageNotContaina/UpArrow16x16.gif "UpArrow16x16") [Back to Top](#BackToTop)  
  
## See Also  
 [Report Parameters &#40;Report Builder and Report Designer&#41;](../Topic/Report%20Parameters%20\(Report%20Builder%20and%20Report%20Designer\).md)   
 [Filter, Group, and Sort Data &#40;Report Builder and SSRS&#41;](../Topic/Filter,%20Group,%20and%20Sort%20Data%20\(Report%20Builder%20and%20SSRS\).md)   
 [Expressions &#40;Report Builder and SSRS&#41;](../Topic/Expressions%20\(Report%20Builder%20and%20SSRS\).md)  
  
  