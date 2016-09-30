---
title: "TN045: MFC-Database Support for Long Varchar-Varbinary"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "TN045: MFC/Database Support for Long Varchar/Varbinary"
f1_keywords: 
  - "vc.mfc.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN045"
  - "Varbinary data type"
  - "Varchar data type"
ms.assetid: cf572c35-5275-45b5-83df-5f0e36114f40
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN045: MFC-Database Support for Long Varchar-Varbinary
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note describes how to retrieve and send the ODBC **SQL_LONGVARCHAR** and **SQL_LONGVARBINARY** data types using the MFC database classes.  
  
## Overview of Long Varchar/Varbinary Support  
 The ODBC **SQL_LONG_VARCHAR** and **SQL_LONGBINARY** data types (referred to here as long data columns) can hold huge amounts of data. There are 3 ways you can handle this data:  
  
-   Bind it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   Bind it to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   Do not bind it at all and retrieve and send the long data value manually, independent of the database classes.  
  
 Each of the three methods has advantages and disadvantages.  
  
 Long data columns are not supported for parameters to a query. They are only supported for outputColumns.  
  
## Binding a Long Data Column to a CString/CByteArray  
 Advantages:  
  
 This approach is simple to understand, and you work with familiar classes. The framework provides <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> support for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You have lots of general string or collection functionality with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> classes, and you can control the amount of memory allocated locally to hold the data value. The framework maintains an old copy of field data during **Edit** or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function calls, and the framework can automatically detect changes to the data for you.  
  
> [!NOTE]
>  Since <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is designed for working on character data, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for working on binary data, it is recommended that you put the character data (**SQL_LONGVARCHAR**) into <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and the binary data (**SQL_LONGVARBINARY**) into <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The RFX functions for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> have an additional argument which lets you override the default size of allocated memory to hold the retrieved value for the data column. Note the nMaxLength argument in the following function declarations:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you retrieve a long data column into a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the maximum returned amount of data is, by default, 255 bytes. Anything beyond this is ignored. In this case, the framework will throw the exception **AFX_SQL_ERROR_DATA_TRUNCATED**. Fortunately, you can explicitly increase nMaxLength to greater values, up to **MAXINT**.  
  
> [!NOTE]
>  The value of nMaxLength is used by MFC to set the local buffer of the **SQLBindColumn** function. This is the local buffer for storage of the data and does not actually affect the amount of data returned by the ODBC driver. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> only make one call using **SQLFetch** to retrieve the data from the back-end database. Each ODBC driver has a different limitation on the amount of data they can return in a single fetch. This limit may be much smaller than the value set in nMaxLength, in which case the exception **AFX_SQL_ERROR_DATA_TRUNCATED** will be thrown. Under these circumstances, switch to using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> so that all the data can be retrieved.  
  
 ClassWizard will bind a **SQL_LONGVARCHAR** to a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or a **SQL_LONGVARBINARY** to a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for you. If you want to allocate more than 255 bytes into which you retrieve your long data column, you can then supply an explicit value for nMaxLength.  
  
 When a long data column is bound to a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, updating the field works just the same as when it is bound to a SQL_**VARCHAR** or SQL_**VARBINARY**. During **Edit**, the data value is cached away and later compared when **Update** is called to detect changes to the data value and set the Dirty and Null values for the column appropriately.  
  
## Binding a Long Data Column to a CLongBinary  
 If your long data column may contain more **MAXINT** bytes of data, you should probably consider retrieving it into a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 Advantages:  
  
 This retrieves an entire long data column, up to available memory.  
  
 Disadvantages:  
  
 The data is held in memory. This approach is also prohibitively expensive for very large amounts of data. You must call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> for the bound data member to ensure the field is included in an **Update** operation.  
  
 If you retrieve long data columns into a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the database classes will check the total size of the long data column, then allocate an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> memory segment large enough to hold it the entire data value. The database classes then retrieve the entire data value into the allocated <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 If the data source cannot return the expected size of the long data column, the framework will throw the exception **AFX_SQL_ERROR_SQL_NO_TOTAL**. If the attempt to allocate the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> fails, a standard memory exception is thrown.  
  
 ClassWizard will bind an **SQL_LONGVARCHAR** or **SQL_LONGVARBINARY** to a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> for you. Select <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> as the Variable Type in the Add Member Variable dialog. ClassWizard will then add an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> call to your <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> call and increment the total number of bound fields.  
  
 To update long data column values, first make sure the allocated <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is large enough to hold your new data by calling **::GlobalSize** on the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. If it is too small, release the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and allocate one the appropriate size. Then set <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to reflect the new size.  
  
 Otherwise, if <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is larger than the size of the data you're replacing, you can either free and reallocate the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, or leave it allocated. Make sure to indicate the number of bytes actually used in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## How Updating a CLongBinary Works  
 It is not necessary to understand how updating a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> works, but it may be useful as an example on how to send long data values to a data source, if you choose this third method, described below.  
  
> [!NOTE]
>  In order for a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> field to be included in an update, you must explicitly call <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> for the field. If you make any change to a field, including setting it Null, you must call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. You must also call <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, with the second parameter being **FALSE**, to mark the field as having a value.  
  
 When updating a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> field, the database classes use ODBC's **DATA_AT_EXEC** mechanism (see ODBC documentation on **SQLSetPos**'s rgbValue argument). When the framework prepares the insert or update statement, instead of pointing to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> containing the data, the *address* of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is set as the *value* of the column instead, and the length indicator set to **SQL_DATA_AT_EXEC**. Later, when the update statement is sent to the data source, **SQLExecDirect** will return **SQL_NEED_DATA**. This alerts the framework that the value of the param for this column is actually the address of a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. The framework calls **SQLGetData** once with a small buffer, expecting the driver to return the actual length of the data. If the driver returns the actual length of the binary large object (the BLOB), MFC reallocates as much space as necessary to fetch the BLOB. If the data source returns **SQL_NO_TOTAL**, indicating that it can't determine the size of the BLOB, MFC will create smaller blocks. The default initial size is 64K, and subsequent blocks will be double the size; for example, the second will be 128K, the third is 256K, and so on. The initial size is configurable.  
  
## Not Binding: Retrieving/Sending Data Directly from ODBC with SQLGetData  
 With this method you completely bypass the database classes, and deal with the long data column yourself.  
  
 Advantages:  
  
 You can cache data to disk if necessary, or decide dynamically how much data to retrieve.  
  
 Disadvantages:  
  
 You don't get the framework's **Edit** or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> support, and you must write code yourself to perform basic functionality (**Delete** does work though, since it is not a column level operation).  
  
 In this case, the long data column must be in the select list of the recordset, but should not be bound to by the framework. One way to do this is to supply your own SQL statement via <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or as the lpszSQL argument to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>'s **Open** function, and not bind the extra column with an RFX_ function call. ODBC requires that unbound fields appear to the right of bound fields, so add your unbound column or columns to the end of the select list.  
  
> [!NOTE]
>  Because your long data column is not bound by the framework, changes to it will not be handled with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> calls. You must create and send the required SQL **INSERT** and **UPDATE** statements yourself.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)