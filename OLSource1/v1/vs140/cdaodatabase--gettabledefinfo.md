---
title: "CDaoDatabase::GetTableDefInfo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoDatabase.GetTableDefInfo"
  - "GetTableDefInfo"
  - "CDaoDatabase::GetTableDefInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tables [C++], getting information about"
  - "databases [C++], getting information about"
  - "AFX_DAO_ALL_INFO"
  - "tabledefs [C++], getting information about"
  - "databases [C++], counting records in tables"
  - "tables [C++]"
  - "AFX_DAO_SECONDARY_INFO"
  - "AFX_DAO_PRIMARY_INFO"
  - "DAO [C++], getting information about tables"
  - "tables [C++], count of records in"
  - "GetTableDefInfo method"
ms.assetid: 853a4262-bad6-4cb1-a854-e46f3f44243c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetTableDefInfo
Call this member function to obtain various kinds of information about a table defined in the database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the tabledef object in the database's TableDefs collection, for lookup by index.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CDaoTableDefInfo](../vs140/cdaotabledefinfo-structure.md) object that returns the information requested.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Options that specify which information about the table to retrieve. The available options are listed here along with what they cause the function to return about the relation:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (Default) Name, Updatable, Attributes  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Primary information plus: Date Created, Date Last Updated, Source Table Name, Connect  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Primary and secondary information plus: Validation Rule, Validation Text, Record Count  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The name of the tabledef object, for lookup by name.  
  
## Remarks  
 Two versions of the function are supplied so you can select a table either by index in the database's TableDefs collection or by the name of the table.  
  
 For a description of the information returned in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see the [CDaoTableDefInfo](../vs140/cdaotabledefinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If you request information at one level, you get information for any prior levels as well.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> option provides information that can be slow to obtain. In this case, counting the records in the table could be very time consuming if there are many records.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase::GetTableDefCount](../vs140/cdaodatabase--gettabledefcount.md)