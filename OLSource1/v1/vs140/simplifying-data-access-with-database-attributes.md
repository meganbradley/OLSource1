---
title: "Simplifying Data Access with Database Attributes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-attr.db_param"
  - "vc-attr.db_column"
  - "vc-attr.db_accessor"
  - "vc-attr.db_command"
  - "vc-attr.db_table"
  - "vc-attr.db_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributes [C++], database"
  - "attributes [C++], data access"
  - "databases [C++], attributes"
  - "data [C++], simplifying access"
  - "data access [C++], database attributes"
  - "database attributes [C++]"
  - "OLE DB consumers [C++], database attributes"
  - "attributes [C++], OLE DB consumer"
ms.assetid: 560d2456-e307-4cb7-ba7b-4d0ed674697f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Simplifying Data Access with Database Attributes
This topic demonstrates the use of database attributes to simplify database operations.  
  
 The basic way to access information from a database is to create a command (or table) class and a user record class for a particular table in the database. The database attributes simplify some of the template declarations that you previously had to do.  
  
 To demonstrate the use of database attributes, the following sections show two equivalent table and user record class declarations: the first uses attributes and the second uses OLE DB Templates. Such declaration code is typically placed in a header file named for the table or command object, for example, Authors.h.  
  
 By comparing the two files, you can see how much simpler it is to use attributes. Among the differences are:  
  
-   Using attributes, you only have to declare one class: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, while with templates you have to declare two: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> call in the attributed version is equivalent to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> call in the template declaration.  
  
-   The **db_table** call in the attributed version is equivalent to the following template declaration:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   The **db_column** calls in the attributed version are equivalent to the column map (see <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) in the template declaration.  
  
 The attributes inject a user record class declaration for you. The user record class is equivalent to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the template declaration. If your table class is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the injected user record class is named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and you can only view its declaration in injected code. For more information, see "Attribute-Injected User Record Classes" in [User Records](../vs140/user-records.md).  
  
 Note that in both the attributed and the templated code, you must set rowset properties using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For information about the attributes discussed in this topic, see [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md).  
  
## Table and Accessor Declaration Using Attributes  
 The following code calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and **db_table** on the table class. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specifies the data source and connection to be used. **db_table** injects the appropriate template code to declare a table class. **db_column** specify the column map and inject the accessor declaration. You can use OLE DB consumer attributes in any project that supports ATL.  
  
 Here is the table and accessor declaration using attributes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Table and Accessor Declaration Using Templates  
 Here is the table and accessor declaration using templates.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [OLE DB Consumer Attributes](../vs140/ole-db-consumer-attributes.md)   
 [Attributes Walkthroughs](assetId:///73df1d5d-261a-4521-98fb-06dcbf5ec0d0)