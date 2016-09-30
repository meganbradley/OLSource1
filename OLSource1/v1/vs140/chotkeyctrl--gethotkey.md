---
title: "CHotKeyCtrl::GetHotKey"
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
  - "HOTKEYF_EXT"
  - "HOTKEYF_ALT"
  - "HOTKEYF_SHIFT"
  - "GetHotKey"
  - "HOTKEYF_CONTRO"
  - "CHotKeyCtrl.GetHotKey"
  - "CHotKeyCtrl::GetHotKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HOTKEYF_EXT"
  - "HOTKEYF_SHIFT"
  - "HOTKEYF_ALT"
  - "GetHotKey method"
  - "HOTKEYF_CONTRO"
ms.assetid: e8ce71d6-18fc-4ba1-b62b-2e84e1c6944c
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHotKeyCtrl::GetHotKey
Retrieves the virtual key code and modifier flags of a keyboard shortcut from a hot key control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Virtual key code of the keyboard shortcut. For a list of standard virtual key codes, see Winuser.h.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of flags that indicate the modifier keys in the keyboard shortcut.  
  
 The modifier flags are as follows:  
  
|Flag|Corresponding Key|  
|----------|-----------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|ALT key|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|CTRL key|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Extended key|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|SHIFT key|  
  
## Return Value  
 In the first overloaded method, a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that contains the virtual key code and modifier flags. The low-order byte of the low-order word contains the virtual key code, the high-order byte of the low-order word contains the modifier flags, and the high-order word is zero.  
  
## Remarks  
 The virtual key code and the modifier keys together define the keyboard shortcut.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHotKeyCtrl Class](../vs140/chotkeyctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHotKeyCtrl::SetHotKey](../vs140/chotkeyctrl--sethotkey.md)