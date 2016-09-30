---
title: "CMFCCaptionBar::OnDrawText"
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
  - "CMFCCaptionBar::OnDrawText"
  - "CMFCCaptionBar.OnDrawText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawText method"
ms.assetid: 67440963-2f89-4d9f-8538-ce26fb6698a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::OnDrawText
Called by the framework to draw the caption bar text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context that is used to display the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bounding rectangle of the text.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The text string to display.  
  
## Remarks  
 The default implementation displays the text by using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and [CMFCCaptionBar::m_clrBarText](../vs140/cmfccaptionbar--m_clrbartext.md) color.  
  
 Override this method in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar's text.  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)