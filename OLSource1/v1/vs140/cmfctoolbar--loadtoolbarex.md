---
title: "CMFCToolBar::LoadToolBarEx"
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
  - "CMFCToolBar::LoadToolBarEx"
  - "CMFCToolBar.LoadToolBarEx"
  - "LoadToolBarEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadToolBarEx method"
ms.assetid: 0c3a57bf-b137-49b4-b1a2-b41a65994dfb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::LoadToolBarEx
Loads the toolbar from application resources by using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> helper class to enable the application to use large images.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the resource IDs for the toolbar images.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether the toolbar is locked or not. If this parameter is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the toolbar is locked. Otherwise, the toolbar is not locked.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 Call this method to load toolbar images from the application resources.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarInfo Class](../vs140/cmfctoolbarinfo-class.md)