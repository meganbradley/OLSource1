---
title: "CMFCVisualManager::OnDrawTabsButtonBorder"
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
  - "CMFCVisualManager::OnDrawTabsButtonBorder"
  - "OnDrawTabsButtonBorder"
  - "CMFCVisualManager.OnDrawTabsButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTabsButtonBorder method"
ms.assetid: 0aaba6f1-e1e1-42e3-adbe-d991c36976dc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTabsButtonBorder
The framework calls this method when it draws the border of a tab button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [CMFCButton](../vs140/cmfcbutton-class.md) object. The framework draws the border for this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instance.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An unsigned integer that specifies the state of the button.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the parent tab window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the border of the tab button.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)