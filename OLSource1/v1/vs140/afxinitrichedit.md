---
title: "AfxInitRichEdit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXWIN/AfxInitRichEdit"
  - "AfxInitRichEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxInitRichEdit function"
ms.assetid: 895c9537-8046-4496-b4fa-01095f1ecfba
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxInitRichEdit
Call this function to initialize the rich edit control (version 1.0) for the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This function is provided for backward compatibility. Applications created with Visual C++ .NET and later use [AfxInitRichEdit2](../vs140/afxinitrichedit2.md).  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loads RICHED32.DLL to initialize version 1.0 of the rich edit control. To use version 2.0 and 3.0 of the rich edit control, RICHED20.DLL needs to be loaded. This is accomplished with a call to [AfxInitRichEdit2](../vs140/afxinitrichedit2.md). If you have dialog resources with the rich edit control created prior to Visual C++ .NET, the rich edit controls are automatically version 1.0. Rich edit controls inserted using the Visual C++ .NET Resource Editor are version 2.0.  
  
 To update rich edit controls in existing Visual C++ applications to version 2.0, open the .RC file as text, change the class name of each rich edit control from "RICHEDIT" to "RichEdit20a". Then replace the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 This function also initializes the common controls library, if the library hasn't already been initialized for the process. If you use the rich edit control directly from your MFC application, you should call this function to assure that MFC has properly initialized the rich edit control runtime. If you call the Create method of [CRichEditCtrl](../vs140/cricheditctrl-class.md), [CRichEditView](../vs140/cricheditview-class.md), or [CRichEditDoc](../vs140/cricheditdoc-class.md), you typically don't need to call this function, but in some cases it might be necessary.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [AfxInitRichEdit2](../vs140/afxinitrichedit2.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)