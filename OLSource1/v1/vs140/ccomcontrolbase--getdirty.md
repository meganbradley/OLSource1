---
title: "CComControlBase::GetDirty"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CComControlBase.GetDirty
  - CComControlBase.GetDirty
  - ATL::CComControlBase::GetDirty
  - GetDirty
  - CComControlBase::GetDirty
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDirty method
ms.assetid: c51ad3f3-d10f-49cc-829e-506af6a47108
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::GetDirty
Returns the value of data member `m_bRequiresSave`.  
  
## Syntax  
  
```  
  
BOOL GetDirty( );  
  
```  
  
## Return Value  
 Returns the value of data member [m_bRequiresSave](../vs140/ccomcontrolbase--m_brequiressave.md).  
  
## Remarks  
 This value is set using [CComControlBase::SetDirty](../vs140/ccomcontrolbase--setdirty.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)