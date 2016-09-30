---
title: "IAxWinHostWindowLic::CreateControlLic"
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
  - "IAxWinHostWindowLic.CreateControlLic"
  - "IAxWinHostWindowLic::CreateControlLic"
  - "CreateControlLic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControlLic method"
ms.assetid: 8b19695b-f7e1-4bea-9679-f2f93311b386
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindowLic::CreateControlLic
Creates a licensed control, initializes it, and hosts it in the window identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The BSTR that contains the license key for the control.  
  
## Remarks  
 See [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md) for a description of the remaining parameters and return value.  
  
 Calling this method is equivalent to calling [IAxWinHostWindowLic::CreateControlLicEx](../vs140/iaxwinhostwindowlic--createcontrollicex.md)  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindowLic Interface](../vs140/iaxwinhostwindowlic-interface.md)