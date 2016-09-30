---
title: "CRecordset::GetFieldValue"
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
  - "CRecordset::GetFieldValue"
  - "CRecordset.GetFieldValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting field information"
  - "CRecordset class, getting field values"
  - "GetFieldValue method"
ms.assetid: 7baf0a0c-2ef3-4ed8-8377-95bff3599788
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetFieldValue
Retrieves field data in the current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of a field.  
  
 *varValu*e  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object that will store the field's value.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The ODBC C data type of the field. Using the default value, **DEFAULT_FIELD_TYPE**, forces <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to determine the C data type from the SQL data type, based on the following table. Otherwise, you can specify the data type directly or choose a compatible data type; for example, you can store any data type into **SQL_C_CHAR**.  
  
|C data type|SQL data type|  
|-----------------|-------------------|  
|**SQL_C_BIT**|**SQL_BIT**|  
|**SQL_C_UTINYINT**|**SQL_TINYINT**|  
|**SQL_C_SSHORT**|**SQL_SMALLINT**|  
|**SQL_C_SLONG**|**SQL_INTEGER**|  
|**SQL_C_FLOAT**|**SQL_REAL**|  
|**SQL_C_DOUBLE**|**SQL_FLOATSQL_DOUBLE**|  
|**SQL_C_TIMESTAMP**|**SQL_DATESQL_TIMESQL_TIMESTAMP**|  
|**SQL_C_CHAR**|**SQL_NUMERICSQL_DECIMALSQL_BIGINTSQL_CHARSQL_VARCHARSQL_LONGVARCHAR**|  
|**SQL_C_BINARY**|**SQL_BINARYSQL_VARBINARYSQL_LONGVARBINARY**|  
  
 For more information about ODBC data types, see the topics "SQL Data Types" and "C Data Types" in Appendix D of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The zero-based index of the field.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that will store the field's value converted to text, regardless of the field's data type.  
  
## Remarks  
 You can look up a field either by name or by index. You can store the field value in either a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 If you have implemented bulk row fetching, the current record is always positioned on the first record in a rowset. To use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on a record within a given rowset, you must first call the [SetRowsetCursorPosition](../vs140/crecordset--setrowsetcursorposition.md) member function to move the cursor to the desired row within that rowset. Then call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for that row. To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter in the [Open](../vs140/crecordset--open.md) member function.  
  
 You can use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to dynamically fetch fields at run time rather than statically binding them at design time. For example, if you have declared a recordset object directly from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you must use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to retrieve the field data; record field exchange (RFX), or bulk record field exchange (Bulk RFX), is not implemented.  
  
> [!NOTE]
>  If you declare a recordset object without deriving from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, do not have the ODBC Cursor Library loaded. The cursor library requires that the recordset have at least one bound column; however, when you use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> directly, none of the columns are bound. The member functions [CDatabase::OpenEx](../vs140/cdatabase--openex.md) and [CDatabase::Open](../vs140/cdatabase--open.md) control whether the cursor library will be loaded.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> calls the ODBC API function **SQLGetData**. If your driver outputs the value **SQL_NO_TOTAL** for the actual length of the field value, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> throws an exception. For more information about **SQLGetData**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample code illustrates calls to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for a recordset object declared directly from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCDatabase#23](../vs140/codesnippet/CPP/crecordset--getfieldvalue_1.cpp)]  
  
> [!NOTE]
>  Unlike the DAO class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not have a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function. If you create an object directly from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, it is effectively read-only.  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)   
 [CRecordset::GetODBCFieldCount](../vs140/crecordset--getodbcfieldcount.md)   
 [CRecordset::GetODBCFieldInfo](../vs140/crecordset--getodbcfieldinfo.md)   
 [CRecordset::SetRowsetCursorPosition](../vs140/crecordset--setrowsetcursorposition.md)