---
title: "CMDIFrameWndEx::EnableAutoHidePanes"
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
  - "CMDIFrameWndEx.EnableAutoHidePanes"
  - "EnableAutoHidePanes"
  - "CMDIFrameWndEx::EnableAutoHidePanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoHidePanes method"
ms.assetid: 02895d77-cd54-4d4a-ae70-4673206d67cb
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::EnableAutoHidePanes
Enables auto-hide mode for panes when they are docked at the specified sides of the main frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the sides of the main frame window that will be enabled. Use one or more of the following flags.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Return Value  
 Call this function to enable auto-hide mode for panes when they are docked at the specified sides of the main frame window.  
  
## Example  
 The following example shows how the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#6](../vs140/codesnippet/CPP/cmdiframewndex--enableautohidepanes_1.cpp)]  
  
## Remarks  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)