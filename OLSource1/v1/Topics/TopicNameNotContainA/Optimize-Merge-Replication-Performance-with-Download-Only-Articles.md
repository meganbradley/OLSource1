---
title: Optimize Merge Replication Performance with Download-Only Articles
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8851faa6-e6df-4ea5-a6ea-2a3471680fa3
---
# Optimize Merge Replication Performance with Download-Only Articles
  Merge replication offers two different article types to address different application needs. Publications can contain one or more of each of these article types as appropriate for the application:  
  
-   Standard articles  
  
-   Download\-only articles  
  
 Download\-only articles provide performance advantages over standard articles and should be used where appropriate.  
  
> [!NOTE]  
>  To use download\-only articles, the compatibility level of the publication must be at least 90RTM.  
  
## Standard Articles  
 Standard articles are the default, offering the full range of merge replication features, including rich conflict detection and resolution. Standard articles are appropriate for tables that are updated by multiple Subscribers; objects other than tables, such as stored procedures and views, are always published as standard articles.  
  
## Download\-Only Articles  
 Download\-only articles are designed for applications with data that is not updated at Subscribers, such as a set of articles that are contained in a product catalog. A product catalog is typically updated at the Publisher, but not at the Subscribers. Because download\-only articles cannot be updated at the Subscriber, tracking metadata is not sent to Subscribers. This can lead to reduced storage on the Subscribers and a performance benefit, especially if the network connection is slow.  
  
 Download\-only articles work in conjunction with client subscriptions: if an article is designated as download\-only, rows for that article cannot be inserted, updated, or deleted at Subscribers who use client subscriptions. Publishers and Subscribers that use the server subscription type \(typically Subscribers that republish data to other Subscribers\) can insert, update, and delete data. For more information about client subscriptions, see [Subscribe to Publications](../../Topics\TopicNameNotContainA/Subscribe-to-Publications.md).  
  
 To specify that an article is download\-only, see [Specify That a Merge Table Article is Download-Only](../../Topics\TopicNameContainA/Specify-That-a-Merge-Table-Article-is-Download-Only.md).  
  
## Using Different Article Types in Your Applications  
 By understanding the requirements of your application, you can make tradeoffs between maximum flexibility and optimal performance. For example, applications with numerous conflicts and changes at both the Publisher and Subscribers will use a publication made up of standard articles. Some applications, such as a sales force automation application, might have articles with a potential for conflicts, and other articles that function as lookup tables, which can be specified as download\-only. Data entry applications, such as point of sales systems and field force automation applications, often strictly partition data in a way that conflicts are eliminated, and data from one Subscriber never goes to another. In these situations, a combination of nonoverlapping partitions, download\-only articles and precomputed partitions provides maximum performance and scalability. For more information about nonoverlapping partitions and precomputed partitions, see [Parameterized Row Filters](../../Topics\TopicNameNotContainA/Parameterized-Row-Filters.md).  
  
## See Also  
 [Article Options for Merge Replication](../../Topics\TopicNameNotContainA/Article-Options-for-Merge-Replication.md)   
 [Optimize Merge Replication Performance with Conditional Delete Tracking](../../Topics\TopicNameNotContainA/Optimize-Merge-Replication-Performance-with-Conditional-Delete-Tracking.md)  
  
  