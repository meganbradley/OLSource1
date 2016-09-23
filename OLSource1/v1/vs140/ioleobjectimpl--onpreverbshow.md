---
title: "IOleObjectImpl::OnPreVerbShow"
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
  - ATL.IOleObjectImpl<T>.OnPreVerbShow
  - OnPreVerbShow
  - ATL::IOleObjectImpl<T>::OnPreVerbShow
  - ATL::IOleObjectImpl::OnPreVerbShow
  - IOleObjectImpl::OnPreVerbShow
  - IOleObjectImpl.OnPreVerbShow
  - IOleObjectImpl<T>::OnPreVerbShow
  - ATL.IOleObjectImpl.OnPreVerbShow
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPreVerbShow method
ms.assetid: a51606e0-5af6-42bf-940c-9b7d979570d9
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleObjectImpl::OnPreVerbShow
Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) before the control has been made visible.  
  
## Syntax  
  
```  
  
HRESULT OnPreVerbShow( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 To prevent the control from being made visible, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)   
 [IOleObjectImpl::OnPostVerbShow](../vs140/ioleobjectimpl--onpostverbshow.md)