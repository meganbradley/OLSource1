---
title: FileTable DDL, Functions, Stored Procedures, and Views
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-blob
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7e2e0f7f-94a8-4178-8bc7-d2e14ac8528c
---
# FileTable DDL, Functions, Stored Procedures, and Views
  Lists the [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statements and the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] database objects that have been added or changed to support the FileTable feature in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
 The Status column in the following tables indicates whether the item is new in [!INCLUDE[ssSQL11](../../Token\Other/ssSQL11_md.md)], or was present in previous versions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] but has been changed in [!INCLUDE[ssSQL11](../../Token\Other/ssSQL11_md.md)] to support semantic search.  
  
 For the list of statements and database objects that support FILESTREAM, see [FILESTREAM DDL, Functions, Stored Procedures, and Views](../../Topics\TopicNameNotContainA/FILESTREAM-DDL,-Functions,-Stored-Procedures,-and-Views.md).  
  
##  <a name="ddl"></a> Transact\-SQL Data Definition Language \(DDL\) Statements  
  
|Object|Status|More Information|  
|------------|------------|----------------------|  
|[ALTER DATABASE &#40;Transact-SQL&#41;](../Topic/ALTER%20DATABASE%20\(Transact-SQL\).md)<br /><br /> [ALTER DATABASE SET Options &#40;Transact-SQL&#41;](../Topic/ALTER%20DATABASE%20SET%20Options%20\(Transact-SQL\).md)|Changed|[Enable the Prerequisites for FileTable](../../Topics\TopicNameNotContainA/Enable-the-Prerequisites-for-FileTable.md)<br /><br /> [Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
|[ALTER TABLE &#40;Transact-SQL&#41;](../Topic/ALTER%20TABLE%20\(Transact-SQL\).md)|Changed|[Create, Alter, and Drop FileTables](../../Topics\TopicNameNotContainA/Create,-Alter,-and-Drop-FileTables.md)<br /><br /> [Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
|[CREATE DATABASE &#40;SQL Server Transact-SQL&#41;](../Topic/CREATE%20DATABASE%20\(SQL%20Server%20Transact-SQL\).md)|Changed|[Enable the Prerequisites for FileTable](../../Topics\TopicNameNotContainA/Enable-the-Prerequisites-for-FileTable.md)|  
|[CREATE TABLE &#40;Transact-SQL&#41;](../Topic/CREATE%20TABLE%20\(Transact-SQL\).md)|Changed|[Create, Alter, and Drop FileTables](../../Topics\TopicNameNotContainA/Create,-Alter,-and-Drop-FileTables.md)|  
|[RESTORE &#40;Transact-SQL&#41;](../Topic/RESTORE%20\(Transact-SQL\).md)<br /><br /> [RESTORE Arguments &#40;Transact-SQL&#41;](../Topic/RESTORE%20Arguments%20\(Transact-SQL\).md)|Changed||  
  
##  <a name="func"></a> Functions  
  
|Object|Status|More Information|  
|------------|------------|----------------------|  
|[FileTableRootPath &#40;Transact-SQL&#41;](../Topic/FileTableRootPath%20\(Transact-SQL\).md)|**Added**|[Work with Directories and Paths in FileTables](../../Topics\TopicNameNotContainA/Work-with-Directories-and-Paths-in-FileTables.md)|  
|[GetFileNamespacePath &#40;Transact-SQL&#41;](../Topic/GetFileNamespacePath%20\(Transact-SQL\).md)|**Added**|[Work with Directories and Paths in FileTables](../../Topics\TopicNameNotContainA/Work-with-Directories-and-Paths-in-FileTables.md)|  
|[GetPathLocator &#40;Transact-SQL&#41;](../Topic/GetPathLocator%20\(Transact-SQL\).md)|**Added**|[Work with Directories and Paths in FileTables](../../Topics\TopicNameNotContainA/Work-with-Directories-and-Paths-in-FileTables.md)|  
  
##  <a name="sproc"></a> Stored Procedures  
  
|Object|Status|More Information|  
|------------|------------|----------------------|  
|[sp_kill_filestream_non_transacted_handles &#40;Transact-SQL&#41;](../Topic/sp_kill_filestream_non_transacted_handles%20\(Transact-SQL\).md)|**Added**|[Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
  
##  <a name="cv"></a> Catalog Views  
  
|Object|Status|More Information|  
|------------|------------|----------------------|  
|[sys.database_filestream_options &#40;Transact-SQL&#41;](../Topic/sys.database_filestream_options%20\(Transact-SQL\).md)|**Added**|[Enable the Prerequisites for FileTable](../../Topics\TopicNameNotContainA/Enable-the-Prerequisites-for-FileTable.md)|  
|[sys.filetable_system_defined_objects &#40;Transact-SQL&#41;](../Topic/sys.filetable_system_defined_objects%20\(Transact-SQL\).md)|**Added**|[Create, Alter, and Drop FileTables](../../Topics\TopicNameNotContainA/Create,-Alter,-and-Drop-FileTables.md)<br /><br /> [Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
|[sys.filetables &#40;Transact-SQL&#41;](../Topic/sys.filetables%20\(Transact-SQL\).md)|**Added**|[Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
|[sys.tables &#40;Transact-SQL&#41;](../Topic/sys.tables%20\(Transact-SQL\).md)|Changed|[Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
  
##  <a name="dmv"></a> Dynamic Management Views  
  
|Object|Status|More Information|  
|------------|------------|----------------------|  
|[sys.dm_filestream_non_transacted_handles &#40;Transact-SQL&#41;](../Topic/sys.dm_filestream_non_transacted_handles%20\(Transact-SQL\).md)|**Added**|[Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)|  
  
## See Also  
 [Manage FileTables](../../Topics\TopicNameNotContainA/Manage-FileTables.md)  
  
  