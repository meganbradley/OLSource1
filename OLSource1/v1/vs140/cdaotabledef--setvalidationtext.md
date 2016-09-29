---
title: "CDaoTableDef::SetValidationText"
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
  - "SetValidationText"
  - "CDaoTableDef.SetValidationText"
  - "CDaoTableDef::SetValidationText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetValidationText method"
  - "CDaoTableDef class, setting validation texts"
  - "tabledefs, setting validation info"
ms.assetid: fd674476-10b4-453e-9ae6-99ae6a4eccb4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetValidationText
Call this member function to set the exception text of a validation rule for a `CDaoTableDef` object with an underlying base table supported by the Microsoft Jet database engine.  
  
## Syntax  
  
```  
  
      void SetValidationText(   
   LPCTSTR lpszValidationText    
);  
```  
  
#### Parameters  
 *lpszValidationText*  
 A pointer to a string expression that specifies the text displayed if entered data is invalid.  
  
## Remarks  
 You cannot set the validation text of an attached table.  
  
 For related information, see the topic "ValidationText Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::SetValidationRule](../vs140/cdaotabledef--setvalidationrule.md)   
 [CDaoTableDef::GetValidationText](../vs140/cdaotabledef--getvalidationtext.md)   
 [CDaoTableDef::GetValidationRule](../vs140/cdaotabledef--getvalidationrule.md)