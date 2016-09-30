---
title: "CMFCVisualManager::OnFillRibbonEdit"
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
  - "CMFCVisualManager::OnFillRibbonEdit"
  - "OnFillRibbonEdit"
  - "CMFCVisualManager.OnFillRibbonEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillRibbonEdit method"
ms.assetid: 39fb0121-37b1-485c-9b94-b6acfdad8320
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillRibbonEdit
The framework calls this method when it fills the interior of an instance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. The framework fills the interior of this edit control.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the edit control.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the edit control is highlighted.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the parent pane is highlighted.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the edit control is unavailable.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A reference to the text color of the edit control.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A reference to the background color of the edit control when it is highlighted.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A reference to the color of selected text on the edit control.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> indicated by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can be a part of a combo box button on the ribbon.  
  
 Override this method in a derived visual manager to customize the appearance of a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)