---
title: "CDaoTableDef::Create"
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
  - "CDaoTableDef::Create"
  - "CDaoTableDef.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabledefs, creating"
  - "CDaoTableDef class, creating"
  - "Create method [C++]"
ms.assetid: f688c8a5-fb65-4a08-8ad4-0516987dec73
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::Create
Call this member function to create a new saved table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the table.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value corresponding to characteristics of the table represented by the tabledef object. You can use the bitwise-OR to combine any of the following constants:  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
  
 *lpszSrcTable*  
 A pointer to a string containing the source table name. By default this value is initialized as **NULL**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string containing the default connection string. By default this value is initialized as **NULL**.  
  
## Remarks  
 Once you have named the tabledef, you can then call [Append](../vs140/cdaotabledef--append.md) to save the tabledef in the database's TableDefs collection. After calling **Append**, the tabledef is in an open state, and you can use it to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object.  
  
 For related information, see the topic "CreateTableDef Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::Open](../vs140/cdaotabledef--open.md)   
 [CDaoTableDef::Close](../vs140/cdaotabledef--close.md)   
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)