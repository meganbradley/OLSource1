---
title: "CHtmlEditCtrlBase::Set2DPosition"
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
  - "CHtmlEditCtrlBase.Set2DPosition"
  - "CHtmlEditCtrlBase::Set2DPosition"
  - "Set2DPosition"
  - "CHtmlEditCtrlBase<T>.Set2DPosition"
  - "CHtmlEditCtrlBase<T>::Set2DPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Set2DPosition method"
ms.assetid: 76e1707e-90f8-4652-b799-08f05903b5f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Set2DPosition
Allows absolutely positioned elements to be moved by dragging.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If true, absolutely positioned elements can be moved by dragging.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_2D_POSITION command ID](https://msdn.microsoft.com/en-us/library/aa769887.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)