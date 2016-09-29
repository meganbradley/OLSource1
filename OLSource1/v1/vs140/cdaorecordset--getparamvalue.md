---
title: "CDaoRecordset::GetParamValue"
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
  - "CDaoRecordset.GetParamValue"
  - "CDaoRecordset::GetParamValue"
  - "GetParamValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParamValue method"
  - "CDaoRecordset class, getting parameter values"
  - "recordsets, getting param values"
ms.assetid: 1f51dd2e-c06a-4a56-8998-2594837f4003
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetParamValue
Call this member function to retrieve the current value of the specified parameter stored in the underlying DAOParameter object.  
  
## Syntax  
  
```  
  
      virtual COleVariant GetParamValue(  
   int nIndex   
);  
virtual COleVariant GetParamValue(  
   LPCTSTR lpszName   
);  
```  
  
#### Parameters  
 `nIndex`  
 The numerical position of the parameter in the underlying DAOParameter object.  
  
 `lpszName`  
 The name of the parameter whose value you want.  
  
## Return Value  
 An object of class [COleVariant](../vs140/colevariant-class.md) that contains the parameter's value.  
  
## Remarks  
 You can access the parameter either by name or by its numerical position in the collection.  
  
 For related information, see the topic "Parameter Object" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetParamValue](../vs140/cdaorecordset--setparamvalue.md)   
 [CDaoRecordset::m_nParams](../vs140/cdaorecordset--m_nparams.md)