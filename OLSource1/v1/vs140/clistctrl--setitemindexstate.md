---
title: "CListCtrl::SetItemIndexState"
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
  - "SetItemIndexState method"
  - "CListCtrl::SetItemIndexState"
  - "CListCtrl.SetItemIndexState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemIndexState method"
ms.assetid: ec2ebe55-4dfc-4899-8aba-8752a7de51ae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItemIndexState
Sets the state of an item in the current list-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to an [LVITEMINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774762) structure that describes an item. The caller is responsible for allocating this structure and setting its members.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The state to set the item, which is a bitwise combination of [list view item states](http://msdn.microsoft.com/library/windows/desktop/bb774733). Specify zero to reset, or one to set, a state.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A mask of the valid bits of the state specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. Specify a bitwise combination (OR) of [list view item states](http://msdn.microsoft.com/library/windows/desktop/bb774733).|  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 For more information about the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter, see [List View Item States](http://msdn.microsoft.com/library/windows/desktop/bb774733).  
  
 For more information about the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter, see the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member of the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure.  
  
 This method sends the [LVM_SETITEMINDEXSTATE](http://msdn.microsoft.com/library/windows/desktop/bb761190) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_SETITEMINDEXSTATE](http://msdn.microsoft.com/library/windows/desktop/bb761190)   
 [LVITEMINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774762)   
 [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760)   
 [List View Item States](http://msdn.microsoft.com/library/windows/desktop/bb774733)