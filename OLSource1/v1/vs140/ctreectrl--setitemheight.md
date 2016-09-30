---
title: "CTreeCtrl::SetItemHeight"
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
  - "CTreeCtrl::SetItemHeight"
  - "CTreeCtrl.SetItemHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemHeight method"
ms.assetid: ff7d5104-cacc-4395-84eb-cb266d5b76cc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetItemHeight
This member function implements the behavior of the Win32 message [TVM_SETITEMHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb773761), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new height of every item in the tree view, in pixels. If this argument is less than the height of the images, then it will be set to the height of the images. If this argument is not even, it will be rounded down to the nearest even value. If this argument is -1, the control will revert to using its default item height.  
  
## Return Value  
 The previous height of the items, in pixels.  
  
## Example  
 See the example for [CTreeCtrl::GetItemHeight](../vs140/ctreectrl--getitemheight.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItemHeight](../vs140/ctreectrl--getitemheight.md)