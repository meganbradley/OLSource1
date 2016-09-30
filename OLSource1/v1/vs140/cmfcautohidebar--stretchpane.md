---
title: "CMFCAutoHideBar::StretchPane"
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
  - "StretchPane"
  - "CMFCAutoHideBar::StretchPane"
  - "CMFCAutoHideBar.StretchPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StretchPane method"
ms.assetid: b1c00693-d67b-4594-be40-83d7379d2b4d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideBar::StretchPane
Resizes the auto-hide bar in its collapsed state to fit the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value is unused in the base implementation. In derived implementations, use this value to indicate the length of the resized pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value is unused in the base implementation. In derived implementations, use  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to handle the case where the auto-hide bar is collapsed vertically, and  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the case where the auto-hide bar is collapsed horizontally.  
  
## Return Value  
 The resulting size of the resized pane.  
  
## Remarks  
 Derived classes can override this method to customize the behavior.  
  
## Requirements  
 **Header:** afxautohidebar.h  
  
## See Also  
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)