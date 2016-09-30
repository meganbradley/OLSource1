---
title: "db_source"
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
  - "vc-attr.db_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "db_source attribute"
ms.assetid: 0ec8bbf7-ade2-4899-bf4c-8608b92779bc
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# db_source
Creates a connection to a data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *db_source*  
 The connection string used to connect to the data source. For the format of the connection string, see [Connection Strings and Data Links](https://msdn.microsoft.com/en-us/library/ms718376.aspx) in the Microsoft Data Access Components (MDAC) SDK.  
  
 *name* (optional)  
 When you use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on a class, *name* is an instance of a data source object that has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute applied to it (see example 1). When you use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> inline in a method implementation, *name* is a variable (local to the method) that can be used to access the data source (see example 2). You pass this *name* to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of **db_command** to associate the data source with a command.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (optional)  
 Identifies the variable that will receive the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of this database command. If the variable does not exist, it will be automatically injected by the attribute.  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> creates a [CDataSource](../vs140/cdatasource-class.md) and a [CSession](../vs140/csession-class.md) object, which together represent a connection with an OLE DB consumer data source.  
  
 When you use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on a class, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object becomes a member of the class.  
  
 When you use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in a method, the injected code will be executed within method scope, and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is created as a local variable.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> adds data source properties to a class or within a method. It is used in conjunction with **db_command** (which takes the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> *name* parameter as its <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter).  
  
 When the consumer attribute provider applies this attribute to a class, the compiler will rename the class to _*YourClassName*Accessor, where *YourClassName* is the name you gave the class, and the compiler will also create a class called *YourClassName,* which derives from \_*YourClassName*Accessor.  In Class View, you will see both classes.  
  
 For an example of this attribute used in an application, see the samples [AtlAgent](assetId:///52bef5da-c1a0-4223-b4e6-9e464b6db409) and [MultiRead](assetId:///5a2a915a-77dc-492f-94b2-1b809995dd5e).  
  
## Example  
 This sample calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on a class to create a connection to the data source <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> using the Northwind database. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a handle for the data source, which can be used internally to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, member, method, local|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)