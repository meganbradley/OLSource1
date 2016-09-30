---
title: "CMFCAutoHideButton::OnDrawBorder"
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
  - "OnDrawBorder"
  - "CMFCAutoHideButton.OnDrawBorder"
  - "CMFCAutoHideButton::OnDrawBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawBorder method"
ms.assetid: a5378dfb-bf0b-49e9-9dc6-2e95326bf565
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton::OnDrawBorder
The framework calls this method when it draws the border of an auto-hide button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bounding rectangle of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The border thickness for each side of the auto-hide button.  
  
## Remarks  
 If you want to customize the border of each auto-hide button in your application, create a new class derived from the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md). In your derived class, override this method.  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
## See Also  
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)