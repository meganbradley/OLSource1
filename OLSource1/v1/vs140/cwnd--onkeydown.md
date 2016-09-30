---
title: "CWnd::OnKeyDown"
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
  - "WM_KEYDOWN"
  - "CWnd::OnKeyDown"
  - "OnKeyDown"
  - "CWnd.OnKeyDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_KEYDOWN"
  - "OnKeyDown method"
ms.assetid: cdd2592c-9f55-4696-8aca-7efe31b04011
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnKeyDown
The framework calls this member function when a nonsystem key is pressed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the virtual key code of the given key. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Repeat count (the number of times the keystroke is repeated as a result of the user holding down the key).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the scan code, key-transition code, previous key state, and context code, as shown in the following list:  
  
|Value|Description|  
|-----------|-----------------|  
|0–7|Scan code (OEM-dependent value).|  
|8|Extended key, such as a function key or a key on the numeric keypad (1 if it is an extended key).|  
|9–10|Not used.|  
|11–12|Used internally by Windows.|  
|13|Context code (1 if the ALT key is held down while the key is pressed; otherwise 0).|  
|14|Previous key state (1 if the key is down before the call, 0 if the key is up).|  
|15|Transition state (1 if the key is being released, 0 if the key is being pressed).|  
  
 For a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message, the key-transition bit (bit 15) is 0 and the context-code bit (bit 13) is 0.  
  
## Remarks  
 A nonsystem key is a keyboard key that is pressed when the ALT key is not pressed or a keyboard key that is pressed when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has the input focus.  
  
 Because of auto-repeat, more than one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> call may occur before an [OnKeyUp](../vs140/cwnd--onkeyup.md) member function call is made. The bit that indicates the previous key state can be used to determine whether the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> call is the first down transition or a repeated down transition.  
  
 For IBM Enhanced 101- and 102-key keyboards, enhanced keys are the right ALT and the right CTRL keys on the main section of the keyboard; the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the slash (/) and ENTER keys in the numeric keypad. Some other keyboards may support the extended-key bit in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnChar](../vs140/cwnd--onchar.md)   
 [CWnd::OnKeyUp](../vs140/cwnd--onkeyup.md)   
 [WM_KEYDOWN](http://msdn.microsoft.com/library/windows/desktop/ms646280)