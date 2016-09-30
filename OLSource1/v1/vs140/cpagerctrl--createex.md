---
title: "CPagerCtrl::CreateEx"
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
  - "CPagerCtrl::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 16903d15-461d-4e48-926a-3c2ff49fca1a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::CreateEx
Creates a pager control with specified extended styles and attaches it to the current <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A bitwise combination of extended styles to be applied to the control. For more information, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter of the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function.|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A bitwise combination (OR) of [window styles](../vs140/window-styles.md) and [pager control styles](http://msdn.microsoft.com/library/windows/desktop/bb760859) to be applied to the control.|  
|[in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that contains the position and size of the control in client coordinates.|  
|[in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the control. This parameter cannot be <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The ID of the control.|  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 To create a pager control, declare a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable, then call the [CPagerCtrl::Create](../vs140/cpagerctrl--create.md) or [CPagerCtrl::CreateEx](../vs140/cpagerctrl--createex.md) method on that variable.  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859)   
 [Window Styles](../vs140/window-styles.md)