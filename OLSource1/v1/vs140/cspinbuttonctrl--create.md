---
title: "CSpinButtonCtrl::Create"
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
  - "UDS_ALIGNRIGHT"
  - "CSpinButtonCtrl::Create"
  - "UDS_WRAP"
  - "UDS_HORZ"
  - "UDS_AUTOBUDDY"
  - "UDS_SETBUDDYINT"
  - "CSpinButtonCtrl.Create"
  - "UDS_NOTHOUSANDS"
  - "UDS_ALIGNLEFT"
  - "UDS_ARROWKEYS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UDS_ARROWKEYS spin button style"
  - "Create method [C++]"
  - "UDS_WRAP spin button style"
  - "UDS_NOTHOUSANDS spin button style"
  - "UDS_HORZ spin button style"
  - "UDS_ALIGNRIGHT spin button style"
  - "UDS_ALIGNLEFT spin button style"
  - "UDS_AUTOBUDDY spin button style"
  - "UDS_SETBUDDYINT spin button style"
ms.assetid: 1afdd778-d502-4b5f-a7ec-64e3449c0ff3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::Create
Creates a spin button control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object..  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the spin button control's style. Apply any combination of spin button control styles to the control. These styles are described in [Up-Down Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb759885) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the spin button control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the spin button control's parent window, usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the spin button control's ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object in two steps First, call the constructor, and then call **Create**, which creates the spin button control and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 To create a spin button control with extended window styles, call [CSpinButtonCtrl::CreateEx](../vs140/cspinbuttonctrl--createex.md) instead of **Create**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::CSpinButtonCtrl](../vs140/cspinbuttonctrl--cspinbuttonctrl.md)