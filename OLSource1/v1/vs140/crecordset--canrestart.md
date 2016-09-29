---
title: "CRecordset::CanRestart"
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
  - "CRecordset::CanRestart"
  - "CanRestart"
  - "CRecordset.CanRestart"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanRestart method"
ms.assetid: 1ba85ff9-28bb-4ac5-a226-63119dc8f55d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CanRestart
Determines whether the recordset allows restarting its query (to refresh its records) by calling the **Requery** member function.  
  
## Syntax  
  
```  
  
BOOL CanRestart( ) const;  
```  
  
## Return Value  
 Nonzero if requery is allowed; otherwise 0.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)