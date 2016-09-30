---
title: "novtable"
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
  - "novtable"
  - "novtable_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "novtable __declspec keyword"
  - "__declspec keyword [C++], novtable"
ms.assetid: cfef09c5-8c1e-4b14-8a72-7d726ded4484
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# novtable
## Microsoft Specific  
 This is a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> extended attribute.  
  
 This form of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can be applied to any class declaration, but should only be applied to pure interface classes, that is, classes that will never be instantiated on their own. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> stops the compiler from generating code to initialize the vfptr in the constructor(s) and destructor of the class. In many cases, this removes the only references to the vtable that are associated with the class and, thus, the linker will remove it. Using this form of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can result in a significant reduction in code size.  
  
 If you attempt to instantiate a class marked with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and then access a class member, you will receive an access violation (AV).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **In Y**   
## END Microsoft Specific  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)