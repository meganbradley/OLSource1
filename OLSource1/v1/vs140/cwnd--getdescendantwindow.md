---
title: "CWnd::GetDescendantWindow"
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
  - "CWnd.GetDescendantWindow"
  - "CWnd::GetDescendantWindow"
  - "GetDescendantWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDescendantWindow method"
ms.assetid: ba024d0e-df6f-4a0e-a563-e799338abced
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDescendantWindow
Call this member function to find the descendant window specified by the given ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the identifier of the control or child window to be retrieved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the window to be returned can be temporary. If **TRUE**, only a permanent window can be returned; if **FALSE,** the function can return a temporary window. For more information on temporary windows see [Technical Note 3](../vs140/tn003--mapping-of-windows-handles-to-objects.md).  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, or **NULL** if no child window is found.  
  
## Remarks  
 This member function searches the entire tree of child windows, not only the windows that are immediate children.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetParentFrame](../vs140/cwnd--getparentframe.md)   
 [CWnd::IsChild](../vs140/cwnd--ischild.md)   
 [CWnd::GetDlgItem](../vs140/cwnd--getdlgitem.md)