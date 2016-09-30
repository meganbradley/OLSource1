---
title: "db_column"
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
  - "vc-attr.db_column"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "db_column attribute"
ms.assetid: 58da4afc-f69c-4ae6-af9a-3f9515f56081
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# db_column
Binds a specified column to a variable in the rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ordinal column number (**DBCOLUMNINFO** ordinal) or column name (ANSI or Unicode string) corresponding to a field in the rowset to which to bind data. If you use numbers, you can skip consecutive ordinals (for example: 1, 2, 3, 5). The name may contain spaces if the OLE DB provider you use supports it. For example, you can use either of the following formats:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 *dbtype* (optional)  
 An OLE DB [Type Indicator](https://msdn.microsoft.com/en-us/library/ms711251.aspx) for the column entry.  
  
 *precision* (optional)  
 The precision to be used for the column entry. For details, see the description of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element of the [DBBINDING structure](https://msdn.microsoft.com/en-us/library/ms716845.aspx)  
  
 *scale* (optional)  
 The scale to be used for the column entry. For details, see the description of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element of the [DBBINDING structure](https://msdn.microsoft.com/en-us/library/ms716845.aspx)  
  
 *status* (optional)  
 A member variable used to hold the status of this column. The status indicates whether the column value is a data value or some other value, such as **NULL**. For possible values, see [Status](https://msdn.microsoft.com/en-us/library/ms722617.aspx) in the *OLE DB Programmer's Reference*.  
  
 *length* (optional)  
 A member variable used to hold the size of the column in bytes.  
  
## Remarks  
 **db_column** binds the specified table column to a variable in the rowset. It delimits member data that can participate in OLE DB <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-based binding. This attribute sets up the column map normally defined using the OLE DB consumer macros [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md), [END_COLUMN_MAP](../vs140/end_column_map.md), and [COLUMN_ENTRY](../vs140/column_entry.md). These manipulate the OLE DB [DBBINDING structure](https://msdn.microsoft.com/en-us/library/ms716845.aspx) to bind the specified column. Each member you mark with the **db_column** attribute will occupy one entry in the column map in the form of a column entry. Therefore, you call this attribute where you would put the column map, that is, in the command or table class.  
  
 Use **db_column** in conjunction with either the [db_table](../vs140/db_table.md) or [db_command](../vs140/db_command.md) attributes.  
  
 When the consumer attribute provider applies this attribute to a class, the compiler will rename the class to _*YourClassName*Accessor, where *YourClassName* is the name you gave the class, and the compiler will also create a class called *YourClassName,* which derives from \_*YourClassName*Accessor.  In Class View, you will see both classes.  
  
 For examples of this attribute used in an application, see the samples [AtlAgent](assetId:///52bef5da-c1a0-4223-b4e6-9e464b6db409), and [MultiRead](assetId:///5a2a915a-77dc-492f-94b2-1b809995dd5e).  
  
## Example  
 This sample binds a column in a table to a **long** data member and specifies status and length fields.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This sample binds four columns to a **long**, a character string, a timestamp, and a **DB_NUMERIC** integer, in that order.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, member, method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)