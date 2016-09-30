---
title: "db_command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "vc-attr.db_command"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "db_command attribute"
ms.assetid: 714c3e15-85d7-408b-9a7c-88505c3e5d24
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# db_command
Creates an OLE DB command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A command string containing the text of an OLE DB command. A simple example is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The *command* syntax is as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A *binding parameter block* is defined as follows:  
  
 **([** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **]** *szVar1* [*, szVar2* [, *nVar3* [, ...]]] **)**  
  
 where:  
  
 **(** marks the start of the data binding block.  
  
 **[** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **]** is one of the following case-insensitive strings:  
  
-   **[db_column]** binds each of the member variables to a column in a rowset.  
  
-   **[bindto]** (same as **[db_column]**).  
  
-   **[in]** binds member variables as input parameters.  
  
-   **[out]** binds member variables as output parameters.  
  
-   **[in,out]** binds member variables as input/output parameters.  
  
 *SzVarX* resolves to a member variable within the current scope.  
  
 **)** marks the end of the data binding block.  
  
 If the command string contains one or more specifiers such as [in], [out], or [in/out], **db_command** builds a parameter map.  
  
 If the command string contains one or more parameters such as [db_column] or [bindto], **db_command** generates a rowset and an accessor map to service these bound variables. See [db_accessor](../vs140/db_accessor.md) for more information.  
  
> [!NOTE]
>  [<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>] syntax and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter are not valid when using **db_command** at the class level.  
  
 Here are some examples of binding parameter blocks. The following example binds the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data members to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> columns, respectively, of the authors table in the pubs database:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 ]  
  
 *name* (optional)  
 The name of the handle you use to work with the rowset. If you specify *name*, **db_command** generates a class with the specified *name*, which can be used to traverse the rowset or to execute multiple action queries. If you do not specify *name*, it will not be possible to return more than one row of results to the user.  
  
 *source_name* (optional)  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variable or instance of a class that has the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute applied to it on which the command executes. See [db_source](../vs140/db_source.md).  
  
 **db_command** checks to ensure that the variable used for *source_name* is valid, so the specified variable should be in function or global scope.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (optional)  
 Identifies the variable that will receive the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> of this database command. If the variable does not exist, it will be automatically injected by the attribute.  
  
 *bindings* (optional)  
 Allows you to separate the binding parameters from the OLE DB command.  
  
 If you specify a value for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, **db_command** will parse the associated value and will not parse the [<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>] parameter. This usage allows you to use OLE DB provider syntax. To disable parsing, without binding parameters, specify **Bindings=""**.  
  
 If you do not specify a value for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, **db_command** will parse the binding parameter block, looking for '**(**', followed by **[**<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>**]** in brackets, followed by one or more previously declared C++ member variables, followed by '**)**'. All text between the parentheses will be stripped from the resulting command, and these parameters will be used to construct column and parameter bindings for this command.  
  
 *bulk_fetch*(optional)  
 An integer value that specifies the number of rows to fetch.  
  
 The default value is 1, which specifies single row fetching (the rowset will be of type [CRowset](../vs140/crowset-class.md)).  
  
 A value greater than 1 specifies bulk row fetching. Bulk row fetching refers to the ability of bulk rowsets to fetch multiple row handles (the rowset will be of type [CBulkRowset](../vs140/cbulkrowset-class.md) and will call <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> with the specified number of rows).  
  
 If *bulk_fetch* is less than one, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> will return zero.  
  
## Remarks  
 **db_command** creates a [CCommand](../vs140/ccommand-class.md) object, which is used by an OLE DB consumer to execute a command.  
  
 You can use **db_command** with either class or function scope; the main difference is the scope of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object. With function scope, data such as bindings terminate at function end. Both class and function scope usages involve the OLE DB Consumer Template class **CCommand<>**, but the template arguments differ for the function and class cases. In the function case, bindings will be made to an **Accessor** that comprises local variables, while the class usage will infer a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>-derived class as the argument. When used as a class attribute, **db_command** works in conjunction with **db_column**.  
  
 **db_command** can be used to execute commands that do not return a result set.  
  
 When the consumer attribute provider applies this attribute to a class, the compiler will rename the class to _*YourClassName*Accessor, where *YourClassName* is the name you gave the class, and the compiler will also create a class called *YourClassName,* which derives from \_*YourClassName*Accessor.  In Class View, you will see both classes.  
  
## Example  
 This sample defines a command that selects the first and last names from a table where the state column matches 'CA'. **db_command** creates and reads a rowset on which you can call wizard-generated functions such as [OpenAll and CloseAll](../vs140/consumer-wizard-generated-methods.md), as well as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> member functions such as [MoveNext](../vs140/crowset--movenext.md).  
  
 Note that this code requires you to provide your own connection string that connects to the pubs database. For information on how to do this in the development environment, see [How to: Connect to a Database from Server Explorer](assetId:///7c1c3067-0d77-471b-872b-639f9f50db74) and [How to: Add New Data Connections in Server Explorer/Database Explorer](assetId:///fb2f513b-ddad-4142-911e-856bba0054c8).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 This sample uses <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> on a data source class <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> on command classes <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, member, method, local|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md)   
 [Stand-Alone Attributes](../vs140/stand-alone-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)