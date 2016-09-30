---
title: "SQL: SQL and C++ Data Types (ODBC)"
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
  - "data types [C++], SQL vs. C++"
  - "SQL data types [C++]"
  - "SQL [C++], vs. C++ data types"
ms.assetid: 066e0070-d4da-435c-9c4b-f7cab3352c86
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SQL: SQL and C++ Data Types (ODBC)
> [!NOTE]
>  This information applies to the MFC ODBC classes. If you are working with the MFC DAO classes, see the topic "Comparison of Microsoft Jet Database Engine SQL and ANSI SQL" in DAO Help.  
  
 The following table maps ANSI SQL data types to C++ data types. This augments the C language information given in Appendix D of the *ODBC SDK* *Programmer's Reference* on the MSDN Library CD. The wizards manage most data type mapping for you. If you do not use a wizard, you can use the mapping information to help you write the field exchange code manually.  
  
### ANSI SQL Data Types Mapped to C++ Data Types  
  
|ANSI SQL data type|C++ data type|  
|------------------------|---------------------|  
|**CHAR**|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|  
|**DECIMAL**|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> 1|  
|**SMALLINT**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**float**|  
|**INTEGER**|**long**|  
|**FLOAT**|**double**|  
|**DOUBLE**|**double**|  
|**NUMERIC**|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> 1|  
|**VARCHAR**|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|**LONGVARCHAR**|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> 2|  
|**BIT**|**BOOL**|  
|**TINYINT**|**BYTE**|  
|**BIGINT**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> 1|  
|**BINARY**|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|**VARBINARY**|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|**LONGVARBINARY**|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> 3|  
|**DATE**|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|**TIME**|**CTime, CString**|  
|**TIMESTAMP**|**CTime, CString**|  
  
 1. ANSI **DECIMAL** and **NUMERIC** map to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> because **SQL_C_CHAR** is the default ODBC transfer type.  
  
 2. Character data beyond 255 characters is truncated by default when mapped to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. You can extend the truncation length by explicitly setting the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 3. Binary data beyond 255 characters is truncated by default when mapped to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You can extend the truncation length by explicitly setting the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 If you are not using the ODBC cursor library, you might encounter a problem when attempting to update two or more long variable-length fields using the Microsoft SQL Server ODBC driver and the MFC ODBC database classes. The ODBC types, **SQL_LONGVARCHAR** and **SQL_LONGVARBINARY**, map to text and image SQL Server types. A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is thrown if you update two or more long variable-length fields on the same call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Therefore, do not update multiple long columns simultaneously with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. You can update multiple long columns simultaneously with the ODBC API **SQLPutData**. You can also use the ODBC cursor library, but this is not recommended for drivers, like the SQL Server driver, that support cursors and do not need the cursor library.  
  
 If you are using the ODBC cursor library with the MFC ODBC database classes and the Microsoft SQL Server ODBC driver, an **ASSERT** might occur along with a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if a call to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> follows a call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Instead, call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Another solution is not to use the ODBC cursor library, because the SQL Server and the SQL Server ODBC driver provide native support for cursors natively and the ODBC cursor library is not needed.  
  
## See Also  
 [SQL](../vs140/sql.md)   
 [SQL: Making Direct SQL Calls (ODBC)](../vs140/sql--making-direct-sql-calls--odbc-.md)