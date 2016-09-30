---
title: "CKeyFrame::CKeyFrame"
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
  - "afxanimationcontroller/CKeyFrame::CKeyFrame"
  - "CKeyFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CKeyFrame class, constructor"
ms.assetid: 3df03c35-33e1-4271-9ef0-6b8e69b749dd
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyFrame::CKeyFrame
Constructs a keyframe that depends on a transition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a transition.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to keyframe.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Offset, in seconds, from keyframe specified by pKeyframe.  
  
## Remarks  
 The constructed keyframe will represent a moment in time within a storyboard when the specified transition ends.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CKeyFrame Class](../vs140/ckeyframe-class.md)