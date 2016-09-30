---
title: "CMFCShellTreeCtrl::SetRelatedList"
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
  - "CMFCShellTreeCtrl.SetRelatedList"
  - "SetRelatedList"
  - "CMFCShellTreeCtrl::SetRelatedList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRelatedList method"
ms.assetid: e1c637ec-1b13-4fd9-a814-8888554a028c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellTreeCtrl::SetRelatedList
Associates a [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object with a [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 This method associates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. These objects may be displayed as an Explorer-like window: if the user selects an object in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the associated items in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will be automatically updated.  
  
 Use the method [CMFCShellTreeCtrl::GetRelatedList](../vs140/cmfcshelltreectrl--getrelatedlist.md) to retrieve the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> associated with a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxshelltreectrl.h  
  
## See Also  
 [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCShellTreeCtrl::GetRelatedList](../vs140/cmfcshelltreectrl--getrelatedlist.md)   
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)