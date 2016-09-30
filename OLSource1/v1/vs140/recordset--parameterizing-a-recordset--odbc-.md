---
title: "Recordset: Parameterizing a Recordset (ODBC)"
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
  - "parameterizing recordsets"
  - "ODBC recordsets, parameterizing"
  - "recordsets, parameterizing"
  - "passing parameters, to queries at runtime"
ms.assetid: 7d1dfeb6-5ee0-45e2-aacc-63bc52a465cd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recordset: Parameterizing a Recordset (ODBC)
This topic applies to the MFC ODBC classes.  
  
 Sometimes you might want to be able to select records at run time, using information you have calculated or obtained from your end user. Recordset parameters let you accomplish that goal.  
  
 This topic explains:  
  
-   [The purpose of a parameterized recordset](#_core_parameterized_recordsets).  
  
-   [When and why you might want to parameterize a recordset](#_core_when_to_use_parameters).  
  
-   [How to declare parameter data members in your recordset class](#_core_parameterizing_your_recordset_class).  
  
-   [How to pass parameter information to a recordset object at run time](#_core_passing_parameter_values_at_run_time).  
  
##  \<a name="_core_parameterized_recordsets">\</a> Parameterized Recordsets  
 A parameterized recordset lets you pass parameter information at run time. This has two valuable effects:  
  
-   It might result in better execution speed.  
  
-   It lets you build a query at run time, based on information not available to you at design time, such as information obtained from your user or calculated at run time.  
  
 When you call **Open** to run the query, the recordset uses the parameter information to complete its **SQL SELECT** statement. You can parameterize any recordset.  
  
##  \<a name="_core_when_to_use_parameters">\</a> When to Use Parameters  
 Typical uses for parameters include:  
  
-   Passing run-time arguments to a predefined query.  
  
     To pass parameters to a stored procedure, you must specify a complete custom ODBC **CALL** statement — with parameter placeholders — when you call **Open**, overriding the recordset's default SQL statement. For more information, see [CRecordset::Open](../vs140/crecordset--open.md) in the *Class Library Reference* and [SQL: Customizing Your Recordset's SQL Statement (ODBC)](../vs140/sql--customizing-your-recordset’s-sql-statement--odbc-.md) and [Recordset: Declaring a Class for a Predefined Query (ODBC)](../vs140/recordset--declaring-a-class-for-a-predefined-query--odbc-.md).  
  
-   Efficiently performing numerous requeries with different parameter information.  
  
     For example, each time your end user looks up information for a particular student in the student registration database, you can specify the student's name or ID as a parameter obtained from the user. Then, when you call your recordset's **Requery** member function, the query selects only that student's record.  
  
     Your recordset's filter string, stored in **m_strFilter**, might look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Suppose you obtain the student ID in the variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. When you set a parameter to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (for example, the student ID 100) the value of the variable is bound to the parameter placeholder represented by the "?" in the filter string.  
  
     Assign the parameter value as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You would not want to set up a filter string this way:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     For a discussion of how to use quotes correctly for filter strings, see [Recordset: Filtering Records (ODBC)](../vs140/recordset--filtering-records--odbc-.md).  
  
     The parameter value is different each time you requery the recordset for a new student ID.  
  
    > [!TIP]
    >  Using a parameter is more efficient than simply a filter. For a parameterized recordset, the database must process a SQL **SELECT** statement only once. For a filtered recordset without parameters, the **SELECT** statement must be processed each time you **Requery** with a new filter value.  
  
 For more information about filters, see [Recordset: Filtering Records (ODBC)](../vs140/recordset--filtering-records--odbc-.md).  
  
##  \<a name="_core_parameterizing_your_recordset_class">\</a> Parameterizing Your Recordset Class  
  
> [!NOTE]
>  This section applies to objects derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in which bulk row fetching has not been implemented. If you are using bulk row fetching, implementing parameters is a similar process. For more information, see [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 Before you create your recordset class, determine what parameters you need, what their data types are, and how the recordset uses them.  
  
#### To parameterize a recordset class  
  
1.  Run the [MFC ODBC Consumer Wizard](../vs140/adding-an-mfc-odbc-consumer.md) from **Add Class** to create the class.  
  
2.  Specify field data members for the recordset's columns.  
  
3.  After the wizard writes the class to a file in your project, go to the .h file and manually add one or more parameter data members to the class declaration. The addition might look something like the following example, part of a snapshot class designed to answer the query "Which students are in the senior class?"  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Add your parameter data members after the wizard-generated field data members. The convention is to append the word "Param" to each user-defined parameter name.  
  
4.  Modify the [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) member function definition in the .cpp file. Add an RFX function call for each parameter data member you added to the class. For information about writing your RFX functions, see [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md). Precede the RFX calls for the parameters with a single call to:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  In the constructor of your recordset class, increment the count of parameters, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
     For information, see [Record Field Exchange: Working with the Wizard Code](../vs140/record-field-exchange--working-with-the-wizard-code.md).  
  
6.  When you write the code that creates a recordset object of this class, place a "?" (question mark) symbol in each place in your SQL statement strings where a parameter is to be replaced.  
  
     At run time, "?" placeholders are filled, in order, by the parameter values you pass. The first parameter data member set after the [SetFieldType](../vs140/cfieldexchange--setfieldtype.md) call replaces the first "?" in the SQL string, the second parameter data member replaces the second "?", and so on.  
  
> [!NOTE]
>  Parameter order is important: the order of RFX calls for parameters in your <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function must match the order of the parameter placeholders in your SQL string.  
  
> [!TIP]
>  The most likely string to work with is the string you specify (if any) for the class's [m_strFilter](../vs140/crecordset--m_strfilter.md) data member, but some ODBC drivers might allow parameters in other SQL clauses.  
  
##  \<a name="_core_passing_parameter_values_at_run_time">\</a> Passing Parameter Values at Run Time  
 You must specify parameter values before you call **Open** (for a new recordset object) or **Requery** (for an existing one).  
  
#### To pass parameter values to a recordset object at run time  
  
1.  Construct the recordset object.  
  
2.  Prepare a string or strings, such as the **m_strFilter** string, containing the SQL statement, or parts of it. Put "?" placeholders where the parameter information is to go.  
  
3.  Assign a run-time parameter value to each parameter data member of the object.  
  
4.  Call the **Open** member function (or **Requery**, for an existing recordset).  
  
 For example, suppose you want to specify a filter string for your recordset using information obtained at run time. Assume you have constructed a recordset of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> earlier — called <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>s — and now want to requery it for a particular kind of student information.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The recordset contains records for those students whose records meet the conditions specified by the filter, which was constructed from run-time parameters. In this case, the recordset contains records for all senior students.  
  
> [!NOTE]
>  If needed, you can set the value of a parameter data member to Null, using [SetParamNull](../vs140/crecordset--setparamnull.md). You can likewise check whether a parameter data member is Null, using [IsFieldNull](../vs140/crecordset--isfieldnull.md).  
  
## See Also  
 [Recordset (ODBC)](../vs140/recordset--odbc-.md)   
 [Recordset: Adding, Updating, and Deleting Records (ODBC)](../vs140/recordset--adding--updating--and-deleting-records--odbc-.md)   
 [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md)