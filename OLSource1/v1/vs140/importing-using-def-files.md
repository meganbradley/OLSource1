---
title: "Importing Using DEF Files"
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
  - "importing DLLs [C++], DEF files"
  - "def files [C++], importing with"
  - ".def files [C++], importing with"
  - "dllimport attribute [C++], DEF files"
  - "DLLs [C++], DEF files"
ms.assetid: aefdbf50-f603-488a-b0d7-ed737bae311d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Importing Using DEF Files
If you choose to use **__declspec(dllimport)** along with a .def file, you should change the .def file to use DATA in place of CONSTANT to reduce the likelihood that incorrect coding will cause a problem:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table shows why.  
  
|Keyword|Emits in the import library|Exports|  
|-------------|---------------------------------|-------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
  
 Using **__declspec(dllimport)** and CONSTANT lists both the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> version and the undecorated name in the .lib DLL import library that is created to allow explicit linking. Using **__declspec(dllimport)** and DATA lists just the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> version of the name.  
  
 If you use CONSTANT, either of the following code constructs can be used to access <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 -or-  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 However, if you use DATA in your .def file, only code compiled with the following definition can access the variable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Using CONSTANT is more risky because if you forget to use the extra level of indirection, you could potentially access the import address table's pointer to the variable — not the variable itself. This type of problem can often manifest as an access violation because the import address table is currently made read-only by the compiler and linker.  
  
 The current Visual C++ linker issues a warning if it sees CONSTANT in the .def file to account for this case. The only real reason to use CONSTANT is if you cannot recompile some object file where the header file did not list **__declspec(dllimport)** on the prototype.  
  
## See Also  
 [Importing into an Application](../vs140/importing-into-an-application.md)