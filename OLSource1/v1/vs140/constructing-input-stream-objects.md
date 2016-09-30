---
title: "Constructing Input Stream Objects"
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
  - "input stream objects"
ms.assetid: ab94866e-6ffe-4f15-b4db-0bd23e636075
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constructing Input Stream Objects
If you use only the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, you do not need to construct an input stream. You must construct an input stream if you use:  
  
-   [Input File Stream Constructors](#vclrfinputfilestreamconstructorsanchor8)  
  
-   [Input String Stream Constructors](#vclrfinputstringstreamconstructorsanchor9)  
  
##  \<a name="vclrfinputfilestreamconstructorsanchor8">\</a> Input File Stream Constructors  
 There are two ways to create an input file stream:  
  
-   Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument constructor, then call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Specify a filename and mode flags in the constructor invocation, thereby opening the file during the construction process:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="vclrfinputstringstreamconstructorsanchor9">\</a> Input String Stream Constructors  
 Input string stream constructors require the address of preallocated, preinitialized storage:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Input Streams](../vs140/input-streams.md)