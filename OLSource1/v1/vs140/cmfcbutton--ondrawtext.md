---
title: "CMFCButton::OnDrawText"
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
  - "OnDrawText"
  - "CMFCButton.OnDrawText"
  - "CMFCButton::OnDrawText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawText method"
ms.assetid: 6d239bb5-d78b-47c4-a7b8-4997c9fe6091
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::OnDrawText
Called by the framework to draw the button text.  
  
## Syntax  
  
```  
virtual void OnDrawText(  
   CDC* pDC,  
   const CRect& rect,  
   const CString& strText,  
   UINT uiDTFlags,  
   UINT uiState   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A reference to a rectangle that bounds the button.  
  
 [in] `strText`  
 The text to draw.  
  
 [in] `uiDTFlags`  
 Flags that specify how to format the text. For more information, see the `nFormat` parameter of the [CDC::DrawText](../vs140/cdc--drawtext.md) method.  
  
 [in] `uiState`  
 (Reserved.)  
  
## Remarks  
 Override this method to use your own code to draw the button text.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::DrawText](../vs140/cdc--drawtext.md)