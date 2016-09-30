---
title: "Compiler Warning (level 1) C4436"
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
ms.assetid: 2b54a1fc-c9c6-4cc9-90be-faa44fc715d5
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4436
dynamic_cast from virtual base 'class1' to 'class2' in constructor or destructor could fail with partially-constructed object        Compile with /vd2 or define 'class2' with #pragma vtordisp(2) in effect  
  
 The compiler has encountered a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operation with the following characteristics.  
  
-   The cast is from a base class pointer to a derived class pointer.  
  
-   The derived class virtually inherits the base class.  
  
-   The derived class does not have a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field for the virtual base.  
  
-   The cast is found in a constructor or destructor of the derived class, or some class which further inherits from the derived class.  
  
 The warning indicates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> might not perform correctly, if it is operating on a partially-constructed object.  That happens if the derived constructor/destructor is operating on a sub-object of some further derived object.  If the derived class named in the warning is never further derived, the warning can be ignored.  
  
## Example  
 The following sample generates C4436 and demonstrates the code generation issue that arises from the missing <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [dynamic_cast Operator](../vs140/dynamic_cast-operator.md)   
 [vtordisp](../vs140/vtordisp.md)   
 [Compiler Warning (level 1) C4437](../vs140/compiler-warning--level-4--c4437.md)