---
title: "CHotKeyCtrl::Create"
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
  - "CHotKeyCtrl.Create"
  - "CHotKeyCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 6e08916c-a0bd-4905-9ddd-9c90d768e30e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHotKeyCtrl::Create
Creates a hot key control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the hot key control's style. Apply any combination of control styles. See [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the hot key control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the hot key control's parent window, usually a [CDialog](../vs140/cdialog-class.md). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the hot key control's ID.  
  
## Return Value  
 Nonzero, if initialization was successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which creates the hot key control and attaches it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 If you want to use extended windows styles with your control, call [CreateEx](../vs140/chotkeyctrl--createex.md) instead of **Create**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHotKeyCtrl Class](../vs140/chotkeyctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHotKeyCtrl::CHotKeyCtrl](../vs140/chotkeyctrl--chotkeyctrl.md)