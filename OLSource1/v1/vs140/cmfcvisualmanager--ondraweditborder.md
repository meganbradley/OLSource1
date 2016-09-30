---
title: "CMFCVisualManager::OnDrawEditBorder"
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
  - "CMFCVisualManager::OnDrawEditBorder"
  - "CMFCVisualManager.OnDrawEditBorder"
  - "OnDrawEditBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawEditBorder method"
ms.assetid: b202b907-6596-4512-b2e7-757fb384eb97
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawEditBorder
The framework calls this method when it draws the border around an instance of the [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is unavailable.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The framework draws the border of this edit box button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the border of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)