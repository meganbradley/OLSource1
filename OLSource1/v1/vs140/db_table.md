---
title: "db_table"
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
  - "vc-attr.db_table"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "db_table attribute"
ms.assetid: ff9eb957-4e6d-4175-afcc-fd8ea916cec0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# db_table
Opens an OLE DB table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *db_table*  
 A string specifying the name of a database table (such as "Products").  
  
 *name* (optional)  
 The name of the handle you use to work with the table. You must specify this parameter if you want to return more than one row of results. **db_table** generates a variable with the specified *name* that can be used to traverse the rowset or execute multiple action queries.  
  
 *source_name* (optional)  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variable or instance of a class that has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute applied to it on which the command executes. See [db_source](../vs140/db_source.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (optional)  
 Identifies the variable that will receive the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of this database command. If the variable does not exist, it will be automatically injected by the attribute.  
  
## Remarks  
 **db_table** creates a [CTable](../vs140/ctable-class.md) object, which is used by an OLE DB consumer to open a table. You can use this attribute only at the class level; you cannot use it inline. Use **db_column** to bind table columns to variables; use **db_param** to delimit (set the parameter type and so on) of parameters.  
  
 When the consumer attribute provider applies this attribute to a class, the compiler will rename the class to _*YourClassName*Accessor, where *YourClassName* is the name you gave the class, and the compiler will also create a class called *YourClassName,* which derives from \_*YourClassName*Accessor.  In Class View, you will see both classes.  
  
## Example  
 The following example opens the Products table for use by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For an example of this attribute used in an application, see the samples [AtlAgent](assetId:///52bef5da-c1a0-4223-b4e6-9e464b6db409) and [MultiRead](assetId:///5a2a915a-77dc-492f-94b2-1b809995dd5e).  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)