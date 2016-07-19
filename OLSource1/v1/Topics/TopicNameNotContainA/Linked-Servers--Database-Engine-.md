---
title: Linked Servers (Database Engine)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6ef578bf-8da7-46e0-88b5-e310fc908bb0
manager: jhubbard
---
# Linked Servers (Database Engine)
Configure a linked server to enable the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] to execute commands against OLE DB data sources outside of the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. Typically linked servers are configured to enable the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] to execute a [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statement that includes tables in another instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], or another database product such as Oracle. Many types OLE DB data sources can be configured as linked servers, including [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Access and Excel. Linked servers offer the following advantages:  
  
-   The ability to access data from outside of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
-   The ability to issue distributed queries, updates, commands, and transactions on heterogeneous data sources across the enterprise.  
  
-   The ability to address diverse data sources similarly.  
  
 You can configure a linked server by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or by using the [sp_addlinkedserver (Transact-SQL)](assetId:///fed3adb0-4c15-4a1a-8acd-1b184aff558f) statement. OLE DB providers vary greatly in the type and number of parameters required. For example some providers require you to provide a security context for the connection using [sp_addlinkedsrvlogin (Transact-SQL)](assetId:///eb69f303-1adf-4602-b6ab-f62e028ed9f6). Some OLE DB providers allow [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] to update data on the OLE DB source. Others provide only read-only data access. For information about each OLE DB provider, consult documentation for that OLE DB provider.  
  
## Linked Server Components  
 A linked server definition specifies the following objects:  
  
-   An OLE DB provider  
  
-   An OLE DB data source  
  
 An *OLE DB provider* is a DLL that manages and interacts with a specific data source. An *OLE DB data source* identifies the specific database that can be accessed through OLE DB. Although data sources queried through linked server definitions are ordinarily databases, OLE DB providers exist for a variety of files and file formats. These include text files, spreadsheet data, and the results of full-text content searches.  
  
 The [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Native Client OLE DB Provider (PROGID: SQLNCLI11) is the official OLE DB provider for [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
> [!NOTE]  
>  [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] distributed queries are designed to work with any OLE DB provider that implements the required OLE DB interfaces. However, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] has been tested against only the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Native Client OLE DB Provider and certain other providers.  
  
## Linked Server Details  
 The following illustration shows the basics of a linked server configuration.  
  
 ![Client tier, server tier, and database server tier](../../Topics/TopicNameNotContainA/media/lsvr.gif "lsvr")  
  
 Typically, linked servers are used to handle distributed queries. When a client application executes a distributed query through a linked server, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] parses the command and sends requests to OLE DB. The rowset request may be in the form of executing a query against the provider or opening a base table from the provider.  
  
 For a data source to return data through a linked server, the OLE DB provider (DLL) for that data source must be present on the same server as the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
 When a third-party OLE DB provider is used, the account under which the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] service runs must have read and execute permissions for the directory, and all subdirectories, in which the provider is installed.  
  
## Managing Providers  
 There is a set of options that control how [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] loads and uses OLE DB providers that are specified in the registry.  
  
## Managing Linked Server Definitions  
 When you are setting up a linked server, register the connection information and data source information with [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. After registered, that data source can be referred to with a single logical name.  
  
 You can use stored procedures and catalog views to manage linked server definitions:  
  
-   Create a linked server definition by running **sp_addlinkedserver**.  
  
-   View information about the linked servers defined in a specific instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] by running a query against the **sys.servers** system catalog views.  
  
-   Delete a linked server definition by running **sp_dropserver**. You can also use this stored procedure to remove a remote server.  
  
 You can also define linked servers by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]. In the Object Explorer, right-click **Server Objects**, select **New**, and select **Linked Server**. You can delete a linked server definition by right-clicking the linked server name and selecting **Delete**.  
  
 When you execute a distributed query against a linked server, include a fully qualified, four-part table name for each data source to query. This four-part name should be in the form *linked_server_name.catalog***.***schema***.***object_name*.  
  
> [!NOTE]  
>  Linked servers can be defined to point back (loop back) to the server on which they are defined. Loopback servers are most useful when testing an application that uses distributed queries on a single server network. Loopback linked servers are intended for testing and are not supported for many operations, such as distributed transactions.  
  
## Related Tasks  
 [Create Linked Servers (SQL Server Database Engine)](../../Topics/TopicNameNotContainA/Create-Linked-Servers--SQL-Server-Database-Engine-.md)  
  
 [sp_addlinkedserver (Transact-SQL)](assetId:///fed3adb0-4c15-4a1a-8acd-1b184aff558f)  
  
 [sp_addlinkedsrvlogin (Transact-SQL)](assetId:///eb69f303-1adf-4602-b6ab-f62e028ed9f6)  
  
 [sp_dropserver (Transact-SQL)](assetId:///0fc83e35-0caa-49a3-a4b6-a1890d4f46ef)  
  
## Related Content  
 [sys.servers (Transact-SQL)](assetId:///4e774ed9-4e83-4726-9f1d-8efde8f9feff)  
  
 [sp_linkedservers (Transact-SQL)](assetId:///d8f82f78-8a1f-4831-bcee-7c36c6e7dfbb)