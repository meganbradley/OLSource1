---
title: "CEditView::OnReplaceAll"
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
  - "CEditView.OnReplaceAll"
  - "OnReplaceAll"
  - "CEditView::OnReplaceAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace button"
  - "CEditView class, overridables"
  - "OnReplaceAll method"
ms.assetid: 9da3567b-4a1a-4497-8507-95a97379a718
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::OnReplaceAll
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> when the user selects the Replace All button in the standard Replace dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The text to replace the search text.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> searches the text in the buffer for the text specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, with case sensitivity specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The search starts at the beginning of the current selection. Each time the search text is found, this function replaces that occurrence of the text with the text specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The search is accomplished through a call to [FindText](../vs140/ceditview--findtext.md). In the default implementation, [OnTextNotFound](../vs140/ceditview--ontextnotfound.md) is called if the text is not found.  
  
 If the current selection does not match <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the selection is updated to the first occurrence of the text specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and a replace is not performed. This allows the user to confirm that this is what they want to do when the selection does not match the text to be replaced.  
  
 Override <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to change the way a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-derived object replaces text.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::OnFindNext](../vs140/ceditview--onfindnext.md)   
 [CEditView::OnTextNotFound](../vs140/ceditview--ontextnotfound.md)   
 [CEditView::FindText](../vs140/ceditview--findtext.md)   
 [CEditView::OnReplaceSel](../vs140/ceditview--onreplacesel.md)