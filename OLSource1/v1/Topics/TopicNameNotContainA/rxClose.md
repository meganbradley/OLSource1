---
title: rxClose
ms.custom: na
ms.devlang: 
  - R
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - r-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f4b0ad6f-0757-438c-9d15-eaf3dc1ebb1b
---
# rxClose
Closes the connection to an RxDataSource object.

## Usage

`rxClose(src)`

## Arguments

_src_: An existing RxDataSource object.

## Remarks
This is one of several generic functions in the  RevoScaleR package that are used for managing data source objects.
For information about how to create a SQL Server data source, see [RxSqlServer](../../Topics\TopicNameNotContainA/RxSqlServerData.md).
For information about working with other data sources such as Hadoop, Teradata, and text files, see the [Microsoft R Server documentation](http://msdn.microsoft.com/microsoft-r/index#) in the MSDN library.

## Return Value
TRUE if the operation was successful; FALSE otherwise. 

## Example
For examples of how to work with ScaleR data sources, see [Data Sources](https://msdn.microsoft.com/microsoft-r/rserver/rserver-scaler-user-guide-3-data-source).

## See Also
[Comparison of rx Functions and CRAN R Functions](../../Topics\TopicNameNotContainA/Summary-of-rx-Functions.md)

[ScaleR Functions for Working with SQL Server Data](../../Topics\TopicNameNotContainA/ScaleR-Functions-for-Working-with-SQL-Server-Data.md)