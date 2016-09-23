---
title: "CComControlBase::SendOnSave"
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
  - CComControlBase.SendOnSave
  - ATL::CComControlBase::SendOnSave
  - CComControlBase::SendOnSave
  - SendOnSave
  - ATL.CComControlBase.SendOnSave
dev_langs: 
  - C++
helpviewer_keywords: 
  - SendOnSave method
ms.assetid: e8768764-d8ca-4e2c-9758-963c6ddd3835
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::SendOnSave
Notifies all advisory sinks registered with the advise holder that the control has been saved.  
  
## Syntax  
  
```  
  
HRESULT SendOnSave( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Sends a notification that the control has just saved its data.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_spOleAdviseHolder](../vs140/ccomcontrolbase--m_spoleadviseholder.md)