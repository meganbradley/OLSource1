---
title: "COleControl::IsInvokeAllowed"
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
  - "COleControl.IsInvokeAllowed"
  - "IsInvokeAllowed"
  - "COleControl::IsInvokeAllowed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsInvokeAllowed method"
  - "OLE controls, as automation server"
ms.assetid: c4747246-d411-4a7b-92c2-e0a9784089b2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::IsInvokeAllowed
Enables automation method invocation.  
  
## Syntax  
  
```  
  
      BOOL IsInvokeAllowed(  
   DISPID dispid   
);  
```  
  
## Return Value  
 Nonzero if the control has been initialized; otherwise 0.  
  
## Remarks  
 The framework's implementation of **IDispatch::Invoke** calls **IsInvokeAllowed** to determine if a given function (identified by `dispid`) may be invoked. The default behavior for an OLE control is to allow automation methods to be invoked only if the control has been initialized; however, **IsInvokeAllowed** is a virtual function and may be overridden if necessary (for example, when the control is being used as an automation server). For more information, see Knowledge Base article Q166472, "HOWTO: Use an OLE Control as an Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::IsInvokeAllowed](../vs140/ccmdtarget--isinvokeallowed.md)