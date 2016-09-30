---
title: "CWnd::OnVKeyToItem"
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
  - "CWnd::OnVKeyToItem"
  - "OnVKeyToItem"
  - "CWnd.OnVKeyToItem"
  - "WM_VKEYTOITEM"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_VKEYTOITEM"
  - "OnVKeyToItem method"
ms.assetid: 775623bb-394b-4384-b186-76a775364712
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnVKeyToItem
If the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object owns a list box with the [LBS_WANTKEYBOARDINPUT](../vs140/list-box-styles.md) style, the list box will send the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> message in response to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the virtual key code of the key that the user pressed. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies a pointer to the list box. The pointer may be temporary and should not be stored for later use.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the current caret position.  
  
## Return Value  
 Specifies the action that the application performed in response to the message. A return value of –2 indicates that the application handled all aspects of selecting the item and requires no further action by the list box. A return value of –1 indicates that the list box should perform the default action in response to the keystroke. A return value of 0 or greater specifies the zero-based index of an item in the list box and indicates that the list box should perform the default action for the keystroke on the given item.  
  
## Remarks  
 This member function is called by the framework only for list boxes that have the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnKeyDown](../vs140/cwnd--onkeydown.md)   
 [WM_VKEYTOITEM](http://msdn.microsoft.com/library/windows/desktop/bb761364)