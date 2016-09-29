---
title: "CRecordset::GetSQL"
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
  - "CRecordset.GetSQL"
  - "GetSQL"
  - "CRecordset::GetSQL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSQL method"
ms.assetid: f6d23a71-872f-474c-8d06-1c1f43f4febb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetSQL
Call this member function to get the SQL statement that was used to select the recordset's records when it was opened.  
  
## Syntax  
  
```  
  
const CString& GetSQL( ) const;  
```  
  
## Return Value  
 A **const** reference to a `CString` that contains the SQL statement.  
  
## Remarks  
 This will generally be a SQL **SELECT** statement. The string returned by `GetSQL` is read-only.  
  
 The string returned by `GetSQL` is typically different from any string you may have passed to the recordset in the `lpszSQL` parameter to the **Open** member function. This is because the recordset constructs a full SQL statement based on what you passed to **Open**, what you specified with ClassWizard, what you may have specified in the **m_strFilter** and `m_strSort` data members, and any parameters you may have specified. For details about how the recordset constructs this SQL statement, see the article [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md).  
  
> [!NOTE]
>  Call this member function only after calling [Open](../vs140/crecordset--open.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::GetDefaultSQL](../vs140/crecordset--getdefaultsql.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)   
 [CRecordset::m_strFilter](../vs140/crecordset--m_strfilter.md)   
 [CRecordset::m_strSort](../vs140/crecordset--m_strsort.md)