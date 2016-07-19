---
title: Import Bulk Data by Using BULK INSERT or OPENROWSET(BULK...) (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-bulk-import-export
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 18a64236-0285-46ea-8929-6ee9bcc020b9
manager: jhubbard
---
# Import Bulk Data by Using BULK INSERT or OPENROWSET(BULK...) (SQL Server)
This topic provides an overview of how to use the [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] BULK INSERT statement and the INSERT...SELECT * FROM OPENROWSET(BULK...) statement to bulk import data from a data file into a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] table. This topic also describes security considerations for using BULK INSERT and OPENROWSET(BULK…), and using these methods to bulk import from a remote data source.  
  
> [!NOTE]  
>  When you use BULK INSERT or OPENROWSET(BULK…), it is important to understand how [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] version handles impersonation. For more information, see "Security Considerations," later in this topic.  
  
## BULK INSERT Statement  
 BULK INSERT loads data from a data file into a table. This functionality is similar to that provided by the **in** option of the **bcp** command; however, the data file is read by the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process. For a description of the BULK INSERT syntax, see [Using Character Format to Import or Export Data](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2).  
  
### Examples  
 For BULK INSERT examples, see:  
  
-   [BULK INSERT (Transact-SQL)](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2)  
  
-   [Examples of Bulk Import and Export of XML Documents (SQL Server)](../../Topics/TopicNameNotContainA/Examples-of-Bulk-Import-and-Export-of-XML-Documents--SQL-Server-.md)  
  
-   [Keep Identity Values When Bulk Importing Data (SQL Server)](../../Topics/TopicNameNotContainA/Keep-Identity-Values-When-Bulk-Importing-Data--SQL-Server-.md)  
  
-   [Keep Nulls or Use Default Values During Bulk Import (SQL Server)](../../Topics/TopicNameNotContainA/Keep-Nulls-or-Use-Default-Values-During-Bulk-Import--SQL-Server-.md)  
  
-   [Specify Field and Row Terminators (SQL Server)](../../Topics/TopicNameNotContainA/Specify-Field-and-Row-Terminators--SQL-Server-.md)  
  
-   [Use a Format File to Bulk Import Data (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Bulk-Import-Data--SQL-Server-.md)  
  
-   [Use Character Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Character-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Native Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Native-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Unicode Character Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Unicode-Character-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Unicode Native Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Unicode-Native-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use a Format File to Skip a Table Column (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Table-Column--SQL-Server-.md)  
  
-   [Use a Format File to Map Table Columns to Data-File Fields (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Map-Table-Columns-to-Data-File-Fields--SQL-Server-.md)  
  
## OPENROWSET(BULK…) Function  
 The OPENROWSET bulk rowset provider is accessed by calling the OPENROWSET function and specifying the BULK option. The OPENROWSET(BULK…) function allows you to access remote data by connecting to a remote data source, such as a data file, through an OLE DB provider.  
  
 To bulk import data, call OPENROWSET(BULK…) from a SELECT…FROM clause within an INSERT statement. The basic syntax for bulk importing data is:  
  
 INSERT ... SELECT * FROM OPENROWSET(BULK...)  
  
 When used in an INSERT statement, OPENROWSET(BULK...) supports table hints. In addition to the regular table hints, such as TABLOCK, the BULK clause can accept the following specialized table hints: IGNORE_CONSTRAINTS (ignores only the CHECK constraints), IGNORE_TRIGGERS, KEEPDEFAULTS, and KEEPIDENTITY. For more information, see [Table Hint (Transact-SQL)](assetId:///8bf1316f-c0ef-49d0-90a7-3946bc8e7a89).  
  
 For information about additional uses of the BULK option, see [OPENROWSET (Transact-SQL)](assetId:///f47eda43-33aa-454d-840a-bb15a031ca17).  
  
### Examples  
 For examples of INSERT...SELECT * FROM OPENROWSET(BULK...) statements, see the following topics:  
  
-   [Examples of Bulk Import and Export of XML Documents (SQL Server)](../../Topics/TopicNameNotContainA/Examples-of-Bulk-Import-and-Export-of-XML-Documents--SQL-Server-.md)  
  
-   [Keep Identity Values When Bulk Importing Data (SQL Server)](../../Topics/TopicNameNotContainA/Keep-Identity-Values-When-Bulk-Importing-Data--SQL-Server-.md)  
  
-   [Keep Nulls or Use Default Values During Bulk Import (SQL Server)](../../Topics/TopicNameNotContainA/Keep-Nulls-or-Use-Default-Values-During-Bulk-Import--SQL-Server-.md)  
  
-   [Use a Format File to Bulk Import Data (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Bulk-Import-Data--SQL-Server-.md)  
  
-   [Use Character Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Character-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use a Format File to Skip a Table Column (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Table-Column--SQL-Server-.md)  
  
-   [Use a Format File to Skip a Data Field (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Data-Field--SQL-Server-.md)  
  
-   [Use a Format File to Map Table Columns to Data-File Fields (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Map-Table-Columns-to-Data-File-Fields--SQL-Server-.md)  
  
## Security Considerations  
 If a user uses a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] login, the security profile of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process account is used. A login using SQL Server authentication cannot be authenticated outside of the Database Engine. Therefore, when a BULK INSERT command is initiated by a login using SQL Server authentication, the connection to the data is made using the security context of the SQL Server process account (the account used by the SQL Server Database Engine service). To successfully read the source data you must grant the account used by the SQL Server Database Engine, access to the source data. In contrast, if a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] user logs on by using Windows Authentication, the user can read only those files that can be accessed by the user account, regardless of the security profile of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process.  
  
 For example, consider a user who logged in to an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] by using Windows Authentication. For the user to be able to use BULK INSERT or OPENROWSET to import data from a data file into a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] table, the user account requires read access to the data file. With access to the data file, the user can import data from the file into a table even if the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process does not have permission to access the file. The user does not have to grant file-access permission to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process.  
  
 [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] and [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows can be configured to enable an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] to connect to another instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] by forwarding the credentials of an authenticated Windows user. This arrangement is known as *impersonation* or *delegation*. Understanding how [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] version handle security for user impersonation is important when you use BULK INSERT or OPENROWSET. User impersonation allows the data file to reside on a different computer than either the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] process or the user. For example, if a user on **Computer_A** has access to a data file on **Computer_B**, and the delegation of credentials has been set appropriately, the user can connect to an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] that is running on **Computer_C**, access the data file on **Computer_B**, and bulk import data from that file into a table on **Computer_C**.  
  
## Bulk Importing from a Remote Data File  
 To use BULK INSERT or INSERT...SELECT \* FROM OPENROWSET(BULK...) to bulk import data from another computer, the data file must be shared between the two computers. To specify a shared data file, use its universal naming convention (UNC) name, which takes the general form, **\\\\***Servername***\\***Sharename***\\***Path***\\***Filename*. Additionally, the account used to access the data file must have the permissions that are required for reading the file on the remote disk.  
  
 For example, the following `BULK INSERT` statement bulk imports data into the `SalesOrderDetail` table of the `AdventureWorks` database from a data file that is named `newdata.txt`. This data file resides in a shared folder named `\dailyorders` on a network share directory named `salesforce` on a system named `computer2`.  
  
```  
BULK INSERT AdventureWorks2012.Sales.SalesOrderDetail  
   FROM '\\computer2\salesforce\dailyorders\neworders.txt';  
GO  
```  
  
> [!NOTE]  
>  This restriction does not apply to the **bcp** utility because the client reads the file independently of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
## See Also  
 [INSERT (Transact-SQL)](assetId:///1054c76e-0fd5-4131-8c07-a6c5d024af50)   
 [SELECT Clause (Transact-SQL)](assetId:///2616d800-4853-4cf1-af77-d32d68d8c2ef)   
 [Bulk Import and Export of Data (SQL Server)](../../Topics/TopicNameNotContainA/Bulk-Import-and-Export-of-Data--SQL-Server-.md)   
 [OPENROWSET (Transact-SQL)](assetId:///f47eda43-33aa-454d-840a-bb15a031ca17)   
 [SELECT (Transact-SQL)](assetId:///dc85caea-54d1-49af-b166-f3aa2f3a93d0)   
 [FROM (Transact-SQL)](assetId:///36b19e68-94f6-4539-aeb1-79f5312e4263)   
 [bcp Utility](../../Topics/TopicNameNotContainA/bcp-Utility.md)   
 [BULK INSERT (Transact-SQL)](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2)