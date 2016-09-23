---
title: "CMFCToolBarButton::OnDrawOnCustomizeList"
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
  - OnDrawOnCustomizeList
  - CMFCToolBarButton.OnDrawOnCustomizeList
  - CMFCToolBarButton::OnDrawOnCustomizeList
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawOnCustomizeList method
ms.assetid: 4c242bfa-6161-4916-91d1-7e615377744d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::OnDrawOnCustomizeList
Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box.  
  
## Syntax  
  
```  
virtual int OnDrawOnCustomizeList(  
   CDC* pDC,  
   const CRect& rect,  
   BOOL bSelected   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 The device context that displays the button.  
  
 [in] `rect`  
 The bounding rectangle of the button.  
  
 [in] `bSelected`  
 Specifies whether the button is selected. If this parameter is `TRUE`, the button is selected. If this parameter is `FALSE`, the button is not selected.  
  
## Return Value  
 The width, in pixels, of the button on the specified device context.  
  
## Remarks  
 This method is called by the customization dialog box (**Commands** tab) when the button is about to display itself on the owner-draw list box.  
  
 The default implementation of this method displays the image and text label of the button if they are available. If the text label of the button is not available, the method displays the tooltip text.  
  
 Override this method to perform custom drawing.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)