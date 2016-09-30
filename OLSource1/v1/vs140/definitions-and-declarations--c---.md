---
title: "Definitions and Declarations (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 56b809c0-e602-4f18-9ca5-cd7a8fbaaf30
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Definitions and Declarations (C++)
## Microsoft Specific  
 The DLL interface refers to all items (functions and data) that are known to be exported by some program in the system; that is, all items that are declared as **dllimport** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. All declarations included in the DLL interface must specify either the **dllimport** or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute. However, the definition must specify only the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute. For example, the following function definition generates a compiler error:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code also generates an error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, this is correct syntax:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The use of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> implies a definition, while **dllimport** implies a declaration. You must use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to force a declaration; otherwise, a definition is implied. Thus, the following examples are correct:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following examples clarify the preceding:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## See Also  
 [dllexport, dllimport](../vs140/dllexport--dllimport.md)