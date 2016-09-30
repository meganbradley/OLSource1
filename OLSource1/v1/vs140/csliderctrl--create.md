---
title: "CSliderCtrl::Create"
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
  - "TBS_HORZ"
  - "TBS_AUTOTICKS"
  - "TBS_RIGHT"
  - "TBS_BOTTOM"
  - "TBS_NOTICKS"
  - "TBS_VERT"
  - "TBS_TOP"
  - "TBS_ENABLESELRANGE"
  - "CSliderCtrl.Create"
  - "CSliderCtrl::Create"
  - "TBS_LEFT"
  - "TBS_BOTH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TBS_BOTTOM constant"
  - "TBS_AUTOTICKS constant"
  - "TBS_HORZ constant"
  - "Create method [C++]"
  - "TBS_LEFT constant"
  - "TBS_TOP constant"
  - "TBS_VERT constant"
  - "TBS_ENABLESELRANGE constant"
  - "TBS_BOTH constant"
  - "TBS_RIGHT constant"
  - "TBS_NOTICKS constant"
ms.assetid: 3702e571-2d57-4b8e-aaad-7d070d7afca0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::Create
Creates a slider control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the slider control's style. Apply any combination of [slider control styles](http://msdn.microsoft.com/library/windows/desktop/bb760147), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], to the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the slider control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the slider control's parent window, usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the slider control's ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the slider control and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 Depending on the values set for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the slider control can have either a vertical or horizontal orientation. It can have tick marks on either side, both sides, or neither. It can also be used to specify a range of consecutive values.  
  
 To apply extended window styles to the slider control, call [CreateEx](../vs140/csliderctrl--createex.md) instead of **Create**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::CSliderCtrl](../vs140/csliderctrl--csliderctrl.md)