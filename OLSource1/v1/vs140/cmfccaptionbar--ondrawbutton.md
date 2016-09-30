---
title: "CMFCCaptionBar::OnDrawButton"
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
  - "CMFCCaptionBar.OnDrawButton"
  - "OnDrawButton"
  - "CMFCCaptionBar::OnDrawButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawButton method"
ms.assetid: fd93f136-7d07-4113-8510-d2bc02c9f54d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::OnDrawButton
Called by the framework to draw the caption bar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context that is used to display the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The button's text label.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the button is enabled; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 Override this method in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar's button.  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)