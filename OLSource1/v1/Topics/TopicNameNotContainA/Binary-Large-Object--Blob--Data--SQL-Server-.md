---
title: Binary Large Object (Blob) Data (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-blob
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 97509274-c3f8-43e5-a37c-52f1ffe0961a
manager: jhubbard
---
# Binary Large Object (Blob) Data (SQL Server)
[!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] provides solutions for storing files and documents in the database or on remote storage devices.  
  
##  <a name="section"></a> In This Section  
 [Compare Options for Storing Blobs (SQL Server)](../../Topics/TopicNameNotContainA/Compare-Options-for-Storing-Blobs--SQL-Server-.md)  
 Compare the advantages of FILESTREAM, FileTables, and Remote Blob Store.  
  
 [FILESTREAM (SQL Server)](../../Topics/TopicNameNotContainA/FILESTREAM--SQL-Server-.md)  
 FILESTREAM enables [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]-based applications to store unstructured data, such as documents and images, on the file system. Applications can leverage the rich streaming APIs and performance of the file system and at the same time maintain transactional consistency between the unstructured data and corresponding structured data.  
  
 [FileTables (SQL Server)](../../Topics/TopicNameNotContainA/FileTables--SQL-Server-.md)  
 The FileTable feature brings support for the Windows file namespace and compatibility with Windows applications to the file data stored in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. FileTable lets an application integrate its storage and data management components, and provides integrated [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] services - including full-text search and semantic search - over unstructured data and metadata.  
  
 In other words, you can store files and documents in special tables in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] called FileTables, but access them from Windows applications as if they were stored in the file system, without making any changes to your client applications.  
  
 [Remote Blob Store (RBS) (SQL Server)](../../Topics/TopicNameNotContainA/Remote-Blob-Store--RBS---SQL-Server-.md)  
 Remote BLOB store (RBS) for [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] lets database administrators store binary large objects (BLOBs) in commodity storage solutions instead of directly on the server. This saves a significant amount of space and avoids wasting expensive server hardware resources. RBS provides a set of API libraries that define a standardized model for applications to access BLOB data. RBS also includes maintenance tools, such as garbage collection, to help manage remote BLOB data.  
  
 RBS is included on the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation media, but is not installed by the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup program.