---
title: "Clipboard Operations in Rich Edit Controls"
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
  - "pasting Clipboard data"
  - "CRichEditCtrl class, paste operation"
  - "cut operation in CRichEditCtrl class"
  - "CRichEditCtrl class, Clipboard operations"
  - "copy operations in rich edit controls"
  - "Clipboard, operations in CRichEditCtrl"
  - "rich edit controls, Clipboard operations"
ms.assetid: 15ce66bc-2636-4a35-a2ae-d52285dc1af6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Clipboard Operations in Rich Edit Controls
Your application can paste the contents of the Clipboard into a rich edit control ([CRichEditCtrl](../vs140/cricheditctrl-class.md)) using either the best available Clipboard format or a specific Clipboard format. You can also determine whether a rich edit control is capable of pasting a Clipboard format.  
  
 You can copy or cut the contents of the current selection by using the [Copy](../vs140/cricheditctrl--copy.md) or [Cut](../vs140/cricheditctrl--cut.md) member function. Similarly, you can paste the contents of the Clipboard into a rich edit control by using the [Paste](../vs140/cricheditctrl--paste.md) member function. The control pastes the first available format that it recognizes, which presumably is the most descriptive format.  
  
 To paste a specific Clipboard format, you can use the [PasteSpecial](../vs140/cricheditctrl--pastespecial.md) member function. This function is useful for applications with a Paste Special command that enables the user to select the Clipboard format. You can use the [CanPaste](../vs140/cricheditctrl--canpaste.md) member function to determine whether a given format is recognized by the control.  
  
 You can also use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to determine whether any available Clipboard format is recognized by a rich edit control. This function is useful in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> handler. An application might enable or gray its Paste command depending on whether the control can paste any available format.  
  
 Rich edit controls register two Clipboard formats: rich-text format and a format called RichEdit Text and Objects. An application can register these formats by using the [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function, specifying the **CF_RTF** and **CF_RETEXTOBJ** values.  
  
## See Also  
 [Using CRichEditCtrl](../vs140/using-cricheditctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)