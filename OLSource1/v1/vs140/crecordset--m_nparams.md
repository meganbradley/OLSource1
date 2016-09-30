---
title: "CRecordset::m_nParams"
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
  - "CRecordset::m_nParams"
  - "CRecordset.m_nParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nParams"
ms.assetid: b49ec433-08de-47b5-a9c7-32c50a33b5a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::m_nParams
Contains the number of parameter data members in the recordset class; that is, the number of parameters passed with the recordset's query.  
  
## Remarks  
 If your recordset class has any parameter data members, the constructor for the class must initialize `m_nParams` with the correct number. The value of `m_nParams` defaults to 0. If you add parameter data members (which you must do manually) you must also manually add an initialization in the class constructor to reflect the number of parameters (which must be at least as large as the number of '?' placeholders in your **m_strFilter** or `m_strSort` string).  
  
 The framework uses this number when it parameterizes the recordset's query.  
  
> [!CAUTION]
>  This number must correspond to the number of "params" registered in `DoFieldExchange` or `DoBulkFieldExchange` after a call to [SetFieldType](../vs140/cfieldexchange--setfieldtype.md) with a parameter value of **CFieldExchange::inputParam**, **CFieldExchange::param**, **CFieldExchange::outputParam**, or **CFieldExchange::inoutParam**.  
  
## Example  
 See the articles [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md) and [Record Field Exchange: Using RFX](../vs140/record-field-exchange--using-rfx.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)   
 [CRecordset::m_nFields](../vs140/crecordset--m_nfields.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)