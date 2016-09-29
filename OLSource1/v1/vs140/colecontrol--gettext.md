---
title: "COleControl::GetText"
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
  - "COleControl::GetText"
  - "COleControl.GetText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetText method"
ms.assetid: 585d8d5c-30bb-4361-9621-b8b5de63b3fa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetText
Implements the Get function of the stock Text or Caption property.  
  
## Syntax  
  
```  
  
BSTR GetText( );  
```  
  
## Return Value  
 The current value of the control text string or a zero-length string if no string is present.  
  
> [!NOTE]
>  For more information on the `BSTR` data type, see [Data Types](../vs140/data-types--mfc-.md) in the Macros and Globals section.  
  
## Remarks  
 Note that the caller of this function must call `SysFreeString` on the string returned in order to free the resource. Within the implementation of the control, use `InternalGetText` to access the control's stock Text or Caption property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::InternalGetText](../vs140/colecontrol--internalgettext.md)   
 [COleControl::SetText](../vs140/colecontrol--settext.md)