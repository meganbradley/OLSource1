---
title: "CDaoTableDef::SetValidationRule"
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
  - "SetValidationRule"
  - "CDaoTableDef.SetValidationRule"
  - "CDaoTableDef::SetValidationRule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetValidationRule method"
  - "CDaoTableDef class, setting validation rules"
  - "tabledefs, setting validation info"
ms.assetid: 08246337-d27b-44ea-93ae-18dc3115df6e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetValidationRule
Call this member function to set a validation rule for a tabledef.  
  
## Syntax  
  
```  
  
      void SetValidationRule(   
   LPCTSTR lpszValidationRule    
);  
```  
  
#### Parameters  
 *lpszValidationRule*  
 A pointer to a string expression that validates an operation.  
  
## Remarks  
 Validation rules are used in connection with update operations. If a tabledef contains a validation rule, updates to that tabledef must match predetermined criteria before the data is changed. If the change does not match the criteria, an exception containing the text of [GetValidationText](../vs140/cdaotabledef--getvalidationtext.md) is displayed.  
  
 Validation is supported only for databases that use the Microsoft Jet database engine. The expression cannot refer to user-defined functions, domain aggregate functions, SQL aggregate functions, or queries. A validation rule for a `CDaoTableDef` object can refer to multiple fields in that object.  
  
 For example, for fields named `hire_date` and `termination_date`, a validation rule might be:  
  
 [!code[NVC_MFCDatabase#34](../vs140/codesnippet/CPP/cdaotabledef--setvalidationrule_1.cpp)]  
  
 For related information, see the topic "ValidationRule Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetValidationText](../vs140/cdaotabledef--getvalidationtext.md)   
 [CDaoTableDef::SetValidationText](../vs140/cdaotabledef--setvalidationtext.md)   
 [CDaoTableDef::GetValidationRule](../vs140/cdaotabledef--getvalidationrule.md)