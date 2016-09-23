---
title: "CMFCVisualManager::OnDrawCaptionButton"
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
  - OnDrawCaptionButton
  - CMFCVisualManager::OnDrawCaptionButton
  - CMFCVisualManager.OnDrawCaptionButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawCaptionButton method
ms.assetid: 5853657c-9968-4556-8b46-a9a508b66366
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawCaptionButton
The framework calls this method when it draws a [CMFCCaptionButton](../vs140/cmfccaptionbutton-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawCaptionButton (  
   CDC* pDC,  
   CMFCCaptionButton* pButton,  
   BOOL bActive,  
   BOOL bHorz,  
   BOOL bMaximized,  
   BOOL bDisabled,  
   int nImageID = -1  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pButton`  
 A pointer to a `CMFCCaptionButton` object. The framework draws this caption button.  
  
 [in] `bActive`  
 A Boolean parameter that specifies whether the button is active.  
  
 [in] `bHorz`  
 A Boolean parameter that specifies whether the caption is horizontal.  
  
 [in] `bMaximized`  
 A Boolean parameter that specifies whether the parent pane is maximized.  
  
 [in] `bDisabled`  
 A Boolean parameter that specifies whether the caption button is disabled.  
  
 [in] `nImageID`  
 The image index for the icon to use for the button. If `nImageID` is -1, this method uses the image index recorded in `pButton`.  
  
## Remarks  
 The default implementation of this method displays a small button from the global instance of the `CMenuImages` class. The buttons are listed in the header file for `CMenuImages`. Some examples include `CMenuImages::IdClose`, `CMenuImages::IdArowLeft`, `CMenuImages::IdArowRight`, `CMenuImages::IdArowDown`, `CMenuImages::IdArowUp`, and `CMenuImages::IdPinHorz`.  
  
 Override this method in a derived class to customize the appearance of caption buttons.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)