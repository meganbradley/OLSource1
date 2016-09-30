---
title: "CDaoTableDef::GetSourceTableName"
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
  - "CDaoTableDef::GetSourceTableName"
  - "CDaoTableDef.GetSourceTableName"
  - "GetSourceTableName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSourceTableName method"
  - "tabledefs, getting table names"
  - "CDaoTableDef class, getting source table names"
ms.assetid: 0b4d4bce-e9ce-41ca-ad3f-fc95813d3666
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetSourceTableName
Call this member function to retrieve the name of an attached table in a source database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that specifies the source name of an attached table, or an empty string if a native data table.  
  
## Remarks  
 An attached table is a table in another database linked to a Microsoft Jet database. Data for attached tables remains in the external database, where it can be manipulated by other applications.  
  
 For related information, see the topic "SourceTableName Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetRecordCount](../vs140/cdaotabledef--getrecordcount.md)   
 [CDaoTableDef::SetSourceTableName](../vs140/cdaotabledef--setsourcetablename.md)