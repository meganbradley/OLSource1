---
title: "CAnimateCtrl::CreateEx"
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
  - "CAnimateCtrl::CreateEx"
  - "CAnimateCtrl.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: ae2aae3d-6582-4410-92fa-692163ca3460
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimateCtrl::CreateEx
Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter for [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the animation control's style. Apply any combination of the window and animation control styles described in [Animation Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb761886) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead of [Create](../vs140/canimatectrl--create.md) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CAnimateCtrl Class](../vs140/canimatectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAnimateCtrl::CAnimateCtrl](../vs140/canimatectrl--canimatectrl.md)   
 [CAnimateCtrl::Open](../vs140/canimatectrl--open.md)   
 [CAnimateCtrl::Play](../vs140/canimatectrl--play.md)   
 [CAnimateCtrl::Seek](../vs140/canimatectrl--seek.md)