---
title: "CBaseTransition::GetStartKeyframe"
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
  - "afxanimationcontroller/CBaseTransition::GetStartKeyframe"
  - "GetStartKeyframe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStartKeyframe method"
ms.assetid: 56a8ee06-ada5-4281-a096-6232546af90e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTransition::GetStartKeyframe
Returns start keyframe.  
  
## Syntax  
  
```  
CBaseKeyFrame* GetStartKeyframe();  
```  
  
## Return Value  
 A valid pointer to a keyframe, or NULL if a transition should not start after a keyframe.  
  
## Remarks  
 This method can be used to access a keyframe object that was previously set by SetKeyframes. It's called by top level code when transitions are being added to storyboard.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)