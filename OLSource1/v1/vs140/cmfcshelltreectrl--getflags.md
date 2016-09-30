---
title: "CMFCShellTreeCtrl::GetFlags"
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
  - "CMFCShellTreeCtrl.GetFlags"
  - "GetFlags"
  - "CMFCShellTreeCtrl::GetFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFlags method"
ms.assetid: bb3208fc-1b0f-4391-af4b-1328ff6747fd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellTreeCtrl::GetFlags
Returns the flags set for the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value that specifies the combination of flags currently set.  
  
## Remarks  
 The flags set in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are sent to the method [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066) whenever the object is refreshed. You can change the flags with the [CMFCShellTreeCtrl::SetFlags](../vs140/cmfcshelltreectrl--setflags.md) method.  
  
## Requirements  
 **Header:** afxshelltreectrl.h  
  
## See Also  
 [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCShellTreeCtrl::SetFlags](../vs140/cmfcshelltreectrl--setflags.md)