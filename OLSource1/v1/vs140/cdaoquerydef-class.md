---
title: "CDaoQueryDef Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoQueryDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects"
  - "CDaoQueryDef class"
  - "queries [Visual Studio], defining"
ms.assetid: 9676a4a3-c712-44d4-8c5d-d1cc78288d3a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef Class
Represents a query definition, or "querydef," usually one saved in a database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoQueryDef::CDaoQueryDef](#cdaoquerydef__cdaoquerydef)|Constructs a **CDaoQueryDef** object. Next call **Open** or **Create**, depending on your needs.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoQueryDef::Append](#cdaoquerydef__append)|Appends the querydef to the database's QueryDefs collection as a saved query.|  
|[CDaoQueryDef::CanUpdate](#cdaoquerydef__canupdate)|Returns nonzero if the query can update the database.|  
|[CDaoQueryDef::Close](#cdaoquerydef__close)|Closes the querydef object. Destroy the C++ object when you finish with it.|  
|[CDaoQueryDef::Create](#cdaoquerydef__create)|Creates the underlying DAO querydef object. Use the querydef as a temporary query, or call **Append** to save it in the database.|  
|[CDaoQueryDef::Execute](#cdaoquerydef__execute)|Executes the query defined by the querydef object.|  
|[CDaoQueryDef::GetConnect](#cdaoquerydef__getconnect)|Returns the connection string associated with the querydef. The connection string identifies the data source. (For SQL pass-through queries only; otherwise an empty string.)|  
|[CDaoQueryDef::GetDateCreated](#cdaoquerydef__getdatecreated)|Returns the date the saved query was created.|  
|[CDaoQueryDef::GetDateLastUpdated](#cdaoquerydef__getdatelastupdated)|Returns the date the saved query was last updated.|  
|[CDaoQueryDef::GetFieldCount](#cdaoquerydef__getfieldcount)|Returns the number of fields defined by the querydef.|  
|[CDaoQueryDef::GetFieldInfo](#cdaoquerydef__getfieldinfo)|Returns information about a specified field defined in the query.|  
|[CDaoQueryDef::GetName](#cdaoquerydef__getname)|Returns the name of the querydef.|  
|[CDaoQueryDef::GetODBCTimeout](#cdaoquerydef__getodbctimeout)|Returns the timeout value used by ODBC (for an ODBC query) when the querydef is executed. This determines how long to allow for the query's action to complete.|  
|[CDaoQueryDef::GetParameterCount](#cdaoquerydef__getparametercount)|Returns the number of parameters defined for the query.|  
|[CDaoQueryDef::GetParameterInfo](#cdaoquerydef__getparameterinfo)|Returns information about a specified parameter to the query.|  
|[CDaoQueryDef::GetParamValue](#cdaoquerydef__getparamvalue)|Returns the value of a specified parameter to the query.|  
|[CDaoQueryDef::GetRecordsAffected](#cdaoquerydef__getrecordsaffected)|Returns the number of records affected by an action query.|  
|[CDaoQueryDef::GetReturnsRecords](#cdaoquerydef__getreturnsrecords)|Returns nonzero if the query defined by the querydef returns records.|  
|[CDaoQueryDef::GetSQL](#cdaoquerydef__getsql)|Returns the SQL string that specifies the query defined by the querydef.|  
|[CDaoQueryDef::GetType](#cdaoquerydef__gettype)|Returns the query type: delete, update, append, make-table, and so on.|  
|[CDaoQueryDef::IsOpen](#cdaoquerydef__isopen)|Returns nonzero if the querydef is open and can be executed.|  
|[CDaoQueryDef::Open](#cdaoquerydef__open)|Opens an existing querydef stored in the database's QueryDefs collection.|  
|[CDaoQueryDef::SetConnect](#cdaoquerydef__setconnect)|Sets the connection string for a SQL pass-through query on an ODBC data source.|  
|[CDaoQueryDef::SetName](#cdaoquerydef__setname)|Sets the name of the saved query, replacing the name in use when the querydef was created.|  
|[CDaoQueryDef::SetODBCTimeout](#cdaoquerydef__setodbctimeout)|Sets the timeout value used by ODBC (for an ODBC query) when the querydef is executed.|  
|[CDaoQueryDef::SetParamValue](#cdaoquerydef__setparamvalue)|Sets the value of a specified parameter to the query.|  
|[CDaoQueryDef::SetReturnsRecords](#cdaoquerydef__setreturnsrecords)|Specifies whether the querydef returns records. Setting this attribute to **TRUE** is only valid for SQL pass-through queries.|  
|[CDaoQueryDef::SetSQL](#cdaoquerydef__setsql)|Sets the SQL string that specifies the query defined by the querydef.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoQueryDef::m_pDAOQueryDef](#cdaoquerydef__m_pdaoquerydef)|A pointer to the OLE interface for the underlying DAO querydef object.|  
|[CDaoQueryDef::m_pDatabase](#cdaoquerydef__m_pdatabase)|A pointer to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object with which the querydef is associated. The querydef might be saved in the database or not.|  
  
## Remarks  
 A querydef is a data access object that contains the SQL statement that describes a query, and its properties, such as "Date Created" and "ODBC Timeout." You can also create temporary querydef objects without saving them, but it is convenient — and much more efficient — to save commonly reused queries in a database. A [CDaoDatabase](../vs140/cdaodatabase-class.md) object maintains a collection, called the QueryDefs collection, that contains its saved querydefs.  
  
> [!NOTE]
>  The DAO database classes are distinct from the MFC database classes based on Open Database Connectivity (ODBC). All DAO database class names have the "CDao" prefix. You can still access ODBC data sources with the DAO classes. In general, the MFC classes based on DAO are more capable than the MFC classes based on ODBC; the DAO-based classes can access data, including through ODBC drivers, via their own database engine. The DAO-based classes also support Data Definition Language (DDL) operations, such as adding tables via the classes, without having to call DAO directly.  
  
## Usage  
 Use querydef objects either to work with an existing saved query or to create a new saved query or temporary query:  
  
1.  In all cases, first construct a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object, supplying a pointer to the [CDaoDatabase](../vs140/cdaodatabase-class.md) object to which the query belongs.  
  
2.  Then do the following, depending on what you want:  
  
    -   To use an existing saved query, call the querydef object's [Open](#cdaoquerydef__open) member function, supplying the name of the saved query.  
  
    -   To create a new saved query, call the querydef object's [Create](#cdaoquerydef__create) member function, supplying the name of the query. Then call [Append](#cdaoquerydef__append) to save the query by appending it to the database's QueryDefs collection. **Create** puts the querydef into an open state, so after calling **Create** you do not call **Open**.  
  
    -   To create a temporary querydef, call **Create**. Pass an empty string for the query name. Do not call **Append**.  
  
 When you finish using a querydef object, call its [Close](#cdaoquerydef__close) member function; then destroy the querydef object.  
  
> [!TIP]
>  The easiest way to create saved queries is to create them and store them in your database using Microsoft Access. Then you can open and use them in your MFC code.  
  
## Purposes  
 You can use a querydef object for any of the following purposes:  
  
-   To create a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object  
  
-   To call the object's **Execute** member function to directly execute an action query or a SQL pass-through query  
  
 You can use a querydef object for any type of query, including select, action, crosstab, delete, update, append, make-table, data definition, SQL pass-through, union, and bulk queries. The query's type is determined by the content of the SQL statement that you supply. For information about query types, see the **Execute** and [GetType](#cdaoquerydef__gettype) member functions. Recordsets are commonly used for row-returning queries, usually those using the **SELECT ... FROM** keywords. **Execute** is most commonly used for bulk operations. For more information, see [Execute](#cdaoquerydef__execute) and [CDaoRecordset](../vs140/cdaorecordset-class.md).  
  
## Querydefs and Recordsets  
 To use a querydef object to create a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object, you typically create or open a querydef as described above. Then construct a recordset object, passing a pointer to your querydef object when you call [CDaoRecordset::Open](../vs140/cdaorecordset-class.md#cdaorecordset__open). The querydef you pass must be in an open state. For more information, see class [CDaoRecordset](../vs140/cdaorecordset-class.md).  
  
 You cannot use a querydef to create a recordset (the most common use for a querydef) unless it is in an open state. Put the querydef into an open state by calling either **Open** or **Create**.  
  
## External Databases  
 Querydef objects are the preferred way to use the native SQL dialect of an external database engine. For example, you can create a Transact SQL query (as used on Microsoft SQL Server) and store it in a querydef object. When you need to use a SQL query not based on the Microsoft Jet database engine, you must provide a connection string that points to the external data source. Queries with valid connection strings bypass the database engine and pass the query directly to the external database server for processing.  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to a Microsoft Jet (.MDB) database.  
  
 For related information, see the topics "QueryDef Object", "QueryDefs Collection", and "CdbDatabase Object" in the DAO SDK.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdao.h  
  
##  \<a name="cdaoquerydef__append">\</a>  CDaoQueryDef::Append  
 Call this member function after you call [Create](#cdaoquerydef__create) to create a new querydef object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 **Append** saves the querydef in the database by appending the object to the database's QueryDefs collection. You can use the querydef as a temporary object without appending it, but if you want it to persist, you must call **Append**.  
  
 If you attempt to append a temporary querydef object, MFC throws an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
##  \<a name="cdaoquerydef__canupdate">\</a>  CDaoQueryDef::CanUpdate  
 Call this member function to determine whether you can modify the querydef — such as changing its name or SQL string.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if you are permitted to modify the querydef; otherwise 0.  
  
### Remarks  
 You can modify the querydef if:  
  
-   It is not based on a database that is open read-only.  
  
-   You have update permissions for the database.  
  
     This depends on whether you have implemented security features. MFC does not provide support for security; you must implement it yourself by calling DAO directly or by using Microsoft Access. See the topic "Permissions Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__cdaoquerydef">\</a>  CDaoQueryDef::CDaoQueryDef  
 Constructs a **CDaoQueryDef** object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to an open [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
### Remarks  
 The object can represent an existing querydef stored in the database's QueryDefs collection, a new query to be stored in the collection, or a temporary query, not to be stored. Your next step depends on the type of querydef:  
  
-   If the object represents an existing querydef, call the object's [Open](#cdaoquerydef__open) member function to initialize it.  
  
-   If the object represents a new querydef to be saved, call the object's [Create](#cdaoquerydef__create) member function. This adds the object to the database's QueryDefs collection. Then call <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> member functions to set the object's attributes. Finally, call [Append](#cdaoquerydef__append).  
  
-   If the object represents a temporary querydef (not to be saved in the database), call **Create**, passing an empty string for the query's name. After calling **Create**, initialize the querydef by directly setting its attributes. Do not call **Append**.  
  
 To set the attributes of the querydef, you can use the [SetName](#cdaoquerydef__setname), [SetSQL](#cdaoquerydef__setsql), [SetConnect](#cdaoquerydef__setconnect), [SetODBCTimeout](#cdaoquerydef__setodbctimeout), and [SetReturnsRecords](#cdaoquerydef__setreturnsrecords) member functions.  
  
 When you finish with the querydef object, call its [Close](#cdaoquerydef__close) member function. If you have a pointer to the querydef, use the **delete** operator to destroy the C++ object.  
  
##  \<a name="cdaoquerydef__close">\</a>  CDaoQueryDef::Close  
 Call this member function when you finish using the querydef object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Closing the querydef releases the underlying DAO object but does not destroy the saved DAO querydef object or the C++ <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object. This is not the same as [CDaoDatabase::DeleteQueryDef](../vs140/cdaodatabase-class.md#cdaodatabase__deletequerydef), which deletes the querydef from the database's QueryDefs collection in DAO (if not a temporary querydef).  
  
##  \<a name="cdaoquerydef__create">\</a>  CDaoQueryDef::Create  
 Call this member function to create a new saved query or a new temporary query.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The unique name of the query saved in the database. For details about the string, see the topic "CreateQueryDef Method" in DAO Help. If you accept the default value, an empty string, a temporary querydef is created. Such a query is not saved in the QueryDefs collection.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The SQL string that defines the query. If you accept the default value of **NULL**, you must later call [SetSQL](#cdaoquerydef__setsql) to set the string. Until then, the query is undefined. You can, however, use the undefined query to open a recordset; see Remarks for details. The SQL statement must be defined before you can append the querydef to the QueryDefs collection.  
  
### Remarks  
 If you pass a name in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, you can then call [Append](#cdaoquerydef__append) to save the querydef in the database's QueryDefs collection. Otherwise, the object is a temporary querydef and is not saved. In either case, the querydef is in an open state, and you can either use it to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object or call the querydef's [Execute](#cdaoquerydef__execute) member function.  
  
 If you do not supply a SQL statement in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, you cannot run the query with **Execute** but you can use it to create a recordset. In that case, MFC uses the recordset's default SQL statement.  
  
##  \<a name="cdaoquerydef__execute">\</a>  CDaoQueryDef::Execute  
 Call this member function to run the query defined by the querydef object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An integer that determines the characteristics of the query. For related information, see the topic "Execute Method" in DAO Help. You can use the bitwise-OR operator ( **&#124;**) to combine the following constants for this argument:  
  
-   **dbDenyWrite** Deny write permission to other users.  
  
-   **dbInconsistent** Inconsistent updates.  
  
-   **dbConsistent** Consistent updates.  
  
-   **dbSQLPassThrough** SQL pass-through. Causes the SQL statement to be passed to an ODBC database for processing.  
  
-   **dbFailOnError** Default value. Roll back updates if an error occurs and report the error to the user.  
  
-   **dbSeeChanges** Generate a run-time error if another user is changing data you are editing.  
  
> [!NOTE]
>  For an explanation of the terms "inconsistent" and "consistent," see the topic "Execute Method" in DAO Help.  
  
### Remarks  
 Querydef objects used for execution in this manner can only represent one of the following query types:  
  
-   Action queries  
  
-   SQL pass-through queries  
  
 **Execute** does not work for queries that return records, such as select queries. **Execute** is commonly used for bulk operation queries, such as **UPDATE**, **INSERT**, or **SELECT INTO**, or for data definition language (DDL) operations.  
  
> [!TIP]
>  The preferred way to work with ODBC data sources is to attach tables to a Microsoft Jet (.MDB) database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
 Call the [GetRecordsAffected](#cdaoquerydef__getrecordsaffected) member function of the querydef object to determine the number of records affected by the most recent **Execute** call. For example, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns information about the number of records deleted, updated, or inserted when executing an action query. The count returned will not reflect changes in related tables when cascade updates or deletes are in effect.  
  
 If you include both **dbInconsistent** and **dbConsistent** or if you include neither, the result is the default, **dbInconsistent**.  
  
 **Execute** does not return a recordset. Using **Execute** on a query that selects records causes MFC to throw an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
##  \<a name="cdaoquerydef__getconnect">\</a>  CDaoQueryDef::GetConnect  
 Call this member function to get the connection string associated with the querydef's data source.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) containing the connection string for the querydef.  
  
### Remarks  
 This function is used only with ODBC data sources and certain ISAM drivers. It is not used with Microsoft Jet (.MDB) databases; in this case, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns an empty string. For more information, see [SetConnect](#cdaoquerydef__setconnect).  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to an .MDB database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
 For information about connection strings, see the topic "Connect Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__getdatecreated">\</a>  CDaoQueryDef::GetDateCreated  
 Call this member function to get the date the querydef object was created.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A [COleDateTime](../vs140/coledatetime-class.md) object containing the date and time the querydef was created.  
  
### Remarks  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
##  \<a name="cdaoquerydef__getdatelastupdated">\</a>  CDaoQueryDef::GetDateLastUpdated  
 Call this member function to get the date the querydef object was last updated — when any of its properties were changed, such as its name, its SQL string, or its connection string.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A [COleDateTime](../vs140/coledatetime-class.md) object containing the date and time the querydef was last updated.  
  
### Remarks  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
##  \<a name="cdaoquerydef__getfieldcount">\</a>  CDaoQueryDef::GetFieldCount  
 Call this member function to retrieve the number of fields in the query.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The number of fields defined in the query.  
  
### Remarks  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is useful for looping through all fields in the querydef. For that purpose, use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> in conjunction with [GetFieldInfo](#cdaoquerydef__getfieldinfo).  
  
##  \<a name="cdaoquerydef__getfieldinfo">\</a>  CDaoQueryDef::GetFieldInfo  
 Call this member function to obtain various kinds of information about a field defined in the querydef.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The zero-based index of the desired field in the querydef's Fields collection, for lookup by index.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object that returns the information requested.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Options that specify which information about the field to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> (Default) Name, Type, Size, Attributes  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> Primary information plus: Ordinal Position, Required, Allow Zero Length, Source Field, Foreign Name, Source Table, Collating Order  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> Primary and secondary information plus: Default Value, Validation Text, Validation Rule  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A string containing the name of the desired field, for lookup by name. You can use a [CString](../vs140/cstringt-class.md).  
  
### Remarks  
 For a description of the information returned in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, see the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. This structure has members that correspond to the descriptive information under <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> above. If you request one level of information, you get any prior levels of information as well.  
  
##  \<a name="cdaoquerydef__getname">\</a>  CDaoQueryDef::GetName  
 Call this member function to retrieve the name of the query represented by the querydef.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The name of the query.  
  
### Remarks  
 Querydef names are unique user-defined names. For more information about querydef names, see the topic "Name Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__getodbctimeout">\</a>  CDaoQueryDef::GetODBCTimeout  
 Call this member function to retrieve the current time limit before a query to an ODBC data source times out.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The number of seconds before a query times out.  
  
### Remarks  
 For information about this time limit, see the topic "ODBCTimeout Property" in DAO Help.  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to a Microsoft Jet (.MDB) database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
##  \<a name="cdaoquerydef__getparametercount">\</a>  CDaoQueryDef::GetParameterCount  
 Call this member function to retrieve the number of parameters in the saved query.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The number of parameters defined in the query.  
  
### Remarks  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is useful for looping through all parameters in the querydef. For that purpose, use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> in conjunction with [GetParameterInfo](#cdaoquerydef__getparameterinfo).  
  
 For related information, see the topics "Parameter Object", "Parameters Collection", and "PARAMETERS Declaration (SQL)" in DAO Help.  
  
##  \<a name="cdaoquerydef__getparameterinfo">\</a>  CDaoQueryDef::GetParameterInfo  
 Call this member function to obtain information about a parameter defined in the querydef.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The zero-based index of the desired parameter in the querydef's Parameters collection, for lookup by index.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A reference to a [CDaoParameterInfo](../vs140/cdaoparameterinfo-structure.md) object that returns the information requested.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Options that specify which information about the parameter to retrieve. The available option is listed here along with what it causes the function to return:  
  
-   <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> (Default) Name, Type  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A string containing the name of the desired parameter, for lookup by name. You can use a [CString](../vs140/cstringt-class.md).  
  
### Remarks  
 For a description of the information returned in <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, see the [CDaoParameterInfo](../vs140/cdaoparameterinfo-structure.md) structure. This structure has members that correspond to the descriptive information under <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> above.  
  
 For related information, see the topic "PARAMETERS Declaration (SQL)" in DAO Help.  
  
##  \<a name="cdaoquerydef__getparamvalue">\</a>  CDaoQueryDef::GetParamValue  
 Call this member function to retrieve the current value of the specified parameter stored in the querydef's Parameters collection.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The name of the parameter whose value you want, for lookup by name.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The zero-based index of the parameter in the querydef's Parameters collection, for lookup by index. You can obtain this value with calls to [GetParameterCount](#cdaoquerydef__getparametercount) and [GetParameterInfo](#cdaoquerydef__getparameterinfo).  
  
### Return Value  
 An object of class [COleVariant](../vs140/colevariant-class.md) that contains the parameter's value.  
  
### Remarks  
 You can access the parameter either by name or by its ordinal position in the collection.  
  
 For related information, see the topic "PARAMETERS Declaration (SQL)" in DAO Help.  
  
##  \<a name="cdaoquerydef__getrecordsaffected">\</a>  CDaoQueryDef::GetRecordsAffected  
 Call this member function to determine how many records were affected by the last call of [Execute](#cdaoquerydef__execute).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The number of records affected.  
  
### Remarks  
 The count returned will not reflect changes in related tables when cascade updates or deletes are in effect.  
  
 For related information see the topic "RecordsAffected Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__getreturnsrecords">\</a>  CDaoQueryDef::GetReturnsRecords  
 Call this member function to determine whether the querydef is based on a query that returns records.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the querydef is based on a query that returns records; otherwise 0.  
  
### Remarks  
 This member function is only used for SQL pass-through queries. For more information about SQL queries, see the [Execute](#cdaoquerydef__execute) member function. For more information about working with SQL pass-through queries, see the [SetReturnsRecords](#cdaoquerydef__setreturnsrecords) member function.  
  
 For related information, see the topic "ReturnsRecords Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__getsql">\</a>  CDaoQueryDef::GetSQL  
 Call this member function to retrieve the SQL statement that defines the query on which the querydef is based.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The SQL statement that defines the query on which the querydef is based.  
  
### Remarks  
 You will then probably parse the string for keywords, table names, and so on.  
  
 For related information, see the topics "SQL Property", "Comparison of Microsoft Jet Database Engine SQL and ANSI SQL", and "Querying a Database with SQL in Code" in DAO Help.  
  
##  \<a name="cdaoquerydef__gettype">\</a>  CDaoQueryDef::GetType  
 Call this member function to determine the query type of the querydef.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The type of the query defined by the querydef. For values, see Remarks.  
  
### Remarks  
 The query type is set by what you specify in the querydef's SQL string when you create the querydef or call an existing querydef's [SetSQL](#cdaoquerydef__setsql) member function. The query type returned by this function can be one of the following values:  
  
-   **dbQSelect** Select  
  
-   **dbQAction** Action  
  
-   **dbQCrosstab** Crosstab  
  
-   **dbQDelete** Delete  
  
-   **dbQUpdate** Update  
  
-   **dbQAppend** Append  
  
-   **dbQMakeTable** Make-table  
  
-   **dbQDDL** Data-definition  
  
-   **dbQSQLPassThrough** Pass-through  
  
-   **dbQSetOperation** Union  
  
-   **dbQSPTBulk** Used with **dbQSQLPassThrough** to specify a query that does not return records.  
  
> [!NOTE]
>  To create a SQL pass-through query, don't set the **dbSQLPassThrough** constant. This is set automatically by the Microsoft Jet database engine when you create a querydef object and set the connection string.  
  
 For information about SQL strings, see [GetSQL](#cdaoquerydef__getsql). For information about query types, see [Execute](#cdaoquerydef__execute).  
  
##  \<a name="cdaoquerydef__isopen">\</a>  CDaoQueryDef::IsOpen  
 Call this member function to determine whether the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object is currently open.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object is currently open; otherwise 0.  
  
### Remarks  
 A querydef must be in an open state before you use it to call [Execute](#cdaoquerydef__execute) or to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object. To put a querydef into an open state call either [Create](#cdaoquerydef__create) (for a new querydef) or [Open](#cdaoquerydef__open) (for an existing querydef).  
  
##  \<a name="cdaoquerydef__m_pdatabase">\</a>  CDaoQueryDef::m_pDatabase  
 Contains a pointer to the [CDaoDatabase](../vs140/cdaodatabase-class.md) object associated with the querydef object.  
  
### Remarks  
 Use this pointer if you need to access the database directly — for example, to obtain pointers to other querydef or recordset objects in the database's collections.  
  
##  \<a name="cdaoquerydef__m_pdaoquerydef">\</a>  CDaoQueryDef::m_pDAOQueryDef  
 Contains a pointer to the OLE interface for the underlying DAO querydef object.  
  
### Remarks  
 This pointer is provided for completeness and consistency with the other classes. However, because MFC rather fully encapsulates DAO querydefs, you are unlikely to need it. If you do use it, do so cautiously — in particular, do not change the value of the pointer unless you know what you are doing.  
  
##  \<a name="cdaoquerydef__open">\</a>  CDaoQueryDef::Open  
 Call this member function to open a querydef previously saved in the database's QueryDefs collection.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A string that contains the name of the saved querydef to open. You can use a [CString](../vs140/cstringt-class.md).  
  
### Remarks  
 Once the querydef is open, you can call its [Execute](#cdaoquerydef__execute) member function or use the querydef to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object.  
  
##  \<a name="cdaoquerydef__setconnect">\</a>  CDaoQueryDef::SetConnect  
 Call this member function to set the querydef object's connection string.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A string that contains a connection string for the associated [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
### Remarks  
 The connection string is used to pass additional information to ODBC and certain ISAM drivers as needed. It is not used for Microsoft Jet (.MDB) databases.  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to an .MDB database.  
  
 Before executing a querydef that represents a SQL pass-through query to an ODBC data source, set the connection string with <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and call [SetReturnsRecords](#cdaoquerydef__setreturnsrecords) to specify whether the query returns records.  
  
 For more information about the connection string's structure and examples of connection string components, see the topic "Connect Property" in DAO Help.  
  
##  \<a name="cdaoquerydef__setname">\</a>  CDaoQueryDef::SetName  
 Call this member function if you want to change the name of a querydef that is not temporary.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A string that contains the new name for a nontemporary query in the associated [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
### Remarks  
 Querydef names are unique, user-defined names. You can call <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> before the querydef object is appended to the QueryDefs collection.  
  
##  \<a name="cdaoquerydef__setodbctimeout">\</a>  CDaoQueryDef::SetODBCTimeout  
 Call this member function to set the time limit before a query to an ODBC data source times out.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *nODBCTimeout*  
 The number of seconds before a query times out.  
  
### Remarks  
 This member function lets you override the default number of seconds before subsequent operations on the connected data source "time out." An operation might time out due to network access problems, excessive query processing time, and so on. Call <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> prior to executing a query with this querydef if you want to change the query timeout value. (As ODBC reuses connections, the timeout value is the same for all clients on the same connection.)  
  
 The default value for query timeouts is 60 seconds.  
  
##  \<a name="cdaoquerydef__setparamvalue">\</a>  CDaoQueryDef::SetParamValue  
 Call this member function to set the value of a parameter in the querydef at run time.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The name of the parameter whose value you want to set.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The value to set; see Remarks.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The ordinal position of the parameter in the querydef's Parameters collection. You can obtain this value with calls to [GetParameterCount](#cdaoquerydef__getparametercount) and [GetParameterInfo](#cdaoquerydef__getparameterinfo).  
  
### Remarks  
 The parameter must already have been established as part of the querydef's SQL string. You can access the parameter either by name or by its ordinal position in the collection.  
  
 Specify the value to set as a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object. For information about setting the desired value and type in your <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object, see class [COleVariant](../vs140/colevariant-class.md).  
  
##  \<a name="cdaoquerydef__setreturnsrecords">\</a>  CDaoQueryDef::SetReturnsRecords  
 Call this member function as part of the process of setting up a SQL pass-through query to an external database.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 *bReturnsRecords*  
 Pass **TRUE** if the query on an external database returns records; otherwise, **FALSE**.  
  
### Remarks  
 In such a case, you must create the querydef and set its properties using other <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> member functions. For a description of external databases, see [SetConnect](#cdaoquerydef__setconnect).  
  
##  \<a name="cdaoquerydef__setsql">\</a>  CDaoQueryDef::SetSQL  
 Call this member function to set the SQL statement that the querydef executes.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A string containing a complete SQL statement, suitable for execution. The syntax of this string depends on the DBMS that your query targets. For a discussion of syntax used in the Microsoft Jet database engine, see the topic "Building SQL Statements in Code" in DAO Help.  
  
### Remarks  
 A typical use of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is setting up a querydef object for use in a SQL pass-through query. (For the syntax of SQL pass-through queries on your target DBMS, see the documentation for your DBMS.)  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset](../vs140/cdaorecordset-class.md)   
 [CDaoDatabase](../vs140/cdaodatabase-class.md)   
 [CDaoTableDef](../vs140/cdaotabledef-class.md)   
 [CDaoException](../vs140/cdaoexception-class.md)