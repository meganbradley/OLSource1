---
title: "Set or Change the Server Collation"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3242deef-6f5f-4051-a121-36b3b4da851d
caps.latest.revision: 35
manager: jhubbard
---
# Set or Change the Server Collation
The server collation acts as the default collation for all system databases that are installed with the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], and also any newly created user databases. The server collation is specified during [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] installation. For more information, see [Collation and Unicode Support](../../Topics/TopicNameNotContainA/Collation-and-Unicode-Support.md).  
  
## Changing the Server Collation  
 Changing the default collation for an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] can be a complex operation and involves the following steps:  
  
-   Make sure you have all the information or scripts needed to re-create your user databases and all the objects in them.  
  
-   Export all your data using a tool such as the [bcp Utility](../../Topics/TopicNameNotContainA/bcp-Utility.md). For more information, see [Bulk Import and Export of Data (SQL Server)](../../Topics/TopicNameNotContainA/Bulk-Import-and-Export-of-Data--SQL-Server-.md).  
  
-   Drop all the user databases.  
  
-   Rebuild the master database specifying the new collation in the SQLCOLLATION property of the **setup** command. For example:  
  
    ```  
    Setup /QUIET /ACTION=REBUILDDATABASE /INSTANCENAME=InstanceName   
    /SQLSYSADMINACCOUNTS=accounts /[ SAPWD= StrongPassword ]   
    /SQLCOLLATION=CollationName  
    ```  
  
     For more information, see [Rebuild System Databases](../../Topics/TopicNameNotContainA/Rebuild-System-Databases.md).  
  
-   Create all the databases and all the objects in them.  
  
-   Import all your data.  
  
> [!NOTE]  
>  Instead of changing the default collation of an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], you can specify a default collation for each new database you create.  
  
## See Also  
 [Collation and Unicode Support](../../Topics/TopicNameNotContainA/Collation-and-Unicode-Support.md)   
 [Set or Change the Database Collation](../../Topics/TopicNameNotContainA/Set-or-Change-the-Database-Collation.md)   
 [Set or Change the Column Collation](../../Topics/TopicNameNotContainA/Set-or-Change-the-Column-Collation.md)   
 [Rebuild System Databases](../../Topics/TopicNameNotContainA/Rebuild-System-Databases.md)