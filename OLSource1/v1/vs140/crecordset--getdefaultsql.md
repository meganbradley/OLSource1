---
title: "CRecordset::GetDefaultSQL"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRecordset::GetDefaultSQL
  - CRecordset.GetDefaultSQL
  - GetDefaultSQL
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDefaultSQL method
ms.assetid: b451db15-3306-4ec2-b0ad-5da7709c29c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::GetDefaultSQL
Called to get the default SQL string to execute.  
  
## Syntax  
  
```  
  
virtual CString GetDefaultSQL( );  
```  
  
## Return Value  
 A `CString` that contains the default SQL statement.  
  
## Remarks  
 The framework calls this member function to get the default SQL statement on which the recordset is based. This might be a table name or a SQL **SELECT** statement.  
  
 You indirectly define the default SQL statement by declaring your recordset class with ClassWizard, and ClassWizard performs this task for you.  
  
 If you need the SQL statement string for your own use, call `GetSQL`, which returns the SQL statement used to select the recordset's records when it was opened. You can edit the default SQL string in your class's override of `GetDefaultSQL`. For example, you could specify a call to a predefined query using a **CALL** statement. (Note, however, that if you edit `GetDefaultSQL`, you also need to modify `m_nFields` to match the number of columns in the data source.)  
  
 For more information, see the article [Recordset: Declaring a Class for a Table (ODBC)](../vs140/recordset--declaring-a-class-for-a-table--odbc-.md).  
  
> [!CAUTION]
>  The table name will be empty if the framework could not identify a table name, if multiple table names were supplied, or if a **CALL** statement could not be interpreted. Note that when using a **CALL** statement, you must not insert whitespace between the curly brace and the **CALL** keyword, nor should you insert whitespace before the curly brace or before the **SELECT** keyword in a **SELECT** statement.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::GetSQL](../vs140/crecordset--getsql.md)