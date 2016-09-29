---
title: "CTreeCtrl::GetItemPartRect"
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
  - "CTreeCtrl::GetItemPartRect"
  - "CTreeCtrl.GetItemPartRect"
  - "GetItemPartRect method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemPartRect method"
ms.assetid: fa508567-471d-44ff-8daf-53f73bbd027c
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetItemPartRect
Retrieves the bounding rectangle for a specified part of a specified item in the current tree-view control.  
  
## Syntax  
  
```  
BOOL GetItemPartRect(  
     HTREEITEM hItem,   
     int nPart,   
     LPRECT lpRect  
)const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `hItem`|Handle to a tree-view control item.|  
|[in] `nPart`|Identifier for the part. Must be set to `TVGIPR_BUTTON`.|  
|[out] `lpRect`|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. If this method is successful, the structure receives the rectangle coordinates of the part specified by `hItem` and `nPart`.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Each tree control item is bounded by a graphics rectangle. Whenever a point in that rectangle is clicked, the item is said to be *hit*. This method returns the largest rectangle such that when a point in the rectangle is clicked, the item identified by the `hItem` parameter is hit.  
  
 This method sends the `TVM_GETITEMPARTRECT` message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the [TreeView_GetItemPartRect](http://msdn.microsoft.com/library/windows/desktop/bb773847) macro.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_treeCtrl`, that is used to access the current tree-view control. The code example also defines an unsigned integer and several HTREEITEM variables. These variables are used in the next example.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#1](../vs140/codesnippet/CPP/ctreectrl--getitempartrect_1.h)]  
  
## Example  
 The following code example uses an accessibility identifier and the [CTreeCtrl::MapAccIdToItem](../vs140/ctreectrl--mapaccidtoitem.md) method to retrieve a handle to the root tree-view item. Then the example uses the handle and the [CTreeCtrl::GetItemPartRect](../vs140/ctreectrl--getitempartrect.md) method to draw a 3D rectangle around that item. In an earlier section of the code example, which is not shown, we created a tree-view that consists of a root country/region node for the United States, subnodes for the states of Pennsylvania and Washington, and tree items for cities in those states. We used the [CTreeCtrl::MapItemToAccID](../vs140/ctreectrl--mapitemtoaccid.md) method to associate the root tree-view item with an accessibility identifier.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#5](../vs140/codesnippet/CPP/ctreectrl--getitempartrect_2.cpp)]  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TreeView_GetItemPartRect](http://msdn.microsoft.com/library/windows/desktop/bb773847)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)   
 [CTreeCtrl::HitTest](../vs140/ctreectrl--hittest.md)