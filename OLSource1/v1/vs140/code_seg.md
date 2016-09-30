---
title: "code_seg"
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
  - "code_seg_CPP"
  - "vc-pragma.code_seg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, code_seg"
  - "code_seg pragma"
ms.assetid: bf4faac1-a511-46a6-8d9e-456851d97d56
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# code_seg
Specifies the text segment where functions are stored in the .obj file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pragma directive does not control placement of object code generated for instantiated templates, nor code generated implicitly by the compiler—for example, special member functions. We recommend that you use the [__declspec(code_seg(...))](../vs140/code_seg--__declspec-.md) attribute instead because it gives you control over placement of all object code. This includes compiler-generated code.  
  
 A *segment* in an .obj file is a named block of data that's loaded into memory as a unit. A *text segment* is a segment that contains executable code. In this article, the terms *segment* and *section* are used interchangeably.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pragma directive tells the compiler to put all subsequent object code from the translation unit into a text segment named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. By default, the text segment used for functions in an .obj file is named .text.  
  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pragma directive without parameters resets the text segment name for the subsequent object code to .text.  
  
 **Push** (optional)  
 Puts a record on the internal compiler stack. A **push** can have an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 **pop** (optional)  
 Removes a record from the top of the internal compiler stack.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (optional)  
 When used with **push**, assigns a name to the record on the internal compiler stack. When used with **pop**, pops records off the internal stack until <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is removed; if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not found on the internal stack, nothing is popped.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> enables multiple records to be popped with just one **pop** command.  
  
 "<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>" (optional)  
 The name of a segment. When used with **pop**, the stack is popped and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> becomes the active text segment name.  
  
 "<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>" (optional)  
 Ignored, but included for compatibility with versions of C++ earlier than version 2.0.  
  
 You can use the [DUMPBIN.EXE](../vs140/dumpbin-command-line.md) application to view .obj files. Versions of DUMPBIN for each supported target architecture are included with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Example  
 This example shows how to use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pragma directive to control where object code is put:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For a list of names that should not be used to create a section, see [/SECTION](../vs140/-section--specify-section-attributes-.md).  
  
 You can also specify sections for initialized data ([data_seg](../vs140/data_seg.md)), uninitialized data ([bss_seg](../vs140/bss_seg.md)), and const variables ([const_seg](../vs140/const_seg.md)).  
  
## See Also  
 [code_seg (__declspec)](../vs140/code_seg--__declspec-.md)   
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)