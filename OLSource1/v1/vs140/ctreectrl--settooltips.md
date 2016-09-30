---
title: "CTreeCtrl::SetToolTips"
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
  - "CTreeCtrl::SetToolTips"
  - "CTreeCtrl.SetToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], setting"
  - "SetToolTips method"
ms.assetid: 23980b3b-09cc-4b78-8efa-0eb0d4c13a18
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetToolTips
This member function implements the behavior of the Win32 message [TVM_SETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb773772), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object that the tree control will use.  
  
## Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object containing the tooltip previously used by the control, or **NULL** if no tooltips were used previously.  
  
## Remarks  
 To use tooltips, indicate the **TVS_NOTOOLTIPS** style when you create the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Example  
 See the example for [CTreeCtrl::GetToolTips](../vs140/ctreectrl--gettooltips.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetToolTips](../vs140/ctreectrl--gettooltips.md)   
 [CTreeCtrl::Create](../vs140/ctreectrl--create.md)