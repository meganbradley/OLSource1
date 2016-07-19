---
title: Import Native and Character Format Data from Earlier Versions of SQL Server
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-bulk-import-export
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e644696f-9017-428e-a5b3-d445d1c630b3
manager: jhubbard
---
# Import Native and Character Format Data from Earlier Versions of SQL Server
In [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], you can use **bcp** to import native and character format data from [!INCLUDE[ssVersion2000](../../Topics/TopicNameContainA/includes/ssVersion2000_md.md)], [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)], [!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)], [!INCLUDE[ssKilimanjaro](../../Topics/TopicNameContainA/includes/ssKilimanjaro_md.md)], or [!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)] by using the **-V** switch. The **-V** switch causes [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] to use data types from the specified earlier version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], and the data file format are the same as the format in that earlier version.  
  
 To specify an earlier [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] version for a data file, use the **-V** switch with one of the following qualifiers:  
  
|SQL Server version|Qualifier|  
|------------------------|---------------|  
|[!INCLUDE[ssVersion2000](../../Topics/TopicNameContainA/includes/ssVersion2000_md.md)]|**-V**<br /> **80**|  
|[!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)]|**-V**<br /> **90**|  
|[!INCLUDE[ssKatmai](../../Topics/TopicNameContainA/includes/ssKatmai_md.md)]|**-V**<br /> **100**|  
|[!INCLUDE[ssSQL11](../../Topics/TopicNameContainA/includes/ssSQL11_md.md)]|**-V 110**|  
  
## Interpretation of Data Types  
 [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)] and later versions have support for some new types. When you want to import a new data type into an earlier [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] version, the data type must be stored in a format that readable by the older **bcp** clients. The following table summarizes how the new data types are converted for compatibility with the earlier versions of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)].  
  
|New data types in SQL Server 2005|Compatible data types in version 6*x*|Compatible data types in version 70|Compatible data types in version 80|  
|---------------------------------------|-------------------------------------------|-----------------------------------------|-----------------------------------------|  
|**bigint**|**decimal**|**decimal**|*|  
|**sql_variant**|**text**|**nvarchar(4000)**|*|  
|**varchar(max)**|**text**|**text**|**text**|  
|**nvarchar(max)**|**ntext**|**ntext**|**ntext**|  
|**varbinary(max)**|**image**|**image**|**image**|  
|XML|**ntext**|**ntext**|**ntext**|  
|UDT**|**image**|**image**|**image**|  
  
 *This type is natively supported.  
  
 **UDT indicates a user defined type.  
  
## Exporting using –V 80  
 When you bulk export data by using the **–V80** switch, **nvarchar(max)**, **varchar(max)**, **varbinary(max)**, XML, and UDT data in native mode are stored with a 4-byte prefix, like **text**, **image**, and **ntext** data, rather than with an 8-byte prefix, which is the default for [!INCLUDE[ssVersion2005](../../Topics/TopicNameContainA/includes/ssVersion2005_md.md)] and later versions.  
  
## Copying Date Values  
 **bcp** uses the ODBC bulk copy API. Therefore, to import date values into [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], **bcp** uses the ODBC date format (*yyyy-mm-dd hh:mm:ss*[*.f...*]).  
  
 The **bcp** command exports character format data files using the ODBC default format for **datetime** and **smalldatetime** values. For example, a **datetime** column containing the date `12 Aug 1998` is bulk copied to a data file as the character string `1998-08-12 00:00:00.000`.  
  
> [!IMPORTANT]  
>  When importing data into a **smalldatetime** field using **bcp**, be sure the value for seconds is 00.000; otherwise the operation will fail. The **smalldatetime** data type only holds values to the nearest minute. BULK INSERT and INSERT ... SELECT * FROM OPENROWSET(BULK...) will not fail in this instance but will truncate the seconds value.  
  
##  <a name="RelatedTasks"></a> Related Tasks  
 **To use data formats for bulk import or bulk export**  
  
-   [Use Character Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Character-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Native Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Native-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Unicode Character Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Unicode-Character-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
-   [Use Unicode Native Format to Import or Export Data (SQL Server)](../../Topics/TopicNameNotContainA/Use-Unicode-Native-Format-to-Import-or-Export-Data--SQL-Server-.md)  
  
## See Also  
 [bcp Utility](../../Topics/TopicNameNotContainA/bcp-Utility.md)   
 [BULK INSERT (Transact-SQL)](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2)   
 [OPENROWSET (Transact-SQL)](assetId:///f47eda43-33aa-454d-840a-bb15a031ca17)   
 [Data Types (Transact-SQL)](assetId:///a54f7373-b247-4d61-8fb8-7f2ec7a8d0a4)   
 [SQL Server Database Engine Backward Compatibility](../../Topics/TopicNameNotContainA/SQL-Server-Database-Engine-Backward-Compatibility.md)   
 [CAST and CONVERT](assetId:///a87d0850-c670-4720-9ad5-6f5a22343ea8)