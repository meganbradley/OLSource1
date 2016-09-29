---
title: "CDaoRecordset::GetSQL"
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
  - "CDaoRecordset.GetSQL"
  - "GetSQL"
  - "CDaoRecordset::GetSQL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSQL method"
  - "recordsets, getting SQL"
  - "CDaoRecordset class, getting SQL"
ms.assetid: b8b32897-99ca-474e-b779-e1c11f92d437
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetSQL
Call this member function to get the SQL statement that was used to select the recordset's records when it was opened.  
  
## Syntax  
  
```  
  
CString GetSQL( ) const;  
  
```  
  
## Return Value  
 A `CString` that contains the SQL statement.  
  
## Remarks  
 This will generally be a SQL **SELECT** statement.  
  
 The string returned by `GetSQL` is typically different from any string you may have passed to the recordset in the `lpszSQL` parameter to the [Open](../vs140/cdaorecordset--open.md) member function. This is because the recordset constructs a full SQL statement based on what you passed to **Open**, what you specified with ClassWizard, and what you may have specified in the [m_strFilter](../vs140/cdaorecordset--m_strfilter.md) and [m_strSort](../vs140/cdaorecordset--m_strsort.md) data members.  
  
> [!NOTE]
>  Call this member function only after calling **Open**.  
  
 For related information, see the topic "SQL Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetDefaultSQL](../vs140/cdaorecordset--getdefaultsql.md)   
 [CDaoRecordset::GetDefaultDBName](../vs140/cdaorecordset--getdefaultdbname.md)   
 [CDaoRecordset::GetName](../vs140/cdaorecordset--getname.md)   
 [CDaoRecordset::GetType](../vs140/cdaorecordset--gettype.md)