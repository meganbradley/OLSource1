---
title: "const_seg"
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
  - "vc-pragma.const_seg"
  - "const_seg_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, const_seg"
  - "const_seg pragma"
ms.assetid: 1eb58ee2-fb0e-4a39-9621-699c8f5ef957
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const_seg
Specifies the segment where [const](../vs140/const--c---.md) variables are stored in the .obj file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The meaning of the terms *segment* and *section* are interchangeable in this topic.  
  
 OBJ files can be viewed with the [dumpbin](../vs140/dumpbin-command-line.md) application. The default segment in the .obj file for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variables is .rdata. Some <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variables, such as scalars, are automatically inlined into the code stream. Inlined code will not appear in .rdata.  
  
 Defining an object requiring dynamic initialization in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> results in undefined behavior.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with no parameters resets the segment to .rdata.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (optional)  
 Puts a record on the internal compiler stack. A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can have an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (optional)  
 Removes a record from the top of the internal compiler stack.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (optional)  
 When used with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, assigns a name to the record on the internal compiler stack. When used with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, pops records off the internal stack until <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is removed; if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not found on the internal stack, nothing is popped.  
  
 Using <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> enables multiple records to be popped with a single <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> command.  
  
 "<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>" (optional)  
 The name of a segment. When used with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the stack is popped and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> becomes the active segment name.  
  
 "<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>" (optional)  
 Included for compatibility with C++ prior to version 2.0. It is ignored.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **test1**  
**test2**  
**test3**  
**test4**   
## Comments  
 See [/SECTION](../vs140/-section--specify-section-attributes-.md) for a list of names you should not use when creating a section.  
  
 You can also specify sections for initialized data ([data_seg](../vs140/data_seg.md)), uninitialized data ([bss_seg](../vs140/bss_seg.md)), and functions ([code_seg](../vs140/code_seg.md)).  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)