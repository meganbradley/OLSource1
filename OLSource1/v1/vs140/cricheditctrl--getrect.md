---
title: "CRichEditCtrl::GetRect"
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
  - "CRichEditCtrl::GetRect"
  - "CRichEditCtrl.GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRect method"
ms.assetid: 0c5d02d2-1ce6-484a-ba26-a0f72f7bb1dd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetRect
Retrieves the formatting rectangle for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      void GetRect(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 [CRect](../vs140/crect-class.md) or pointer to a [RECT](../vs140/rect-structure.md) to receive the formatting rectangle of this `CRichEditCtrl` object.  
  
## Remarks  
 The formatting rectangle is the bounding rectangle for the text. This value is independent of the size of the `CRichEditCtrl` object.  
  
 For more information, see [EM_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb761596) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [LimitText](../vs140/cricheditctrl--limittext.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetRect](../vs140/cricheditctrl--setrect.md)