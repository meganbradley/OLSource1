---
title: "CDaoRecordset::SetParamValueNull"
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
  - "CDaoRecordset.SetParamValueNull"
  - "SetParamValueNull"
  - "CDaoRecordset::SetParamValueNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, setting param values"
  - "SetParamValueNull method"
  - "CDaoRecordset class, setting parameter values to null"
ms.assetid: 74fa9170-8d30-4b1e-8b14-640852a511e3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetParamValueNull
Call this member function to set the parameter to a Null value.  
  
## Syntax  
  
```  
  
      void SetParamValueNull(  
   int nIndex   
);  
void SetParamValueNull(  
   LPCTSTR lpszName   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index of the field in the recordset, for lookup by zero-based index.  
  
 `lpszName`  
 The name of the field in the recordset, for lookup by name.  
  
## Remarks  
 C++ **NULL** is not the same as Null, which, in database terminology, means "having no value."  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)