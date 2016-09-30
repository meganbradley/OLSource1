---
title: "CMFCToolBar::LoadToolBar"
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
  - "CMFCToolBar::LoadToolBar"
  - "LoadToolBar"
  - "CMFCToolBar.LoadToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadToolBar method"
ms.assetid: 44a42479-f6eb-4397-8369-42c2cd5c95f9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::LoadToolBar
Loads the toolbar from application resources.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The resource ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether the toolbar is locked or not. If this parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the toolbar is locked. Otherwise, the toolbar is not locked.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The framework calls this method during initialization to load the images that are associated with the toolbar.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar--loadtoolbar_1.h)]  
[!code[NVC_MFC_IEDemo#7](../vs140/codesnippet/CPP/cmfctoolbar--loadtoolbar_2.cpp)]  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)