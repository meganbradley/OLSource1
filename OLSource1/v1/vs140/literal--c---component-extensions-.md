---
title: "literal (C++ Component Extensions)"
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
  - "literal"
  - "literal_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "literal keyword [C++]"
ms.assetid: 6b1a1f36-2e1d-4a23-8eb6-172f4f3c477f
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# literal (C++ Component Extensions)
A variable (data member) marked as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in a **/clr** compilation is the native equivalent of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable.  
  
## All Platforms  
 **Remarks**  
  
 (There are no remarks for this language feature that apply to all runtimes.)  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 (There are no remarks for this language feature that apply to only the Windows Runtime.)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
  
## Remarks  
 A data member marked as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>must be initialized when declared and the value must be a constant integral, enum, or string type. Conversion from the type of the initialization expression to the type of the static const data-member must not require a user-defined conversion.  
  
 No memory is allocated for the literal field at runtime; the compiler only inserts its value in the metadata for the class.  
  
 A variable marked <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will not be available in metadata to other compilers.  
  
 For more information, see [static (C++)](../vs140/static--c---.md) and [const (C++)](../vs140/const--c---.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a context-sensitive keyword. See [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md) for more information.  
  
## Example  
 This example shows that a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable implies <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample shows the affect of literal in metadata:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice the difference in the metadata for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>: the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive is applied to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, meaning it can be ignored by other compilers.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following sample, authored in C#, references the metadata created in the previous sample and shows the affect of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> variables:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Requirements  
 Compiler option: **/clr**  
  
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)