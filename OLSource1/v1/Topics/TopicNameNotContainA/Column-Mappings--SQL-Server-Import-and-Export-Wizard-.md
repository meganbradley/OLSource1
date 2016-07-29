---
title: "Column Mappings (SQL Server Import and Export Wizard)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eadc54a6-f936-4ffc-91d7-fbfd2bdcab93
caps.latest.revision: 47
manager: jhubbard
---
# Column Mappings (SQL Server Import and Export Wizard)
After you select the existing tables and views to copy or review the query that you provided, if you click **Edit mappings**, the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Import and Export Wizard shows the **Column Mappings** dialog box. On this page you can specify and configure destination columns to receive the copied data.  
  
 You don't have to copy all the columns in a table when you select the Table Copy option. Select **<ignore\>** in the **Destination** column of the **Column Mappings** dialog box for columns that you don't want to copy.  
  
 For more info about how the wizard maps data types from source columns to destination columns, see [How the Wizard maps data types from source to destination](../../Topics/TopicNameNotContainA/SQL-Server-Import-and-Export-Wizard.md#wizardMapping).  
  
 For more info about the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Import and Export Wizard and how it works, see [SQL Server Import and Export Wizard](../../Topics/TopicNameNotContainA/SQL-Server-Import-and-Export-Wizard.md).  
  
> [!NOTE]  
>  If the **Create destination table** option and the **Edit SQL** button are disabled on the **Column Mappings** page, go back to the **Select Source Tables and Views** page and enter the name of a new table in the **Destination** column. After you specify a new destination table or tables and click **Next**, the **Create destination table** option is automatically selected and the **Edit SQL** button is enabled on the **Column Mappings** page. You can select **Edit SQL** to show the **Create Table SQL Statement** dialog box.  
  
## Screen shot  
 The following screen shot shows the **Column Mappings** dialog box of the Wizard.  
  
 ![Column mappings page of the Import and Export Wizard](../../Topics/TopicNameNotContainA/media/Column-mappings.png "Column)  
  
## Options on this page  
 **Source**  
 Identifies the selected source table, view, or query.  
  
 **Destination**  
 Identifies the selected destination table, view, or query.  
  
 **Create destination table/file**  
 Specify whether to create the destination table if it does not already exist.  
  
 If you specified a new destination table on the **Select Source Tables and Views** page, the **Create destination table** option is automatically selected and the **Edit SQL** button is enabled. Otherwise, you can go back to the **Select Source Tables and Views** page and enter the name of a new table in the **Destination** column.  
  
 **Delete rows in destination table/file**  
 Specify whether to clear the data from an existing table before loading new data.  
  
 **Append rows to destination table/file**  
 Specify whether to append the new data to the data already present in an existing table.  
  
 **Edit SQL**  
 Use the default statement in the **Create Table SQL Statement** dialog box, or modify it for your purposes. If you modify this statement, you must also make associated changes to table mapping. For more info, see [Create Table SQL Statement (SQL Server Import and Export Wizard)](../../Topics/TopicNameNotContainA/Create-Table-SQL-Statement--SQL-Server-Import-and-Export-Wizard-.md).  
  
 If you specified a new destination table on the **Select Source Tables and Views** page, the **Create destination table** option is automatically selected and the **Edit SQL** button is enabled. Otherwise, you can go back to the **Select Source Tables and Views** page and enter the name of a new table in the **Destination** column.  
  
 **Drop and re-create destination table**  
 Choose this option to overwrite the destination table. This option is only available when you use the wizard to create the destination table. The destination table is only dropped and re-created if you save the package that the wizard creates, and then run the package again.  
  
 **Enable identity insert**  
 Choose this option to allow existing identity values in the source data to be inserted into an identity column in the destination table. By default, the destination identity column does not allow this.  
  
> [!NOTE]  
>  If your existing primary keys are in an identity column or the equivalent, you typically have to select this option to keep your existing primary key values.  Otherwise the destination identity column assigns new values.  
  
 **Mappings**  
 Displays how each column in the data source maps to a column in the destination.  
  
 This list has the following columns:  
  
 **Source**  
 View each source column for which you can set transformation parameters.  
  
 **Destination**  
 Specify whether you want to ignore a column during the copy operation. You can copy only a subset of columns by selecting **<ignore\>** in this column for columns that you want to skip. Before you map columns, you must ignore all columns that will not be mapped.  
  
 **Type**  
 Select a data type for the column.  
  
 **Nullable**  
 Specify whether a column will allow a null value.  
  
 **Size**  
 Specify the number of characters in the column.  
  
 **Precision**  
 Specify the precision of displayed data, referring to the number of digits.  
  
 **Scale**  
 Specify the scale of displayed data, referring to the number of decimal places.  
  
## What's next?  
 After you specify and configure destination columns to receive the copied data and click **OK**, the **Column Mappings** dialog box returns you to the **Select Source Tables and Views** page or to the **Configure Flat File Destination** page. For more info, see [Select Source Tables and Views (SQL Server Import and Export Wizard)](../../Topics/TopicNameNotContainA/Select-Source-Tables-and-Views--SQL-Server-Import-and-Export-Wizard-.md) or [Configure Flat File Destination (SQL Server Import and Export Wizard)](../../Topics/TopicNameNotContainA/Configure-Flat-File-Destination--SQL-Server-Import-and-Export-Wizard-.md).  
  
 If you specified a mapping that's not valid in the **Mappings** list, then the **Column Mappings** dialog box takes you to the **Review Data Type Mapping** page. On this page, you review the warnings, specify conversion options, and also specify how to handle errors. For more info, see [Review Data Type Mapping (SQL Server Import and Export Wizard)](../../Topics/TopicNameNotContainA/Review-Data-Type-Mapping--SQL-Server-Import-and-Export-Wizard-.md).