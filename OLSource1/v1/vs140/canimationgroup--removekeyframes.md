---
title: "CAnimationGroup::RemoveKeyframes"
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
  - "RemoveKeyframes"
  - "afxanimationcontroller/CAnimationGroup::RemoveKeyframes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveKeyframes method"
ms.assetid: 764e3258-6364-4b3c-8bda-d6420df11543
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationGroup::RemoveKeyframes
Removes and optionally destroys all keyframes that belong to an animation group.  
  
## Syntax  
  
```  
void RemoveKeyframes();  
```  
  
## Remarks  
 If m_bAutodestroyKeyframes member is TRUE then keyframes are removed and destroyed, otherwise keyframes are just removed from the internal list of keyframes.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationGroup Class](../vs140/canimationgroup-class.md)