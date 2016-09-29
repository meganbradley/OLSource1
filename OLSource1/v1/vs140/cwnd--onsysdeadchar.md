---
title: "CWnd::OnSysDeadChar"
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
  - "CWnd::OnSysDeadChar"
  - "WM_SYSDEADCHAR"
  - "CWnd.OnSysDeadChar"
  - "OnSysDeadChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SYSDEADCHAR"
  - "OnSysDeadChar method"
ms.assetid: 70083c9f-15f8-4467-8c53-cfb0dd0711f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSysDeadChar
The framework calls this member function if the `CWnd` object has the input focus when the [OnSysKeyUp](../vs140/cwnd--onsyskeyup.md) or [OnSysKeyDown](../vs140/cwnd--onsyskeydown.md) member function is called.  
  
## Syntax  
  
```  
  
      afx_msg void OnSysDeadChar(  
   UINT nChar,  
   UINT nRepCnt,  
   UINT nFlags   
);  
```  
  
#### Parameters  
 `nChar`  
 Specifies the dead-key character value.  
  
 `nRepCnt`  
 Specifies the repeat count.  
  
 `nFlags`  
 Specifies the scan code, key-transition code, previous key state, and context code, as shown in the following list:  
  
|Value|Meaning|  
|-----------|-------------|  
|0–7|Scan code (OEM-dependent value). Low byte of high-order word.|  
|8|Extended key, such as a function key or a key on the numeric keypad (1 if it is an extended key; otherwise 0).|  
|9–10|Not used.|  
|11–12|Used internally by Windows.|  
|13|Context code (1 if the ALT key is held down while the key is pressed; otherwise 0).|  
|14|Previous key state (1 if the key is down before the call, 0 if the key is up).|  
|15|Transition state (1 if the key is being released, 0 if the key is being pressed).|  
  
## Remarks  
 It specifies the character value of a dead key.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnSysKeyDown](../vs140/cwnd--onsyskeydown.md)   
 [CWnd::OnSysKeyUp](../vs140/cwnd--onsyskeyup.md)   
 [WM_SYSDEADCHAR](http://msdn.microsoft.com/library/windows/desktop/ms646285)   
 [CWnd::OnDeadChar](../vs140/cwnd--ondeadchar.md)