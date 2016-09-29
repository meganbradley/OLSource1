---
title: "CRichEditView::OnCharEffect"
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
  - "OnCharEffect"
  - "CRichEditView.OnCharEffect"
  - "CRichEditView::OnCharEffect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "OnCharEffect method"
ms.assetid: ccd7cddb-46a3-45e9-8c24-fbda1095e780
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnCharEffect
Call this function to toggle the character formatting effects for the current selection.  
  
## Syntax  
  
```  
  
      void OnCharEffect(  
   DWORD dwMask,  
   DWORD dwEffect   
);  
```  
  
#### Parameters  
 `dwMask`  
 The character formatting effects to modify in the current selection.  
  
 `dwEffect`  
 The desired list of character formatting effects to toggle.  
  
## Remarks  
 Each call to this function toggles the specified formatting effects for the current selection.  
  
 For more information on the `dwMask` and `dwEffect` parameters and their potential values, see the corresponding data members of [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#155](../vs140/codesnippet/CPP/cricheditview--onchareffect_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::SetCharFormat](../vs140/cricheditview--setcharformat.md)