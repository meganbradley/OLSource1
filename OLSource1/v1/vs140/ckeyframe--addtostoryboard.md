---
title: "CKeyFrame::AddToStoryboard"
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
  - "AddToStoryboard"
  - "afxanimationcontroller/CKeyFrame::AddToStoryboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToStoryboard method"
ms.assetid: c6d83e7a-81e9-4738-ad89-e1cbc2dff5ac
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyFrame::AddToStoryboard
Adds a keyframe to a storyboard.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a storyboard.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether to add keyframe or transition recursively.  
  
## Return Value  
 TRUE, if keyframe was added successfully.  
  
## Remarks  
 This method adds a keyframe to storyboard. If it depends on other keyframe or transition and bDeepAdd is TRUE, this method tries to add them recursively.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CKeyFrame Class](../vs140/ckeyframe-class.md)