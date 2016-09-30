---
title: "CEvent::Unlock"
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
  - "CEvent.Unlock"
  - "CEvent::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 88e899c8-fe94-48bb-bd2d-138c629db062
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEvent::Unlock
Releases the event object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the thread owned the event object and the event is an automatic event; otherwise 0.  
  
## Remarks  
 This member function is called by threads that currently own an automatic event to release it after they are done, if their lock object is to be reused. If the lock object is not to be reused, this function will be called by the lock object's destructor.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CEvent Class](../vs140/cevent-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)