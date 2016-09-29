---
title: "CUtlProps::GetPropValue"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CUtlProps::GetPropValue"
  - "CUtlProps.GetPropValue"
  - "GetPropValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPropValue method"
ms.assetid: 9a3fbadb-7814-48f7-96a4-b960fc4ecf2e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUtlProps::GetPropValue
Gets a property from a property set.  
  
## Syntax  
  
```  
  
      OUT_OF_LINE HRESULT GetPropValue(  
   const GUID* pguidPropSet,  
   DBPROPID dwPropId,  
   VARIANT* pvValue   
);  
```  
  
#### Parameters  
 `pguidPropSet`  
 [in] The GUID for the PropSet.  
  
 `dwPropId`  
 [in] The property index.  
  
 `pvValue`  
 [out] A pointer to a variant that contains the new property value.  
  
## Return Value  
 `Failure` on failure and `S_OK` if successful.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CUtlProps Class](../vs140/cutlprops-class.md)