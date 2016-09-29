---
title: "CWnd::OnCharToItem"
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
  - "CWnd::OnCharToItem"
  - "OnCharToItem"
  - "CWnd.OnCharToItem"
  - "WM_CHARTOITEM"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCharToItem method"
  - "WM_CHARTOITEM"
ms.assetid: 91f0708c-396b-4944-b0ca-19952c1c5c43
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCharToItem
Called when a list box with the [LBS_WANTKEYBOARDINPUT](../vs140/list-box-styles.md) style sends its owner a [WM_CHARTOITEM](http://msdn.microsoft.com/library/windows/desktop/bb761358) message in response to a [WM_CHAR](../vs140/cwnd--onchar.md) message.  
  
## Syntax  
  
```  
  
      afx_msg int OnCharToItem(  
   UINT nChar,  
   CListBox* pListBox,  
   UINT nIndex   
);  
```  
  
#### Parameters  
 `nChar`  
 Specifies the value of the key pressed by the user.  
  
 `pListBox`  
 Specifies a pointer to the list box. It may be temporary.  
  
 `nIndex`  
 Specifies the current caret position.  
  
## Return Value  
 The framework calls this member function to specify the action that the application performed in response to the call. A return value of –2 indicates that the application handled all aspects of selecting the item and wants no further action by the list box. A return value of –1 indicates that the list box should perform the default action in response to the keystroke. A return value of 0 or greater specifies the zero-based index of an item in the list box and indicates that the list box should perform the default action for the keystroke on the given item.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnChar](../vs140/cwnd--onchar.md)   
 [WM_CHARTOITEM](http://msdn.microsoft.com/library/windows/desktop/bb761358)