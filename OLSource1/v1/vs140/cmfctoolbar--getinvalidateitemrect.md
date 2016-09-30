---
title: "CMFCToolBar::GetInvalidateItemRect"
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
  - "GetInvalidateItemRect"
  - "CMFCToolBar::GetInvalidateItemRect"
  - "CMFCToolBar.GetInvalidateItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInvalidateItemRect method"
ms.assetid: 48a2eb26-edd5-43d9-ae75-eaec1b1f0fee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetInvalidateItemRect
Retrieves the region of the client area that must be redrawn for the button at the given index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the button for which to retrieve the client area.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that receives the region of the client area.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter must not be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no button exists at the provided index, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> receives a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that is initialized to zero.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)