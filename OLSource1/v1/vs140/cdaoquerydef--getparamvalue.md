---
title: "CDaoQueryDef::GetParamValue"
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
  - "CDaoQueryDef.GetParamValue"
  - "GetParamValue"
  - "CDaoQueryDef::GetParamValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, getting information"
  - "GetParamValue method"
  - "QueryDef objects, getting values of parameters"
  - "DAO (Data Access Objects), getting parameters"
  - "parameter values, getting querydef"
ms.assetid: 3e60e1c0-c1bb-4333-b3d0-5be092734ac1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetParamValue
Call this member function to retrieve the current value of the specified parameter stored in the querydef's Parameters collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the parameter whose value you want, for lookup by name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the parameter in the querydef's Parameters collection, for lookup by index. You can obtain this value with calls to [GetParameterCount](../vs140/cdaoquerydef--getparametercount.md) and [GetParameterInfo](../vs140/cdaoquerydef--getparameterinfo.md).  
  
## Return Value  
 An object of class [COleVariant](../vs140/colevariant-class.md) that contains the parameter's value.  
  
## Remarks  
 You can access the parameter either by name or by its ordinal position in the collection.  
  
 For related information, see the topic "PARAMETERS Declaration (SQL)" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::SetParamValue](../vs140/cdaoquerydef--setparamvalue.md)