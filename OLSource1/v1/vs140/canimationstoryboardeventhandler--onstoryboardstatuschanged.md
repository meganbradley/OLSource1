---
title: "CAnimationStoryboardEventHandler::OnStoryboardStatusChanged"
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
  - "OnStoryboardStatusChanged"
  - "afxanimationcontroller/CAnimationStoryboardEventHandler::OnStoryboardStatusChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStoryboardStatusChanged method"
ms.assetid: b517ad42-03d4-4c53-92bf-ceb87f939e13
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationStoryboardEventHandler::OnStoryboardStatusChanged
Handles OnStoryboardStatusChanged events, which occur when a storyboard's status changes  
  
## Syntax  
  
```  
IFACEMETHOD(  
   OnStoryboardStatusChanged  
) ( __in IUIAnimationStoryboard *storyboard, __in UI_ANIMATION_STORYBOARD_STATUS newStatus, __in UI_ANIMATION_STORYBOARD_STATUS previousStatus );  
```  
  
#### Parameters  
 `storyboard`  
 A pointer to storyboard whose status has changed.  
  
 `newStatus`  
 Specifies new storyboard status.  
  
 `previousStatus`  
 Specifies previous storyboard status.  
  
## Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationStoryboardEventHandler Class](../vs140/canimationstoryboardeventhandler-class.md)