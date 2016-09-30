---
title: "CDaoTableDef::CanUpdate"
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
  - "CDaoTableDef.CanUpdate"
  - "CDaoTableDef::CanUpdate"
  - "CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), update support"
  - "CDaoTableDef class, updating tables"
  - "tabledefs, updating"
  - "CanUpdate method"
ms.assetid: 4937f537-2973-4503-a7b9-e57b4fbeebc9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::CanUpdate
Call this member function to determine whether the definition of the table underlying a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object can be changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the table structure (schema) can be modified (add or delete fields and indexes), otherwise 0.  
  
## Remarks  
 By default, a newly created table underlying a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object can be updated, and an attached table underlying a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object cannot be updated. A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object may be updatable, even if the resulting recordset is not updatable.  
  
 For related information, see the topic "Updatable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetDateLastUpdated](../vs140/cdaotabledef--getdatelastupdated.md)