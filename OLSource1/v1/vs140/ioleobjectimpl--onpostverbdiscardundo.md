---
title: "IOleObjectImpl::OnPostVerbDiscardUndo"
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
  - "OnPostVerbDiscardUndo"
  - "IOleObjectImpl::OnPostVerbDiscardUndo"
  - "ATL.IOleObjectImpl.OnPostVerbDiscardUndo"
  - "IOleObjectImpl.OnPostVerbDiscardUndo"
  - "ATL::IOleObjectImpl::OnPostVerbDiscardUndo"
  - "ATL::IOleObjectImpl<T>::OnPostVerbDiscardUndo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbDiscardUndo method"
ms.assetid: d6811945-b7a6-4812-9eb6-18422fb65f3f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbDiscardUndo
Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) after the undo state is discarded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method with code you want executed after the undo state is discarded.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md)   
 [IOleObjectImpl::OnPreVerbDiscardUndo](../vs140/ioleobjectimpl--onpreverbdiscardundo.md)