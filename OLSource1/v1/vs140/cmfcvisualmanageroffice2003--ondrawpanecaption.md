---
title: "CMFCVisualManagerOffice2003::OnDrawPaneCaption"
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
  - "CMFCVisualManagerOffice2003::OnDrawPaneCaption"
  - "OnDrawPaneCaption"
  - "CMFCVisualManagerOffice2003.OnDrawPaneCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPaneCaption method"
ms.assetid: 1289d1f9-ed82-49d7-bfc7-0de5e2ee25ad
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawPaneCaption
The framework calls this method when it draws a caption for a [CDockablePane](../vs140/cdockablepane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CDockablePane](../vs140/cdockablepane-class.md) object. The framework draws the caption for this pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the control bar is active.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption buttons.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the caption.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)