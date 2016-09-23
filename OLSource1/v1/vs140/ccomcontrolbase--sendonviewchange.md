---
title: "CComControlBase::SendOnViewChange"
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
  - SendOnViewChange
  - CComControlBase.SendOnViewChange
  - CComControlBase::SendOnViewChange
  - ATL.CComControlBase.SendOnViewChange
  - ATL::CComControlBase::SendOnViewChange
dev_langs: 
  - C++
helpviewer_keywords: 
  - SendOnViewChange method
ms.assetid: 09a4424f-b045-474a-ad70-d07638f172b6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::SendOnViewChange
Notifies all registered advisory sinks that the control's view has changed.  
  
## Syntax  
  
```  
  
      HRESULT SendOnViewChange(  
   DWORD dwAspect,  
   LONG lindex = -1  
);  
```  
  
#### Parameters  
 `dwAspect`  
 The aspect or view of the control.  
  
 *lindex*  
 The portion of the view that has changed. Only -1 is valid.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 `SendOnViewChange` calls [IAdviseSink::OnViewChange](http://msdn.microsoft.com/library/windows/desktop/ms694337). The only value of *lindex* currently supported is -1, which indicates that the entire view is of interest.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md)