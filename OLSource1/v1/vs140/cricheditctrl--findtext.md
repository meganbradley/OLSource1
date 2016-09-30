---
title: "CRichEditCtrl::FindText"
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
  - "FR_WHOLEWORD"
  - "FR_MATCHCASE"
  - "CRichEditCtrl::FindText"
  - "CRichEditCtrl.FindText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindText method"
  - "FR_WHOLEWORD"
  - "FR_MATCHCASE"
ms.assetid: d7eee081-412d-4def-a583-3bf0c48cb5e1
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::FindText
Finds text within the rich edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For a list of possible values, see <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [EM_FINDTEXTEXT](http://msdn.microsoft.com/library/windows/desktop/bb788011) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *pFindText*  
 Pointer to the [FINDTEXTEX](http://msdn.microsoft.com/library/windows/desktop/bb787909) structure giving the parameters for the search and returning the range where the match was found.  
  
## Return Value  
 Zero-based character position of the next match; – 1 if there are no more matches.  
  
## Remarks  
 You can search either up or down by setting the proper range parameters in the [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure within the **FINDTEXTEX** structure.  
  
 For more information, see [EM_FINDTEXTEX](http://msdn.microsoft.com/library/windows/desktop/bb788011) message and [FINDTEXTEX](http://msdn.microsoft.com/library/windows/desktop/bb787909) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#9](../vs140/codesnippet/CPP/cricheditctrl--findtext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetSel](../vs140/cricheditctrl--setsel.md)