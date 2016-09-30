---
title: "CDaoTableDef::SetSourceTableName"
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
  - "SetSourceTableName"
  - "CDaoTableDef::SetSourceTableName"
  - "CDaoTableDef.SetSourceTableName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, setting source table names"
  - "tabledefs, setting table names"
  - "SetSourceTableName method"
ms.assetid: 5c75c3e7-f195-4043-ada0-cc9442d14799
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetSourceTableName
Call this member function to specify the name of an attached table or the name of the base table on which the `CDaoTableDef` object is based, as it exists in the original source of the data.  
  
## Syntax  
  
```  
  
      void SetSourceTableName(   
   LPCTSTR lpszSrcTableName    
);  
```  
  
#### Parameters  
 *lpszSrcTableName*  
 A pointer to a string expression that specifies a table name in the external database. For a base table, the setting is an empty string ("").  
  
## Remarks  
 You must then call [RefreshLink](../vs140/cdaotabledef--refreshlink.md). This property setting is empty for a base table and read/write for an attached table or an object not appended to a collection.  
  
 For related information, see the topic "SourceTableName Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::RefreshLink](../vs140/cdaotabledef--refreshlink.md)   
 [CDaoTableDef::GetSourceTableName](../vs140/cdaotabledef--getsourcetablename.md)