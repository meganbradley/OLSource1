---
title: "VSCT Samples in C# and C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSCT files, samples"
ms.assetid: 3218584b-c619-487c-9486-514b04937020
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSCT Samples in C# and C++
VSCT has become the new way of defining commands. Because of this, a change has occurred in how the VSCT samples are compiled in C# and C++. Commands are now defined in C++ with external files and in C# with a Symbols section in the .vsct file.  
  
## Defining Commands  
  
### C++ External Files  
 In the C++ samples, the VSCT compiler includes external files to define constants used inside the definitions of your commands. The way to include these files and thereby define the constants in the definitions of your commands is to add an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag inside the .vsct file and specify the name of the external file references inside the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute. These files are:  
  
-   Guids.h  
  
-   CommandIDs.h  
  
-   Resources.h  
  
 The following snippet from a C++ .vsct file demonstrates how to include these files:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
### C# Symbols  
 In the C# samples, the .vsct file has a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section in the file itself to define commands. The definition of symbols in a .vsct file in C# stems from the way the IDs of the elements are defined by the command table. The following is a snippet from a C# .vsct file that specifies commands and constants associated with them:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Embedding Bitmaps  
  
### C#  
 Bitmaps in C++ and C# CTO binaries are stored externally on disk. The bitmap id is defined in a way so that the definition must provide a GUID attribute for the bitmap, a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attribute of the bitmap strip containing the bitmaps, and then the numeric ids of the elements used inside a button definition (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> attribute). An important aspect of this declaration is that the element id must be the actual index (1-based) of the bitmap inside the bitmap strip.  
  
 In the following example a bitmap strip is included that contains only one element. The ID for this element is defined as guidMenuAndCommandsCmdSet:bmpArrow, so bmpArrow must be defined as 1. It is also the declaration of the bitmap.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)