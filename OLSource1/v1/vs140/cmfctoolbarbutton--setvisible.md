---
title: "CMFCToolBarButton::SetVisible"
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
  - "CMFCToolBarButton::SetVisible"
  - "CMFCToolBarButton.SetVisible"
  - "SetVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetVisible method"
ms.assetid: 1b458ed4-0b4a-43f9-b47b-74fdd4d46d9b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetVisible
Specifies whether the button is visible.  
  
## Syntax  
  
```  
void SetVisible(  
   BOOL bShow=TRUE  
);  
```  
  
#### Parameters  
 [in] `bShow`  
 A Boolean value that specifies whether to show or hide the button. If this parameter is `TRUE`, the button is shown. If the parameter is `FALSE`, the button is hidden.  
  
## Remarks  
 Use this function to hide or show a particular toolbar button. Call the [CPane::AdjustSizeImmediate](../vs140/cpane--adjustsizeimmediate.md) method after you call this method.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::AdjustSizeImmediate](../vs140/cpane--adjustsizeimmediate.md)