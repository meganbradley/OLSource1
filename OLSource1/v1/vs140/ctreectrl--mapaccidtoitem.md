---
title: "CTreeCtrl::MapAccIdToItem"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTreeCtrl::MapAccIdToItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - MapAccIdToItem method
ms.assetid: 67d67d8f-b887-4746-8d4c-43b1449d7273
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::MapAccIdToItem
Maps the specified accessibility identifier to the handle of a tree-view item in the current tree-view control.  
  
## Syntax  
  
```  
HTREEITEM MapAccIdToItem(  
          UINT uAccId  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `uAccId`|An accessibility identifier for an element in the tree-view item.|  
  
## Return Value  
 The handle to a tree-view item (`HTREEITEM`) that corresponds to the `uAccId` parameter. For more information, see the `hItem` member of the [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure.  
  
## Remarks  
 Accessibility aids are applications that help people with disabilities use computers. An accessibility identifier is used by the `IAccessible` interface to uniquely specify an element in a window. For more information about accessibility identifiers, search for the "About Active Accessibility Support" topic at [Microsoft Developer Network](http://go.microsoft.com/fwlink/?LinkId=56322).  
  
 This method sends the [TVM_MAPACCIDTOHTREEITEM](http://msdn.microsoft.com/library/windows/desktop/bb773734) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_treeCtrl`, that is used to access the current tree-view control. The code example also defines an unsigned integer and several HTREEITEM variables. These variables are used in the next example.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#1](../vs140/codesnippet/CPP/ctreectrl--mapaccidtoitem_1.h)]
  
  
## Example  
 The following code example uses an accessibility identifier and the [CTreeCtrl::MapAccIdToItem](../vs140/ctreectrl--mapaccidtoitem.md) method to retrieve a handle to the root tree-view item. The example uses the handle and the [CTreeCtrl::GetItemPartRect](../vs140/ctreectrl--getitempartrect.md) method to draw a 3D rectangle around that item. In an earlier section of the code example, which is not shown, we created a tree-view that consists of a root country/region node for the United States, subnodes for the states of Pennsylvania and Washington, and tree items for cities in those states. We used the [CTreeCtrl::MapItemToAccID](../vs140/ctreectrl--mapitemtoaccid.md) method to associate the root tree-view item with an accessibility identifier.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#5](../vs140/codesnippet/CPP/ctreectrl--mapaccidtoitem_2.cpp)]
  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_MAPACCIDTOHTREEITEM](http://msdn.microsoft.com/library/windows/desktop/bb773734)   
 [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459)   
 [CTreeCtrl::MapItemToAccID](../vs140/ctreectrl--mapitemtoaccid.md)