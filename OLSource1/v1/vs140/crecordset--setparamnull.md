---
title: "CRecordset::SetParamNull"
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
  - "SetParamNull"
  - "CRecordset::SetParamNull"
  - "CRecordset.SetParamNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParamNull method"
ms.assetid: d24a7cec-3fdf-4a7d-8cfb-571fc101e2ae
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::SetParamNull
Flags a parameter as Null (specifically having no value) or as non-Null.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE** (the default value), the parameter is flagged as Null. Otherwise, the parameter is flagged as non-Null.  
  
## Remarks  
 Unlike [SetFieldNull](../vs140/crecordset--setfieldnull.md), you can call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> before you have opened the recordset.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is typically used with predefined queries (stored procedures).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::FlushResultSet](../vs140/crecordset--flushresultset.md)