---
title: "CDaoTableDef::GetDateLastUpdated"
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
  - "GetDateLastUpdated"
  - "CDaoTableDef.GetDateLastUpdated"
  - "CDaoTableDef::GetDateLastUpdated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, getting date last updated"
  - "tabledefs, getting date info"
  - "GetDateLastUpdated method"
ms.assetid: 800b741c-565d-4ade-afd2-54f02b35cca2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetDateLastUpdated
Call this function to determine the date and time the table underlying the **CDaoTableDef** object was last updated.  
  
## Syntax  
  
```  
  
COleDateTime GetDateLastUpdated( );  
  
```  
  
## Return Value  
 A value that contains the date and time the table underlying the **CDaoTableDef** object was last updated.  
  
## Remarks  
 The date and time settings are derived from the computer on which the base table was created or last updated. In a multiuser environment, users should get these settings directly from the file server to avoid discrepancies; that is, all clients should use a "standard" time source — perhaps from one server.  
  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetDateCreated](../vs140/cdaotabledef--getdatecreated.md)