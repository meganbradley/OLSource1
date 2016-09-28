---
title: "CEditView::GetBufferLength"
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
  - "CEditView::GetBufferLength"
  - "CEditView.GetBufferLength"
  - "GetBufferLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lengths, buffer"
  - "buffers, length"
  - "CEditView class, attributes"
  - "GetBufferLength method"
ms.assetid: 58a996bb-75d0-4d2f-a7ea-a7961434f42e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::GetBufferLength
Call this member function to obtain the number of characters currently in the edit control's buffer, not including the null terminator.  
  
## Syntax  
  
```  
  
UINT GetBufferLength( ) const;  
  
```  
  
## Return Value  
 The length of the string in the buffer.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::LockBuffer](../vs140/ceditview--lockbuffer.md)   
 [CEditView::UnlockBuffer](../vs140/ceditview--unlockbuffer.md)