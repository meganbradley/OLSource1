---
title: "Record Field Exchange: Using the RFX Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ODBC [C++], data types"
  - "data types [C++], ODBC record field exchange"
  - "RFX (ODBC) [C++], function syntax and parameters"
  - "DoFieldExchange method, and RFX functions"
  - "ODBC [C++], RFX"
  - "RFX (ODBC) [C++], data types"
  - "function calls, RFX functions"
ms.assetid: c594300b-5a29-4119-a68b-e7ca32def696
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record Field Exchange: Using the RFX Functions
This topic explains how to use the RFX function calls that make up the body of your <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> override.  
  
> [!NOTE]
>  This topic applies to classes derived from [CRecordset](../vs140/crecordset-class.md) in which bulk row fetching has not been implemented. If you are using bulk row fetching, bulk record field exchange (Bulk RFX) is implemented. Bulk RFX is similar to RFX. To understand the differences, see [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 The RFX global functions exchange data between columns on the data source and field data members in your recordset. You write the RFX function calls in your recordset's [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) member function. This topic describes the functions briefly and shows the data types for which RFX functions are available. [Technical Note 43](../vs140/tn043--rfx-routines.md) describes how to write your own RFX functions for additional data types.  
  
##  \<a name="_core_rfx_function_syntax">\</a> RFX Function Syntax  
 Each RFX function takes three parameters (and some take an optional fourth or fifth parameter):  
  
-   A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. You simply pass along the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer passed to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   The name of the column as it appears on the data source.  
  
-   The name of the corresponding field data member or parameter data member in the recordset class.  
  
-   (Optional) In some of the functions, the maximum length of the string or array being transferred. This defaults to 255 bytes, but you might want to change it. The maximum size is based on the maximum size of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object — **INT_MAX** (2,147,483,647) bytes — but you will probably encounter driver limits before that size.  
  
-   (Optional) In the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function, you sometimes use a fifth parameter to specify the data type of a column.  
  
 For more information, see the RFX functions under [Macros and Globals](../vs140/macros--global-functions--and-global-variables.md) in the *Class Library Reference*. For an example of when you might make special use of the parameters, see [Recordset: Obtaining SUMs and Other Aggregate Results (ODBC)](../vs140/recordset--obtaining-sums-and-other-aggregate-results--odbc-.md).  
  
##  \<a name="_core_rfx_data_types">\</a> RFX Data Types  
 The class library supplies RFX functions for transferring many different data types between the data source and your recordsets. The following list summarizes the RFX functions by data type. In cases where you must write your own RFX function calls, select from these functions by data type.  
  
|Function|Data type|  
|--------------|---------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|**BOOL**|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|**BYTE**|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
 For more information, see the RFX function documentation under [Macros and Globals](../vs140/macros--global-functions--and-global-variables.md) in the *Class Library Reference*. For information about how C++ data types map to SQL data types, see the table ANSI SQL Data Types Mapped to C++ Data Types in [SQL: SQL and C++ Data Types (ODBC)](../vs140/sql--sql-and-c---data-types--odbc-.md).  
  
## See Also  
 [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md)   
 [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md)   
 [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md)   
 [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md)   
 [CRecordset Class](../vs140/crecordset-class.md)   
 [CFieldExchange Class](../vs140/cfieldexchange-class.md)