---
title: "CRichEditCtrl::SetRect"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRichEditCtrl.SetRect
  - CRichEditCtrl::SetRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetRect method
ms.assetid: 75c959ae-c11e-4e94-a1ff-b5f8259393a6
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::SetRect
Sets the formatting rectangle for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      void SetRect(  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `lpRect`  
 [CRect](../vs140/crect-class.md) or pointer to a [RECT](../vs140/rect-structure.md) that indicates the new bounds for the formatting rectangle.  
  
## Remarks  
 The formatting rectangle is the limiting rectangle for the text. The limiting rectangle is independent of the size of the rich edit control window. When this `CRichEditCtrl` object is first created, the formatting rectangle is the same size as the client area of the window. Use `SetRect` to make the formatting rectangle larger or smaller than the rich edit window.  
  
 For more information, see [EM_SETRECT](http://msdn.microsoft.com/library/windows/desktop/bb761657) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#30](../vs140/codesnippet/CPP/cricheditctrl--setrect_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetRect](../vs140/cricheditctrl--getrect.md)