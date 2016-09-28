---
title: "CEditView::LockBuffer"
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
  - "LockBuffer"
  - "CEditView::LockBuffer"
  - "CEditView.LockBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEditView class, attributes"
  - "buffers, locking"
  - "LockBuffer method"
ms.assetid: f5f21c68-97d2-433f-b3f6-800627ca870f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::LockBuffer
Call this member function to obtain a pointer to the buffer. The buffer should not be modified.  
  
## Syntax  
  
```  
  
LPCTSTR LockBuffer( ) const;  
  
```  
  
## Return Value  
 A pointer to the edit control's buffer.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::UnlockBuffer](../vs140/ceditview--unlockbuffer.md)   
 [CEditView::GetBufferLength](../vs140/ceditview--getbufferlength.md)