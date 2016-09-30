---
title: "CAnimateCtrl::Play"
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
  - "CAnimateCtrl::Play"
  - "Play"
  - "CAnimateCtrl.Play"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Play method"
ms.assetid: e1fc008e-0d6d-4219-9a5e-22a28c4d6be4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimateCtrl::Play
Call this function to play an AVI clip in an animation control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the frame where playing begins. Value must be less than 65,536. A value of 0 means begin with the first frame in the AVI clip.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the frame where playing ends. Value must be less than 65,536. A value of – 1 means end with the last frame in the AVI clip.  
  
 *nRep*  
 Number of times to replay the AVI clip. A value of – 1 means replay the file indefinitely.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The animation control will play the clip in the background while your thread continues executing. If the animation control has <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> style, the AVI clip will be played using a transparent background rather than the background color specified in the animation clip.  
  
## Example  
 See the example for [CAnimateCtrl::CAnimateCtrl](../vs140/canimatectrl--canimatectrl.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CAnimateCtrl Class](../vs140/canimatectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAnimateCtrl::Open](../vs140/canimatectrl--open.md)   
 [CAnimateCtrl::Stop](../vs140/canimatectrl--stop.md)   
 [CAnimateCtrl::Seek](../vs140/canimatectrl--seek.md)   
 [CAnimateCtrl::Create](../vs140/canimatectrl--create.md)