---
title: "CDaoQueryDef::SetParamValue"
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
  - "SetParamValue"
  - "CDaoQueryDef::SetParamValue"
  - "CDaoQueryDef.SetParamValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parameter values, setting querydef"
  - "SetParamValue method"
  - "parameter values"
  - "QueryDef objects, setting parameter values"
  - "CDaoQueryDef class, setting parameter values"
ms.assetid: 2031a51d-aa37-4b96-aef8-9d0a2435163c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::SetParamValue
Call this member function to set the value of a parameter in the querydef at run time.  
  
## Syntax  
  
```  
  
      virtual void SetParamValue(   
   LPCTSTR lpszName,   
   const COleVariant& varValue    
);  
virtual void SetParamValue(   
   int nIndex,   
   const COleVariant& varValue    
);  
```  
  
#### Parameters  
 `lpszName`  
 The name of the parameter whose value you want to set.  
  
 `varValue`  
 The value to set; see Remarks.  
  
 `nIndex`  
 The ordinal position of the parameter in the querydef's Parameters collection. You can obtain this value with calls to [GetParameterCount](../vs140/cdaoquerydef--getparametercount.md) and [GetParameterInfo](../vs140/cdaoquerydef--getparameterinfo.md).  
  
## Remarks  
 The parameter must already have been established as part of the querydef's SQL string. You can access the parameter either by name or by its ordinal position in the collection.  
  
 Specify the value to set as a `COleVariant` object. For information about setting the desired value and type in your `COleVariant` object, see class [COleVariant](../vs140/colevariant-class.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetParamValue](../vs140/cdaoquerydef--getparamvalue.md)