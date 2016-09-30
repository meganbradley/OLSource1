---
title: "selectany"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "selectany_cpp"
  - "selectany"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], selectany"
  - "selectany __declspec keyword"
ms.assetid: 9c353017-5a42-4f50-b741-bd13da1ce84d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# selectany
**Microsoft Specific**  
  
 Tells the compiler that the declared global data item (variable or object) is a pick-any COMDAT (a packaged function).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 At link time, if multiple definitions of a COMDAT are seen, the linker picks one and discards the rest. If the linker option [/OPT:REF](../vs140/-opt--optimizations-.md) (Optimizations) is selected, then COMDAT elimination will occur to remove all the unreferenced data items in the linker output.  
  
 Constructors and assignment by global function or static methods in the declaration do not create a reference and will not prevent /OPT:REF elimination. Side effects from such code should not be depended on when no other references to the data exist.  
  
 For dynamically initialized, global objects, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will discard an unreferenced object's initialization code, as well.  
  
 A global data item can normally be initialized only once in an EXE or DLL project. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used in initializing global data defined by headers, when the same header appears in more than one source file. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is available in both the C and C++ compilers.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can only be applied to the actual initialization of global data items that are externally visible.  
  
## Example  
 This code shows how to use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This code shows how to use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute to ensure data COMDAT folding when you also use the [/OPT:ICF](../vs140/-opt--optimizations-.md) linker option. Note that data must be marked with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and placed in a **const** (readonly) section. You must explicitly specify the read-only section.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)