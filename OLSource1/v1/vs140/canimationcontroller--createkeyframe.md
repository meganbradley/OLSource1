---
title: "CAnimationController::CreateKeyframe"
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
  - "afxanimationcontroller/CAnimationController::CreateKeyframe"
  - "CreateKeyframe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateKeyframe method"
ms.assetid: 452062a5-329d-484e-ade3-57c16ed8c26e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::CreateKeyframe
Creates a keyframe that depends on transition and adds it to the specified group.  
  
## Syntax  
  
```  
CKeyFrame* CreateKeyframe(  
   UINT32 nGroupID,  
   CBaseTransition* pTransition  
);  
CKeyFrame* CreateKeyframe(  
   UINT32 nGroupID,  
   CBaseKeyFrame* pKeyframe,  
   UI_ANIMATION_SECONDS offset = 0.0  
);  
```  
  
#### Parameters  
 `nGroupID`  
 Specifies Group ID for which keyframe is created.  
  
 `pTransition`  
 A pointer to transition. Keyframe will be inserted to storyboard after this transition.  
  
 `pKeyframe`  
 A pointer to base keyframe for this keyframe.  
  
 `offset`  
 Offset in seconds from the base keyframe specified by pKeyframe.  
  
## Return Value  
 A pointer to newly created keyframe if the function succeeds.  
  
## Remarks  
 You can store the returned pointer and base other keyframes on the newly created keyframe (see the second overload). It's possible to begin transitions at keyframes - see CBaseTransition::SetKeyframes. You don't need to delete keyframes created in this way, because they are deleted automatically by animation groups. Be careful when creating keyframes based on other keyframes and transitions and avoid circular references.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)