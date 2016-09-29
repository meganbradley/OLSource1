---
title: "CMFCToolBarEditBoxButton::OnSize"
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
  - "OnSize"
  - "CMFCToolBarEditBoxButton.OnSize"
  - "CMFCToolBarEditBoxButton::OnSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSize method"
ms.assetid: ce027ea8-ca2f-45ff-9c26-ad1ca5df367a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnSize
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
 This method overrides the default class implementation, [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton--onsize.md), by updating the size and position of the internal `CEdit` object.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton--onsize.md)   
 [CEdit Class](../vs140/cedit-class.md)