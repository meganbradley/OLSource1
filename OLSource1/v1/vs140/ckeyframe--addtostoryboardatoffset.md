---
title: "CKeyFrame::AddToStoryboardAtOffset"
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
  - "AddToStoryboardAtOffset"
  - "afxanimationcontroller/CKeyFrame::AddToStoryboardAtOffset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToStoryboardAtOffset method"
ms.assetid: ab3ac6a3-b10c-4a8c-b303-324d2d671f49
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyFrame::AddToStoryboardAtOffset
Adds a keyframe to storyboard at offset.  
  
## Syntax  
  
```  
virtual BOOL AddToStoryboardAtOffset(  
   IUIAnimationStoryboard* pStoryboard,  
   BOOL bDeepAdd  
);  
```  
  
#### Parameters  
 `pStoryboard`  
 A pointer to a storyboard.  
  
 `bDeepAdd`  
 Specifies whether to add a keyframe this keyframe depend on recursively.  
  
## Return Value  
 TRUE, if keyframe was added successfully.  
  
## Remarks  
 This function is called by the framework to add a keyframe to storyboard at offset.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CKeyFrame Class](../vs140/ckeyframe-class.md)