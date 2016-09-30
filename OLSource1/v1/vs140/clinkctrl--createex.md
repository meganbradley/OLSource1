---
title: "CLinkCtrl::CreateEx"
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
  - "CLinkCtrl::CreateEx"
  - "CLinkCtrl.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 22b553e3-342a-4c6d-9043-c6e67bb57277
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::CreateEx
Creates a link control with extended styles and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a zero-terminated string that contains the marked up text to display. For more information, see the section "Markup and Link Access" in the topic [Overview of SysLink Controls](http://msdn.microsoft.com/library/windows/desktop/bb760706) in the [MSDN Library](http://go.microsoft.com/fwlink/?linkid=556).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the extended style of the link control. For a list of extended Windows styles, see the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter for [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the link control's style. Apply any combination of control styles. For more information, see [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the link control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the link control's parent window. It must not be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the link control's ID.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if initialization was successful; otherwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instead of [Create](../vs140/clinkctrl--create.md) to apply extended Windows style constants.  
  
 The second form of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method is deprecated. Use the first form that specifies the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::Create](../vs140/clinkctrl--create.md)