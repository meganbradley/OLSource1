---
title: "CMFCVisualManager::OnFillOutlookPageButton"
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
  - "CMFCVisualManager.OnFillOutlookPageButton"
  - "OnFillOutlookPageButton"
  - "CMFCVisualManager::OnFillOutlookPageButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillOutlookPageButton method"
ms.assetid: 5f1180e9-0fc1-4e7e-a7a1-a018a222108b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillOutlookPageButton
The framework calls this method when it fills the interior of an Outlook page button.  
  
## Syntax  
  
```  
virtual void OnFillOutlookPageButton(  
   CDC* pDC,  
   const CRect& rect,  
   BOOL bIsHighlighted,  
   BOOL bIsPressed,  
   COLORREF& clrText  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the Outlook page button.  
  
 [in] `bIsHighlighted`  
 A Boolean parameter that specifies whether the button is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean parameter that specifies whether the button is pressed.  
  
 [out] `clrText`  
 A reference to a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. This method stores the text color of the outlook page button in this parameter.  
  
## Remarks  
 Override this function in a derived visual manager to customize the appearance of Outlook page buttons.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)