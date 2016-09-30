---
title: "Recordset: Filtering Records (ODBC)"
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
  - "data [MFC], filtering"
  - "recordsets [C++], filtering"
  - "filtering recordsets"
  - "ODBC recordsets [C++], filtering records"
  - "filters [C++], recordset object"
ms.assetid: 5c075f37-c837-464d-90c1-d028a9d1c175
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recordset: Filtering Records (ODBC)
This topic applies to the MFC ODBC classes.  
  
 This topic explains how to filter a recordset so that it selects only a particular subset of the available records. For example, you might want to select only the class sections for a particular course, such as MATH101. A filter is a search condition defined by the contents of a SQL **WHERE** clause. When the framework appends it to the recordset's SQL statement, the **WHERE** clause constrains the selection.  
  
 You must establish a recordset object's filter after you construct the object but before you call its **Open** member function (or before you call the **Requery** member function for an existing recordset object whose **Open** member function has been called previously).  
  
#### To specify a filter for a recordset object  
  
1.  Construct a new recordset object (or prepare to call **Requery** for an existing object).  
  
2.  Set the value of the object's [m_strFilter](../vs140/crecordset--m_strfilter.md) data member.  
  
     The filter is a null-terminated string that contains the contents of the SQL **WHERE** clause but not the keyword **WHERE**. For example, use:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     not  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The literal string "MATH101" is shown with single quotation marks above. In the ODBC SQL specification, single quotes are used to denote a character string literal. Check your ODBC driver documentation for the quoting requirements of your DBMS in this situation. This syntax is also discussed further near the end of this topic.  
  
3.  Set any other options you need, such as sort order, locking mode, or parameters. Specifying a parameter is especially useful. For information about parameterizing your filter, see [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md).  
  
4.  Call **Open** for the new object (or **Requery** for a previously opened object).  
  
> [!TIP]
>  Using parameters in your filter is potentially the most efficient method for retrieving records.  
  
> [!TIP]
>  Recordset filters are useful for [joining](../vs140/recordset--performing-a-join--odbc-.md) tables and for using [parameters](../vs140/recordset--parameterizing-a-recordset--odbc-.md) based on information obtained or calculated at run time.  
  
 The recordset selects only those records that meet the search condition you specified. For example, to specify the course filter described above (assuming a variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> currently set, for instance, to "MATH101"), do the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The recordset contains records for all class sections for MATH101.  
  
 Notice how the filter string was set in the example above, using a string variable. This is the typical usage. But suppose you wanted to specify the literal value 100 for the course ID. The following code shows how to set the filter string correctly with a literal value:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Note the use of single quote characters; if you set the filter string directly, the filter string is **not**:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The quoting shown above conforms to the ODBC specification, but some DBMSs might require other quote characters. For more information, see [SQL: Customizing Your Recordset's SQL Statement (ODBC)](../vs140/sql--customizing-your-recordset’s-sql-statement--odbc-.md).  
  
> [!NOTE]
>  If you choose to override the recordset's default SQL string by passing your own SQL string to **Open**, you should not set a filter if your custom string has a **WHERE** clause. For more information about overriding the default SQL, see [SQL: Customizing Your Recordset's SQL Statement (ODBC)](../vs140/sql--customizing-your-recordset’s-sql-statement--odbc-.md).  
  
## See Also  
 [Recordset (ODBC)](../vs140/recordset--odbc-.md)   
 [Recordset: Sorting Records (ODBC)](../vs140/recordset--sorting-records--odbc-.md)   
 [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md)   
 [Recordset: How Recordsets Update Records (ODBC)](../vs140/recordset--how-recordsets-update-records--odbc-.md)   
 [Recordset: Locking Records (ODBC)](../vs140/recordset--locking-records--odbc-.md)