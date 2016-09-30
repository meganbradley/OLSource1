---
title: "CMFCShellTreeCtrl::GetRelatedList"
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
  - "CMFCShellTreeCtrl.GetRelatedList"
  - "CMFCShellTreeCtrl::GetRelatedList"
  - "GetRelatedList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRelatedList method"
ms.assetid: 66ea2905-4249-461a-aad9-73f1ac141731
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellTreeCtrl::GetRelatedList
Returns a pointer to the [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object that is associated with this [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that is associated with this tree control object.  
  
## Remarks  
 By using a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object together with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, you can create an Explorer-like window. Use the method [CMFCShellTreeCtrl::SetRelatedList](../vs140/cmfcshelltreectrl--setrelatedlist.md) to associate the two classes. After they are associated, the framework automatically updates the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the selection in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> changes.  
  
## Requirements  
 **Header:** afxshelltreectrl.h  
  
## See Also  
 [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCShellTreeCtrl::SetRelatedList](../vs140/cmfcshelltreectrl--setrelatedlist.md)   
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)