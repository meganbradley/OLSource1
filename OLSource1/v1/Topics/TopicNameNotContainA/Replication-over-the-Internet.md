---
title: Replication over the Internet
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 04e7f4ed-e244-4bbe-ba12-09c33abea09e
manager: jhubbard
---
# Replication over the Internet
Replicating data over the Internet allows remote, disconnected users to access data when they need it using a connection to the Internet. Replicate data over the Internet using:  
  
-   A Virtual Private Network (VPN). For more information, see [Publish Data over the Internet Using VPN](../../Topics/TopicNameNotContainA/Publish-Data-over-the-Internet-Using-VPN.md).  
  
-   The Web synchronization option for merge replication. For more information, see [Web Synchronization for Merge Replication](../../Topics/TopicNameNotContainA/Web-Synchronization-for-Merge-Replication.md).  
  
 All types of [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] replication can replicate data over a VPN, but you should consider Web synchronization if you are using merge replication.