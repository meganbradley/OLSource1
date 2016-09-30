---
title: "CMFCShellListCtrl::OnGetItemIcon"
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
  - "CMFCShellListCtrl.OnGetItemIcon"
  - "CMFCShellListCtrl::OnGetItemIcon"
  - "OnGetItemIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetItemIcon method"
ms.assetid: c277dce1-3b06-4cdb-b4b3-6d09f704560d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::OnGetItemIcon
The framework calls this method to retrieve the icon associated with a shell list item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The item index.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter that describes the item.  
  
## Return Value  
 The index of the icon image if successful; -1 if the function fails.  
  
## Remarks  
 The icon image index is based on the system image list.  
  
 By default, this method relies on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. The value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not used in the default implementation. You can use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to implement custom behavior.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)