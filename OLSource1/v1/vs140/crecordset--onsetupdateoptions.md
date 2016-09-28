---
title: "CRecordset::OnSetUpdateOptions"
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
  - "CRecordset::OnSetUpdateOptions"
  - "OnSetUpdateOptions"
  - "CRecordset.OnSetUpdateOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetUpdateOptions method"
ms.assetid: d60523f0-20df-418b-a196-c37bb7849c03
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::OnSetUpdateOptions
Called to set options (used on update) for the specified ODBC statement.  
  
## Syntax  
  
```  
  
      virtual void OnSetUpdateOptions(  
   HSTMT hstmt   
);  
```  
  
#### Parameters  
 `hstmt`  
 The **HSTMT** of the ODBC statement whose options are to be set.  
  
## Remarks  
 Call `OnSetUpdateOptions` to set options (used on update) for the specified ODBC statement. The framework calls this member function after it creates an HSTMT to update records in a recordset. (Whereas `OnSetOptions` is used for selection operations, `OnSetUpdateOptions` is used for update operations.) `OnSetUpdateOptions` determines the data source's support for scrollable cursors and for cursor concurrency and sets the recordset's options accordingly.  
  
 Override `OnSetUpdateOptions` to set options of an ODBC statement before that statement is used to access a database.  
  
 For more information about cursors, see the article [ODBC](../vs140/odbc-basics.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OnSetOptions](../vs140/cdatabase--onsetoptions.md)   
 [CRecordset::OnSetOptions](../vs140/crecordset--onsetoptions.md)