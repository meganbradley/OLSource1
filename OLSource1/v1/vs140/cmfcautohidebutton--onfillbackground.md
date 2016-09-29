---
title: "CMFCAutoHideButton::OnFillBackground"
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
  - "CMFCAutoHideButton.OnFillBackground"
  - "CMFCAutoHideButton::OnFillBackground"
  - "OnFillBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillBackground method"
ms.assetid: ab8577e8-60d4-4e23-a36b-e32160f357ca
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton::OnFillBackground
The framework calls this method when it fills the background of an auto-hide button.  
  
## Syntax  
  
```  
virtual void OnFillBackground(  
   CDC* pDC,  
   CRect rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 The bounding rectangle of the auto-hide button.  
  
## Remarks  
 If you want to customize the background for auto-hide buttons in your application, create a new class derived from the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md). In your derived class, override this method.  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
## See Also  
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)