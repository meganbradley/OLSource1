---
title: "CMFCVisualManager::OnDrawPaneCaption"
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
  - "CMFCVisualManager.OnDrawPaneCaption"
  - "OnDrawPaneCaption"
  - "CMFCVisualManager::OnDrawPaneCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPaneCaption method"
ms.assetid: b692ee97-f5b5-43ed-bb40-ff2dd7484d75
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawPaneCaption
The framework calls this method when it draws a caption for an instance of the [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework draws the caption for this pane.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the control bar is active.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption buttons.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the caption.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of pane captions.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)