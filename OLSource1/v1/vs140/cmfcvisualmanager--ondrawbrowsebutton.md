---
title: "CMFCVisualManager::OnDrawBrowseButton"
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
  - "CMFCVisualManager.OnDrawBrowseButton"
  - "CMFCVisualManager::OnDrawBrowseButton"
  - "OnDrawBrowseButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawBrowseButton method"
ms.assetid: 881aca78-2b34-46ea-b5fe-4c3ae2aa0328
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawBrowseButton
The framework calls this method when it draws the browse button for an edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundary for the browse button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an edit control. The visual manager draws the browse button for this edit control.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An enumerated value that specifies the state of the button.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. This is a reserved value and is currently unused.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this function in a derived class if you want to customize the appearance of browse buttons in instances of the [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md). The possible values for the state of the button are <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)