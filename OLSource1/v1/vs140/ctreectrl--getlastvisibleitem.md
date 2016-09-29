---
title: "CTreeCtrl::GetLastVisibleItem"
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
  - "CTreeCtrl.GetLastVisibleItem"
  - "CTreeCtrl::GetLastVisibleItem"
  - "GetLastVisibleItem method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLastVisibleItem method"
ms.assetid: 967eb60b-8293-4411-8362-fa842a665750
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetLastVisibleItem
Retrieves the last unexpanded node item in the current tree-view control.  
  
## Syntax  
  
```  
HTREEITEM GetLastVisibleItem() const;  
```  
  
## Return Value  
 The handle to the last unexpanded node item if the method is successful; otherwise, `NULL`.  
  
## Remarks  
 This method sends the [TVM_GETNEXTITEM](http://msdn.microsoft.com/library/windows/desktop/bb773622) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the `TVGN_LASTVISIBLE` flag in the `flag` parameter of that message.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example defines a variable, `m_treeCtrl`, that is used to access the current tree-view control. The code example also defines an unsigned integer and several HTREEITEM variables. One or more of these variables are used in the next example.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#1](../vs140/codesnippet/CPP/ctreectrl--getlastvisibleitem_1.h)]  
  
## Example  
 The following code example retrieves a handle to the last unexpanded tree-view node item, and then draws a 3D rectangle around that item. In an earlier section of the code example, which is not shown, we created a tree-view that consists of a root country/region node for the United States, subnodes for the states of Pennsylvania and Washington, and tree items for cities in those states.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#6](../vs140/codesnippet/CPP/ctreectrl--getlastvisibleitem_2.cpp)]  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_GETNEXTITEM](http://msdn.microsoft.com/library/windows/desktop/bb773622)