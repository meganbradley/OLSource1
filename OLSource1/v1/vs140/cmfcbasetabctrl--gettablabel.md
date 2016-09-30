---
title: "CMFCBaseTabCtrl::GetTabLabel"
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
  - "GetTabLabel"
  - "CMFCBaseTabCtrl::GetTabLabel"
  - "CMFCBaseTabCtrl.GetTabLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabLabel method"
ms.assetid: b7069046-c598-40da-ac2a-1cdeee7d75ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabLabel
Retrieves the text of a tab label.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. This method stores the label of the tab in this parameter.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This method fails if the index <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is invalid.  
  
 You set the label for a tab when you create the tab by using [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md). You can also change the label after creation with the method [CMFCBaseTabCtrl::SetTabLabel](../vs140/cmfcbasetabctrl--settablabel.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabLabel](../vs140/cmfcbasetabctrl--settablabel.md)