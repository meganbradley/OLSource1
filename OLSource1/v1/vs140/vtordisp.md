---
title: "vtordisp"
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
  - "vc-pragma.vtordisp"
  - "vtordisp_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, vtordisp"
  - "vtordisp pragma"
ms.assetid: 05b7d73c-43fa-4b62-8c8a-170a9e427391
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vtordisp
**C++ Specific**  
  
 Controls the addition of the hidden vtordisp construction/destruction displacement member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pushes the current vtordisp setting on the internal compiler stack and sets the new vtordisp setting to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not specified, the current vtordisp setting is not changed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Removes the top record from the internal compiler stack and restores the vtordisp setting to the removed value.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the new value for the vtordisp setting. Possible values are 0, 1 or 2, corresponding to the /vd0, /vd1, and /vd2 compiler options. For more information, see [/vd (Disable Construction Displacements)](../vs140/-vd--disable-construction-displacements-.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Equivalent to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Equivalent to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pragma is applicable only to code that uses virtual bases. If a derived class overrides a virtual function that it inherits from a virtual base class, and if a constructor or destructor for the derived class calls that function using a pointer to the virtual base class, the compiler might introduce additional hidden <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> fields into classes with virtual bases.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> pragma affects the layout of classes that follow it. The /vd0, /vd1, and /vd2 options specify the same behavior for complete modules. Specifying <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> suppresses the hidden <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> members. Turn off <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> only if there is no possibility that the class's constructors and destructors call virtual functions on the object pointed to by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> pointer.  
  
 Specifying <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the default, enables the hidden <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> members where they are necessary.  
  
 Specifying <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> enables the hidden <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> members for all virtual bases with virtual functions.  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> might be necessary to ensure correct performance of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> on a partially-constructed object. For more information, see [Compiler Warning (level 1) C4436](../vs140/compiler-warning--level-1--c4436.md).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, with no arguments, restores the vtordisp setting to its initial setting.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END C++ Specific**  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)