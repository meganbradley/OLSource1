---
title: "CDaoTableDef Class"
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
  - "CDaoTableDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database classes [C++], DAO"
  - "tabledefs [C++]"
  - "CDaoTableDef class"
  - "database tables [C++], attached table definition"
  - "database tables [C++], base table definition"
ms.assetid: 7c5d2254-8475-43c4-8a6c-2d32ead194c9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef Class
Represents the stored definition of a base table or an attached table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoTableDef::CDaoTableDef](#cdaotabledef__cdaotabledef)|Constructs a **CDaoTableDef** object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoTableDef::Append](#cdaotabledef__append)|Adds a new table to the database.|  
|[CDaoTableDef::CanUpdate](#cdaotabledef__canupdate)|Returns nonzero if the table can be updated (you can modify the definition of fields or the table properties).|  
|[CDaoTableDef::Close](#cdaotabledef__close)|Closes an open tabledef.|  
|[CDaoTableDef::Create](#cdaotabledef__create)|Creates a table which can be added to the database using [Append](#cdaotabledef__append).|  
|[CDaoTableDef::CreateField](#cdaotabledef__createfield)|Called to create a field for a table.|  
|[CDaoTableDef::CreateIndex](#cdaotabledef__createindex)|Called to create an index for a table.|  
|[CDaoTableDef::DeleteField](#cdaotabledef__deletefield)|Called to delete a field from a table.|  
|[CDaoTableDef::DeleteIndex](#cdaotabledef__deleteindex)|Called to delete an index from a table.|  
|[CDaoTableDef::GetAttributes](#cdaotabledef__getattributes)|Returns a value that indicates one or more characteristics of a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[CDaoTableDef::GetConnect](#cdaotabledef__getconnect)|Returns a value that provides information about the source of a table.|  
|[CDaoTableDef::GetDateCreated](#cdaotabledef__getdatecreated)|Returns the date and time the base table underlying a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object was created.|  
|[CDaoTableDef::GetDateLastUpdated](#cdaotabledef__getdatelastupdated)|Returns the date and time of the most recent change made to the design of the base table.|  
|[CDaoTableDef::GetFieldCount](#cdaotabledef__getfieldcount)|Returns a value that represents the number of fields in the table.|  
|[CDaoTableDef::GetFieldInfo](#cdaotabledef__getfieldinfo)|Returns specific kinds of information about the fields in the table.|  
|[CDaoTableDef::GetIndexCount](#cdaotabledef__getindexcount)|Returns the number of indexes for the table.|  
|[CDaoTableDef::GetIndexInfo](#cdaotabledef__getindexinfo)|Returns specific kinds of information about the indexes for the table.|  
|[CDaoTableDef::GetName](#cdaotabledef__getname)|Returns the user-defined name of the table.|  
|[CDaoTableDef::GetRecordCount](#cdaotabledef__getrecordcount)|Returns the number of records in the table.|  
|[CDaoTableDef::GetSourceTableName](#cdaotabledef__getsourcetablename)|Returns a value that specifies the name of the attached table in the source database.|  
|[CDaoTableDef::GetValidationRule](#cdaotabledef__getvalidationrule)|Returns a value that validates the data in a field as it is changed or added to a table.|  
|[CDaoTableDef::GetValidationText](#cdaotabledef__getvalidationtext)|Returns a value that specifies the text of the message that your application displays if the value of a Field object does not satisfy the specified validation rule.|  
|[CDaoTableDef::IsOpen](#cdaotabledef__isopen)|Returns nonzero if the table is open.|  
|[CDaoTableDef::Open](#cdaotabledef__open)|Opens an existing tabledef stored in the database's TableDef's collection.|  
|[CDaoTableDef::RefreshLink](#cdaotabledef__refreshlink)|Updates the connection information for an attached table.|  
|[CDaoTableDef::SetAttributes](#cdaotabledef__setattributes)|Sets a value that indicates one or more characteristics of a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
|[CDaoTableDef::SetConnect](#cdaotabledef__setconnect)|Sets a value that provides information about the source of a table.|  
|[CDaoTableDef::SetName](#cdaotabledef__setname)|Sets the name of the table.|  
|[CDaoTableDef::SetSourceTableName](#cdaotabledef__setsourcetablename)|Sets a value that specifies the name of an attached table in the source database.|  
|[CDaoTableDef::SetValidationRule](#cdaotabledef__setvalidationrule)|Sets a value that validates the data in a field as it is changed or added to a table.|  
|[CDaoTableDef::SetValidationText](#cdaotabledef__setvalidationtext)|Sets a value that specifies the text of the message that your application displays if the value of a Field object does not satisfy the specified validation rule.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoTableDef::m_pDAOTableDef](#cdaotabledef__m_pdaotabledef)|A pointer to the DAO interface underlying the tabledef object.|  
|[CDaoTableDef::m_pDatabase](#cdaotabledef__m_pdatabase)|Source database for this table.|  
  
## Remarks  
 Each DAO database object maintains a collection, called TableDefs, that contains all saved DAO tabledef objects.  
  
 You manipulate a table definition using a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object. For example, you can:  
  
-   Examine the field and index structure of any local, attached, or external table in a database.  
  
-   Call the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> member functions for attached tables, and use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member function to update connections to attached tables.  
  
-   Call the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member function to determine if you can edit field definitions in the table.  
  
-   Get or set validation conditions using the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> member functions.  
  
-   Use the **Open** member function to create a table-, dynaset-, or snapshot-type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
    > [!NOTE]
    >  The DAO database classes are distinct from the MFC database classes based on Open Database Connectivity (ODBC). All DAO database class names have the "CDao" prefix. You can still access ODBC data sources with the DAO classes; the DAO classes generally offer superior capabilities because they are specific to the Microsoft Jet database engine.  
  
### To use tabledef objects either to work with an existing table or to create a new table  
  
1.  In all cases, first construct a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object, supplying a pointer to a [CDaoDatabase](../vs140/cdaodatabase-class.md) object to which the table belongs.  
  
2.  Then do the following, depending on what you want:  
  
    -   To use an existing saved table, call the tabledef object's [Open](#cdaotabledef__open) member function, supplying the name of the saved table.  
  
    -   To create a new table, call the tabledef object's [Create](#cdaotabledef__create) member function, supplying the name of the table. Call [CreateField](#cdaotabledef__createfield) and [CreateIndex](#cdaotabledef__createindex) to add fields and indexes to the table.  
  
    -   Call [Append](#cdaotabledef__append) to save the table by appending it to the database's TableDefs collection. **Create** puts the tabledef into an open state, so after calling **Create** you do not call **Open**.  
  
        > [!TIP]
        >  The easiest way to create saved tables is to create them and store them in your database using Microsoft Access. Then you can open and use them in your MFC code.  
  
 To use the tabledef object you have opened or created, create and open a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object, specifying the name of the tabledef with a **dbOpenTable** value in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter.  
  
 To use a tabledef object to create a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object, you typically create or open a tabledef as described above, then construct a recordset object, passing a pointer to your tabledef object when you call [CDaoRecordset::Open](../vs140/cdaorecordset-class.md#cdaorecordset__open). The tabledef you pass must be in an open state. For more information, see class [CDaoRecordset](../vs140/cdaorecordset-class.md).  
  
 When you finish using a tabledef object, call its [Close](../vs140/cdaorecordset-class.md#cdaorecordset__close) member function; then destroy the tabledef object.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdao.h  
  
##  \<a name="cdaotabledef__append">\</a>  CDaoTableDef::Append  
 Call this member function after you call [Create](#cdaotabledef__create) to create a new tabledef object to save the tabledef in the database.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The function appends the object to the database's TableDefs collection. You can use the tabledef as a temporary object while defining it by not appending it, but if you want to save and use it, you must call **Append**.  
  
> [!NOTE]
>  If you attempt to append an unnamed tabledef (containing a null or empty string), MFC throws an exception.  
  
 For related information, see the topic "Append Method" in DAO Help.  
  
##  \<a name="cdaotabledef__canupdate">\</a>  CDaoTableDef::CanUpdate  
 Call this member function to determine whether the definition of the table underlying a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object can be changed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the table structure (schema) can be modified (add or delete fields and indexes), otherwise 0.  
  
### Remarks  
 By default, a newly created table underlying a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object can be updated, and an attached table underlying a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object cannot be updated. A <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object may be updatable, even if the resulting recordset is not updatable.  
  
 For related information, see the topic "Updatable Property" in DAO Help.  
  
##  \<a name="cdaotabledef__cdaotabledef">\</a>  CDaoTableDef::CDaoTableDef  
 Constructs a **CDaoTableDef** object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to a [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
### Remarks  
 After constructing the object, you must call the [Create](#cdaotabledef__create) or [Open](#cdaotabledef__open) member function. When you finish with the object, you must call its [Close](#cdaotabledef__close) member function and destroy the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdaotabledef__close">\</a>  CDaoTableDef::Close  
 Call this member function to close and release the tabledef object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Usually after calling **Close**, you delete the tabledef object if it was allocated with **new**.  
  
 You can call [Open](#cdaotabledef__open) again after calling **Close**. This lets you reuse the tabledef object.  
  
 For related information, see the topic "Close Method" in DAO Help.  
  
##  \<a name="cdaotabledef__create">\</a>  CDaoTableDef::Create  
 Call this member function to create a new saved table.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the table.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A value corresponding to characteristics of the table represented by the tabledef object. You can use the bitwise-OR to combine any of the following constants:  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
  
 *lpszSrcTable*  
 A pointer to a string containing the source table name. By default this value is initialized as **NULL**.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to a string containing the default connection string. By default this value is initialized as **NULL**.  
  
### Remarks  
 Once you have named the tabledef, you can then call [Append](#cdaotabledef__append) to save the tabledef in the database's TableDefs collection. After calling **Append**, the tabledef is in an open state, and you can use it to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object.  
  
 For related information, see the topic "CreateTableDef Method" in DAO Help.  
  
##  \<a name="cdaotabledef__createfield">\</a>  CDaoTableDef::CreateField  
 Call this member function to add a field to the table.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to a string expression specifying the name of this field.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A value indicating the data type of the field. The setting can be one of these values:  
  
|Type|Size (bytes)|Description|  
|----------|--------------------|-----------------|  
|**dbBoolean**|1 byte|BOOL|  
|**dbByte**|1|BYTE|  
|**dbInteger**|2|int|  
|**dbLong**|4|long|  
|**dbCurrency**|8|Currency ( [COleCurrency](../vs140/colecurrency-class.md))|  
|**dbSingle**|4|float|  
|**dbDouble**|8|double|  
|**dbDate**|8|Date/Time ( [COleDateTime](../vs140/coledatetime-class.md))|  
|**dbText**|1 – 255|Text ( [CString](../vs140/cstringt-class.md))|  
|**dbLongBinary**|0|Long Binary (OLE Object), [CLongBinary](../vs140/clongbinary-class.md) or [CByteArray](../vs140/cbytearray-class.md)|  
|**dbMemo**|0|Memo ( [CString](../vs140/cstringt-class.md))|  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A value that indicates the maximum size, in bytes, of a field that contains text, or the fixed size of a field that contains text or numeric values. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter is ignored for all but text fields.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A value corresponding to characteristics of the field and that can be combined using a bitwise-OR.  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbFixedField**|The field size is fixed (default for Numeric fields).|  
|**dbVariableField**|The field size is variable (Text fields only).|  
|**dbAutoIncrField**|The field value for new records is automatically incremented to a unique long integer that cannot be changed. Only supported for Microsoft Jet database tables.|  
|**dbUpdatableField**|The field value can be changed.|  
|**dbDescending**|The field is sorted in descending (Z – A or 100 – 0) order (applies only to a Field object in a Fields collection of an Index object). If you omit this constant, the field is sorted in ascending (A – Z or 0 – 100) order (default).|  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A reference to a [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure.  
  
### Remarks  
 A **DAOField** (OLE) object is created and appended to the Fields collection of the **DAOTableDef** (OLE) object. Besides its use for examining object properties, you can also use <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to construct an input parameter for creating new fields in a tabledef. The first version of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is simpler to use, but if you want finer control, you can use the second version of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, which takes a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> parameter.  
  
 If you use the version of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> that takes a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameter, you must carefully set each of the following members of the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> structure:  
  
-   **m_strName**  
  
-   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
-   **m_lSize**  
  
-   **m_lAttributes**  
  
-   **m_bAllowZeroLength**  
  
 The remaining members of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> should be set to **0**, **FALSE**, or an empty string, as appropriate for the member, or a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> may occur.  
  
 For related information, see the topic "CreateField Method" in DAO Help.  
  
##  \<a name="cdaotabledef__createindex">\</a>  CDaoTableDef::CreateIndex  
 Call this function to add an index to a table.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A reference to a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure.  
  
### Remarks  
 Indexes specify the order of records accessed from database tables and whether or not duplicate records are accepted. Indexes also provide efficient access to data.  
  
 You do not have to create indexes for tables, but in large, unindexed tables, accessing a specific record or creating a recordset can take a long time. On the other hand, creating too many indexes slows down update, append, and delete operations as all indexes are automatically updated. Consider these factors as you decide which indexes to create.  
  
 The following members of the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> structure must be set:  
  
-   **m_strName** A name must be supplied.  
  
-   <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> Must point to an array of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> structures.  
  
-   <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> Must specify the number of fields in the array of <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> structures.  
  
 The remaining members will be ignored if set to **FALSE**. In addition, the **m_lDistinctCount** member is ignored during creation of the index.  
  
##  \<a name="cdaotabledef__deletefield">\</a>  CDaoTableDef::DeleteField  
 Call this member function to remove a field and make it inaccessible.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to a string expression that is the name of an existing field.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The index of the field in the table's zero-based Fields collection, for lookup by index.  
  
### Remarks  
 You can use this member function on a new object that has not been appended to the database or when [CanUpdate](#cdaotabledef__canupdate) returns nonzero.  
  
 For related information, see the topic "Delete Method" in DAO Help.  
  
##  \<a name="cdaotabledef__deleteindex">\</a>  CDaoTableDef::DeleteIndex  
 Call this member function to delete an index in an underlying table.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to a string expression that is the name of an existing index.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The array index of the index object in the database's zero-based TableDefs collection, for lookup by index.  
  
### Remarks  
 You can use this member function on a new object that hasn't been appended to the database or when [CanUpdate](#cdaotabledef__canupdate) returns nonzero.  
  
 For related information, see the topic "Delete Method" in DAO Help.  
  
##  \<a name="cdaotabledef__getattributes">\</a>  CDaoTableDef::GetAttributes  
 For a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object, the return value specifies characteristics of the table represented by the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object and can be a sum of these constants:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns a value that indicates one or more characteristics of a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
### Remarks  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
|**dbAttachedTable**|Indicates the table is an attached table from a non-ODBC database, such as a Paradox database.|  
|**dbAttachedODBC**|Indicates the table is an attached table from an ODBC database, such as Microsoft SQL Server.|  
  
 A system table is a table created by the Microsoft Jet database engine to contain various internal information.  
  
 A hidden table is a table created for temporary use by the Microsoft Jet database engine.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getconnect">\</a>  CDaoTableDef::GetConnect  
 Call this member function to obtain the connection string for a data source.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object containing the path and database type for the table.  
  
### Remarks  
 For a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object that represents an attached table, the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object consists of one or two parts (a database type specifier and a path to the database).  
  
 The path as shown in the table below is the full path for the directory containing the database files and must be preceded by the identifier "DATABASE=". In some cases (as with Microsoft Jet and Microsoft Excel databases), a specific filename is included in the database path argument.  
  
 The table in [CDaoTableDef::SetConnect](#cdaotabledef__setconnect) shows possible database types and their corresponding database specifiers and paths:  
  
 For Microsoft Jet database base tables, the specifier is a empty string ("").  
  
 If a password is required but not provided, the ODBC driver displays a login dialog box the first time a table is accessed and again if the connection is closed and reopened. If an attached table has the **dbAttachSavePWD** attribute, the login prompt will not appear when the table is reopened.  
  
 For related information, see the topic "Connect Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getdatecreated">\</a>  CDaoTableDef::GetDateCreated  
 Call this function to determine the date and time the table underlying the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object was created.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A value containing the date and time of the creation of the table underlying the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The date and time settings are derived from the computer on which the base table was created or last updated. In a multiuser environment, users should get these settings directly from the file server to avoid discrepancies; that is, all clients should use a "standard" time source — perhaps from one server.  
  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
##  \<a name="cdaotabledef__getdatelastupdated">\</a>  CDaoTableDef::GetDateLastUpdated  
 Call this function to determine the date and time the table underlying the **CDaoTableDef** object was last updated.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A value that contains the date and time the table underlying the **CDaoTableDef** object was last updated.  
  
### Remarks  
 The date and time settings are derived from the computer on which the base table was created or last updated. In a multiuser environment, users should get these settings directly from the file server to avoid discrepancies; that is, all clients should use a "standard" time source — perhaps from one server.  
  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
##  \<a name="cdaotabledef__getfieldcount">\</a>  CDaoTableDef::GetFieldCount  
 Call this member function to retrieve the number of fields defined in the table.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The number of fields in the table.  
  
### Remarks  
 If its value is 0, there are no objects in the collection.  
  
 For related information, see the topic "Count Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getfieldinfo">\</a>  CDaoTableDef::GetFieldInfo  
 Call this member function to obtain various kinds of information about a field defined in the tabledef.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The index of the field object in the table's zero-based Fields collection, for lookup by index.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A reference to a [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Options that specify which information about the field to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> (Default) Name, Type, Size, Attributes. Use this option for fastest performance.  
  
-   <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> Primary information, plus: Ordinal Position, Required, Allow Zero Length, Collating Order, Foreign Name, Source Field, Source Table  
  
-   <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> Primary and secondary information, plus: Validation Rule, Validation Text, Default Value  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A pointer to the name of the field object, for lookup by name. The name is a string with up to 64 characters that uniquely names the field.  
  
### Remarks  
 One version of the function lets you look up a field by index. The other version lets you look up a field by name.  
  
 For a description of the information returned, see the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getindexcount">\</a>  CDaoTableDef::GetIndexCount  
 Call this member function to obtain the number of indexes for a table.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The number of indexes for the table.  
  
### Remarks  
 If its value is 0, there are no indexes in the collection.  
  
 For related information, see the topic "Count Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getindexinfo">\</a>  CDaoTableDef::GetIndexInfo  
 Call this member function to obtain various kinds of information about an index defined in the tabledef.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The numeric index of the Index object in the table's zero-based Indexes collection, for lookup by its position in the collection.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A reference to a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Options that specify which information about the index to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> Name, Field Info, Fields. Use this option for fastest performance.  
  
-   <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> Primary information, plus: Primary, Unique, Clustered, Ignore Nulls, Required, Foreign  
  
-   <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> Primary and secondary information, plus: Distinct Count  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A pointer to the name of the index object, for lookup by name.  
  
### Remarks  
 One version of the function lets you look up an index by its position in the collection. The other version lets you look up an index by name.  
  
 For a description of the information returned, see the [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getname">\</a>  CDaoTableDef::GetName  
 Call this member function to obtain the user-defined name of the underlying table.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A user-defined name for a table.  
  
### Remarks  
 This name starts with a letter and can contain a maximum of 64 characters. It can include numbers and underscore characters but cannot include punctuation or spaces.  
  
 For related information, see the topic "Name Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getrecordcount">\</a>  CDaoTableDef::GetRecordCount  
 Call this member function to find out how many records are in a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The number of records accessed in a tabledef object.  
  
### Remarks  
 Calling <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> for a table-type <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object reflects the approximate number of records in the table and is affected immediately as table records are added and deleted. Rolled back transactions will appear as part of the record count until you call [CDaoWorkSpace::CompactDatabase](../vs140/cdaoworkspace-class.md#cdaoworkspace__compactdatabase). A <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object with no records has a record count property setting of 0. When working with attached tables or ODBC databases, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> always returns –1.  
  
 For related information, see the topic "RecordCount Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getsourcetablename">\</a>  CDaoTableDef::GetSourceTableName  
 Call this member function to retrieve the name of an attached table in a source database.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object that specifies the source name of an attached table, or an empty string if a native data table.  
  
### Remarks  
 An attached table is a table in another database linked to a Microsoft Jet database. Data for attached tables remains in the external database, where it can be manipulated by other applications.  
  
 For related information, see the topic "SourceTableName Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getvalidationrule">\</a>  CDaoTableDef::GetValidationRule  
 Call this member function to retrieve the validation rule for a tabledef.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A **CString** object that validates the data in a field as it is changed or added to a table.  
  
### Remarks  
 Validation rules are used in connection with update operations. If a tabledef contains a validation rule, updates to that tabledef must match predetermined criteria before the data is changed. If the change does not match the criteria, an exception containing the value of [GetValidationText](#cdaotabledef__getvalidationtext) is thrown. For a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object, this <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is read-only for an attached table and read/write for a base table.  
  
 For related information, see the topic "ValidationRule Property" in DAO Help.  
  
##  \<a name="cdaotabledef__getvalidationtext">\</a>  CDaoTableDef::GetValidationText  
 Call this function to retrieve the string to display when a user enters data that does not match the validation rule.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object that specifies the text displayed if the user enters data that does not match the validation rule.  
  
### Remarks  
 For a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object, this <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> is read-only for an attached table and read/write for a base table.  
  
 For related information, see the topic "ValidationText Property" in DAO Help.  
  
##  \<a name="cdaotabledef__isopen">\</a>  CDaoTableDef::IsOpen  
 Call this member function to determine whether the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object is currently open.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object is open; otherwise 0.  
  
### Remarks  
  
##  \<a name="cdaotabledef__m_pdatabase">\</a>  CDaoTableDef::m_pDatabase  
 Contains a pointer to the [CDaoDatabase](../vs140/cdaodatabase-class.md) object for this table.  
  
### Remarks  
  
##  \<a name="cdaotabledef__m_pdaotabledef">\</a>  CDaoTableDef::m_pDAOTableDef  
 Contains a pointer to the OLE interface for the DAO tabledef object underlying the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Use this pointer if you need to access the DAO interface directly.  
  
##  \<a name="cdaotabledef__open">\</a>  CDaoTableDef::Open  
 Call this member function to open a tabledef previously saved in the database's TableDef's collection.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 A pointer to a string that specifies a table name.  
  
### Remarks  
  
##  \<a name="cdaotabledef__refreshlink">\</a>  CDaoTableDef::RefreshLink  
 Call this member function to update the connection information for an attached table.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 You change the connection information for an attached table by calling [SetConnect](#cdaotabledef__setconnect) on the corresponding <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object and then using the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> member function to update the information. When you call <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, the attached table's properties are not changed.  
  
 To force the modified connect information to take effect, all open [CDaoRecordset](../vs140/cdaorecordset-class.md) objects based on this tabledef must be closed.  
  
 For related information, see the topic "RefreshLink Method" in DAO Help.  
  
##  \<a name="cdaotabledef__setattributes">\</a>  CDaoTableDef::SetAttributes  
 Sets a value that indicates one or more characteristics of a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Characteristics of the table represented by the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object and can be a sum of these constants:  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
  
### Remarks  
 When setting multiple attributes, you can combine them by summing the appropriate constants using the bitwise-OR operator. Setting **dbAttachExclusive** on a nonattached table produces an exception. Combining the following values also produce an exception:  
  
-   **dbAttachExclusive &#124; dbAttachedODBC**  
  
-   **dbAttachSavePWD &#124; dbAttachedTable**  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
##  \<a name="cdaotabledef__setconnect">\</a>  CDaoTableDef::SetConnect  
 For a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object that represents an attached table, the string object consists of one or two parts (a database type specifier and a path to the database).  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to a string expression that specifies additional parameters to pass to ODBC or installable ISAM drivers.  
  
### Remarks  
 The path as shown in the table below is the full path for the directory containing the database files and must be preceded by the identifier "DATABASE=". In some cases (as with Microsoft Jet and Microsoft Excel databases), a specific filename is included in the database path argument.  
  
> [!NOTE]
>  Do not include whitespace around the equal sign in path statements of the form "DATABASE=drive:\\\path". This will result in an exception being thrown and the connection failing.  
  
 The following table shows possible database types and their corresponding database specifiers and paths:  
  
|Database type|Specifier|Path|  
|-------------------|---------------|----------|  
|Database using the Jet database engine|"[ <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>];"|" <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>:\\\                                        *path*\\\                                        *filename*.MDB"|  
|dBASE III|"dBASE III;"|" <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|dBASE IV|"dBASE IV;"|" <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|dBASE 5|"dBASE 5.0;"|" <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|Paradox 3.x|"Paradox 3.x;"|" <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|Paradox 4.x|"Paradox 4.x;"|" <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|Paradox 5.x|"Paradox 5.x;"|" <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|Excel 3.0|"Excel 3.0;"|" <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>:\\\                                        *path*\\\                                        *filename*.XLS"|  
|Excel 4.0|"Excel 4.0;"|" <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>:\\\                                        *path*\\\                                        *filename*.XLS"|  
|Excel 5.0 or Excel 95|"Excel 5.0;"|" <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>:\\\                                        *path*\\\                                        *filename*.XLS"|  
|Excel 97|"Excel 8.0;"|" <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>:\\\                                        *path*\                                        *filename*.XLS"|  
|HTML Import|"HTML Import;"|" <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>:\\\                                        *path*\                                        *filename*"|  
|HTML Export|"HTML Export;"|" <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>:\\\                                        *path*"|  
|Text|"Text;"|"drive:\\\path"|  
|ODBC|"ODBC; DATABASE= <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>; UID=                                        *user*;PWD=                                        *password*; DSN=                                        *datasourcename;* LOGINTIMEOUT=                                        *seconds;*" (This may not be a complete connection string for all servers; it is just an example. It is very important not to have spaces between the parameters.)|None|  
|Exchange|"Exchange;\<br />\<br /> MAPILEVEL=                                        *folderpath*;\<br />\<br /> [TABLETYPE={ 0 &#124; 1 };]\<br />\<br /> [PROFILE=                                        *profile*;]\<br />\<br /> [PWD=                                        *password*;]\<br />\<br /> [DATABASE= <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>;]"|*"drive*:\\\                                        *path*\\\                                        *filename*.MDB"|  
  
> [!NOTE]
>  Btrieve is no longer supported as of DAO 3.5.  
  
 You must use a double backslash (\\\\) in the connection strings. If you have modified the properties of an existing connection using <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, you must subsequently call [RefreshLink](#cdaotabledef__refreshlink). If you are initializing the connection properties using <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, you need not call <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, but should you choose to do so, first append the tabledef.  
  
 If a password is required but not provided, the ODBC driver displays a login dialog box the first time a table is accessed and again if the connection is closed and reopened.  
  
 You can set the connection string for a <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object by providing a source argument to the **Create** member function. You can check the setting to determine the type, path, user ID, password, or ODBC data source of the database. For more information, see the documentation for the specific driver.  
  
 For related information, see the topic "Connect Property" in DAO Help.  
  
##  \<a name="cdaotabledef__setname">\</a>  CDaoTableDef::SetName  
 Call this member function to set a user-defined name for a table.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A pointer to a string expression that specifies a name for a table.  
  
### Remarks  
 The name must start with a letter and can contain a maximum of 64 characters. It can include numbers and underscore characters but cannot include punctuation or spaces.  
  
 For related information, see the topic "Name Property" in DAO Help.  
  
##  \<a name="cdaotabledef__setsourcetablename">\</a>  CDaoTableDef::SetSourceTableName  
 Call this member function to specify the name of an attached table or the name of the base table on which the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object is based, as it exists in the original source of the data.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *lpszSrcTableName*  
 A pointer to a string expression that specifies a table name in the external database. For a base table, the setting is an empty string ("").  
  
### Remarks  
 You must then call [RefreshLink](#cdaotabledef__refreshlink). This property setting is empty for a base table and read/write for an attached table or an object not appended to a collection.  
  
 For related information, see the topic "SourceTableName Property" in DAO Help.  
  
##  \<a name="cdaotabledef__setvalidationrule">\</a>  CDaoTableDef::SetValidationRule  
 Call this member function to set a validation rule for a tabledef.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 *lpszValidationRule*  
 A pointer to a string expression that validates an operation.  
  
### Remarks  
 Validation rules are used in connection with update operations. If a tabledef contains a validation rule, updates to that tabledef must match predetermined criteria before the data is changed. If the change does not match the criteria, an exception containing the text of [GetValidationText](#cdaotabledef__getvalidationtext) is displayed.  
  
 Validation is supported only for databases that use the Microsoft Jet database engine. The expression cannot refer to user-defined functions, domain aggregate functions, SQL aggregate functions, or queries. A validation rule for a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> object can refer to multiple fields in that object.  
  
 For example, for fields named <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, a validation rule might be:  
  
 [!code[NVC_MFCDatabase#34](../vs140/codesnippet/CPP/cdaotabledef-class_1.cpp)]  
  
 For related information, see the topic "ValidationRule Property" in DAO Help.  
  
##  \<a name="cdaotabledef__setvalidationtext">\</a>  CDaoTableDef::SetValidationText  
 Call this member function to set the exception text of a validation rule for a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object with an underlying base table supported by the Microsoft Jet database engine.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *lpszValidationText*  
 A pointer to a string expression that specifies the text displayed if entered data is invalid.  
  
### Remarks  
 You cannot set the validation text of an attached table.  
  
 For related information, see the topic "ValidationText Property" in DAO Help.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase](../vs140/cdaodatabase-class.md)   
 [CDaoRecordset](../vs140/cdaorecordset-class.md)