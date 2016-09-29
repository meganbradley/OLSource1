---
title: "CComControlBase::AppearanceType"
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
  - "ATL::CComControlBase::AppearanceType"
  - "ATL.CComControlBase.AppearanceType"
  - "AppearanceType"
  - "CComControlBase::AppearanceType"
  - "CComControlBase.AppearanceType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AppearanceType method"
ms.assetid: f841fd7f-383e-4658-a8f0-87f9d671ec21
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::AppearanceType
Override if your **m_nAppearance** stock property isn't of type **short**.  
  
## Syntax  
  
```  
  
typedef short AppearanceType;  
  
```  
  
## Remarks  
 The ATL Control Wizard adds **m_nAppearance** stock property of type short. Override `AppearanceType` if you use a different data type.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)