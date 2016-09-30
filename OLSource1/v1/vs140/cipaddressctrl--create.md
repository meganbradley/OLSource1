---
title: "CIPAddressCtrl::Create"
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
  - "CIPAddressCtrl.Create"
  - "CIPAddressCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 8ef6254c-7594-4d0a-8e73-377c0db85e08
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CIPAddressCtrl::Create
Creates an IP Address Control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The IP Address control's style. Apply a combination of window styles. You must include the **WS_CHILD** style because the control must be a child window. See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of windows styles.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to the IP Address Control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the IP Address Control's parent window. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The IP Address Control's ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object in two steps.  
  
1.  Call the constructor, which creates the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
2.  Call **Create**, which creates the IP Address Control.  
  
 If you want to use extended windows styles with your control, call [CreateEx](../vs140/cipaddressctrl--createex.md) instead of **Create**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CIPAddressCtrl Class](../vs140/cipaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CIPAddressCtrl::CIPAddressCtrl](../vs140/cipaddressctrl--cipaddressctrl.md)