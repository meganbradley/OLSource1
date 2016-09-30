---
title: "CWinAppEx::OnViewDoubleClick"
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
  - "CWinAppEx.OnViewDoubleClick"
  - "OnViewDoubleClick"
  - "CWinAppEx::OnViewDoubleClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnViewDoubleClick method"
ms.assetid: 69016ffe-7a82-4ec2-aa16-5be455cfe890
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::OnViewDoubleClick
Calls the user-defined command that is associated with a view when the user double-clicks anywhere within that view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an object derived from the [CView Class](../vs140/cview-class.md).  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The view ID.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the framework finds a command; otherwise false.  
  
## Remarks  
 In order to support custom mouse behavior, you must call this function when you process the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message. This method will execute the command associated with the view ID supplied by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information about custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md)