---
title: "CWnd::OnSysChar"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWnd.OnSysChar
  - CWnd::OnSysChar
  - WM_SYSCHAR
  - OnSysChar
dev_langs: 
  - C++
helpviewer_keywords: 
  - WM_SYSCHAR
  - OnSysChar method
ms.assetid: cbda8967-7756-4c54-8538-b2d1229f68c3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnSysChar
The framework calls this member function if `CWnd` has the input focus and the [WM_SYSKEYUP](../vs140/cwnd--onsyskeyup.md) and [WM_SYSKEYDOWN](../vs140/cwnd--onsyskeydown.md) messages are translated.  
  
## Syntax  
  
```  
  
      afx_msg void OnSysChar(  
   UINT nChar,  
   UINT nRepCnt,  
   UINT nFlags   
);  
```  
  
#### Parameters  
 `nChar`  
 Specifies the ASCII-character key code of a Control-menu key.  
  
 `nRepCnt`  
 Specifies the repeat count (the number of times the keystroke is repeated as a result of the user holding down the key).  
  
 `nFlags`  
 The `nFlags` parameter can have these values:  
  
|Value|Meaning|  
|-----------|-------------|  
|0-15|Specifies the repeat count. The value is the number of times the keystroke is repeated as a result of the user holding down the key..|  
|16-23|Specifies the scan code. The value depends on the original equipment manufacturer (OEM)|  
|24|Specifies whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. The value is 1 if it is an extended key; otherwise, it is 0.|  
|25-28|Used internally by Windows.|  
|29|Specifies the context code. The value is 1 if the ALT key is held down while the key is pressed; otherwise, the value is 0.|  
|30|Specifies the previous key state. The value is 1 if the key is down before the message is sent, or it is 0 if the key is up.|  
|31|Specifies the transition state. The value is 1 if the key is being released, or it is 0 if the key is being pressed.|  
  
## Remarks  
 It specifies the virtual key code of the Control-menu key. (For a list of of standard virtual key codes, see Winuser.h)  
  
 When the context code is 0, `WM_SYSCHAR` can pass the [WM_SYSCHAR](http://msdn.microsoft.com/library/windows/desktop/ms646357) message to the [TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms646373) Windows function, which will handle it as though it were a normal key message instead of a system character-key. This allows accelerator keys to be used with the active window even if the active window does not have the input focus.  
  
 For IBM Enhanced 101- and 102-key keyboards, enhanced keys are the right ALT and the right CTRL keys on the main section of the keyboard; the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the slash (/) and ENTER keys in the numeric keypad. Some other keyboards may support the extended-key bit in `nFlags`.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms646373)   
 [CWnd::OnSysKeyDown](../vs140/cwnd--onsyskeydown.md)   
 [CWnd::OnSysKeyUp](../vs140/cwnd--onsyskeyup.md)   
 [WM_SYSCHAR](http://msdn.microsoft.com/library/windows/desktop/ms646357)