---
title: Install and Configure Semantic Search
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-search
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2cdd0568-7799-474b-82fb-65d79df3057c
---
# Install and Configure Semantic Search
  Describes the prerequisites for statistical semantic search and how to install or check them.  
  
## Installing Semantic Search  
  
###  <a name="HowToCheckInstalled"></a> How To: Check Whether Semantic Search Is Installed  
 Query the **IsFullTextInstalled** property of the [SERVERPROPERTY &#40;Transact-SQL&#41;](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md) metadata function.  
  
 A return value of 1 indicates that Full\-Text Search and Semantic Search are installed; a return value of 0 indicates that they are not installed.  
  
```tsql  
SELECT SERVERPROPERTY('IsFullTextInstalled');  
GO  
```  
  
###  <a name="BasicsSemanticSearch"></a> How To: Install Semantic Search  
 To install Semantic Search, select **Full\-Text and Semantic Extractions for Search** on the **Features to Install** page during setup.  
  
 Statistical Semantic Search depends on Full\-Text Search. These two optional features of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] are installed together.  
  
## Installing or Removing the Semantic Language Statistics Database  
 Semantic Search has an additional external dependency that is called the semantic language statistics database. This database contains the statistical language models required by semantic search. A single semantic language statistics database contains the language models for all the languages that are supported for semantic indexing.  
  
###  <a name="HowToCheckDatabase"></a> How To: Check Whether the Semantic Language Statistics Database Is Installed  
 Query the catalog view [sys.fulltext_semantic_language_statistics_database &#40;Transact-SQL&#41;](../Topic/sys.fulltext_semantic_language_statistics_database%20\(Transact-SQL\).md).  
  
 If the semantic language statistics database is installed and registered for the instance, then the query results contain a single row of information about the database.  
  
```tsql  
SELECT * FROM sys.fulltext_semantic_language_statistics_database;  
GO  
```  
  
###  <a name="HowToInstallModel"></a> How To: Install, Attach, and Register the Semantic Language Statistics Database  
 The semantic language statistics database is not installed by the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] setup program. To set up the Semantic Language Statistics database as a prerequisite for semantic indexing, do the following tasks:  
  
 **1. Install the semantic language statistics database.**  
 1.  Locate the semantic language statistics database on the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installation media or download it from the Web.  
  
    -   Locate the Windows installer package named **SemanticLanguageDatabase.msi** on the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installation media.  
  
    -   Download the installer package from the [Microsoft® SQL Server® 2014 Semantic Language Statistics](http://go.microsoft.com/fwlink/?LinkID=296743) page on the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Download Center.  
  
2.  Run the **SemanticLanguageDatabase.msi** Windows installer package to extract the database and log file.  
  
     You can optionally change the destination directory. By default, the installer extracts the files to a folder named **Microsoft Semantic Language Database** in the Program Files folder. The MSI file contains a compressed database file and log file.  
  
3.  Move the extracted database file and log file to a suitable location in the file system.  
  
     If you leave the files in their default location, it will not be possible to extract another copy of the database for another instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
> [!IMPORTANT]  
>  When the semantic language statistics database is extracted, restricted permissions are assigned to the database file and log file in the default location in the file system. As a result, you may not have permission to attach the database if you leave it in the default location. If an error is raised when you try to attach the database, move the files, or check and fix file system permissions as appropriate.  
  
 **2. Attach the semantic language statistics database.**  
 Attach the database to the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] by using [!INCLUDE[ssManStudio](../../Token\Other/ssManStudio_md.md)] or by calling [CREATE DATABASE &#40;SQL Server Transact-SQL&#41;](../Topic/CREATE%20DATABASE%20\(SQL%20Server%20Transact-SQL\).md) with the **FOR ATTACH** syntax. For more information, see [Database Detach and Attach &#40;SQL Server&#41;](../Topic/Database%20Detach%20and%20Attach%20\(SQL%20Server\).md).  
  
 By default, the name of the database is **semanticsdb**. You can optionally give the database a different name when you attach it. You have to provide this name when you register the database in the subsequent step.  
  
```tsql  
CREATE DATABASE semanticsdb  
            ON ( FILENAME = 'C:\Microsoft Semantic Language Database\semanticsdb.mdf' )  
            LOG ON ( FILENAME = 'C:\Microsoft Semantic Language Database\semanticsdb_log.ldf' )  
            FOR ATTACH;  
GO  
```  
  
 This code sample assumes that you have moved the database from its default location to a new location.  
  
 **3. Register the semantic language statistics database.**  
 Call the stored procedure [sp_fulltext_semantic_register_language_statistics_db &#40;Transact-SQL&#41;](../Topic/sp_fulltext_semantic_register_language_statistics_db%20\(Transact-SQL\).md) and provide the name that you gave to the database when you attached it.  
  
```tsql  
EXEC sp_fulltext_semantic_register_language_statistics_db @dbname = N'semanticsdb';  
GO  
```  
  
###  <a name="HowToUnregister"></a> How To: Unregister, Detach, and Remove the Semantic Language Statistics Database  
 **Unregister the semantic language statistics database.**  
 Call the stored procedure [sp_fulltext_semantic_unregister_language_statistics_db &#40;Transact-SQL&#41;](../Topic/sp_fulltext_semantic_unregister_language_statistics_db%20\(Transact-SQL\).md). You do not have to provide the name of the database since an instance can have only one semantic language statistics database.  
  
```tsql  
EXEC sp_fulltext_semantic_unregister_language_statistics_db;  
GO  
```  
  
 **Detach the semantic language statistics database.**  
 Call the stored procedure [sp_detach_db &#40;Transact-SQL&#41;](../Topic/sp_detach_db%20\(Transact-SQL\).md) and provide the name of the database.  
  
```tsql  
USE master;  
GO  
  
EXEC sp_detach_db @dbname = N'semanticsdb';  
GO  
```  
  
 **Remove the semantic language statistics database.**  
 After unregistering and detaching the database, you can simply delete the database file. There is no uninstall program and there is no entry in **Programs and Features** in the Control Panel.  
  
###  <a name="reqinstall"></a> Requirements and Restrictions for Installing and Removing the Semantic Language Statistics Database  
  
-   You can only attach and register one semantic language statistics database on an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
     Each instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] on a single computer requires a separate physical copy of the semantic language statistics database. Attach one copy to each instance.  
  
-   You cannot detach a valid and registered semantic language statistics database and replace it with an arbitrary database that has the same name. Doing so will cause active or future index populations to fail.  
  
-   The semantic language statistics database is read\-only. You cannot customize this database. If you alter the content of the database in any way, the results for future semantic indexing are indeterministic. To restore the original state of this data, you can drop the altered database, and download and attach a new and unaltered copy of the database.  
  
-   It is possible to detach or drop the semantic language statistics database. If there are any active indexing operations that have read locks on the database, then the detach or drop operation will fail or time out. This is consistent with existing behavior. After the database is removed, semantic indexing operations will fail.  
  
## Installing Optional Support for Newer Document Types  
  
###  <a name="office"></a> How to: Install the Latest Filters for Microsoft Office and other Microsoft Document Types  
 This release of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installs the latest [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] word breakers and stemmers, but does not install the latest filters for [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Office documents and other [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] document types. These filters are required for indexing documents created with recent versions of [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Office and other [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] applications. To download the latest filters, see [Microsoft Office 2010 Filter Packs](http://go.microsoft.com/fwlink/?LinkId=218293).  
  
  