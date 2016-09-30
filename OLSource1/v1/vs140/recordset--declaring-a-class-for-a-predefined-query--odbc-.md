---
title: "Recordset: Declaring a Class for a Predefined Query (ODBC)"
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
  - "ODBC recordsets, queries"
  - "predefined queries and recordsets"
  - "stored procedures, and recordsets"
  - "recordsets, predefined queries"
  - "recordsets, stored procedures"
ms.assetid: d27c4df9-dad2-4484-ba72-92ab0c8ff928
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recordset: Declaring a Class for a Predefined Query (ODBC)
This topic applies to the MFC ODBC classes.  
  
 This topic explains how to create a recordset class for a predefined query (sometimes called a stored procedure, as in Microsoft SQL Server).  
  
> [!NOTE]
>  This topic applies to objects derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in which bulk row fetching has not been implemented. If bulk row fetching is implemented, the process is very similar. To understand the differences between recordsets that implement bulk row fetching and those that do not, see [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 Some database management systems (DBMSs) allow you to create a predefined query and call it from your programs like a function. The query has a name, might take parameters, and might return records. The procedure in this topic describes how to call a predefined query that returns records (and perhaps takes parameters).  
  
 The database classes do not support updating predefined queries. The difference between a snapshot predefined query and a dynaset predefined query is not updateability but whether changes made by other users (or other recordsets in your program) are visible in your recordset.  
  
> [!TIP]
>  You do not need a recordset to call a predefined query that does not return records. Prepare the SQL statement as described below, but execute it by calling the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function [ExecuteSQL](../vs140/cdatabase--executesql.md).  
  
 You can create a single recordset class to manage calling a predefined query, but you must do some of the work yourself. The wizards do not support creating a class specifically for this purpose.  
  
#### To create a class for calling a predefined query (stored procedure)  
  
1.  Use the [MFC ODBC Consumer Wizard](../vs140/adding-an-mfc-odbc-consumer.md) from **Add Class** to create a recordset class for the table that contributes the most columns returned by the query. This gives you a head start.  
  
2.  Manually add field data members for any columns of any tables that the query returns but that the wizard did not create for you.  
  
     For example, if the query returns three columns each from two additional tables, add six field data members (of the appropriate data types) to the class.  
  
3.  Manually add [RFX](../vs140/record-field-exchange--rfx-.md) function calls in the [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) member function of the class, one corresponding to the data type of each added field data member.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  You must know the data types and the order of columns returned in the result set. The order of RFX function calls in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must match the order of result set columns.  
  
4.  Manually add initializations for the new field data members in the recordset class constructor.  
  
     You must also increment the initialization value for the [m_nFields](../vs140/crecordset--m_nfields.md) data member. The wizard writes the initialization, but it only covers the field data members it adds for you. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Some data types should not be initialized here, for example, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or byte arrays.  
  
5.  If the query takes parameters, add a parameter data member for each parameter, an RFX function call for each, and an initialization for each.  
  
6.  You must increment <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for each added parameter, as you did <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for added fields in step 4 of this procedure. For more information, see [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md).  
  
7.  Manually write a SQL statement string with the following form:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     where **CALL** is an ODBC keyword, **proc-name** is the name of the query as it is known on the data source, and the "?" items are placeholders for the parameter values you supply to the recordset at run time (if any). The following example prepares a placeholder for one parameter:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
8.  In the code that opens the recordset, set the values of the recordset's parameter data members and then call the **Open** member function, passing your SQL string for the **lpszSQL** parameter. Or instead, replace the string returned by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member function in your class.  
  
 The following examples show the procedure for calling a predefined query, named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, which takes one parameter for a sales district number. This query returns three columns: <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. All columns are from the Customers table.  
  
 The following recordset specifies field data members for the columns the query returns and a parameter for the sales district number requested at run time.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This class declaration is as the wizard writes it, except for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member added manually. Other members are not shown here.  
  
 The next example shows the initializations for the data members in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> constructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Note the initializations for [m_nFields](../vs140/crecordset--m_nfields.md) and [m_nParams](../vs140/crecordset--m_nparams.md). The wizard initializes <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; you initialize <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The next example shows the RFX functions in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Besides making the RFX calls for the three returned columns, this code manages binding the parameter you pass at run time. The parameter is keyed to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (district number) column.  
  
 The next example shows how to set up the SQL string and how to use it to open the recordset.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This code constructs a snapshot, passes it a parameter obtained earlier from the user, and calls the predefined query. When the query runs, it returns records for the specified sales district. Each record contains columns for the account number, customer's last name, and customer's phone number.  
  
> [!TIP]
>  You might want to handle a return value (output parameter) from a stored procedure. For more information and an example, see [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md).  
  
## See Also  
 [Recordset (ODBC)](../vs140/recordset--odbc-.md)   
 [Recordset: Requerying a Recordset (ODBC)](../vs140/recordset--requerying-a-recordset--odbc-.md)   
 [Recordset: Declaring a Class for a Table (ODBC)](../vs140/recordset--declaring-a-class-for-a-table--odbc-.md)   
 [Recordset: Performing a Join (ODBC)](../vs140/recordset--performing-a-join--odbc-.md)