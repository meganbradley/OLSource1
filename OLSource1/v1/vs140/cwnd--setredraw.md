---
title: "CWnd::SetRedraw"
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
  - "CWnd::SetRedraw"
  - "Redraw"
  - "CWnd.SetRedraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Redraw method"
  - "SetRedraw method"
ms.assetid: f3bebab9-7787-44c4-b93f-62f91786e586
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetRedraw
An application calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to allow changes to be redrawn or to prevent changes from being redrawn.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the state of the redraw flag. If this parameter is **TRUE**, the redraw flag is set; if **FALSE**, the flag is cleared.  
  
## Remarks  
 This member function sets or clears the redraw flag. While the redraw flag is cleared, the contents will not be updated after each change and will not be repainted until the redraw flag is set. For example, an application that needs to add several items to a list box can clear the redraw flag, add the items, and then set the redraw flag. Finally, the application can call the [Invalidate](../vs140/cwnd--invalidate.md) or [InvalidateRect](../vs140/cwnd--invalidaterect.md) member function to cause the list box to be repainted.  
  
## Example  
 [!code[NVC_MFCWindowing#117](../vs140/codesnippet/CPP/cwnd--setredraw_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SETREDRAW](http://msdn.microsoft.com/library/windows/desktop/dd145219)