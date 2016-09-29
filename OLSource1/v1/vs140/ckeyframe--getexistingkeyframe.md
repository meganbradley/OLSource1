---
title: "CKeyFrame::GetExistingKeyframe"
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
  - "afxanimationcontroller/CKeyFrame::GetExistingKeyframe"
  - "GetExistingKeyframe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExistingKeyframe method"
ms.assetid: 48e435c0-21be-4010-8a1e-03536936aba9
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyFrame::GetExistingKeyframe
Returns a pointer to a keyframe this keyframe depends on.  
  
## Syntax  
  
```  
CBaseKeyFrame* GetExistingKeyframe();  
```  
  
## Return Value  
 A valid pointer to keyframe, or NULL if this keyframe does not depend on other keyframe.  
  
## Remarks  
 This is an accessor to a keyframe this keyframe depends on.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CKeyFrame Class](../vs140/ckeyframe-class.md)