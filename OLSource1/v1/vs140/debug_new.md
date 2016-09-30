---
title: "DEBUG_NEW"
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
  - "DEBUG_NEW"
  - "AFX/DEBUG_NEW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DEBUG_NEW macro"
ms.assetid: 9b379344-4093-4bec-a3eb-e0d8a63ada9d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DEBUG_NEW
Assists in finding memory leaks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> everywhere in your program that you would ordinarily use the **new** operator to allocate heap storage.  
  
 In debug mode (when the **_DEBUG** symbol is defined), <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keeps track of the filename and line number for each object that it allocates. Then, when you use the [CMemoryState::DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md) member function, each object allocated with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is shown with the filename and line number where it was allocated.  
  
 To use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, insert the following directive into your source files:  
  
 [!code[NVC_MFCCObjectSample#14](../vs140/codesnippet/CPP/debug_new_1.cpp)]  
  
 Once you insert this directive, the preprocessor will insert <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> wherever you use **new**, and MFC does the rest. When you compile a release version of your program, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> resolves to a simple **new** operation, and the filename and line number information are not generated.  
  
> [!NOTE]
>  In previous versions of MFC (4.1 and earlier) you needed to put the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement after all statements that called the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macros. This is no longer necessary.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [MFC Debugging Techniques](../vs140/mfc-debugging-techniques.md)