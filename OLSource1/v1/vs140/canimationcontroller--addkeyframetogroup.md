---
title: "CAnimationController::AddKeyframeToGroup"
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
  - "afxanimationcontroller/CAnimationController::AddKeyframeToGroup"
  - "AddKeyframeToGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddKeyframeToGroup method"
ms.assetid: 0b58961b-c534-44ff-9cc6-5abb66556313
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::AddKeyframeToGroup
Adds a keyframe to group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies Group ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a keyframe.  
  
## Return Value  
 TRUE if the function succeeds; otherwise FALSE.  
  
## Remarks  
 Usually you don't need to call this method, use CAnimationController::CreateKeyframe instead, which creates and adds the created keyframe to a group automatically.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)