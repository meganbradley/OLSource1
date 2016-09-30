---
title: "CMFCRibbonBaseElement::IsAutoRepeatMode"
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
  - "CMFCRibbonBaseElement::IsAutoRepeatMode"
  - "CMFCRibbonBaseElement.IsAutoRepeatMode"
  - "IsAutoRepeatMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAutoRepeatMode method"
ms.assetid: d8452391-143f-4ab2-8a75-56653c9fab4c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::IsAutoRepeatMode
Indicates whether the ribbon element is in auto repeat mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
## Return Value  
 Always returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 By default this method always returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Override this method to indicate whether the ribbon element is in auto repeat mode.  
  
 In auto repeat mode, the ribbon element responds at a set interval, measured in milliseconds, to sustained user input.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWnd::SetTimer](../vs140/cwnd--settimer.md)