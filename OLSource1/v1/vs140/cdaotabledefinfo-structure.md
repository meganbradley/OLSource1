---
title: "CDaoTableDefInfo Structure"
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
  - "CDaoTableDefInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDefInfo structure"
  - "DAO (Data Access Objects), TableDefs collection"
ms.assetid: c01ccebb-5615-434e-883c-4f60eac943dd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDefInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a tabledef object defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Uniquely names the tabledef object. To retrieve the value of this property directly, call the tabledef object's [GetName](../vs140/cdaotabledef--getname.md) member function. For more information, see the topic "Name Property" in DAO Help.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates whether changes can be made to the table. The quick way to determine whether a table is updatable is to open a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object for the table and call the object's [CanUpdate](../vs140/cdaotabledef--canupdate.md) member function. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> always returns nonzero (**TRUE**) for a newly created tabledef object and 0 (**FALSE**) for an attached tabledef object. A new tabledef object can be appended only to a database for which the current user has write permission. If the table contains only nonupdatable fields, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns 0. When one or more fields are updatable, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns nonzero. You can edit only the updatable fields. For more information, see the topic "Updatable Property" in DAO Help.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies characteristics of the table represented by the tabledef object. To retrieve the current attributes of a tabledef, call its [GetAttributes](../vs140/cdaotabledef--getattributes.md) member function. The value returned can be a combination of these long constants (using the bitwise-OR (**&#124;**) operator):  
  
-   **dbAttachExclusive** For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.  
  
-   **dbAttachSavePWD** For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.  
  
-   **dbSystemObject** Indicates the table is a system table provided by the Microsoft Jet database engine. (Read-only.)  
  
-   **dbHiddenObject** Indicates the table is a hidden table provided by the Microsoft Jet database engine (for temporary use). (Read-only.)  
  
-   **dbAttachedTable** Indicates the table is an attached table from a non-ODBC database, such as a Paradox database.  
  
-   **dbAttachedODBC** Indicates the table is an attached table from an ODBC database, such as Microsoft SQL Server.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The date and time the table was created. To directly retrieve the date the table was created, call the [GetDateCreated](../vs140/cdaotabledef--getdatecreated.md) member function of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object associated with the table. See Comments below for more information. For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The date and time of the most recent change made to the design of the table. To directly retrieve the date the table was last updated, call the [GetDateLastUpdated](../vs140/cdaotabledef--getdatelastupdated.md) member function of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object associated with the table. See Comments below for more information. For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
 *m_strSrcTableName*  
 Specifies the name of an attached table if any. To directly retrieve the source table name, call the [GetSourceTableName](../vs140/cdaotabledef--getsourcetablename.md) member function of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object associated with the table.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Provides information about the source of an open database. You can check this property by calling the [GetConnect](../vs140/cdaotabledef--getconnect.md) member function of your <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. For more information about connect strings, see <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A value that validates the data in tabledef fields as they are changed or added to a table. Validation is supported only for databases that use the Microsoft Jet database engine. To directly retrieve the validation rule, call the [GetValidationRule](../vs140/cdaotabledef--getvalidationrule.md) member function of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object associated with the table. For related information, see the topic "ValidationRule Property" in DAO Help.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A value that specifies the text of the message that your application should display if the validation rule specified by the ValidationRule property is not satisfied. For related information, see the topic "ValidationText Property" in DAO Help.  
  
 *m_lRecordCount*  
 The number of records accessed in a tabledef object. This property setting is read-only. To directly retrieve the record count, call the [GetRecordCount](../vs140/cdaotabledef--getrecordcount.md) member function of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. The documentation for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> describes the record count further. Note that retrieving this count can be a time-consuming operation if the table contains many records.  
  
## Remarks  
 The tabledef is an object of class [CDaoTableDef](../vs140/cdaotabledef-class.md). The references to Primary, Secondary, and All above indicate how the information is returned by the [GetTableDefInfo](../vs140/cdaodatabase--gettabledefinfo.md) member function in class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 Information retrieved by the [CDaoDatabase::GetTableDefInfo](../vs140/cdaodatabase--gettabledefinfo.md) member function is stored in a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure. Call the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object in whose TableDefs collection the tabledef object is stored. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 The date and time settings are derived from the computer on which the base table was created or last updated. In a multiuser environment, users should get these settings directly from the file server to avoid discrepancies in the DateCreated and LastUpdated property settings.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [CDaoTableDef::CanUpdate](../vs140/cdaotabledef--canupdate.md)   
 [CDaoTableDef::GetAttributes](../vs140/cdaotabledef--getattributes.md)   
 [CDaoTableDef::GetDateCreated](../vs140/cdaotabledef--getdatecreated.md)   
 [CDaoTableDef::GetDateLastUpdated](../vs140/cdaotabledef--getdatelastupdated.md)   
 [CDaoTableDef::GetRecordCount](../vs140/cdaotabledef--getrecordcount.md)   
 [CDaoTableDef::GetSourceTableName](../vs140/cdaotabledef--getsourcetablename.md)   
 [CDaoTableDef::GetValidationRule](../vs140/cdaotabledef--getvalidationrule.md)   
 [CDaoTableDef::GetValidationText](../vs140/cdaotabledef--getvalidationtext.md)