---
title: "CTreeCtrl::SetExtendedStyle"
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
  - "SetExtendedStyle method"
  - "CTreeCtrl::SetExtendedStyle"
  - "CTreeCtrl.SetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExtendedStyle method"
ms.assetid: 4769a2db-9dd8-4e54-8b38-ecf77f4b3d4c
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetExtendedStyle
Sets the extended styles for the current tree-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A bitmask that specifies which styles in the current tree-view control are affected by this method. If this parameter is zero, it is ignored and the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is assigned to the tree-view control.\<br />\<br /> Specify zero or a bitwise combination (OR) of styles described in [Tree-View Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb759981).|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A bitmask that specifies which styles in the current tree-view control to set or clear.\<br />\<br /> To set a combination of styles, specify a bitwise combination (OR) of styles described in [Tree-View Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb759981). To clear a set of styles, specify zero.|  
  
## Return Value  
 A value that contains the previous extended control styles.  
  
## Remarks  
 This method clears the styles specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter, then sets the styles specified in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter. Only the extended styles that correspond to the bits in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> change.  
  
 This method sends the [TVM_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb773744) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, that is used to access the current tree-view control. The code example also defines an unsigned integer and several HTREEITEM variables. These variables are used in the next example.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#1](../vs140/codesnippet/CPP/ctreectrl--setextendedstyle_1.h)]  
  
## Example  
 The following code example adds the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> extended style to the current tree-view control. In an earlier section of the code example, which is not shown, we created a tree-view that consists of a root country/region node for the United States, subnodes for the states of Pennsylvania and Washington, and tree items for cities in those states. We intentionally made the tree-view control narrow so that it must automatically scroll to display the tree item that has the focus.  
  
 [!code[NVC_MFC_CTreeCtrl_s1#3](../vs140/codesnippet/CPP/ctreectrl--setextendedstyle_2.cpp)]  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb773744)   
 [CTreeCtrl::GetExtendedStyle](../vs140/ctreectrl--getextendedstyle.md)   
 [Tree-View Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb759981)