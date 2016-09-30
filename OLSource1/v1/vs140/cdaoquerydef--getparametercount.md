---
title: "CDaoQueryDef::GetParameterCount"
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
  - "GetParameterCount"
  - "CDaoQueryDef.GetParameterCount"
  - "CDaoQueryDef::GetParameterCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, counting parameters"
  - "DAO (Data Access Objects), counting items"
  - "QueryDef objects, counting parameters"
  - "GetParameterCount method"
  - "counting querydef parameters"
  - "parameter count in querydef"
ms.assetid: b75f41e7-55dc-4b13-878e-f528c2df4423
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetParameterCount
Call this member function to retrieve the number of parameters in the saved query.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of parameters defined in the query.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is useful for looping through all parameters in the querydef. For that purpose, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in conjunction with [GetParameterInfo](../vs140/cdaoquerydef--getparameterinfo.md).  
  
 For related information, see the topics "Parameter Object", "Parameters Collection", and "PARAMETERS Declaration (SQL)" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetParamValue](../vs140/cdaoquerydef--getparamvalue.md)   
 [CDaoQueryDef::SetParamValue](../vs140/cdaoquerydef--setparamvalue.md)