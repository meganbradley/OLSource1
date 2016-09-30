---
title: "CAnimateCtrl::Create"
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
  - "ACS_TRANSPARENT"
  - "CAnimateCtrl.Create"
  - "CAnimateCtrl::Create"
  - "ACS_AUTOPLAY"
  - "ACS_CENTER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "animation controls [C++], styles"
  - "Create method [C++]"
  - "ACS_AUTOPLAY style"
  - "ACS_TRANSPARENT style"
  - "ACS_CENTER style"
ms.assetid: 52cdcfeb-06bf-4b61-ac59-1a44aa55f7d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimateCtrl::Create
Creates an animation control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the animation control's style. Apply any combination of the windows styles described in the Remarks section below and the animation control styles described in [Animation Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb761886) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the animation control's position and size. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the animation control's parent window, usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the animation control's ID.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the animation control and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 Apply the following [window styles](../vs140/window-styles.md) to an animation control.  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
 If you want to use extended windows styles with your animation control, call [CreateEx](../vs140/canimatectrl--createex.md) instead of **Create**.  
  
 In addition to the window styles listed above, you may want to apply one or more of the animation control styles to an animation control. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on [animation control styles](http://msdn.microsoft.com/library/windows/desktop/bb761886).  
  
## Example  
 See the example for [CAnimateCtrl::CAnimateCtrl](../vs140/canimatectrl--canimatectrl.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CAnimateCtrl Class](../vs140/canimatectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAnimateCtrl::CAnimateCtrl](../vs140/canimatectrl--canimatectrl.md)   
 [CAnimateCtrl::Open](../vs140/canimatectrl--open.md)   
 [CAnimateCtrl::Play](../vs140/canimatectrl--play.md)   
 [CAnimateCtrl::Seek](../vs140/canimatectrl--seek.md)