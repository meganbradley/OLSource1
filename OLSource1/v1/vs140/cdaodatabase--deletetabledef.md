---
title: "CDaoDatabase::DeleteTableDef"
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
  - "DeleteTableDef"
  - "CDaoDatabase::DeleteTableDef"
  - "CDaoDatabase.DeleteTableDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "databases [C++], deleting tabledefs"
  - "tabledefs [C++], deleting"
  - "DAO [C++], deleting items"
  - "DeleteTableDef method"
  - "tables [C++]"
  - "tables [C++], deleting"
ms.assetid: 8c31c889-923a-4585-b7ff-ecc5edf4e7ce
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::DeleteTableDef
Call this member function to delete the specified table and all of its data from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object's TableDefs collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the tabledef to delete.  
  
## Remarks  
 Afterwards, that table is no longer defined in the database.  
  
> [!NOTE]
>  Be very careful not to delete system tables.  
  
 For information about creating tabledef objects, see class [CDaoTableDef](../vs140/cdaotabledef-class.md). A tabledef object becomes associated with a particular <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object when you construct the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, passing it a pointer to the database object.  
  
 For related information, see the topic "Delete Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::Create](../vs140/cdaotabledef--create.md)   
 [CDaoQueryDef::Create](../vs140/cdaoquerydef--create.md)   
 [CDaoDatabase::CreateRelation](../vs140/cdaodatabase--createrelation.md)