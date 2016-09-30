---
title: "CTabCtrl::SetExtendedStyle"
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
  - "CTabCtrl::SetExtendedStyle"
  - "CTabCtrl.SetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExtendedStyle method"
  - "extended styles"
ms.assetid: 35d16be9-0a4f-4ed2-81e7-d1b9520e7606
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetExtendedStyle
Sets the extended styles for a tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Value specifying a combination of tab control extended styles.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value that indicates which styles in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are to be affected. Only the extended styles in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be changed. All other styles will be maintained as is. If this parameter is zero, then all of the styles in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will be affected.  
  
## Return Value  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value that contains the previous [tab control extended styles](http://msdn.microsoft.com/library/windows/desktop/bb760546), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 This member function implements the behavior of the Win32 message [TCM_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb760627), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::GetExtendedStyle](../vs140/ctabctrl--getextendedstyle.md)   
 [CTabCtrl::CreateEx](../vs140/ctabctrl--createex.md)