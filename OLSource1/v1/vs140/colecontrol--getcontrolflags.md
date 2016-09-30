---
title: "COleControl::GetControlFlags"
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
  - "GetControlFlags"
  - "COleControl.GetControlFlags"
  - "COleControl::GetControlFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControlFlags method"
ms.assetid: 4a469282-7229-47ac-b9ca-66f921c92490
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetControlFlags
Retrieves the control flag settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An ORed combination of the flags in the ControlFlags enumeration:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Remarks  
 By default, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 If set, uses a begin-paint function tailored for OLE controls instead of the [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) API (set by default).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 If not set, disables the call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> made by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and gains a small speed advantage. If you are using windowless activation, the flag has no effect.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 If set, provides mouse interaction while your control is inactive by enabling <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>'s implementation of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interface, which is disabled by default.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 If set, eliminates extra drawing operations and the accompanying visual flicker. Use when your control draws itself identically in the inactive and active states. If you are using windowless activation, the flag has no effect.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 If set, indicates your control uses windowless activation.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 If set, indicates that the control will perform optimized drawing, if the container supports it.  
  
 For more information about <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and other optimizations of OLE controls, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::IntersectClipRect](../vs140/cdc--intersectcliprect.md)   
 [COleControl::SetControlSize](../vs140/colecontrol--setcontrolsize.md)