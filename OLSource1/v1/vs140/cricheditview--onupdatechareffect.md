---
title: "CRichEditView::OnUpdateCharEffect"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnUpdateCharEffect
  - CRichEditView::OnUpdateCharEffect
  - CRichEditView.OnUpdateCharEffect
dev_langs: 
  - C++
helpviewer_keywords: 
  - CRichEditView class, operations
  - OnUpdateCharEffect method
ms.assetid: a0f45929-ce0e-4a33-9457-836772fac2b3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditView::OnUpdateCharEffect
The framework calls this function to update the command UI for character effect commands.  
  
## Syntax  
  
```  
  
      void OnUpdateCharEffect(  
   CCmdUI* pCmdUI,  
   DWORD dwMask,  
   DWORD dwEffect   
);  
```  
  
#### Parameters  
 `pCmdUI`  
 Pointer to a [CCmdUI](../vs140/ccmdui-class.md) object.  
  
 `dwMask`  
 Indicates the character formatting mask.  
  
 `dwEffect`  
 Indicates the character formatting effect.  
  
## Remarks  
 The mask `dwMask` specifies which character formatting attributes to check. The flags `dwEffect` list the character formatting attributes to set/clear.  
  
 For more information on the `dwMask` and `dwEffect` parameters and their potential values, see the corresponding data members of [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#158](../vs140/codesnippet/CPP/cricheditview--onupdatechareffect_1.cpp)]
  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)