---
title: "CMFCToolBarEditBoxButton::OnMove"
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
  - "OnMove"
  - "CMFCToolBarEditBoxButton.OnMove"
  - "CMFCToolBarEditBoxButton::OnMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMove method"
ms.assetid: 0aa69f08-147f-4c68-b580-200a39ba97c7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnMove
Called by the framework when the parent toolbar moves.  
  
## Syntax  
  
```  
virtual void OnMove();  
```  
  
## Remarks  
 This method overrides the default class implementation ([CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton--onmove.md)) by updating the position of the internal `CEdit` object  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton--onmove.md)   
 [CEdit Class](../vs140/cedit-class.md)