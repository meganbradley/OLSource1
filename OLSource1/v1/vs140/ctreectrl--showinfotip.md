---
title: "CTreeCtrl::ShowInfoTip"
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
  - "CTreeCtrl.ShowInfoTip"
  - "ShowInfoTip method"
  - "CTreeCtrl::ShowInfoTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowInfoTip method"
ms.assetid: 4595a623-1f96-45c3-9cd6-84a55beceaad
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::ShowInfoTip
Displays the infotip for the specified item in the current tree-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A handle to a tree-view item in the control. For more information, see the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member of the [TVITEMEX](http://msdn.microsoft.com/library/windows/desktop/bb773459) structure.|  
  
## Remarks  
 For more information about the difference between tooltips and infotips, search for the "Tooltips and Infotips" topic at [Microsoft Developer Network](http://go.microsoft.com/fwlink/?LinkId=56322).  
  
 This method sends the [TVM_SHOWINFOTIP](http://msdn.microsoft.com/library/windows/desktop/bb773779) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_SHOWINFOTIP](http://msdn.microsoft.com/library/windows/desktop/bb773779)