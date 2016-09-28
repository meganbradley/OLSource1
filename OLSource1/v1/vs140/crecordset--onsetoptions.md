---
title: "CRecordset::OnSetOptions"
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
  - "CRecordset::OnSetOptions"
  - "OnSetOptions"
  - "CRecordset.OnSetOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetOptions method"
ms.assetid: 9b8add17-44e7-41f8-86ce-88b5e0282329
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::OnSetOptions
Called to set options (used on selection) for the specified ODBC statement.  
  
## Syntax  
  
```  
  
      virtual void OnSetOptions(  
   HSTMT hstmt   
);  
```  
  
#### Parameters  
 `hstmt`  
 The **HSTMT** of the ODBC statement whose options are to be set.  
  
## Remarks  
 Call `OnSetOptions` to set options (used on selection) for the specified ODBC statement. The framework calls this member function to set initial options for the recordset. `OnSetOptions` determines the data source's support for scrollable cursors and for cursor concurrency and sets the recordset's options accordingly. (Whereas `OnSetOptions` is used for selection operations, `OnSetUpdateOptions` is used for update operations.)  
  
 Override `OnSetOptions` to set options specific to the driver or the data source. For example, if your data source supports opening for exclusive access, you might override `OnSetOptions` to take advantage of that ability.  
  
 For more information about cursors, see the article [ODBC](../vs140/odbc-basics.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OnSetOptions](../vs140/cdatabase--onsetoptions.md)   
 [CRecordset::OnSetUpdateOptions](../vs140/crecordset--onsetupdateoptions.md)