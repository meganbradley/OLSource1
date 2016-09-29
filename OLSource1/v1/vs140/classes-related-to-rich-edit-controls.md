---
title: "Classes Related to Rich Edit Controls"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rich edit controls, and CRichEditItem"
  - "CRichEditCtrl class, related classes"
  - "CRichEditDoc class, Rich Edit controls"
  - "rich edit controls, classes related to"
  - "classes [C++], related to rich edit controls"
  - "rich edit controls, and CRichEditView"
  - "CRichEditCtrlItem class and CRichEditCtrl"
  - "rich edit controls, and CRichEditDoc"
  - "CRichEditView class, and CRichEditCtrl"
ms.assetid: 4b31c2cc-6ea1-4146-b7c5-b0b5b419f14d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes Related to Rich Edit Controls
The [CRichEditView](../vs140/cricheditview-class.md), [CRichEditDoc](../vs140/cricheditdoc-class.md), and [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) classes provide the functionality of the rich edit control ([CRichEditCtrl](../vs140/cricheditctrl-class.md)) within the context of MFC's document/view architecture. `CRichEditView` maintains the text and formatting characteristic of text. `CRichEditDoc` maintains the list of OLE client items that are in the view. `CRichEditCntrItem` provides container-side access to the OLE client item. To modify the contents of a `CRichEditView`, use [CRichEditView::GetRichEditCtrl](../vs140/cricheditview--getricheditctrl.md) to access the underlying rich edit control.  
  
## See Also  
 [Using CRichEditCtrl](../vs140/using-cricheditctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)