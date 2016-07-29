---
title: "Bulk Insert Task Editor (Connection Page)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 51252c20-8865-4ede-a3fd-bd73a968f47d
caps.latest.revision: 33
manager: jhubbard
---
# Bulk Insert Task Editor (Connection Page)
Use the **Connection** page of the **Bulk Insert Task Editor** dialog box to specify the source and destination of the bulk insert operation and the format to use.  
  
 To learn about working with bulk inserts, see [Bulk Insert Task](../../Topics/TopicNameNotContainA/Bulk-Insert-Task.md) and [Format Files for Importing or Exporting Data (SQL Server)](../../Topics/TopicNameNotContainA/Format-Files-for-Importing-or-Exporting-Data--SQL-Server-.md).  
  
## Options  
 **Connection**  
 Select an OLE DB connection manager in the list, or click <**New connection...**> to create a new connection.  
  
 **Related Topics:** [OLE DB Connection Manager](../../Topics/TopicNameNotContainA/OLE-DB-Connection-Manager.md), [Configure OLE DB Connection Manager](../../Topics/TopicNameNotContainA/Configure-OLE-DB-Connection-Manager.md)  
  
 **DestinationTable**  
 Type the name of the destination table or view or select a table or view in the list.  
  
 **Format**  
 Select the source of the format for the bulk insert. This property has the options listed in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|**Use File**|Select a file containing the format specification. Selecting this option displays the dynamic option, **FormatFile**.|  
|**Specify**|Specify the format. Selecting this option displays the dynamic options, **RowDelimiter** and **ColumnDelimiter**.|  
  
 **File**  
 Select a File or Flat File connection manager in the list, or click <**New connection...**> to create a new connection.  
  
 The file location is relative to the SQL Server Database Engine specified in the connection manager for this task. The text file must be accessible by the SQL Server Database Engine either on a local hard drive on the server, or via a share or mapped drive to the SQL Server. The file is not accessed by the SSIS Runtime.  
  
 If you access the source file by using a Flat File connection manager, the Bulk Insert task does not use the format specified in the Flat File connection manager. Instead, the Bulk Insert task uses either the format specified in a format file or the values of the **RowDelimiter** and **ColumnDelimiter** properties of the task.  
  
 **Related Topics:** [File Connection Manager](../../Topics/TopicNameNotContainA/File-Connection-Manager.md), [File Connection Manager Editor](../../Topics/TopicNameNotContainA/File-Connection-Manager-Editor.md), [Flat File Connection Manager](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager.md), [Flat File Connection Manager Editor (General Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--General-Page-.md), [Flat File Connection Manager Editor (Columns Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--Columns-Page-.md), [Flat File Connection Manager Editor (Advanced Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--Advanced-Page-.md)  
  
 **Refresh Tables**  
 Refresh the list of tables and views.  
  
## Format Dynamic Options  
  
### Format = Use File  
 **FormatFile**  
 Type the path of the format file or click the ellipsis button **(…)** to locate the format file.  
  
### Format = Specify  
 **RowDelimiter**  
 Specify the row delimiter in the source file. The default value is **{CR}{LF}**.  
  
 **ColumnDelimiter**  
 Specify the column delimiter in the source file. The default is **Tab**.  
  
## See Also  
 [Integration Services Error and Message Reference](../../Topics/TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Bulk Insert Task Editor (General Page)](../../Topics/TopicNameNotContainA/Bulk-Insert-Task-Editor--General-Page-.md)   
 [Bulk Insert Task Editor (Options Page)](../../Topics/TopicNameNotContainA/Bulk-Insert-Task-Editor--Options-Page-.md)   
 [Expressions Page](../../Topics/TopicNameNotContainA/Expressions-Page.md)   
 [BULK INSERT (Transact-SQL)](assetId:///be3984e1-5ab3-4226-a539-a9f58e1e01e2)   
 [Control Flow](../../Topics/TopicNameNotContainA/Control-Flow.md)