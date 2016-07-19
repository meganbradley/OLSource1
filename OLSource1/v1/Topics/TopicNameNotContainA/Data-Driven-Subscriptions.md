---
title: Data-Driven Subscriptions
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
ms.assetid: ba009f62-0d4f-45e7-a27c-36fd5f0cd3a8
manager: mblythe
---
# Data-Driven Subscriptions
A data-driven subscription provides a way to use dynamic subscription data that is retrieved from an external data source at run time. A data-driven subscription can also use static text and default values that you specify when the subscription is defined. You can use data-driven subscriptions to do the following:  
  
-   Distribute a report to a fluctuating list of subscribers. For example, you can use data-driven subscriptions to distribute a report throughout a large organization where subscribers vary from one month to the next, or use other criteria that determines group membership from an existing set of users.  
  
-   Filter the report output using report parameter values that are retrieved at run time.  
  
-   Vary report output formats and delivery options for each report delivery.  
  
 A data-driven subscription is composed of multiple parts. The fixed aspects of a data-driven subscription are defined when you create the subscription, and these include the following:  
  
-   The report for which the subscription is defined (a subscription is always associated with a single report).  
  
-   The delivery extension used to distribute the report. You can specify report server e-mail delivery, file share delivery, the null delivery provider used for preloading the cache, or a custom delivery extension. You cannot specify multiple delivery extensions within a single subscription.  
  
-   The subscriber data source. You must specify a connection string to the data source that contains subscriber data when you define the subscription. The subscriber data source cannot be specified dynamically at run time.  
  
-   The query that you use to select subscriber data must be specified when you define the subscription. You cannot change the query at run time.  
  
 Dynamic values used in a data-driven subscription are obtained when the subscription is processed. Examples of variable data that you might use in a subscription include the subscriber name, e-mail address, preferred report output format, or any value that is valid for a report parameter. To use dynamic values in a data-driven subscription, you define a mapping between the fields that are returned in the query to specific delivery options and to report parameters. Variable data is retrieved from a subscriber data source each time the subscription is processed.  
  
## Requirements for using Data-Driven Subscriptions  
 Data-driven subscription functionality is not available in all editions. There are also limitations on the kinds of data sources that you can use to retrieve subscription data at run time. The following list provides more information about the requirements:  
  
-   For more information about the editions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that support Data-driven subscription functionality, see [Features Supported by the Editions of SQL Server 2012](http://go.microsoft.com/fwlink/?linkid=232473) (http://go.microsoft.com/fwlink/?linkid=232473).  
  
-   For subscription data, choose a data source that can provide schema information to the report server. Examples of supported data source types include [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] relational data, Oracle, [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] databases, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package data, ODBC data sources, and OLE DB data sources. For more information about subscriber data source requirements, see [Use an External Data Source for Subscriber Data (Data-Driven Subscription)](../../Topics/TopicNameNotContainA/Use-an-External-Data-Source-for-Subscriber-Data--Data-Driven-Subscription-.md).  
  
## Working with Data-Driven Subscriptions  
 The following topics provide more information about data-driven subscriptions.  
  
|Topics|Description|  
|------------|-----------------|  
|[Create, Modify, and Delete Data-Driven Subscriptions](../../Topics/TopicNameNotContainA/Create--Modify--and-Delete-Data-Driven-Subscriptions.md)|Explains how to create, modify, or delete a data-driven subscription.|  
|[Use an External Data Source for Subscriber Data (Data-Driven Subscription)](../../Topics/TopicNameNotContainA/Use-an-External-Data-Source-for-Subscriber-Data--Data-Driven-Subscription-.md)|Provides information about the data sources that you can use for a data-driven subscription.|  
|[Tutorial: Creating a Data-Driven Subscription](assetId:///79ab0572-43e9-4dc4-9b5a-cd8b627b8274)|Provides step-by-step instruction for learning how to create a data-driven subscription.|  
|[Caching Reports (SSRS)](../../Topics/TopicNameNotContainA/Caching-Reports--SSRS-.md)|Describes how to use the Null Delivery Provider with a data-driven subscription to preload the cache.|  
  
## See Also  
 [Subscriptions and Delivery (Reporting Services)](../../Topics/TopicNameNotContainA/Subscriptions-and-Delivery--Reporting-Services-.md)   
 [Create Data-driven Subscription Page (Report Manager)](../../Topics/TopicNameNotContainA/Create-Data-driven-Subscription-Page--Report-Manager-.md)   
 [Preload the Cache (Report Manager)](../../Topics/TopicNameNotContainA/Preload-the-Cache--Report-Manager-.md)