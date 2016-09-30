---
title: "COleControlSite::ModifyStyle"
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
  - "COleControlSite.ModifyStyle"
  - "COleControlSite::ModifyStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "ModifyStyle method"
ms.assetid: 7858f5b7-6ae6-40a9-9b77-d8f3e6cd5a71
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::ModifyStyle
Modifies the styles of the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The styles to be removed from the current window styles.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The styles to be added from the current window styles.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Window positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if the styles are changed, otherwise zero.  
  
## Remarks  
 The control's stock Enabled property will be modified to match the setting for **WS_DISABLED**. The control's stock Border Style property will be modified to match the requested setting for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. All other styles are applied directly to the control's window handle, if one is present.  
  
 Modifies the window styles of the control. Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about the available window styles.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls the Win32 function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and redraws the window by combining <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with the following four flags:  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Does not activate the window.  
  
 To modify a window's extended styles, call [ModifyStyleEx](../vs140/colecontrolsite--modifystyleex.md).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)