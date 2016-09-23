---
title: "IOleObjectImpl::OnPreVerbDiscardUndo"
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
  - OnPreVerbDiscardUndo
  - IOleObjectImpl::OnPreVerbDiscardUndo
  - ATL::IOleObjectImpl<T>::OnPreVerbDiscardUndo
  - ATL::IOleObjectImpl::OnPreVerbDiscardUndo
  - ATL.IOleObjectImpl.OnPreVerbDiscardUndo
  - IOleObjectImpl.OnPreVerbDiscardUndo
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPreVerbDiscardUndo method
ms.assetid: 53e6fa48-c156-4b60-82b7-6781c31c4808
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleObjectImpl::OnPreVerbDiscardUndo
Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) before the undo state is discarded.  
  
## Syntax  
  
```  
  
HRESULT OnPreVerbDiscardUndo( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 To prevent the undo state from being discarded, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md)   
 [IOleObjectImpl::OnPostVerbDiscardUndo](../vs140/ioleobjectimpl--onpostverbdiscardundo.md)