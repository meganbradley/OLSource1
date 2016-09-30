---
title: "CDaoRecordset::GetDefaultDBName"
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
  - "CDaoRecordset::GetDefaultDBName"
  - "GetDefaultDBName"
  - "CDaoRecordset.GetDefaultDBName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting default database names"
  - "CDaoRecordset class, getting default database name"
  - "GetDefaultDBName method"
ms.assetid: 366a1b18-a0c6-459a-9944-d060c86aa4c8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetDefaultDBName
Call this member function to determine the name of the database for this recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that contains the path and name of the database from which this recordset is derived.  
  
## Remarks  
 If a recordset is created without a pointer to a [CDaoDatabase](../vs140/cdaodatabase-class.md), then this path is used by the recordset to open the default database. By default, this function returns an empty string. When ClassWizard derives a new recordset from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, it will create this function for you.  
  
 The following example illustrates the use of the double backslash (\\\\) in the string, as is required for the string to be interpreted correctly.  
  
 [!code[NVC_MFCDatabase#4](../vs140/codesnippet/CPP/cdaorecordset--getdefaultdbname_1.cpp)]  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetDefaultSQL](../vs140/cdaorecordset--getdefaultsql.md)   
 [CDaoRecordset::GetName](../vs140/cdaorecordset--getname.md)   
 [CDaoRecordset::GetSQL](../vs140/cdaorecordset--getsql.md)   
 [CDaoRecordset::GetType](../vs140/cdaorecordset--gettype.md)