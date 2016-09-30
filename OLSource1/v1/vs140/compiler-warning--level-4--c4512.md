---
title: "Compiler Warning (level 4) C4512"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4512"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4512"
ms.assetid: afb68995-684a-4be5-a73a-38d7a16dc030
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4512
'class' : assignment operator could not be generated  
  
 The compiler cannot generate an assignment operator for the given class. No assignment operator was created.  
  
 An assignment operator for the base class that is not accessible by the derived class can cause this warning.  
  
 To avoid this warning, specify a user-defined assignment operator for the class.  
  
 The compiler will also generate an assignment operator function for a class that does not define one. This assignment operator is a memberwise copy of the data members of an object. Because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data items cannot be modified after initialization, if the class contains a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> item, the default assignment operator would not work. Another cause of the C4512 warning is a declaration of a nonstatic data member of reference type. If the intent is to create a non-copyable type, you must also prevent the creation of a default copy constructor.  
  
 You can resolve the C4512 warning for your code in one of three ways:  
  
-   Explicitly define an assignment operator for the class.  
  
-   Remove **const** or the reference operator from the data item in the class.  
  
-   Use the #pragma [warning](../vs140/warning.md) statement to suppress the warning.  
  
## Example  
 The following sample generates C4512.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>