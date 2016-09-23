---
title: "IOleControlImpl::FreezeEvents"
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
  - FreezeEvents
  - IOleControlImpl::FreezeEvents
  - IOleControlImpl.FreezeEvents
dev_langs: 
  - C++
helpviewer_keywords: 
  - FreezeEvents method
ms.assetid: cea12375-76e2-4aa1-8632-da2998bca60d
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleControlImpl::FreezeEvents
In ATL's implementation, `FreezeEvents` increments the control class's `m_nFreezeEvents` data member if `bFreeze` is **TRUE**, and decrements `m_nFreezeEvents` if `bFreeze` is **FALSE**.  
  
## Syntax  
  
```  
  
      HRESULT FreezeEvents(  
   BOOL bFreeze   
);  
```  
  
## Remarks  
 `FreezeEvents` then returns `S_OK`.  
  
 See [IOleControl::FreezeEvents](http://msdn.microsoft.com/library/windows/desktop/ms678482) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleControlImpl Class](../vs140/iolecontrolimpl-class.md)   
 [CComControlBase::m_nFreezeEvents](../vs140/ccomcontrolbase--m_nfreezeevents.md)