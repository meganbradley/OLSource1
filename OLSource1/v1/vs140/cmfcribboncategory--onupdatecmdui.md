---
title: "CMFCRibbonCategory::OnUpdateCmdUI"
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
  - "CMFCRibbonCategory::OnUpdateCmdUI"
  - "CMFCRibbonCategory.OnUpdateCmdUI"
  - "OnUpdateCmdUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateCmdUI method"
ms.assetid: 1882ddf4-09af-43c4-99bf-36526919fff5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::OnUpdateCmdUI
Calls the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function in each of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to enable or disable the user-interface elements in them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that specifies which user-interface elements are to be enabled and which are to be disabled.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the window that controls the enabling or disabling of the user-interface elements.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to disable the user-interface item if no handler is defined in a message map; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)