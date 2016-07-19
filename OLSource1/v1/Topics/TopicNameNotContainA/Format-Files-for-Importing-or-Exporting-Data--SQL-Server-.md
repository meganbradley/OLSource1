---
title: Format Files for Importing or Exporting Data (SQL Server)
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-bulk-import-export
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b7b97d68-4336-4091-aee4-1941fab568e3
manager: jhubbard
---
# Format Files for Importing or Exporting Data (SQL Server)
When you bulk import data into a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] table or bulk export data from a table, you can use a *format file* to store all the format information that is required to bulk export or bulk import data. This includes format information for each field in a data file relative to that table.  
  
 [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] supports two types of format files: XML formats and non-XML format files. Both non-XML format files and XML format files contain descriptions of every field in a data file, and XML format files also contain descriptions of the corresponding table columns. Generally, XML and non-XML format files are interchangeable. However, we recommend that you use the XML syntax for new format files because they provide several advantages over non-XML format files. For more information, see [XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/XML-Format-Files--SQL-Server-.md).  
  
 **In this Topic:**  
  
-   [Benefits of Format Files](#Benefits)  
  
-   [Examples of Format Files](#ExamplesOfFFs)  
  
-   [When Is a Format File Required?](#WhenFFrequired)  
  
-   [Related Tasks](#RelatedTasks)  
  
##  <a name="Benefits"></a> Benefits of Format Files  
  
-   Provides a flexible system for writing data files that requires little or no editing to comply with other data formats or to read data files from other software.  
  
-   Enables you to bulk import data without having to add or delete unnecessary data or to reorder existing data in the data file. Format files are particularly useful when a mismatch exists between fields in the data file and columns in the table.  
  
##  <a name="ExamplesOfFFs"></a> Examples of Format Files  
 The following examples show the layout of a non-XML format file and of an XML format file. These format files correspond to the `HumanResources.myTeam` table in the [!INCLUDE[ssSampleDBobject](../../Topics/TopicNameContainA/includes/ssSampleDBobject_md.md)] sample database. This table contains four columns: `EmployeeID`, `Name`, `Title`, and `ModifiedDate`.  
  
> [!NOTE]  
>  For information about this table and how to create it, see [HumanResources.myTeam Sample Table (SQL Server)](../../Topics/TopicNameNotContainA/HumanResources.myTeam-Sample-Table--SQL-Server-.md).  
  
### A. Using a non-XML format file  
 The following non-XML format file uses the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] native data format for the `HumanResources.myTeam` table. This format file was created by using the following `bcp` command.  
  
```  
bcp AdventureWorks.HumanResources.myTeam format nul -f myTeam.Fmt -n -T   
The contents of this format file are as follows: 9.0  
4  
1       SQLSMALLINT   0       2       ""   1     EmployeeID               ""  
2       SQLNCHAR      2       100     ""   2     Name                     SQL_Latin1_General_CP1_CI_AS  
3       SQLNCHAR      2       100     ""   3     Title                    SQL_Latin1_General_CP1_CI_AS  
4       SQLNCHAR      2       100     ""   4     Background               SQL_Latin1_General_CP1_CI_AS  
```  
  
 For more information, see [Non-XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/Non-XML-Format-Files--SQL-Server-.md).  
  
 [&#91;Top&#93;](#Top)  
  
### B. Using an XML format file  
 The following XML format file uses the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] native data format for the `HumanResources.myTeam` table. This format file was created by using the following `bcp` command.  
  
```  
bcp AdventureWorks.HumanResources.myTeam format nul -f myTeam.Xml -x -n -T   
```  
  
 The format file contains:  
  
```  
 <?xml version="1.0"?>  
<BCPFORMAT xmlns="http://schemas.microsoft.com/sqlserver/2004/bulkload/format" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">  
 <RECORD>  
  <FIELD ID="1" xsi:type="NativePrefix" LENGTH="1"/>  
  <FIELD ID="2" xsi:type="NCharPrefix" PREFIX_LENGTH="2" MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
  <FIELD ID="3" xsi:type="NCharPrefix" PREFIX_LENGTH="2" MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
  <FIELD ID="4" xsi:type="NCharPrefix" PREFIX_LENGTH="2" MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
 </RECORD>  
 <ROW>  
  <COLUMN SOURCE="1" NAME="EmployeeID" xsi:type="SQLSMALLINT"/>  
  <COLUMN SOURCE="2" NAME="Name" xsi:type="SQLNVARCHAR"/>  
  <COLUMN SOURCE="3" NAME="Title" xsi:type="SQLNVARCHAR"/>  
  <COLUMN SOURCE="4" NAME="Background" xsi:type="SQLNVARCHAR"/>  
 </ROW>  
</BCPFORMAT>  
```  
  
 For more information, see [XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/XML-Format-Files--SQL-Server-.md).  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="WhenFFrequired"></a> When Is a Format File Required?  
 An INSERT ... SELECT * FROM OPENROWSET(BULK...) statement always requires a format file.  
  
-   For **bcp** or BULK INSERT, in simple situations, using a format file is optional and rarely necessary. However, for complex bulk-import situations, a format file is frequently required.  
  
 Format files are required if:  
  
-   The same data file is used as a source for multiple tables that have different schemas.  
  
-   The data file has a different number of fields that the target table has columns; for example:  
  
    -   The target table contains at least one column for which either a default value is defined or NULL is allowed.  
  
    -   The users do not have SELECT/INSERT permissions on one or more columns in the table.  
  
    -   A single data file is used with two or more tables that have different schemas.  
  
-   The column order is different for the data file and table.  
  
-   The terminating characters or prefix lengths differ among the columns of the data file.  
  
> [!NOTE]  
>  In the absence of a format file, if a **bcp** command specifies a data-format switch (**-n**, **-c**, **-w**, or **-N**) or a BULK INSERT operation specifies the DATAFILETYPE option, the specified data format is used as the default method of interpreting the fields of the data file.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create a Format File (SQL Server)](../../Topics/TopicNameContainA/Create-a-Format-File--SQL-Server-.md)  
  
-   [Use a Format File to Bulk Import Data (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Bulk-Import-Data--SQL-Server-.md)  
  
-   [Use a Format File to Skip a Table Column (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Table-Column--SQL-Server-.md)  
  
-   [Use a Format File to Skip a Data Field (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Data-Field--SQL-Server-.md)  
  
-   [Use a Format File to Map Table Columns to Data-File Fields (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Map-Table-Columns-to-Data-File-Fields--SQL-Server-.md)  
  
 [&#91;Top&#93;](#Top)  
  
## See Also  
 [Non-XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/Non-XML-Format-Files--SQL-Server-.md)   
 [XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/XML-Format-Files--SQL-Server-.md)   
 [Data Formats for Bulk Import or Bulk Export (SQL Server)](../../Topics/TopicNameNotContainA/Data-Formats-for-Bulk-Import-or-Bulk-Export--SQL-Server-.md)