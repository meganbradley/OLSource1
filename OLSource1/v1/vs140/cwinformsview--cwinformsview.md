---
title: "CWinFormsView::CWinFormsView"
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
  - "CWinFormsView::CWinFormsView"
  - "CWinFormsView.CWinFormsView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinFormsView class, constructors"
ms.assetid: 03125327-4cec-4d3e-9af2-cf3159bfc627
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsView::CWinFormsView
Constructs a `CWinFormsView` object.  
  
## Syntax  
  
```  
CWinFormsView(  
   System::Type^ pManagedViewType  
);  
```  
  
#### Parameters  
 `pManagedViewType`  
 A pointer to the data type of the Windows Forms user control. For more information, see <xref:System.Type*?displayProperty=fullName>.  
  
## Example  
 In the following example, the `CUserView` class inherits from `CWinFormsView` and passes the type of `UserControl1` to the `CWinFormsView` constructor. `UserControl1` is a custom-built control in ControlLibrary1.dll.  
  
 [!CODE [NVC_MFC_Managed#1](NVC_MFC_Managed#1)]  
  
 [!CODE [NVC_MFC_Managed#2](NVC_MFC_Managed#2)]  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsView Overview](../vs140/cwinformsview-class.md)