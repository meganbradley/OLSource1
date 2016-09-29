---
title: "CMFCToolBarDateTimeCtrl::OnMove"
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
  - "CMFCToolBarDateTimeCtrl.OnMove"
  - "CMFCToolBarDateTimeCtrl::OnMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMove method"
ms.assetid: 018f36a8-15a0-490a-9df5-1e9bbacca208
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::OnMove
Called by the framework when the parent toolbar moves.  
  
## Syntax  
  
```  
virtual void OnMove();  
```  
  
## Remarks  
 This method overrides the default class implementation ([CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton--onmove.md)) by updating the position of the internal `CMFCToolBarDateTimeCtrlImpl` object.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarDateTimeCtrlImpl Class](assetId:///4fcddcbc-b374-4c27-bfb4-09fb0ca2eac5)