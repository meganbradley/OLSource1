---
title: "IOleObjectImpl::OnPostVerbShow"
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
  - "IOleObjectImpl::OnPostVerbShow"
  - "ATL.IOleObjectImpl.OnPostVerbShow"
  - "IOleObjectImpl.OnPostVerbShow"
  - "ATL::IOleObjectImpl::OnPostVerbShow"
  - "OnPostVerbShow"
  - "IOleObjectImpl<T>::OnPostVerbShow"
  - "ATL::IOleObjectImpl<T>::OnPostVerbShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbShow method"
ms.assetid: 37311c36-5975-4679-aabe-798c22ce9e89
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbShow
Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) after the control has been made visible.  
  
## Syntax  
  
```  
  
HRESULT OnPostVerbShow( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Override this method with code you want executed after the control has been made visible.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)   
 [IOleObjectImpl::OnPreVerbShow](../vs140/ioleobjectimpl--onpreverbshow.md)