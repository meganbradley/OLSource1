---
title: "CIPAddressCtrl::CreateEx"
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
  - "CIPAddressCtrl.CreateEx"
  - "CIPAddressCtrl::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: d450b924-923e-4d42-b02b-a0855f09d5c9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CIPAddressCtrl::CreateEx
Call this function to create a control (a child window) and associate it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter for [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The IP Address control's style. Apply a combination of window styles. You must include the **WS_CHILD** style because the control must be a child window. See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of windows styles.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead of [Create](../vs140/cipaddressctrl--create.md) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CIPAddressCtrl Class](../vs140/cipaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CIPAddressCtrl::CIPAddressCtrl](../vs140/cipaddressctrl--cipaddressctrl.md)