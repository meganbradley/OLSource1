---
title: "pack"
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
  - "pack_CPP"
  - "vc-pragma.pack"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, pack"
  - "pack pragma"
ms.assetid: e4209cbb-5437-4b53-b3fe-ac264501d404
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pack
Specifies packing alignment for structure, union, and class members.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 To pack a class is to place its members directly after each other in memory, which can mean that some or all members can be aligned on a boundary smaller than the default alignment the target architecture. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> gives control at the data-declaration level. This differs from compiler option [/Zp](../vs140/-zp--struct-member-alignment-.md), which only provides module-level control. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> takes effect at the first <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> declaration after the pragma is seen. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has no effect on definitions. Calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with no arguments sets <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to the value set in the compiler option **/Zp**. If the compiler option is not set, the default value is 8.  
  
 If you change the alignment of a structure, it may not use as much space in memory, but you may see a decrease in performance or even get a hardware-generated exception for unaligned access.  You can modify this exception behavior by using [SetErrorMode](http://msdn.microsoft.com/library/windows/desktop/ms680621).  
  
 **show** (optional)  
 Displays the current byte value for packing alignment. The value is displayed by a warning message.  
  
 **push** (optional)  
 Pushes the current packing alignment value on the internal compiler stack, and sets the current packing alignment value to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not specified, the current packing alignment value is pushed.  
  
 **pop** (optional)  
 Removes the record from the top of the internal compiler stack. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not specified with **pop**, then the packing value associated with the resulting record on the top of the stack is the new packing alignment value. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is specified, for example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> becomes the new packing alignment value. If you pop with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, for example, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, then all records on the stack are popped until the record that has <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is found. That record is popped and the packing value associated with the resulting record on the top of is the stack the new packing alignment value. If you pop with an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that is not found in any record on the stack, then the **pop** is ignored.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (optional)  
 When used with **push**, assigns a name to the record on the internal compiler stack. When used with **pop**, pops records off the internal stack until <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is removed; if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not found on the internal stack, nothing is popped.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (optional)  
 Specifies the value, in bytes, to be used for packing. If the compiler option [/Zp](../vs140/-zp--struct-member-alignment-.md) is not set for the module, the default value for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is 8. Valid values are 1, 2, 4, 8, and 16. The alignment of a member will be on a boundary that is either a multiple of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or a multiple of the size of the member, whichever is smaller.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is undefined.  
  
 For more information about how to modify alignment, see these topics:  
  
-   [__alignof](../vs140/__alignof-operator.md)  
  
-   [align](../vs140/align--c---.md)  
  
-   [__unaligned](../vs140/__unaligned.md)  
  
-   [Structure Alignment Examples](../vs140/examples-of-structure-alignment.md) (x64 specific)  
  
    > [!WARNING]
    >  Note that in Visual Studio 2015 and later you can use the standard alignas and alignof operators which, unlike <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are portable across compilers. The C++ standard does not address packing, so you must still use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (or the corresponding extension on other compilers) to specify alignments smaller than the target architecture’s word size.  
  
## Example  
 The following sample shows how to use the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> pragma to change the alignment of a structure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following sample shows how to use the **push**, **pop**, and **show** syntax.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)