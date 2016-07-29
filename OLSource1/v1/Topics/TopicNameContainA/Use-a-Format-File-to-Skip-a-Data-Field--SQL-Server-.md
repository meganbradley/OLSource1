---
title: "Use a Format File to Skip a Data Field (SQL Server)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-bulk-import-export
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6a76517e-983b-47a1-8f02-661b99859a8b
caps.latest.revision: 35
manager: jhubbard
---
# Use a Format File to Skip a Data Field (SQL Server)
A data file can contain more fields than the number of columns in the table. This topic describes modifying both non-XML and XML format files to accommodate a data file with more fields by mapping the table columns to the corresponding data fields and ignoring the extra fields.  
  
> [!NOTE]  
>  Either a non-XML or XML format file can be used to bulk import a data file into the table by using a **bcp** command, BULK INSERT statement, or INSERT ... SELECT * FROM OPENROWSET(BULK...) statement. For more information, see [Use a Format File to Bulk Import Data (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Bulk-Import-Data--SQL-Server-.md).  
  
## Sample Data File and Table  
 The examples of modified format files in this topic are based on the following table and data file.  
  
### Sample Table  
 The examples require that a table named `myTestSkipField` be created in the [!INCLUDE[ssSampleDBnormal](../../Topics/TopicNameContainA/includes/ssSampleDBnormal_md.md)] sample database under the `dbo` schema. To create this table, in [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] Query Editor, run the following code:  
  
```  
USE AdventureWorks2012;  
GO  
CREATE TABLE myTestSkipField   
   (  
   PersonID smallint,  
   FirstName nvarchar(50) ,  
   LastName nvarchar(50)   
   );  
GO  
```  
  
### Sample Data File  
 The data file, `myTestSkipField-c.dat`, contains the following records:  
  
```  
1,Skipme,DataField3,DataField4  
1,Skipme,DataField3,DataField4  
1,Skipme,DataField3,DataField4  
```  
  
 To bulk import data from `myTestSkipField-c.dat` into the `myTestSkipField` table, the format file must do the following:  
  
-   Map the first data field to the first column, `PersonID`.  
  
-   Skip the second data field.  
  
-   Map the third data field to the second column, `FirstName`.  
  
-   Map the fourth data field to the third column, `LastName`.  
  
## Non-XML Format File for More Data Fields  
 The following format file, `myTestSkipField.fmt`, maps the fields in `myTestSkipField-c.dat` to the columns of the `myTestSkipField` table. The format file uses character data format. Skipping a column mapping requires changing its column order value to 0, as shown for the `ExtraField` column in the format file.  
  
 The `myTestSkipField.fmt` format file contains the following information:  
  
```  
9.0  
4  
1       SQLCHAR       0       7       ","      1     PersonID               ""  
2       SQLCHAR       0       100       ","    0     ExtraField             SQL_Latin1_General_CP1_CI_AS  
3       SQLCHAR       0       100     ","      2     FirstName              SQL_Latin1_General_CP1_CI_AS  
4       SQLCHAR       0       100     "\r\n"   3     LastName               SQL_Latin1_General_CP1_CI_AS  
  
```  
  
> [!NOTE]  
>  For information about the syntax of non-XML format files, see [Non-XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/Non-XML-Format-Files--SQL-Server-.md).  
  
### Examples  
 The following example uses `INSERT ... SELECT * FROM OPENROWSET(BULK...)` using the `myTestSkipField.fmt` format file. The example bulk imports the `myTestSkipField-c.dat` data file into the `myTestSkipField` table. To create the sample table and data file, see "Sample Data File and Table," earlier in this topic.  
  
 In the [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] Query Editor, run the following code:  
  
```  
USE AdventureWorks2012;  
GO  
INSERT INTO myTestSkipField   
   SELECT *  
      FROM  OPENROWSET(BULK  'C:\myTestSkipField-c.dat',  
      FORMATFILE='C:\myTestSkipField.fmt'    
       ) AS t1;  
GO   
```  
  
## XML Format File for More Data Fields  
 The format file presented in this example is based on another format file, `myTestSkipField.xml`, which uses character data format throughout and whose fields correspond exactly in number and order to the columns in the `myTestSkipField` table. To view the contents of that format file, see [Create a Format File (SQL Server)](../../Topics/TopicNameContainA/Create-a-Format-File--SQL-Server-.md).  
  
 The following format file, `myTestSkipField.xml`, maps the fields in `myTestSkipField-c.dat` to the columns of the `myTestSkipField` table. The format file uses character data format.  
  
 The `myTestSkipField.xml` format file contains the following information:  
  
```  
<?xml version="1.0"?>  
<BCPFORMAT xmlns="http://schemas.microsoft.com/sqlserver/2004/bulkload/format" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">  
 <RECORD>  
  <FIELD ID="1" xsi:type="CharTerm" TERMINATOR="," MAX_LENGTH="7"/>  
  <FIELD ID="2" xsi:type="CharTerm" TERMINATOR="," MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
  <FIELD ID="3" xsi:type="CharTerm" TERMINATOR="," MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
  <FIELD ID="4" xsi:type="CharTerm" TERMINATOR="\r\n" MAX_LENGTH="100" COLLATION="SQL_Latin1_General_CP1_CI_AS"/>  
 </RECORD>  
 <ROW>  
  <COLUMN SOURCE="1" NAME="PersonID" xsi:type="SQLSMALLINT"/>  
  <COLUMN SOURCE="3" NAME="FirstName" xsi:type="SQLNVARCHAR"/>  
  <COLUMN SOURCE="4" NAME="LastName" xsi:type="SQLNVARCHAR"/>  
 </ROW>  
</BCPFORMAT>  
```  
  
### Examples  
 The following example uses `INSERT ... SELECT * FROM OPENROWSET(BULK...)` using the `myTestSkipField.Xml` format file. The example bulk imports the `myTestSkipField-c.dat` data file into the `myTestSkipField` table. To create the sample table and data file, see "Sample Data File and Table," earlier in this topic.  
  
 In the [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] Query Editor, run the following code:  
  
```  
USE AdventureWorks2012;  
GO  
INSERT INTO myTestSkipField   
  SELECT *  
      FROM  OPENROWSET(BULK  'C:\myTestSkipField-c.dat',  
      FORMATFILE='C:\myTestSkipField.xml'    
       ) AS t1;  
GO  
  
```  
  
> [!NOTE]  
>  For information about the syntax of the XML Schema and additional samples of XML format files, see [XML Format Files (SQL Server)](../../Topics/TopicNameNotContainA/XML-Format-Files--SQL-Server-.md).  
  
## See Also  
 [bcp Utility](../../Topics/TopicNameNotContainA/bcp-Utility.md)   
 [BULK INSERT](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2)   
 [OPENROWSET (Transact-SQL)](assetId:///f47eda43-33aa-454d-840a-bb15a031ca17)   
 [Use a Format File to Skip a Table Column (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Skip-a-Table-Column--SQL-Server-.md)   
 [Use a Format File to Map Table Columns to Data-File Fields (SQL Server)](../../Topics/TopicNameContainA/Use-a-Format-File-to-Map-Table-Columns-to-Data-File-Fields--SQL-Server-.md)