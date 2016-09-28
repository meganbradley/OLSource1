---
title: "CTreeCtrl::SetItemStateEx"
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
  - "SetItemStateEx method"
  - "CTreeCtrl::SetItemStateEx"
  - "CTreeCtrl.SetItemStateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemStateEx method"
ms.assetid: 26fbc87a-7473-48f0-8d1a-5d94f79763dd
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetItemStateEx
Sets the extended state of the specified item in the current tree-view control.  
  
## Syntax  
  
```  
BOOL SetItemStateEx(  
     HTREEITEM hItem,   
     UINT uStateEx  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `hItem`|Handle to a tree-view control item.|  
|[in] `uStateEx`|The extended state of the item. For more information, see the `uStateEx` member of the [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [TVM_SETITEM](http://msdn.microsoft.com/library/windows/desktop/bb773758) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This method assigns the `uStateEx` parameter to the `uStateEx` member of a [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure, and then uses that structure in the message.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_treeCtrl`, that is used to access the current tree-view control. The code example also defines an unsigned integer and several HTREEITEM variables. These variables are used in the next example.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#1](../vs140/codesnippet/CPP/ctreectrl--setitemstateex_1.h)]  
  
## Example  
 The following code example sets a tree-view item to disabled state. In an earlier section of the code example, which is not shown, we created a tree-view that consists of a root country/region node for the United States, subnodes for the states of Pennsylvania and Washington, and tree items for cities in those states. This code example sets the Pennsylvania node to disabled state.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#7](../vs140/codesnippet/CPP/ctreectrl--setitemstateex_2.cpp)]  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItemStateEx](../vs140/ctreectrl--getitemstateex.md)   
 [TVM_SETITEM](http://msdn.microsoft.com/library/windows/desktop/bb773758)   
 [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459)