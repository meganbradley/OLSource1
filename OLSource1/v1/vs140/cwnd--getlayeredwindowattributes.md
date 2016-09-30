---
title: "CWnd::GetLayeredWindowAttributes"
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
  - "GetLayeredWindowAttributes"
  - "CWnd::GetLayeredWindowAttributes"
  - "CWnd.GetLayeredWindowAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLayeredWindowAttributes method"
ms.assetid: 9bae4578-63d8-4869-ab19-94d6696b1612
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetLayeredWindowAttributes
Retrieves the opacity and transparency color key of a layered window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pcrKey*  
 Pointer to a **COLORREF** value that receives the transparency color key to be used when composing the layered window. All pixels painted by the window in this color will be transparent. This can be **NULL** if the argument is not needed.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a **BYTE** that receives the Alpha value used to describe the opacity of the layered window. When the variable referred to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is 0, the window is completely transparent. When the variable referred to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 255, the window is opaque. This can be **NULL** if the argument is not needed.  
  
 *pdwFlags*  
 Pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that receives a layering flag. This can be **NULL** if the argument is not needed. For a complete list of possible values, see [GetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633508).  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [GetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633508), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)