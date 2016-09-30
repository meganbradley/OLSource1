---
title: "CDaoQueryDefInfo Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CDaoQueryDefInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), QueryDefs collection"
  - "CDaoQueryDefInfo structure"
ms.assetid: e20837dc-e78d-4171-a195-1b4075fb5d2a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDefInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a querydef object defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Uniquely names the querydef object. For more information, see the topic "Name Property" in DAO Help. Call [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md) to retrieve this property directly.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value that indicates the operational type of a querydef object. The value can be one of the following:  
  
-   **dbQSelect** Select — the query selects records.  
  
-   **dbQAction** Action — the query moves or changes data but does not return records.  
  
-   **dbQCrosstab** Crosstab — the query returns data in a spreadsheet-like format.  
  
-   **dbQDelete** Delete — the query deletes a set of specified rows.  
  
-   **dbQUpdate** Update — the query changes a set of records.  
  
-   **dbQAppend** Append — the query adds new records to the end of a table or query.  
  
-   **dbQMakeTable** Make-table — the query creates a new table from a recordset.  
  
-   **dbQDDL** Data-definition — the query affects the structure of tables or their parts.  
  
-   **dbQSQLPassThrough** Pass-through — the SQL statement is passed directly to the database backend, without intermediate processing.  
  
-   **dbQSetOperation** Union — the query creates a snapshot-type recordset object containing data from all specified records in two or more tables with any duplicate records removed. To include the duplicates, add the keyword **ALL** in the querydef's SQL statement.  
  
-   **dbQSPTBulk** Used with **dbQSQLPassThrough** to specify a query that does not return records.  
  
> [!NOTE]
>  To create a SQL pass-through query, you do not set the **dbQSQLPassThrough** constant. This is set automatically by the Microsoft Jet database engine when you create a querydef object and set the Connect property.  
  
 For more information, see the topic "Type Property" in DAO Help.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The date and time the querydef was created. To directly retrieve the date the querydef was created, call the [GetDateCreated](../vs140/cdaotabledef--getdatecreated.md) member function of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object associated with the table. See Comments below for more information. Also see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The date and time of the most recent change made to the querydef. To directly retrieve the date the table was last updated, call the [GetDateLastUpdated](../vs140/cdaoquerydef--getdatelastupdated.md) member function of the querydef. See Comments below for more information. And see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Indicates whether changes can be made to a querydef object. If this property is **TRUE**, the querydef is updatable; otherwise, it is not. Updatable means the querydef object's query definition can be changed. The Updatable property of a querydef object is set to **TRUE** if the query definition can be updated, even if the resulting recordset is not updatable. To retrieve this property directly, call the querydef's [CanUpdate](../vs140/cdaoquerydef--canupdate.md) member function. For more information, see the topic "Updatable Property" in DAO Help.  
  
 *m_bReturnsRecords*  
 Indicates whether a SQL pass-through query to an external database returns records. If this property is **TRUE**, the query returns records. To directly retrieve this property, call [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md). Not all SQL pass-through queries to external databases return records. For example, a SQL **UPDATE** statement updates records without returning records, while a SQL **SELECT** statement does return records. For more information, see the topic "ReturnsRecords Property" in DAO Help.  
  
 *m_strSQL*  
 The SQL statement that defines the query executed by a querydef object. The SQL property contains the SQL statement that determines how records are selected, grouped, and ordered when you execute the query. You can use the query to select records to include in a dynaset- or snapshot-type recordset object. You can also define bulk queries to modify data without returning records. You can retrieve the value of this property directly by calling the querydef's [GetSQL](../vs140/cdaoquerydef--getsql.md) member function.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Provides information about the source of a database used in a pass-through query. This information takes the form of a connect string. For more information about connect strings, and for information about retrieving the value of this property directly, see the [CDaoDatabase::GetConnect](../vs140/cdaodatabase--getconnect.md) member function.  
  
 *m_nODBCTimeout*  
 The number of seconds the Microsoft Jet database engine waits before a timeout error occurs when a query is run on an ODBC database. When you're using an ODBC database, such as Microsoft SQL Server, there may be delays because of network traffic or heavy use of the ODBC server. Rather than waiting indefinitely, you can specify how long the Microsoft Jet engine waits before it produces an error. The default timeout value is 60 seconds. You can retrieve the value of this property directly by calling the querydef's [GetODBCTimeout](../vs140/cdaoquerydef--getodbctimeout.md) member function. For more information, see the topic "ODBCTimeout Property" in DAO Help.  
  
## Remarks  
 The querydef is an object of class [CDaoQueryDef](../vs140/cdaoquerydef-class.md). The references to Primary, Secondary, and All above indicate how the information is returned by the [GetQueryDefInfo](../vs140/cdaodatabase--getquerydefinfo.md) member function in class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 Information retrieved by the [CDaoDatabase::GetQueryDefInfo](../vs140/cdaodatabase--getquerydefinfo.md) member function is stored in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure. Call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for the database object in whose QueryDefs collection the querydef object is stored. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. Class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> also supplies member functions for directly accessing all of the properties returned in a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object, so you will probably seldom need to call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 When you append a new field or parameter object to the Fields or Parameters collection of a querydef object, an exception is thrown if the underlying database does not support the data type specified for the new object.  
  
 The date and time settings are derived from the computer on which the querydef was created or last updated. In a multiuser environment, users should get these settings directly from the file server using the **net time** command to avoid discrepancies in the DateCreated and LastUpdated property settings.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)