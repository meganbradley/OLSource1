---
title: "Constructing Output Stream Objects"
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
  - "output stream objects"
ms.assetid: 93c8eab6-610c-4f48-b76d-1d960cac7641
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constructing Output Stream Objects
If you use only the predefined <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects, you do not need to construct an output stream. You must use constructors for:  
  
-   [Output File Stream Constructors](#vclrfoutputfilestreamconstructorsanchor1)  
  
-   [Output String Stream Constructors](#vclrfoutputstringstreamconstructorsanchor2)  
  
##  \<a name="vclrfoutputfilestreamconstructorsanchor1">\</a> Output File Stream Constructors  
 You can construct an output file stream in one of two ways:  
  
-   Use the default constructor, and then call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Specify a filename and mode flags in the constructor call.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="vclrfoutputstringstreamconstructorsanchor2">\</a> Output String Stream Constructors  
 To construct an output string stream, you can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the following way:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> "manipulator" adds the necessary terminating null character to the string.  
  
## See Also  
 [Output Streams](../vs140/output-streams.md)