---
title: "CDaoTableDef::GetDateCreated"
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
  - "CDaoTableDef.GetDateCreated"
  - "CDaoTableDef::GetDateCreated"
  - "GetDateCreated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDateCreated method"
  - "CDaoTableDef class, getting date created"
  - "tabledefs, getting date info"
ms.assetid: b55a0805-9adc-4c5e-b68f-cfa825a422f7
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetDateCreated
Call this function to determine the date and time the table underlying the `CDaoTableDef` object was created.  
  
## Syntax  
  
```  
  
COleDateTime GetDateCreated( );  
  
```  
  
## Return Value  
 A value containing the date and time of the creation of the table underlying the `CDaoTableDef` object.  
  
## Remarks  
 The date and time settings are derived from the computer on which the base table was created or last updated. In a multiuser environment, users should get these settings directly from the file server to avoid discrepancies; that is, all clients should use a "standard" time source — perhaps from one server.  
  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetDateLastUpdated](../vs140/cdaotabledef--getdatelastupdated.md)