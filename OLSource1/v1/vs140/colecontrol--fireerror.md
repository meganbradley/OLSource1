---
title: "COleControl::FireError"
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
  - "COleControl::FireError"
  - "FireError"
  - "COleControl.FireError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireError method"
ms.assetid: 9ad37e04-29d4-4b58-b081-a81549c75422
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireError
Fires the stock Error event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *scode*  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The description of the error being reported.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The Help ID of the error being reported.  
  
## Remarks  
 This event provides a way of signalling, at appropriate places in your code, that an error has occurred within your control. Unlike other stock events, such as Click or MouseMove, Error is never fired by the framework.  
  
 To report an error that occurs during a property get function, property set function, or automation method, call [COleControl::ThrowError](../vs140/colecontrol--throwerror.md).  
  
 The implementation of an OLE control's Stock Error event uses an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value. If your control uses this event, and is intended to be used in Visual Basic 4.0, you will receive errors because the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value is not supported in Visual Basic.  
  
 To fix this, manually change the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter in the control's .ODL file to a **long**. In addition, any custom event, method, or property that uses an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter also causes the same problem.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DisplayError](../vs140/colecontrol--displayerror.md)