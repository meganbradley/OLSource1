---
title: "CMFCToolBarDateTimeCtrl::OnSize"
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
  - "CMFCToolBarDateTimeCtrl.OnSize"
  - "OnSize"
  - "CMFCToolBarDateTimeCtrl::OnSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSize method"
ms.assetid: b68a9fa9-7393-456d-95a1-3f98373b8616
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::OnSize
Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size.  
  
## Syntax  
  
```  
virtual void OnSize(  
   int iSize  
);  
```  
  
#### Parameters  
 [in] `iSize`  
 The new width of the button, in pixels.  
  
## Remarks  
 This method overrides the default class implementation ([CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton--onsize.md)) by updating the size and position of the internal `CMFCToolBarDateTimeCtrlImpl` object.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton--onsize.md)