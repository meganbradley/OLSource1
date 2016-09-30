---
title: "CMFCToolBarButton::OnUpdateToolTip"
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
  - "OnUpdateToolTip"
  - "CMFCToolBarButton::OnUpdateToolTip"
  - "CMFCToolBarButton.OnUpdateToolTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateToolTip method"
ms.assetid: 2b1cb54a-b1c9-42d8-a99c-7d66d3c274f1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnUpdateToolTip
Called by the framework when the parent toolbar updates its tooltip text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The parent window.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the button in the parent button collection.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The control that displays the tooltip text.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that receives the updated tooltip text.  
  
## Return Value  
 This method returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation of this method does nothing and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Override this method to return a nonzero value if you provide a tooltip text string.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)