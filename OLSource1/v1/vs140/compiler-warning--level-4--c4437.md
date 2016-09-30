---
title: "Compiler Warning (level 4) C4437"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
dev_langs: 
  - "C++"
ms.assetid: dc07e350-20eb-474c-a7ad-f841ae7ec339
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4437
dynamic_cast from virtual base 'class1' to 'class2' could fail in some contexts        Compile with /vd2 or define 'class2' with #pragma vtordisp(2) in effect  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
 The compiler has encountered a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operation with the following characteristics.  
  
-   The cast is from a base class pointer to a derived class pointer.  
  
-   The derived class virtually inherits the base class.  
  
-   The derived class does not have a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field for the virtual base.  
  
-   The cast is not found in a constructor or destructor of the derived class, or some class which further inherits from the derived class (otherwise, compiler warning C4436 will be issued).  
  
 The warning indicates that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> might not perform correctly if it is operating on a partially-constructed object.  This situation occurs when the enclosing function is called from a constructor or destructor of a class that inherits the derived class that is named in the warning.  If the derived class that is named in the warning is never further derived, or the enclosing function is not called during object construction or destruction, the warning can be ignored.  
  
## Example  
 The following sample generates C4437 and demonstrates the code generation issue that arises from the missing <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [dynamic_cast Operator](../vs140/dynamic_cast-operator.md)   
 [vtordisp](../vs140/vtordisp.md)   
 [Compiler Warning (level 1) C4436](../vs140/compiler-warning--level-1--c4436.md)