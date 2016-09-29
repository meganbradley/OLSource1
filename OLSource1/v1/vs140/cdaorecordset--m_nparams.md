---
title: "CDaoRecordset::m_nParams"
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
  - "m_nParams"
  - "CDaoRecordset::m_nParams"
  - "CDaoRecordset.m_nParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parameter data members in recordsets"
  - "m_nParams"
ms.assetid: 191f2767-04aa-4ea4-9aa5-02b458e1cdaa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_nParams
Contains the number of parameter data members in the recordset class — the number of parameters passed with the recordset's query.  
  
## Remarks  
 If your recordset class has any parameter data members, the constructor for the class must initialize `m_nParams` with the correct number. The value of `m_nParams` defaults to 0. If you add parameter data members — which you must do manually — you must also manually add an initialization in the class constructor to reflect the number of parameters (which must be at least as large as the number of '?' placeholders in your **m_strFilter** or `m_strSort` string).  
  
 The framework uses this number when it parameterizes the recordset's query.  
  
> [!NOTE]
>  This number must correspond to the number of "params" registered in `DoFieldExchange` after a call to `SetFieldType` with the parameter **CFieldExchange::param**.  
  
 For related information, see the topic "Parameter Object" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)